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
    public partial class frmKesintiYap : Form
    {
        private int KisiNo;
        private int IcraNo;
        public frmKesintiYap(int kisiNo, int IcraKayıtNo)
        {
            InitializeComponent();
            this.KisiNo = kisiNo;
            this.IcraNo = IcraKayıtNo;
            LoadAlacak();
        }
        private void LoadAlacak()
        {
            try
            {
                NpgsqlCommand command = new NpgsqlCommand();
                string sql = "SELECT kayitno,  turAdi  FROM public.tb_alacak_turleri ATT inner join tb_icra_alacak AAA on AAA.\"alacakTurNo\" = ATT.kayitno and AAA.\"icraKayitNo\" = @kayit_no ORDER BY kayitno ASC";
                command.CommandText = sql;
                command.Parameters.AddWithValue("@kayit_no", NpgsqlTypes.NpgsqlDbType.Integer, this.IcraNo);
                DataTable dt = dbConnection.getData(command);
                DataRow dr = dt.NewRow();
                dr[0] = -1;
                dr[1] = "";
                dt.Rows.InsertAt(dr, 0);
                cBoxAlacak.DataSource = dt;
                cBoxAlacak.ValueMember = "kayitno";
                cBoxAlacak.DisplayMember = "turAdi";
            }
            catch (Exception)
            {

                throw;
            }
        }
        private Decimal parayaCevir(String text)
        {
            Decimal result = -1;
            try
            {
                result = Convert.ToDecimal(text);
                if (result < 0)
                {
                    MessageBoxs.WarningMessage("Para negatif olamaz");
                }
            }
            catch (Exception)
            {
                MessageBoxs.WarningMessage("Hatalı Para Formatı");
            }
            return result;
        }
        private void addKesinti()
        {
            try
            {
                decimal bakiye = parayaCevir(tBoxBakiye.Text);
                if (bakiye > 0)
                {
                    NpgsqlCommand command = new NpgsqlCommand();
                    command.CommandText = "INSERT INTO tb_kesintiler VALUES (default, @kisi, @icra, @tur, @tarih, @tutar);";
                    command.Parameters.AddWithValue("@tutar", NpgsqlTypes.NpgsqlDbType.Money, bakiye);
                    command.Parameters.AddWithValue("@tarih", NpgsqlTypes.NpgsqlDbType.Date, Date_date.Value);
                    command.Parameters.AddWithValue("@tur", NpgsqlTypes.NpgsqlDbType.Integer, Convert.ToInt32(cBoxAlacak.SelectedValue));
                    command.Parameters.AddWithValue("@kisi", NpgsqlTypes.NpgsqlDbType.Integer, KisiNo);
                    command.Parameters.AddWithValue("@icra", NpgsqlTypes.NpgsqlDbType.Integer, IcraNo);
                    dbConnection.sendQuery(command);
                    MessageBoxs.SuccessMessage("Kesinti Sisteme Eklendi");
                    this.Close();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
        private void btnaddKesinti_Click(object sender, EventArgs e)
        {
            try
            {
                if(tBoxBakiye.Text != "" && cBoxAlacak.SelectedIndex != 0)
                {
                    addKesinti();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void tBoxBakiye_Validating(object sender, CancelEventArgs e)
        {
            tBoxBakiye.Text = tBoxBakiye.Text.Replace(',', '.');
        }
    }
}
