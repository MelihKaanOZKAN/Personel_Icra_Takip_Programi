using Npgsql;
using Personel_Icra_Takip_Programı.Class;
using Personel_Icra_Takip_Programı.Classlar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Personel_Icra_Takip_Programı.Forms
{
    public partial class frm_addPersonel : Form
    {
        public frm_addPersonel()
        {
            InitializeComponent();
        }
        private DataTable getKurumListesi()
        {
            DataTable dt = new DataTable();
            try
            {
                NpgsqlCommand command = new NpgsqlCommand();
                string sql = "SELECT kk5 as \"Kurum Numarası\", adi as \"Kurum Adı\" FROM public.tb_kurumlar";
                command.CommandText = sql;
                dt = dbConnection.getData(command);
                DataRow dr = dt.NewRow();
                dr[0] = -1;
                dr[1] = "";
                dt.Rows.InsertAt(dr, 0);
            }
            catch (Exception ex)
            {
                MessageBoxs.ErrorMessage(ex);
            }
            return dt;
        }
        private void fillCBoxKurumlar()
        {
            try
            {
                DataTable dt = this.getKurumListesi();
                cBoxKurumlar.DataSource = dt;
                cBoxKurumlar.DisplayMember = "Kurum Adı";
                cBoxKurumlar.ValueMember = "Kurum Numarası";
            }
            catch (Exception ex)
            {
                MessageBoxs.ErrorMessage(ex);
            }
        }
        private void loadPersonel(int kisiNo)
        {
            try
            {
                NpgsqlCommand command = new NpgsqlCommand();
                command.CommandText = "SELECT tc_no, adı, soyadı, ckurum FROM public.tb_personel WHERE kisi_no=@kisino";
                command.Parameters.AddWithValue("@kisino", NpgsqlTypes.NpgsqlDbType.Integer, kisiNo);
                DataTable dt = dbConnection.getData(command);
                tBoxTCNo.Text= dt.Rows[0][0].ToString();
                tBoxAdi.Text = dt.Rows[0][1].ToString();
                tBoxSoyadi.Text = dt.Rows[0][2].ToString();
                fillCBoxKurumlar();
                cBoxKurumlar.SelectedValue = dt.Rows[0][3].ToString();
                tboxKisiNo.Enabled = false;
                tBoxTCNo.Enabled = false;

            }
            catch (Exception)
            {

                throw;
            }
        }

        private bool checkAlreadySaved(int kisiNo)
        {
            bool result = false;
            try
            {
                NpgsqlCommand command = new NpgsqlCommand();
                command.CommandText = "SELECT COUNT(tc_no) FROM public.tb_personel WHERE kisi_no=@kisino";
                command.Parameters.AddWithValue("@kisino", NpgsqlTypes.NpgsqlDbType.Integer, kisiNo);
                DataTable dt = dbConnection.getData(command);
                if (dt.Rows[0][0].ToString() != "0")
                {
                    result = true;

                }
 
            }
            catch (Exception)
            {

                throw;
            }
            return result;
        }
        private void updatePersonel()
        {
            try
            {
                NpgsqlCommand command = new NpgsqlCommand();
                command.CommandText = "UPDATE public.tb_personel SET  adı=@adı, soyadı=@soyadı, ckurum=@ckurum WHERE kisi_no=@kisino";
                command.Parameters.AddWithValue("@kisino", NpgsqlTypes.NpgsqlDbType.Integer, Convert.ToInt32(tboxKisiNo.Text));
                command.Parameters.AddWithValue("@adı", NpgsqlTypes.NpgsqlDbType.Text, tBoxAdi.Text);
                command.Parameters.AddWithValue("@soyadı", NpgsqlTypes.NpgsqlDbType.Text, tBoxSoyadi.Text);
                command.Parameters.AddWithValue("@ckurum", NpgsqlTypes.NpgsqlDbType.Integer, Convert.ToInt32(cBoxKurumlar.SelectedValue));
                dbConnection.sendQuery(command);
                tboxKisiNo.Enabled = false;
                tBoxTCNo.Enabled = false;
              
                MessageBoxs.SuccessMessage("Kişi Güncelleme Başarılı");

            }
            catch (Exception)
            {

                throw;
            }
        }
        private void addPersonel()
        {
            try
            {
                NpgsqlCommand command = new NpgsqlCommand();
                command.CommandText = "INSERT INTO public.tb_personel (kisi_no, tc_no, adı, soyadı, ckurum) VALUES (@kisino, @tcno, @adı, @soyadı, @ckurum)";
                command.Parameters.AddWithValue("@kisino", NpgsqlTypes.NpgsqlDbType.Integer, Convert.ToInt32(tboxKisiNo.Text));
                command.Parameters.AddWithValue("@tcno", NpgsqlTypes.NpgsqlDbType.Bigint, Convert.ToDecimal(tBoxTCNo.Text));
                command.Parameters.AddWithValue("@adı", NpgsqlTypes.NpgsqlDbType.Text, tBoxAdi.Text);
                command.Parameters.AddWithValue("@soyadı", NpgsqlTypes.NpgsqlDbType.Text, tBoxSoyadi.Text);
                command.Parameters.AddWithValue("@ckurum", NpgsqlTypes.NpgsqlDbType.Integer, Convert.ToInt32(cBoxKurumlar.SelectedValue));
                dbConnection.sendQuery(command);
                tboxKisiNo.Enabled = false;
                tBoxTCNo.Enabled = false;
                MessageBoxs.SuccessMessage("Kişi Oluşturma Başarılı");

            }
            catch (Exception)
            {

                throw;
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (checkAlreadySaved(Convert.ToInt32(tboxKisiNo.Text)))
                {
                    updatePersonel();
                }
                else
                {
                    addPersonel();
                }
            }
            catch (Exception ex)
            {
                MessageBoxs.ErrorMessage(ex);
            }
        }

        private void cBoxKurumlar_DropDown(object sender, EventArgs e)
        {
        }

        private void frm_addPersonel_Load(object sender, EventArgs e)
        {
            try
            {
                if (tboxKisiNo.Text != "")
                {
                    fillCBoxKurumlar();
                    loadPersonel(Convert.ToInt32(tboxKisiNo.Text));

                }
            }
            catch (Exception ex)
            {
                MessageBoxs.ErrorMessage(ex);
            }
        }

      

        private void cBoxKurumlar_SelectedValueChanged(object sender, EventArgs e)
        {
            if(cBoxKurumlar.SelectedValue.ToString() != "-1" && cBoxKurumlar.SelectedValue.ToString() != "System.Data.DataRowView")
            {
                btnSave.Enabled = true;
            }
            else
            {

                btnSave.Enabled = false;
            }
        }
    }
}
