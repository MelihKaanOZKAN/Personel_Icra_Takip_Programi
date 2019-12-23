using Npgsql;
using Personel_Icra_Takip_Programı.Class;
using Personel_Icra_Takip_Programı.Classlar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Personel_Icra_Takip_Programı.Forms
{
    public partial class frmCevapYaziları : Form
    {
        public int IcraKayıtNumarası;
        private string cevapDosyaYolu = "";
        private string ekDosyaYolu = "";
        
        public frmCevapYaziları(int IcraKayıtNumarası)
        {
            try
            {

                InitializeComponent();
                this.IcraKayıtNumarası = IcraKayıtNumarası;
                getCevaplar();
            }
            catch (Exception ex)
            {
                MessageBoxs.ErrorMessage(ex);
            }
        }
        private void getCevaplar()
        {
            try
            {
                NpgsqlCommand command = new NpgsqlCommand();
                command.CommandText = "SELECT kayitno as \"Kayıt Numarası\", evraktarihi as \"Evrak Tarihi\", evraksayisi as \"Evrak Sayısı\" FROM tb_cevaplar WHERE icra=@kayitno ";
                command.Parameters.AddWithValue("@kayitno", NpgsqlTypes.NpgsqlDbType.Integer, this.IcraKayıtNumarası);
                dgv_cevaplar.DataSource = dbConnection.getData(command);
            }
            catch (Exception)
            {

                throw;
            }
        }
        private void getEkler()
        {
            try
            {
                NpgsqlCommand command = new NpgsqlCommand();
                command.CommandText = "SELECT kayitno as \"Kayıt Numarası\", aciklama as \"Açıklama\" FROM tb_cevaplar_ekler WHERE yazıno=@kayitno";
                command.Parameters.AddWithValue("@kayitno", NpgsqlTypes.NpgsqlDbType.Integer, Convert.ToInt32(dgv_cevaplar.SelectedRows[0].Cells[0].Value));
                dgv_ekler.DataSource = dbConnection.getData(command);
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openFile = new OpenFileDialog();
                openFile.Filter = "PDF Dosyası |*.pdf|UDF Dosyası |*.udf";
                openFile.RestoreDirectory = true;
                if (openFile.ShowDialog() == DialogResult.OK)
                {
                    cevapDosyaYolu = openFile.FileName;
                }


            }
            catch (Exception ex)
            {
                MessageBoxs.ErrorMessage(ex);
            }
        }

        private void btnOpenEk_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openFile = new OpenFileDialog();
                openFile.Filter = "PDF Dosyası |*.pdf|UDF Dosyası |*.udf|JPEG Dosyası |*.jpg";
                openFile.RestoreDirectory = true;
                if (openFile.ShowDialog() == DialogResult.OK)
                {
                    ekDosyaYolu = openFile.FileName;
                }


            }
            catch (Exception ex)
            {
                MessageBoxs.ErrorMessage(ex);
            }
        }
        private string getFileExtension(string input)
        {
            string[] tmp = input.Split('.');
            return tmp[tmp.Length - 1];
        }
        private void addEk()
        {
            try
            {
                NpgsqlCommand command = new NpgsqlCommand();
                command.CommandText = "INSERT INTO tb_cevaplar_ekler (kayitno, yazıno, goruntu, dosya_uzantisi, aciklama) VALUES (default, @yazino, @goruntu, @uzantı, @aciklama); ";
                command.Parameters.AddWithValue("@yazino", NpgsqlTypes.NpgsqlDbType.Integer, Convert.ToInt32(dgv_cevaplar.SelectedRows[0].Cells[0].Value));
                 command.Parameters.AddWithValue("@goruntu", NpgsqlTypes.NpgsqlDbType.Bytea, File.ReadAllBytes(ekDosyaYolu));
                command.Parameters.AddWithValue("@uzantı", NpgsqlTypes.NpgsqlDbType.Varchar, getFileExtension(ekDosyaYolu));
                command.Parameters.AddWithValue("@aciklama", NpgsqlTypes.NpgsqlDbType.Text, richTox_ek_aciklama.Text);
                dbConnection.sendQuery(command);
                ekDosyaYolu = "";
                richTox_ek_aciklama.Text = "";
                MessageBoxs.SuccessMessage("Evrak Eki Sisteme Başarıyla Eklendi");
                getEkler();
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void addCevap()
        {
            try
            {
                NpgsqlCommand command = new NpgsqlCommand();
                command.CommandText = "INSERT INTO tb_cevaplar VALUES (default, @kayitno, @tarih, @evraksayisi, @goruntu, @uzantı); ";
                command.Parameters.AddWithValue("@kayitno", NpgsqlTypes.NpgsqlDbType.Integer, IcraKayıtNumarası);
                command.Parameters.AddWithValue("@tarih", NpgsqlTypes.NpgsqlDbType.Date, Date_date.Value);
                command.Parameters.AddWithValue("@evraksayisi", NpgsqlTypes.NpgsqlDbType.Integer, Convert.ToInt32(tBox_evrak_sayısı.Text));
                command.Parameters.AddWithValue("@goruntu", NpgsqlTypes.NpgsqlDbType.Bytea, File.ReadAllBytes(cevapDosyaYolu));
                command.Parameters.AddWithValue("@uzantı", NpgsqlTypes.NpgsqlDbType.Varchar, getFileExtension(cevapDosyaYolu));
                dbConnection.sendQuery(command);
                cevapDosyaYolu = "";
                MessageBoxs.SuccessMessage("Evrak Sisteme Başarıyla Eklendi");
            }
            catch (Exception)
            {

                throw;
            }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {   if(cevapDosyaYolu != "" && tBox_evrak_sayısı.Text != "")
                {
                    addCevap();
                    getCevaplar();
                }
            }
            catch (Exception ex)
            {
                MessageBoxs.ErrorMessage(ex);
            }
        }
        private void saveFile(byte[] file, string filename)
        {
            try
            {
                File.WriteAllBytes(filename, file);
            }
            catch (Exception)
            {

                throw;
            }
        }
        private void evrakıAçToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                int kayitNo = Convert.ToInt32(dgv_cevaplar.SelectedRows[0].Cells[0].Value);
                NpgsqlCommand command = new NpgsqlCommand();
                command.CommandText = "select  \"goruntu\", \"dosya_uzantisi\" from tb_cevaplar  where kayitno =  @kayitno_";
                command.Parameters.AddWithValue("@kayitno_", NpgsqlTypes.NpgsqlDbType.Integer, kayitNo);
                DataTable dt = dbConnection.getData(command);
                if (dt.Rows.Count > 0)
                {
                    string FILEPATH = Environment.ExpandEnvironmentVariables("%APPDATA%\\PersonelIcraTakipProgrami\\tmp");
                    Directory.CreateDirectory(FILEPATH);
                    FILEPATH += "\\" + kayitNo + "_" + DateTime.Now.Year + "_" + DateTime.Now.Month + "_" + DateTime.Now.Day  + "_" + DateTime.Now.Millisecond + "."+ dt.Rows[0][1].ToString();
                    byte[] byteArray = (byte[])dt.Rows[0][0];
                    saveFile(byteArray, FILEPATH);
                    Process.Start(FILEPATH);
                }
            }
            catch (Exception ex)
            {
                MessageBoxs.ErrorMessage(ex);
            }
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                int kayitNo = Convert.ToInt32(dgv_ekler.SelectedRows[0].Cells[0].Value);
                NpgsqlCommand command = new NpgsqlCommand();
                command.CommandText = "select  \"goruntu\", \"dosya_uzantisi\", \"aciklama\" from tb_cevaplar_ekler  where kayitno =  @kayitno_";
                command.Parameters.AddWithValue("@kayitno_", NpgsqlTypes.NpgsqlDbType.Integer, kayitNo);
                DataTable dt = dbConnection.getData(command);
                if (dt.Rows.Count > 0)
                {
                    string FILEPATH = Environment.ExpandEnvironmentVariables("%APPDATA%\\PersonelIcraTakipProgrami\\tmp");
                    Directory.CreateDirectory(FILEPATH);
                    FILEPATH += "\\" + kayitNo + "_" + dt.Rows[0][2].ToString() + "_" + DateTime.Now.Year + "_" + DateTime.Now.Month + "_" + DateTime.Now.Day + "_" + DateTime.Now.Millisecond + "." + dt.Rows[0][1].ToString();
                    byte[] byteArray = (byte[])dt.Rows[0][0];
                    saveFile(byteArray, FILEPATH);
                    Process.Start(FILEPATH);
                }
            }
            catch (Exception ex)
            {
                MessageBoxs.ErrorMessage(ex);
            }
        }

        private void btnAddEk_Click(object sender, EventArgs e)
        {
            try
            {
                addEk();
            }
            catch (Exception ex)
            {
                MessageBoxs.ErrorMessage(ex);
            }
        }

        private void frmCevapYaziları_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                string FILEPATH = Environment.ExpandEnvironmentVariables("%APPDATA%\\PersonelIcraTakipProgrami\\tmp");
               if (Directory.Exists(FILEPATH))
                {
                    Directory.Delete(FILEPATH, true);
                }

            }
            catch (Exception ex)
            {
                MessageBoxs.ErrorMessage(ex);
            }
        }

        private void dgv_cevaplar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                getEkler();
                btnAddEk.Enabled = true;
            }
            catch (Exception ex)
            {
                  MessageBoxs.ErrorMessage(ex);
            }
        }
    }
    }
