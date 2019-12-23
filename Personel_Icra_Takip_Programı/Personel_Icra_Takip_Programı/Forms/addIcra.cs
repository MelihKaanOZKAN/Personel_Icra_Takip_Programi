using Npgsql;
using Personel_Icra_Takip_Programı.Class;
using Personel_Icra_Takip_Programı.Classlar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Personel_Icra_Takip_Programı.Forms
{
    public partial class addIcra : Form
    {
        public int IcraKayitNo;
        public addIcra(int IcraKayitNo)
        {
            try
            {
                InitializeComponent();
                LoadIcraDairesi();
                LoadAlacak();
                LoadIcraTuru();
                dgvBorclular.DataSource = prepareBorcluDGV();
                dgvAlacak.DataSource = prepareAlacakDGV();
                dgvAlacak.Columns[0].Visible = false;
                this.IcraKayitNo = IcraKayitNo;
                if (IcraKayitNo != 0)
                {
                    LoadIcraInfo();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        public addIcra()
        {
            try
            {
                InitializeComponent();
                LoadIcraDairesi();
                LoadAlacak();
                LoadIcraTuru();
                dgvBorclular.DataSource = prepareBorcluDGV();
                dgvAlacak.DataSource = prepareAlacakDGV();
                dgvAlacak.Columns[0].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBoxs.ErrorMessage(ex);
            }
        }
        private void LoadIcraInfo()
        {
            try
            {
                NpgsqlCommand command = new NpgsqlCommand();
                command.CommandText = "SELECT esasno, tarih, icradairesi, tutar, icraturu, oncelik, sabit_kesinti FROM tb_icralar IC WHERE kayitno = @kayitno_";
                command.Parameters.AddWithValue("@kayitno_", NpgsqlTypes.NpgsqlDbType.Integer,this.IcraKayitNo);
                DataTable dt = dbConnection.getData(command);
                if (dt.Rows.Count > 0)
                {
                    tBoxEsasNo.Text = dt.Rows[0][0].ToString();
                    Date_date.Value = Convert.ToDateTime(dt.Rows[0][1]);
                    cBox_İcraDairesi.SelectedValue = Convert.ToInt32(dt.Rows[0][2]);
                    tBoxBakiye.Text = dt.Rows[0][3].ToString();
                    cBox_IcraTuru.SelectedValue = Convert.ToInt32(dt.Rows[0][4]);
                    cBox_Oncelik.Checked = Convert.ToBoolean(dt.Rows[0][5]);
                    tBox_sabit_kesinti.Text = dt.Rows[0][6].ToString();
                    loadBorclular();
                    loadAlaakTuru();
                    tBoxEsasNo.Enabled = false;
                    Date_date.Enabled = false;
                    cBox_IcraTuru.Enabled = false;
                    cBox_İcraDairesi.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Hata oluştu. Dosya bulunamadı");
                    this.Close();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
        private void loadBorclular()
        {
            NpgsqlCommand command = new NpgsqlCommand();
            command.CommandText = "select kisi_no, tc_no, adı, soyadı FROM tb_personel P inner join tb_borclular IC on p.kisi_no = IC.kisi where IC.icra = @kayitno_";
            command.Parameters.AddWithValue("@kayitno_", NpgsqlTypes.NpgsqlDbType.Integer, this.IcraKayitNo);
            DataTable dt = dbConnection.getData(command);
            DataTable dt2 = (DataTable)dgvBorclular.DataSource;

            for(int i = 0; i < dt.Rows.Count; i++)
            {
                DataRow dr = dt2.NewRow();
                dr[0] = dt.Rows[i][0];
                dr[1] = dt.Rows[i][1];
                dr[2] = dt.Rows[i][2];
                dr[3] = dt.Rows[i][3];
                dt2.Rows.Add(dr);
            }
            dgvBorclular.DataSource = dt2;
        }
        private void loadAlaakTuru()
        {
            NpgsqlCommand command = new NpgsqlCommand();
            command.CommandText = "select kayitno, turadi FROM tb_alacak_turleri A inner join tb_icra_alacak A2 on A2.\"alacakTurNo\" = A.kayitno where A2.\"icraKayitNo\" = @kayitno_";
            command.Parameters.AddWithValue("@kayitno_", NpgsqlTypes.NpgsqlDbType.Integer, this.IcraKayitNo);
            DataTable dt = dbConnection.getData(command);
            DataTable dt2 = (DataTable)dgvAlacak.DataSource;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DataRow dr = dt2.NewRow();
                dr[0] = dt.Rows[i][0];
                dr[1] = dt.Rows[i][1];
                dt2.Rows.Add(dr);
            }
            dgvAlacak.DataSource = dt2;
        }
        private void LoadIcraDairesi()
        {
            try
            {
                NpgsqlCommand command = new NpgsqlCommand();
                command.CommandText = "SELECT kurumno, adı FROM public.tb_icradairesi ORDER BY kurumno ASC";
                DataTable dt = dbConnection.getData(command);
                DataRow dr = dt.NewRow();
                dr[0] = -1;
                dr[1] = "";
                dt.Rows.InsertAt(dr, 0);
                cBox_İcraDairesi.DataSource = dt;
               cBox_İcraDairesi.ValueMember = "kurumno";
                cBox_İcraDairesi.DisplayMember = "adı";
            }
            catch (Exception)
            {

                throw;
            }
        }
        private void LoadIcraTuru()
        {
            try
            {
                NpgsqlCommand command = new NpgsqlCommand();
                string sql = "SELECT kayitno, turadi  FROM public.tb_icra_turleri ORDER BY kayitno ASC";
                command.CommandText = sql;
                DataTable dt = dbConnection.getData(command);
                DataRow dr = dt.NewRow();
                dr[0] = -1;
                dr[1] = "";
                dt.Rows.InsertAt(dr, 0);
                cBox_IcraTuru.DataSource = dt;
                cBox_IcraTuru.ValueMember = "kayitno";
                cBox_IcraTuru.DisplayMember = "turadi";
            }
            catch (Exception)
            {

                throw;
            }
        }
        private void LoadAlacak()
        {
            try
            {
                NpgsqlCommand command = new NpgsqlCommand();
                string sql = "SELECT kayitno,  turAdi  FROM public.tb_alacak_turleri ORDER BY kayitno ASC";
                command.CommandText = sql;
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
        private DataTable prepareBorcluDGV()
        {
            DataTable dt = new DataTable();
            try
            {
                dt.Columns.Add("Kişi No");
                dt.Columns.Add("Tc Kimlik No");
                dt.Columns.Add("Adı");
                dt.Columns.Add("Soyadı");
            }
            catch (Exception)
            {

                throw;
            }
            return dt;
        }
        private DataTable prepareAlacakDGV()
        {
            DataTable dt = new DataTable();
            try
            {
                dt.Columns.Add("AlacakId");
                dt.Columns.Add("Alacak Türü");
            }
            catch (Exception)
            {

                throw;
            }
            return dt;
        }

        private void btn_add_borclu_Click(object sender, EventArgs e)
        {
            try
            {
                if(tBoxTCNo.Text != ""&& tBoxTCNo.TextLength==11)
                {
                    DataTable dt = (DataTable)dgvBorclular.DataSource;
                    DataRow dr = dt.NewRow();
                    dt.PrimaryKey = new DataColumn[] { dt.Columns[0] };
                    dr[0] = tbox_borclu_kisino.Text;
                    dr[1] = tBoxTCNo.Text;
                    dr[2] = tBoxAdi.Text;
                    dr[3] = tBoxSoyadi.Text;
                    if(!dt.Rows.Contains(dr))
                    {
                        dt.Rows.Add(dr);
                        dt.AcceptChanges();
                    }
                    dgvBorclular.DataSource = dt;
                    clearBorcluTbox();
                }
            }
            catch (Exception ex)
            {
                MessageBoxs.WarningMessage("Hata: Bu Kayıt Zaten Ekli");
            }
        }
        private void clearBorcluTbox()
        {
            tbox_borclu_kisino.Text = "";
            tBoxTCNo.Text = "";
            tBoxAdi.Text = "";
            tBoxSoyadi.Text = "";
        }
        private void btn_add_alacakTuru_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = (DataTable)dgvAlacak.DataSource;
                DataRow dr = dt.NewRow();

                dt.PrimaryKey = new DataColumn[] { dt.Columns[0] };
                dr[0] = cBoxAlacak.SelectedValue;
                dr[1] = cBoxAlacak.Text;
                if (!dt.Rows.Contains(dr))
                {
                    dt.Rows.Add(dr);
                    dt.AcceptChanges();
                }
                dgvAlacak.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBoxs.WarningMessage("Hata: Bu Kayıt Zaten Ekli");
            }
        }
        private void loadKisi()
        {
            NpgsqlCommand command = new NpgsqlCommand();
            command.CommandText = "SELECT  kisi_no, adı, soyadı FROM public.tb_personel WHERE tc_no=@tcno";
            command.Parameters.AddWithValue("@tcno", NpgsqlTypes.NpgsqlDbType.Bigint, Convert.ToDecimal(tBoxTCNo.Text));
            DataTable dt = dbConnection.getData(command);
            if(dt.Rows.Count > 0)
            {
                tbox_borclu_kisino.Text = dt.Rows[0][0].ToString();
                tBoxAdi.Text = dt.Rows[0][1].ToString();
                tBoxSoyadi.Text = dt.Rows[0][2].ToString();
            }
        }
        private void tBoxTCNo_KeyDown(object sender, KeyEventArgs e)
        {
        }
        private Decimal parayaCevir(String text)
        {
            Decimal result=-1;
            try
            {
                result = Convert.ToDecimal(text, new CultureInfo("tr-TR"));
                if(result < 0)
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

        private decimal[] getBorclu()
        {
            
            DataTable dt = (DataTable)dgvBorclular.DataSource;
            decimal[] result = new decimal[dt.Rows.Count];
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                result[i] = Convert.ToDecimal(dt.Rows[i][0]);
            }
            return result;
        }
        private int[] getAlacak()
        {

            DataTable dt = (DataTable)dgvAlacak.DataSource;
            int[] result = new int[dt.Rows.Count];
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                result[i] = Convert.ToInt32(dt.Rows[i][0]);
            }
            return result;
        }


        private void UpdateIcra2DB()
        {
            try
            {
                decimal bakiye = parayaCevir(tBoxBakiye.Text);
                if (bakiye > 0)
                {
                    NpgsqlCommand command = new NpgsqlCommand();
                    command.CommandText = "select updateIcra(@kayitno_, @esasno , @tarih , @icra_dairesi, @tutar_ , @icraturu, @borclu , @alacak, @oncelik, @sabit_kesinti);";
                    command.Parameters.AddWithValue("@kayitno_", NpgsqlTypes.NpgsqlDbType.Integer, this.IcraKayitNo);

                    command.Parameters.AddWithValue("@esasno", NpgsqlTypes.NpgsqlDbType.Text, tBoxEsasNo.Text);
                    command.Parameters.AddWithValue("@tarih", NpgsqlTypes.NpgsqlDbType.Date, Date_date.Value);

                    command.Parameters.AddWithValue("@icra_dairesi", NpgsqlTypes.NpgsqlDbType.Integer, Convert.ToInt32(cBox_İcraDairesi.SelectedValue));

                    command.Parameters.AddWithValue("@sabit_kesinti", NpgsqlTypes.NpgsqlDbType.Money, parayaCevir(tBox_sabit_kesinti.Text));
                    command.Parameters.AddWithValue("@tutar_", NpgsqlTypes.NpgsqlDbType.Money, bakiye);
                    command.Parameters.AddWithValue("@icraturu", NpgsqlTypes.NpgsqlDbType.Integer, Convert.ToInt32(cBox_IcraTuru.SelectedValue));
                    command.Parameters.AddWithValue("@oncelik", NpgsqlTypes.NpgsqlDbType.Boolean, cBox_Oncelik.Checked);
                    command.Parameters.AddWithValue("@borclu", NpgsqlTypes.NpgsqlDbType.Array | NpgsqlTypes.NpgsqlDbType.Integer, getBorclu());
                    command.Parameters.AddWithValue("@alacak", NpgsqlTypes.NpgsqlDbType.Array | NpgsqlTypes.NpgsqlDbType.Integer, getAlacak());
                    // command.CommandType = CommandType.StoredProcedure;
                    dbConnection.sendQuery(command);
                    MessageBoxs.SuccessMessage("İcra Dosyası Güncelleme Başarılı");
                }
            }
            catch (Exception)
            {

                throw;
            }


        }

        private void addIcra2DB()
        {
            try
            {
                decimal bakiye = parayaCevir(tBoxBakiye.Text);
                if (bakiye > 0)
                {
                    NpgsqlCommand command = new NpgsqlCommand();
                    command.CommandText = "select addIcra(@esasno , @tarih , @icra_dairesi, @tutar_ , @icraturu, @borclu , @alacak, @oncelik, @sabit_kesinti);";
                    command.Parameters.AddWithValue("@esasno", NpgsqlTypes.NpgsqlDbType.Text, tBoxEsasNo.Text);
                    command.Parameters.AddWithValue("@tarih", NpgsqlTypes.NpgsqlDbType.Date, Date_date.Value);

                    command.Parameters.AddWithValue("@icra_dairesi", NpgsqlTypes.NpgsqlDbType.Integer, Convert.ToInt32(cBox_İcraDairesi.SelectedValue));

                    command.Parameters.AddWithValue("@tutar_", NpgsqlTypes.NpgsqlDbType.Money, bakiye);

                    command.Parameters.AddWithValue("@sabit_kesinti", NpgsqlTypes.NpgsqlDbType.Money, parayaCevir(tBox_sabit_kesinti.Text));

                    command.Parameters.AddWithValue("@icraturu", NpgsqlTypes.NpgsqlDbType.Integer, Convert.ToInt32(cBox_IcraTuru.SelectedValue));
                    command.Parameters.AddWithValue("@oncelik", NpgsqlTypes.NpgsqlDbType.Boolean, cBox_Oncelik.Checked);
                    command.Parameters.AddWithValue("@borclu", NpgsqlTypes.NpgsqlDbType.Array | NpgsqlTypes.NpgsqlDbType.Integer, getBorclu());
                    command.Parameters.AddWithValue("@alacak", NpgsqlTypes.NpgsqlDbType.Array | NpgsqlTypes.NpgsqlDbType.Integer, getAlacak());
                    // command.CommandType = CommandType.StoredProcedure;
                    dbConnection.sendQuery(command);
                    MessageBoxs.SuccessMessage("İcra Dosyası Oluşturma Başarılı");
                    clear();
                }
            }
            catch (Exception)
            {

                throw;
            }
               

        }
        private void clear()
        {
            clearBorcluTbox();
            cBoxAlacak.SelectedIndex = 0;
            cBox_IcraTuru.SelectedIndex = 0;
            cBox_İcraDairesi.SelectedIndex = 0;
            tBoxBakiye.Text = "";
            dgvBorclular.DataSource = prepareBorcluDGV();
            dgvAlacak.DataSource = prepareAlacakDGV();
        }
        private void btn_save_Click(object sender, EventArgs e)
        {
            try
            {
                if(dgvAlacak.Rows.Count == 0 || dgvBorclular.Rows.Count == 0)
                {
                    MessageBoxs.WarningMessage("Dikkat borçlu veya kesinti yapılabilecek alacak şeçilmemiş.");
                    return;
                }
                if (this.IcraKayitNo != 0)
                {
                    UpdateIcra2DB();
                }
                else
                {
                    addIcra2DB();
                }
            }
            catch (Exception ex)
            {
                MessageBoxs.ErrorMessage(ex);
            }
        }

        private void tBoxTCNo_TextChanged(object sender, EventArgs e)
        {
            if(tBoxTCNo.TextLength == 11)
            {
                loadKisi();
            }
        }

        private void tBoxBakiye_Validating(object sender, CancelEventArgs e)
        {
            tBoxBakiye.Text = tBoxBakiye.Text.Replace(',', '.');
        }

        private void cBox_Oncelik_CheckedChanged(object sender, EventArgs e)
        {
            tBox_sabit_kesinti.Enabled = cBox_Oncelik.Checked;
            tBox_sabit_kesinti.Text = "0";
        }

        private void tBox_sabit_kesinti_Validating(object sender, CancelEventArgs e)
        {
            tBox_sabit_kesinti.Text = tBox_sabit_kesinti.Text.Replace(',', '.');
        }
    }
}
