using Npgsql;
using Personel_Icra_Takip_Programı.Class;
using Personel_Icra_Takip_Programı.Classlar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Personel_Icra_Takip_Programı.Forms
{
    public partial class frmMuzekkereler : Form
    {
        public int IcraKayitNo;
        public frmMuzekkereler( int IcraKayitNo)
        {
            InitializeComponent();
            this.IcraKayitNo = IcraKayitNo;
            loadMuzekkere();
        }
        private void loadMuzekkere()
        {
            try
            {
                NpgsqlCommand command = new NpgsqlCommand();
                command.CommandText = "select kayitno as \"Kayıt No\", gelistarihi  as \"Tarih\" from tb_muzekkereler where icra =  @kayitno_";
                command.Parameters.AddWithValue("@kayitno_", NpgsqlTypes.NpgsqlDbType.Integer, this.IcraKayitNo);
                dgv_muzekkereler.DataSource = dbConnection.getData(command);

            }
            catch (Exception)
            {

                throw;
            }
        }
        private void addMuzekkere()
        {
            try
            {
                NpgsqlCommand command = new NpgsqlCommand();
                command.CommandText = "INSERT INTO tb_muzekkereler (\"gelistarihi\", \"icra\", \"goruntu\", \"dosya_uzantantisi\") VALUES (@tarih, @kayitno , @goruntu , @uzantı);";
                command.Parameters.AddWithValue("@kayitno", NpgsqlTypes.NpgsqlDbType.Integer, this.IcraKayitNo);
                command.Parameters.AddWithValue("@tarih", NpgsqlTypes.NpgsqlDbType.Date, Date_date.Value);
                command.Parameters.AddWithValue("@goruntu", NpgsqlTypes.NpgsqlDbType.Bytea, File.ReadAllBytes(pdfViewer.FileName));
                command.Parameters.AddWithValue("@uzantı", NpgsqlTypes.NpgsqlDbType.Varchar, "pdf");
                dbConnection.sendQuery(command);
                MessageBoxs.SuccessMessage("Müzekkere eklendi");
                loadMuzekkere();

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
                openFile.Filter = "PDF Dosyası | *.pdf";
                openFile.RestoreDirectory = true;
                if (openFile.ShowDialog() == DialogResult.OK)
                {

                    pdfViewer.LoadFromFile(openFile.FileName);

                }

                
            }
            catch (Exception ex)
            {
                MessageBoxs.ErrorMessage(ex);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {

                addMuzekkere();
            }
            catch (Exception ex)
            {
                MessageBoxs.ErrorMessage(ex);
            }
        }
        private void dgv_muzekkereler_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int kayitNo = Convert.ToInt32(dgv_muzekkereler.Rows[e.RowIndex].Cells[0].Value);
                NpgsqlCommand command = new NpgsqlCommand();
                command.CommandText = "select  \"goruntu\", \"dosya_uzantantisi\" from tb_muzekkereler where kayitno =  @kayitno_";
                command.Parameters.AddWithValue("@kayitno_", NpgsqlTypes.NpgsqlDbType.Integer, kayitNo);
                DataTable dt = dbConnection.getData(command);
                if(dt.Rows.Count > 0)
                {

                    byte[] byteArray = (byte[]) dt.Rows[0][0];
                    MemoryStream stream = new MemoryStream(byteArray);
                    pdfViewer.LoadFromStream(stream);
                }

            }
            catch (Exception ex)
            {
                MessageBoxs.ErrorMessage(ex);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog save = new SaveFileDialog();
                save.Filter = "PDF Dosyası | *.pdf";
                if (save.ShowDialog() == DialogResult.OK)
                {
                    MemoryStream stream = new MemoryStream();

                    pdfViewer.SaveToFile(stream);
                    byte[] bytesInStream = new byte[stream.Length];
                    bytesInStream = stream.ToArray();

                    FileStream fileStream = new FileStream(save.FileName, FileMode.Create, FileAccess.Write);
                    stream.CopyTo(fileStream);
                    fileStream.Write(bytesInStream, 0, bytesInStream.Length);
                    fileStream.Close();
                }
                MessageBoxs.SuccessMessage("Dosya Kaydedildi");
            }
            catch (Exception ex)
            {
                MessageBoxs.ErrorMessage(ex);
            }
        }
    }
}
