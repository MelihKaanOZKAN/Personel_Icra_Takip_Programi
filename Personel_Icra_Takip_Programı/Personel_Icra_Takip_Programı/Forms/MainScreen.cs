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
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Personel_Icra_Takip_Programı.Forms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            InitializeComponent();
            Thread.CurrentThread.CurrentCulture = CultureInfo.GetCultureInfo("tr-TR");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            kryptonDockableNavigator1.SelectedPage = kryptonPage1;
            LoadIcraTuru();
            LoadAlacak();
            fillCBoxKurumlar();
            changeKurumButtonMode(false);
        }

        #region Personel
        private void kesintiEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmIcralar frmIcralar = new frmIcralar(Convert.ToInt32(dataGV_Personel.SelectedRows[0].Cells[0].Value));
            frmIcralar.Show();
        }

        private void icraSırasıAlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRaporEkranı form = new frmRaporEkranı(Convert.ToInt32(dataGV_Personel.SelectedRows[0].Cells[0].Value));
            form.Show();

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
        private void btnAddPersonel_Click(object sender, EventArgs e)
        {
            frm_addPersonel form = new frm_addPersonel();
            form.Show();

        }

        private void görüntüleToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                frm_addPersonel form = new frm_addPersonel();
                form.tboxKisiNo.Text = dataGV_Personel.Rows[dataGV_Personel.SelectedRows[0].Index].Cells[0].Value.ToString();
                form.Show();
            }
            catch (Exception ex)
            {
                MessageBoxs.ErrorMessage(ex);
            }
        }
        private NpgsqlCommand getFilteCkurum(NpgsqlCommand input)
        {
            try
            {
                if (cBoxKurumlar.SelectedIndex != 0)
                {
                    input.CommandText += " ckurum=@ckurum  ";
                    input.Parameters.AddWithValue("@ckurum", NpgsqlTypes.NpgsqlDbType.Integer, Convert.ToInt32(cBoxKurumlar.SelectedValue));
                }
            }
            catch (Exception)
            {

                throw;
            }
            return input;
        }
        private  string getSearchAnd (string input)
        {
            if(input[input.Length-2] == ' ')
            {
                input += "AND ";
            }
            return input;
        }
            
       private NpgsqlCommand getFilter(NpgsqlCommand input)
        {

            try
            {
                if (cBoxKurumlar.SelectedIndex != 0 || tBox_searchAdi.Text != "" || tBox_Search_kisiNo.Text != ""|| tBox_Search_Soyadi.Text != "" || tBox_search_tcno.Text != "")
                {
                    input.CommandText += "WHERE ";
                    getFilteCkurum(input);
                    if(tBox_Search_kisiNo.Text != "")
                    {
                        input.CommandText = getSearchAnd(input.CommandText);
                        input.CommandText += " kisi_no=@kisino  ";
                        input.Parameters.AddWithValue("@kisino", NpgsqlTypes.NpgsqlDbType.Integer, Convert.ToInt32(tBox_Search_kisiNo.Text));

                    }
                   else if (tBox_search_tcno.Text != "")
                    {
                        input.CommandText = getSearchAnd(input.CommandText);
                        input.CommandText += " tc_no=@tcno  ";
                        input.Parameters.AddWithValue("@tcno", NpgsqlTypes.NpgsqlDbType.Bigint, Convert.ToDecimal(tBox_search_tcno.Text));

                    }
                    else
                    {
                        if(tBox_searchAdi.Text != "")
                        {

                            input.CommandText = getSearchAnd(input.CommandText);
                            input.CommandText += " P.adı ILIKE @adı  ";
                            input.Parameters.AddWithValue("@adı",  tBox_searchAdi.Text+"%");

                        }
                        if (tBox_Search_Soyadi.Text != "")
                        {

                            input.CommandText = getSearchAnd(input.CommandText);
                            input.CommandText += " P.soyadı ILIKE @soyadı  ";
                            input.Parameters.AddWithValue("@soyadı", tBox_Search_Soyadi.Text+"%");

                        }
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
            return input;
        }



        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                NpgsqlCommand command = new NpgsqlCommand();
                command.CommandText = "SELECT kisi_no as \"Kişi Numarası\", tc_no as \"Kimlik Numarası\", CK.adi as \"Çalıştığı Kurum\", adı as \"Adı\", soyadı as \"Soyadı\" FROM public.tb_personel P " +
                    "INNER JOIN tb_kurumlar CK on CK.kk5=P.ckurum ";

               command= getFilter(command);
                dataGV_Personel.DataSource = dbConnection.getData(command);
            }
            catch (Exception ex)
            {
                MessageBoxs.ErrorMessage(ex);
            }
        }
        #endregion
        #region GM
        private void changeGMTextBoxstatus(bool status)
        {
            tBox_kk1.Enabled = status;
            tbox_kk2.Enabled = status;
            tbox_kk3.Enabled = status;
            tBox_kk4.Enabled = status;
            tBox_genelMudurlukAdı.Enabled = status;
        }
        private void clearGM()
        {
            clearGMTextBoxs();
            changeKurumButtonMode(false);
            dataGV_Kurumlar.DataSource = null;
        }
        private void clearGMTextBoxs()
        {
            Tbox_kk0.Text = "";
            tBox_kk1.Text = "";
            tbox_kk2.Text = "";
            tbox_kk3.Text = "";
            tBox_kk4.Text = "";
            tBox_genelMudurlukAdı.Text = "";
        }
        private void clearGMButtons()
        {
            btn_addGM.Text = "Ekle";
            btn_UpdateGM.Text = "Güncelle";
            btn_delGM.Text = "Sil";
            clearGM();
        }
        private void refreshData()
        {
            try
            {
                NpgsqlCommand command = new NpgsqlCommand();
                string sql = "SELECT kk0 as \"KK0\", kk1 as \"KK1\",  kk2 as \"KK2\", kk3 as \"KK3\", kk4 as \"KK4\",adi as \"Genel Müdürlük Adı\" FROM public.tb_gmudurluk";
                command.CommandText = sql;
                DataGV_GM.DataSource = dbConnection.getData(command);
                DataGV_GM.Columns[0].Width = 30;
                DataGV_GM.Columns[1].Width = 30;
                DataGV_GM.Columns[2].Width = 30;
                DataGV_GM.Columns[3].Width = 30;
                DataGV_GM.Columns[4].Width = 30;
                DataGV_GM.Columns[5].Width = 400;
                clearGMButtons();
            }
            catch (Exception ex)
            {
                MessageBoxs.ErrorMessage(ex);
            }
        }
        private void btn_addGM_Click(object sender, EventArgs e)
        {
            try
            {
                if (btn_addGM.Text == "Ekle")
                {
                    clearGMTextBoxs();
                    btn_delGM.Enabled = false;
                    btn_UpdateGM.Enabled = false;
                    changeGMTextBoxstatus(true);
                    btn_addGM.Text = "Kaydet";
                }
                else if (btn_addGM.Text == "Kaydet")
                {
                   NpgsqlCommand command = new NpgsqlCommand();
                    command.CommandText = "INSERT INTO public.tb_gmudurluk (kk1, kk2, kk3, kk4, adi) " +
                        "VALUES (@kk1, @kk2, @kk3, @kk4, @adi);";
                    command.Parameters.AddWithValue("@kk1", NpgsqlTypes.NpgsqlDbType.Smallint, Int16.Parse(tBox_kk1.Text));
                    command.Parameters.AddWithValue("@kk2", NpgsqlTypes.NpgsqlDbType.Smallint, Int16.Parse(tbox_kk2.Text));
                    command.Parameters.AddWithValue("@kk3", NpgsqlTypes.NpgsqlDbType.Smallint, Int16.Parse(tbox_kk3.Text));
                    command.Parameters.AddWithValue("@kk4", NpgsqlTypes.NpgsqlDbType.Smallint, Int16.Parse(tBox_kk4.Text));
                    command.Parameters.AddWithValue("@adi", NpgsqlTypes.NpgsqlDbType.Varchar, tBox_genelMudurlukAdı.Text);
                    dbConnection.sendQuery(command);
                    refreshData();
                    changeGMTextBoxstatus(false);
                    btn_delGM.Enabled = true;
                    btn_UpdateGM.Enabled = true;
                    btn_addGM.Text = "Ekle";

                }
            }
            catch (Exception ex)
            {
               MessageBoxs.ErrorMessage(ex);
            }
        }
        private void DataGV_GM_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex > -1)
                {
                    Tbox_kk0.Text = DataGV_GM.Rows[e.RowIndex].Cells[0].Value.ToString();
                    tBox_kk1.Text = DataGV_GM.Rows[e.RowIndex].Cells[1].Value.ToString();
                    tbox_kk2.Text = DataGV_GM.Rows[e.RowIndex].Cells[2].Value.ToString();
                    tbox_kk3.Text = DataGV_GM.Rows[e.RowIndex].Cells[3].Value.ToString();
                    tBox_kk4.Text = DataGV_GM.Rows[e.RowIndex].Cells[4].Value.ToString();
                    tBox_genelMudurlukAdı.Text = DataGV_GM.Rows[e.RowIndex].Cells[5].Value.ToString();
                    changeKurumButtonMode(true);
                    refreshKurumData();
                }
            }
            catch (Exception ex)
            {
                MessageBoxs.ErrorMessage(ex);
            }
        }
        private void btn_GMGetData_Click(object sender, EventArgs e)
        {
            refreshData();
        }
        private void btn_UpdateGM_Click(object sender, EventArgs e)
        {
            try
            {
                if (Tbox_kk0.Text != "")
                {
                    if (btn_UpdateGM.Text == "Güncelle")
                    {
                        btn_delGM.Enabled = false;
                        btn_addGM.Enabled = false;
                        changeGMTextBoxstatus(true);
                        btn_UpdateGM.Text = "Kaydet";
                    }
                    else if (btn_UpdateGM.Text == "Kaydet")
                    {
                        NpgsqlCommand command = new NpgsqlCommand();
                        command.CommandText = "UPDATE public.tb_gmudurluk SET kk1=@kk1, kk2=@kk2, kk3=@kk3, kk4=@kk4, adi=@adi WHERE kk0=@kk0 ;";
                        command.Parameters.AddWithValue("@kk0", NpgsqlTypes.NpgsqlDbType.Smallint, Int16.Parse(Tbox_kk0.Text));
                        command.Parameters.AddWithValue("@kk1", NpgsqlTypes.NpgsqlDbType.Smallint, Int16.Parse(tBox_kk1.Text));
                        command.Parameters.AddWithValue("@kk2", NpgsqlTypes.NpgsqlDbType.Smallint, Int16.Parse(tbox_kk2.Text));
                        command.Parameters.AddWithValue("@kk3", NpgsqlTypes.NpgsqlDbType.Smallint, Int16.Parse(tbox_kk3.Text));
                        command.Parameters.AddWithValue("@kk4", NpgsqlTypes.NpgsqlDbType.Smallint, Int16.Parse(tBox_kk4.Text));
                        command.Parameters.AddWithValue("@adi", NpgsqlTypes.NpgsqlDbType.Varchar, tBox_genelMudurlukAdı.Text);
                        dbConnection.sendQuery(command);
                        refreshData();
                        changeGMTextBoxstatus(false);
                        btn_delGM.Enabled = true;
                        btn_addGM.Enabled = true;
                        btn_UpdateGM.Text = "Güncelle";
                    }
                }
                else
                {

                    MessageBoxs.WarningMessage("Önce Genel Müdürlük Seçmelisiniz");
                }
            }
            catch (Exception ex)
            {
                MessageBoxs.ErrorMessage(ex);
            }
        }
        private void btn_delGM_Click(object sender, EventArgs e)
        {
            try
            {
                if (Tbox_kk0.Text != "")
                {
                    DialogResult dr = MessageBoxs.DeleteQuestion("Seçili Genel Müdürlük Silinecektir?");
                    if (dr == DialogResult.Yes)
                    {
                        NpgsqlCommand command = new NpgsqlCommand();
                        command.CommandText = "DELETE FROM public.tb_gmudurluk WHERE kk0=@kk0 ;";
                        command.Parameters.AddWithValue("@kk0", NpgsqlTypes.NpgsqlDbType.Smallint, Int16.Parse(Tbox_kk0.Text));
                        dbConnection.sendQuery(command);
                        refreshData();
                    }
                }
                else
                {

                    MessageBoxs.WarningMessage("Önce Genel Müdürlük Seçmelisiniz");
                }
            }
           catch(Exception ex)
            {
                MessageBoxs.ErrorMessage(ex);
            }
        }
        #endregion
        #region Kurumlar
        private void clearKurum()
        {
            tBox_kk5.Text = "";
            tBoxKurumAdi.Text = "";
        }
        private void clearKurumButtons()
        {
            btn_AddKurum.Text = "Ekle";
            btn_UpdateKurum.Text = "Güncelle";
            btn_DeleteKurum.Text = "Sil";
            clearKurum();
        }
        private void changeKurumButtonMode(bool mode)
        {
            if(!mode)
            {
                clearKurum();
            }
            btn_AddKurum.Enabled = mode;
            btn_DeleteKurum.Enabled = mode;
            btn_UpdateKurum.Enabled = mode;
        }
        private void changeKurumTboxMode(bool mode)
        {
            tBox_kk5.Enabled = mode;
            tBoxKurumAdi.Enabled = mode;
        }
        private void refreshKurumData()
        {
            try
            {

                string sql = "SELECT kk5 as \"Kurum Kodu\",  KU.adi as \"Kurum Adı\"  " +
                    " FROM public.tb_kurumlar KU " +
                    "INNER JOIN public.tb_gmudurluk GM on GM.kk0=KU.genelmudurluk WHERE GM.kk0=@kk0";
                NpgsqlCommand command = new NpgsqlCommand(sql);
                command.Parameters.AddWithValue("@kk0", NpgsqlTypes.NpgsqlDbType.Smallint, Int16.Parse(Tbox_kk0.Text));
                dataGV_Kurumlar.DataSource = dbConnection.getData(command);
                clearKurumButtons();
                changeKurumTboxMode(false);
            }
            catch (Exception)
            {

                throw;
            }

        }
        private void changeTboxMode(bool mode)
        {
            tBox_kk5.Enabled = mode;
            tBoxKurumAdi.Enabled = mode;
        }
        private void btn_AddKurum_Click(object sender, EventArgs e)
        {
            try
            {
                if (btn_AddKurum.Text == "Ekle")
                {
                    clearKurum();
                    btn_UpdateKurum.Enabled = false;
                    btn_DeleteKurum.Enabled = false;
                    changeKurumTboxMode(true);
                    btn_AddKurum.Text = "Kaydet";
                }
                else if (btn_AddKurum.Text == "Kaydet")
                {
                    NpgsqlCommand command = new NpgsqlCommand();
                    command.CommandText = "INSERT INTO public.tb_kurumlar (kk5, genelmudurluk, adi) " +
                        "VALUES (@kk5, @kk0, @adi);";
                    command.Parameters.AddWithValue("@kk5", NpgsqlTypes.NpgsqlDbType.Smallint, Int16.Parse(tBox_kk5.Text));
                    command.Parameters.AddWithValue("@kk0", NpgsqlTypes.NpgsqlDbType.Smallint, Int16.Parse(Tbox_kk0.Text));
                    command.Parameters.AddWithValue("@adi", NpgsqlTypes.NpgsqlDbType.Varchar, tBoxKurumAdi.Text);
                    dbConnection.sendQuery(command);
                    refreshKurumData();
                    btn_UpdateKurum.Enabled = true;
                    btn_DeleteKurum.Enabled = true;
                    btn_AddKurum.Text = "Ekle";
                }
            }
            catch(PostgresException ex)
            {
                if(ex.Message.Contains("duplicate"))
                {
                    MessageBoxs.ErrorMessage(new Exception("Bu Kurum Kodu Mevcuttur"));
                }
            }
            catch (Exception ex)
            {
                MessageBoxs.ErrorMessage(ex);
            }
        }
        private void btn_UpdateKurum_Click(object sender, EventArgs e)
        {
            try
            {
                if(tBox_kk5.Text!="")
                {
                    if (btn_UpdateKurum.Text == "Güncelle")
                    {
                        btn_AddKurum.Enabled = false;
                        btn_DeleteKurum.Enabled = false;
                        changeKurumTboxMode(true);
                        tBox_kk5.Enabled = false;
                        btn_UpdateKurum.Text = "Kaydet";
                    }
                    else if (btn_UpdateKurum.Text == "Kaydet")
                    {
                        NpgsqlCommand command = new NpgsqlCommand();
                        command.CommandText = "UPDATE public.tb_kurumlar SET  adi=@adi WHERE kk5=@kk5 ;";
                        command.Parameters.AddWithValue("@kk5", NpgsqlTypes.NpgsqlDbType.Smallint, Int16.Parse(tBox_kk5.Text));
                         command.Parameters.AddWithValue("@adi", NpgsqlTypes.NpgsqlDbType.Varchar, tBoxKurumAdi.Text);
                        dbConnection.sendQuery(command);
                        refreshKurumData();
                        btn_AddKurum.Enabled = true;
                        btn_DeleteKurum.Enabled = true ;

                        btn_UpdateKurum.Text = "Güncelle";
                    }
                }
                else
                {
                    MessageBoxs.WarningMessage("Önce Kurum Seçiniz");
                }
            }
            catch (Exception ex)
            {
               MessageBoxs.ErrorMessage(ex);
            }
        }
        private void btn_DeleteKurum_Click(object sender, EventArgs e)
        {
            try
            {
                if (tBox_kk5.Text != "")
                {
                        DialogResult dr = MessageBoxs.DeleteQuestion("Seçili Kurum Silinecektir?");
                        if (dr == DialogResult.Yes)
                        {
                            NpgsqlCommand command = new NpgsqlCommand();
                            command.CommandText = "DELETE FROM public.tb_kurumlar WHERE kk05@kk5 ;";
                            command.Parameters.AddWithValue("@kk5", NpgsqlTypes.NpgsqlDbType.Smallint, Int16.Parse(tBox_kk5.Text));
                            dbConnection.sendQuery(command);
                            refreshKurumData();
                        }
                }
                else
                {
                    MessageBoxs.WarningMessage("Önce Kurum Seçiniz");
                }
            }
            catch (Exception ex)
            {
                MessageBoxs.ErrorMessage(ex);
            }
        }
        private void btn_SearchKurum_Click(object sender, EventArgs e)
        {
            try
            {
                refreshKurumData();
            }
            catch (Exception ex)
            {
                MessageBoxs.ErrorMessage(ex);
            }
        }
        private void dataGV_Kurumlar_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex > -1)
            {
                tBox_kk5.Text = dataGV_Kurumlar.Rows[e.RowIndex].Cells[0].Value.ToString();
                tBoxKurumAdi.Text = dataGV_Kurumlar.Rows[e.RowIndex].Cells[1].Value.ToString();
            }
              
        }


        #endregion
        #region referanceData
        private void cBox_ReferansceData_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cBox_ReferansceData.SelectedIndex != 0)
            {
                btn_ref_add.Enabled = true;
                btn_ref_del.Enabled = true;
                btn_ref_update.Enabled = true;
                if (cBox_ReferansceData.SelectedIndex == 2)
                {
                    CHeck_BakiyeDusumu.Visible = true;
                }
                else
                {

                    CHeck_BakiyeDusumu.Visible = false;
                }
            }
            else
            {
                btn_ref_add.Enabled = false;
                btn_ref_del.Enabled = false;
                btn_ref_update.Enabled = false;
                DGV_referance.DataSource = null;
            }
        }
        private void cBox_ReferansceData_DropDown(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("DataTypeNo", typeof(int));
            dt.Columns.Add("DataType", typeof(string));
            DataRow dr = dt.NewRow();
            dr[0] = 0;
            dr[1] = "";
            dt.Rows.Add(dr);
            dr = dt.NewRow();
            dr[0] = 1;
            dr[1] = "Ücret Türleri";
            dt.Rows.Add(dr);
            dr = dt.NewRow();
            dr[0] = 2;
            dr[1] = "İcra Türleri";
            dt.Rows.Add(dr);
            cBox_ReferansceData.DataSource = dt;
            cBox_ReferansceData.DisplayMember = "DataType";
            cBox_ReferansceData.ValueMember = "DataTypeNo";

        }
        private void searchAlacak()
        {
            try
            {
                NpgsqlCommand command = new NpgsqlCommand();
                string sql = "SELECT kayitno as \"Kayıt No\", turAdi as \"Ücret Türü\" FROM public.tb_alacak_turleri ORDER BY kayitno ASC";
                command.CommandText = sql;
                DGV_referance.DataSource = dbConnection.getData(command);
            }
            catch (Exception)
            {

                throw;
            }
        }
        private void searchIcraTuru()
        {
            try
            {
                NpgsqlCommand command = new NpgsqlCommand();
                string sql = "SELECT kayitno as \"Kayıt No\", turadi as \"İcra Türü\", kesintidusumu as \"Bakiyeden Düşüm\" FROM public.tb_icra_turleri ORDER BY kayitno ASC";
                command.CommandText = sql;
                DGV_referance.DataSource = dbConnection.getData(command);
            }
            catch (Exception)
            {

                throw;
            }
        }
        private void btn_Ref_search_Click(object sender, EventArgs e)
        {
            try
            {
                switch (cBox_ReferansceData.SelectedValue)
                {
                    case 0:
                        {
                            DGV_referance.DataSource = null;
                            ref_clearButtons();
                            break;
                        }
                    case 1:
                        {
                            searchAlacak();
                            break;
                        }
                    case 2:
                        {

                            searchIcraTuru();
                            break;
                        }
                }
            }
            catch (Exception ex)
            {
                MessageBoxs.ErrorMessage(ex);
            }
        }
        private void DGV_referance_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex > -1)
                {
                    tBox_Ref_KayitNo.Text = DGV_referance.Rows[e.RowIndex].Cells[0].Value.ToString();
                    tBox_turadi.Text = DGV_referance.Rows[e.RowIndex].Cells[1].Value.ToString();
                    if (cBox_ReferansceData.SelectedIndex == 2)
                    {
                        CHeck_BakiyeDusumu.Checked = (bool)DGV_referance.Rows[e.RowIndex].Cells[2].Value;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBoxs.ErrorMessage(ex);
            }
        }
        private void ref_clearTextBoxs()
        {
            tBox_Ref_KayitNo.Text = "";
            tBox_turadi.Text = "";
            CHeck_BakiyeDusumu.Checked = false;
        }
        private void ref_clearButtons()
        {
            btn_ref_add.Text = "Ekle";
            btn_ref_add.Enabled = true;
            btn_ref_del.Text = "Sil";
            btn_ref_del.Enabled = true;
            btn_ref_update.Text = "Güncelle";
            btn_ref_update.Enabled = true;
            ref_clearTextBoxs();
        }
        private void changeRefTextBoxMode (bool mode)
        {
            tBox_turadi.Enabled = mode;
            CHeck_BakiyeDusumu.Enabled = mode;
        }
        private void addAlacak()
        {
            if(btn_ref_add.Text == "Ekle")
            {
                ref_clearTextBoxs();
                btn_ref_del.Enabled = false;
                btn_ref_update.Enabled = false;
                btn_ref_add.Text = "Kaydet";
                cBox_ReferansceData.Enabled = false;
                changeRefTextBoxMode(true);
            }
            else if(btn_ref_add.Text == "Kaydet")
            {
                NpgsqlCommand command = new NpgsqlCommand();
                string sql = "INSERT INTO public.tb_alacak_turleri (turadi) VALUES (@turadi);";
                command.CommandText = sql;
                command.Parameters.AddWithValue("@turadi", NpgsqlTypes.NpgsqlDbType.Text, tBox_turadi.Text);
                dbConnection.sendQuery(command);
                ref_clearButtons();
                changeRefTextBoxMode(false);
                cBox_ReferansceData.Enabled = true;
                searchAlacak();
            }
        }
        private void addIcraTuru()
        {
            if (btn_ref_add.Text == "Ekle")
            {
                ref_clearTextBoxs();
                btn_ref_del.Enabled = false;
                btn_ref_update.Enabled = false;
                btn_ref_add.Text = "Kaydet";
                cBox_ReferansceData.Enabled = false;
                changeRefTextBoxMode(true);
            }
            else if (btn_ref_add.Text == "Kaydet")
            {
                NpgsqlCommand command = new NpgsqlCommand();
                string sql = "INSERT INTO public.tb_icra_turleri (turadi, kesintidusumu) VALUES (@turadi, @dusum);";
                command.CommandText = sql;
                command.Parameters.AddWithValue("@turadi", NpgsqlTypes.NpgsqlDbType.Text, tBox_turadi.Text);
                command.Parameters.AddWithValue("@dusum", NpgsqlTypes.NpgsqlDbType.Boolean, CHeck_BakiyeDusumu.Checked);
                dbConnection.sendQuery(command);
                ref_clearButtons();
                changeRefTextBoxMode(false);
                cBox_ReferansceData.Enabled = true;
                searchIcraTuru();
            }
        }
        private void updateAlacak()
        {
            try
            {
                if (btn_ref_update.Text == "Güncelle")
                {
                    btn_ref_del.Enabled = false;
                    btn_ref_add.Enabled = false;
                    btn_ref_update.Text = "Kaydet";
                    cBox_ReferansceData.Enabled = false;
                    changeRefTextBoxMode(true);
                }
                else if (btn_ref_update.Text == "Kaydet")
                {
                    NpgsqlCommand command = new NpgsqlCommand();
                    string sql = "UPDATE public.tb_alacak_turleri SET turadi=@turadi WHERE kayitno=@kayitno;";
                    command.CommandText = sql;
                    command.Parameters.AddWithValue("@turadi", NpgsqlTypes.NpgsqlDbType.Text, tBox_turadi.Text);
                    command.Parameters.AddWithValue("@kayitno", NpgsqlTypes.NpgsqlDbType.Integer, Convert.ToInt32(tBox_Ref_KayitNo.Text));
                    dbConnection.sendQuery(command);
                    ref_clearButtons();
                    changeRefTextBoxMode(false);
                    cBox_ReferansceData.Enabled = true;
                    searchAlacak();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
        private void updateIcraTuru()
        {
            try
            {
                if (btn_ref_update.Text == "Güncelle")
                {
                    btn_ref_del.Enabled = false;
                    btn_ref_add.Enabled = false;
                    btn_ref_update.Text = "Kaydet";
                    cBox_ReferansceData.Enabled = false;
                    changeRefTextBoxMode(true);
                }
                else if (btn_ref_update.Text == "Kaydet")
                {
                    NpgsqlCommand command = new NpgsqlCommand();
                    string sql = "UPDATE public.tb_icra_turleri SET turadi=@turadi, kesintidusumu=@dusum WHERE kayitno=@kayitno;";
                    command.CommandText = sql;
                    command.Parameters.AddWithValue("@turadi", NpgsqlTypes.NpgsqlDbType.Text, tBox_turadi.Text);
                    command.Parameters.AddWithValue("@kayitno", NpgsqlTypes.NpgsqlDbType.Integer, Convert.ToInt32(tBox_Ref_KayitNo.Text));
                    command.Parameters.AddWithValue("@dusum", NpgsqlTypes.NpgsqlDbType.Boolean, CHeck_BakiyeDusumu.Checked);
                    dbConnection.sendQuery(command);
                    ref_clearButtons();
                    changeRefTextBoxMode(false);
                    cBox_ReferansceData.Enabled = true;
                    searchIcraTuru();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
        private void delAlacak()
        {
            try
            {
                NpgsqlCommand command = new NpgsqlCommand();
                command.CommandText = "DELETE FROM public.tb_alacak_turleri WHERE kayitno=@kayitno";
                command.Parameters.AddWithValue("@kayitno", NpgsqlTypes.NpgsqlDbType.Integer, Convert.ToInt32(tBox_Ref_KayitNo.Text));
                dbConnection.sendQuery(command);
                ref_clearButtons();
                changeRefTextBoxMode(false);
                cBox_ReferansceData.Enabled = true;
                searchAlacak();

            }
            catch (Exception)
            {

                throw;
            }
        }
        private void delIcraTuru()
        {
            try
            {
                NpgsqlCommand command = new NpgsqlCommand();
                command.CommandText = "DELETE FROM public.tb_icra_turleri WHERE kayitno=@kayitno";
                command.Parameters.AddWithValue("@kayitno", NpgsqlTypes.NpgsqlDbType.Integer, Convert.ToInt32(tBox_Ref_KayitNo.Text));
                dbConnection.sendQuery(command);
                ref_clearButtons();
                changeRefTextBoxMode(false);
                cBox_ReferansceData.Enabled = true;
                searchAlacak();

            }
            catch (Exception)
            {

                throw;
            }
        }
        private void btn_ref_add_Click(object sender, EventArgs e)
        {

            try
            {
                switch (cBox_ReferansceData.SelectedValue)
                {
                    case 1:
                        {
                            addAlacak();
                            break;
                        }
                    case 2:
                        {
                            addIcraTuru();
                            break;
                        }
                }
            }
            catch (Exception ex)
            {
                MessageBoxs.ErrorMessage(ex);
            }
        }
        private void btn_ref_update_Click(object sender, EventArgs e)
        {
            try
            {
                if (tBox_Ref_KayitNo.Text != "")
                {
                    switch (cBox_ReferansceData.SelectedValue)
                    {
                        case 1:
                            {
                                updateAlacak();
                                break;
                            }
                        case 2:
                            {
                                updateIcraTuru();
                                break;
                            }
                    }
                }
                else
                {
                    MessageBoxs.WarningMessage("Önce Kayıt Seçiniz");
                }

            }
            catch (Exception ex)
            {
                MessageBoxs.ErrorMessage(ex);
            }
        }
        private void btn_ref_del_Click(object sender, EventArgs e)
        {
            try
            {
                if (tBox_Ref_KayitNo.Text != "")
                {
                    DialogResult dr = MessageBoxs.DeleteQuestion("Seçili kayıt silinecek?");
                    if (dr == DialogResult.Yes)
                    {
                        switch (cBox_ReferansceData.SelectedValue)
                        {
                            case 1:
                                {
                                    delAlacak();
                                    break;
                                }
                            case 2:
                                {
                                    delIcraTuru();
                                    break;
                                }
                        }
                    }
                }
                else
                {
                    MessageBoxs.WarningMessage("Önce Kayıt Seçiniz");
                }
            }
            catch (Exception ex)
            {
                MessageBoxs.ErrorMessage(ex);
            }
        }
        #endregion
        #region icraDaireleri
        private void searchIcraDairesi()
        {
            try
            {
                NpgsqlCommand command = new NpgsqlCommand();
                command.CommandText = "SELECT kurumno AS \"Kurum No\", adı AS \"Kurum Adı\", " +
                    "banka AS \"Banka Adı\", iban AS \"IBAN No\" FROM public.tb_icradairesi ORder BY kurumno ASC";
                DGVIcraDaireleri.DataSource = dbConnection.getData(command);
                    
            }
            catch (Exception)
            {

                throw;
            }
        }
        private void btn_icradairesi_search_Click(object sender, EventArgs e)
        {
            try
            {
                searchIcraDairesi();
            }
            catch (Exception ex)
            {
                MessageBoxs.ErrorMessage(ex);
            }
        }
        private void changeIcraDairesiTextBoxMode(bool mode)
        {
            tBox_icra_kurumIBAN.Enabled = mode;
            tBox_icra_kurumAdı.Enabled = mode;
            tBox_icra_kurumBanka.Enabled = mode;
        }
        private void clearIcraDairesiTextBox()
        {
            tBox_icra_kurumAdı.Text = "";
            tBox_icra_kurumBanka.Text = "";
            tBox_icra_kurumIBAN.Text = "";
            tBox_icra_kurumno.Text = "";
        }
        private void clearIcraDairesiButtons()
        {
            btn_icradairesi_add.Text = "Ekle";
            btn_icradairesi_add.Enabled = true;
            btn_icradairesi_del.Text = "Sil";
            btn_icradairesi_del.Enabled = true;
            btn_icradairesi_update.Text = "Güncelle";
            btn_icradairesi_update.Enabled = true;
            clearIcraDairesiTextBox();
        }
        private void addIcraDairesi()
        {
            try
            {
                if (btn_icradairesi_add.Text == "Ekle")
                {
                    clearIcraDairesiTextBox();
                    btn_icradairesi_del.Enabled = false;
                    btn_icradairesi_update.Enabled = false;
                    btn_icradairesi_add.Text = "Kaydet";
                    changeIcraDairesiTextBoxMode(true);
                }
                else if (btn_icradairesi_add.Text == "Kaydet")
                {
                    NpgsqlCommand command = new NpgsqlCommand();
                    command.CommandText = "INSERT INTO public.tb_icradairesi (adı, banka, iban) VALUES (@adı, @banka, @iban)";
                    command.Parameters.AddWithValue("@adı", NpgsqlTypes.NpgsqlDbType.Text, tBox_icra_kurumAdı.Text);
                    command.Parameters.AddWithValue("@banka", NpgsqlTypes.NpgsqlDbType.Text, tBox_icra_kurumBanka.Text);
                    command.Parameters.AddWithValue("@iban", NpgsqlTypes.NpgsqlDbType.Text, tBox_icra_kurumIBAN.Text);
                    dbConnection.sendQuery(command);
                    clearIcraDairesiButtons();
                    changeIcraDairesiTextBoxMode(false);
                    searchIcraDairesi();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
        private void updateIcraDairesi()
        {
            try
            {
                if (btn_icradairesi_update.Text == "Güncelle")
                {
                    btn_icradairesi_del.Enabled = false;
                    btn_icradairesi_add.Enabled = false;
                    btn_icradairesi_update.Text = "Kaydet";
                    changeIcraDairesiTextBoxMode(true);
                }
                else if (btn_icradairesi_update.Text == "Kaydet")
                {
                    NpgsqlCommand command = new NpgsqlCommand();
                    command.CommandText = "UPDATE public.tb_icradairesi SET adı=@adı, banka=@banka, iban=@iban WHERE kurumno=@kurumno ";
                    command.Parameters.AddWithValue("@adı", NpgsqlTypes.NpgsqlDbType.Text, tBox_icra_kurumAdı.Text);
                    command.Parameters.AddWithValue("@banka", NpgsqlTypes.NpgsqlDbType.Text, tBox_icra_kurumBanka.Text);
                    command.Parameters.AddWithValue("@iban", NpgsqlTypes.NpgsqlDbType.Text, tBox_icra_kurumIBAN.Text);
                    command.Parameters.AddWithValue("@kurumno", NpgsqlTypes.NpgsqlDbType.Integer, Convert.ToInt32(tBox_icra_kurumno.Text));
                    dbConnection.sendQuery(command);
                    clearIcraDairesiButtons();
                    changeIcraDairesiTextBoxMode(false);
                    searchIcraDairesi();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
        private void delIcraDairesi()
        {
            try
            {
                NpgsqlCommand command = new NpgsqlCommand();
                command.CommandText = "DELETE FROM  public.tb_icradairesi WHERE kurumno=@kurumno ";
                command.Parameters.AddWithValue("@kurumno", NpgsqlTypes.NpgsqlDbType.Integer, Convert.ToInt32(tBox_icra_kurumno.Text));
                dbConnection.sendQuery(command);
                clearIcraDairesiButtons();
                searchIcraDairesi();
            }
            catch (Exception)
            {

                throw;
            }
        }
        private void btn_icradairesi_add_Click(object sender, EventArgs e)
        {
            try
            {
                addIcraDairesi();
            }
            catch (Exception ex)
            {
                MessageBoxs.ErrorMessage(ex);
            }
        }
        private void btn_icradairesi_update_Click(object sender, EventArgs e)
        {
            try
            {
                if(tBox_icra_kurumno.Text == "")
                {
                    MessageBoxs.WarningMessage("Önce Kayıt Seçmelisiniz");
                }
                else
                {

                    updateIcraDairesi();
                }
            }
            catch (Exception ex)
            {
                MessageBoxs.ErrorMessage(ex);
            }
        }
        private void btn_icradairesi_del_Click(object sender, EventArgs e)
        {
            try
            {
                if(tBox_icra_kurumno.Text != "")
                {
                    DialogResult dr = MessageBoxs.DeleteQuestion("Seçili Kayıt Silinecek?");
                    if(dr == DialogResult.Yes)
                    {
                        delIcraDairesi();
                    }
                }
                else
                {
                    MessageBoxs.WarningMessage("Önce Kayıt Seçmelisiniz");
                }
            }
            catch (Exception ex)
            {
                MessageBoxs.ErrorMessage(ex);
            }
        }
        private void DGVIcraDaireleri_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                tBox_icra_kurumno.Text = DGVIcraDaireleri.Rows[e.RowIndex].Cells[0].Value.ToString();
                tBox_icra_kurumAdı.Text = DGVIcraDaireleri.Rows[e.RowIndex].Cells[1].Value.ToString();
                tBox_icra_kurumBanka.Text = DGVIcraDaireleri.Rows[e.RowIndex].Cells[2].Value.ToString();
                tBox_icra_kurumIBAN.Text = DGVIcraDaireleri.Rows[e.RowIndex].Cells[3].Value.ToString();
            }
        }

        #endregion

        #region icralar
        private void cevaplarıGörüntüleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int iNo = Convert.ToInt32(dataGV_Icralar.Rows[dataGV_Icralar.SelectedRows[0].Index].Cells[0].Value);
            frmCevapYaziları form = new frmCevapYaziları(iNo);
            form.Show();
        }
        private void btnAddIcra_Click(object sender, EventArgs e)
        {
            addIcra form = new addIcra();
            form.Show();
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

                cBox_İcraTuru_Kesinti.DataSource = dt;
                cBox_İcraTuru_Kesinti.ValueMember = "kayitno";
                cBox_İcraTuru_Kesinti.DisplayMember = "turadi";

            }
            catch (Exception)
            {

                throw;
            }
        }
        private bool hasFilter()
        {
            bool result = false;
            if (tBox_icralar_kimlikNo.Text != "")
                result = true;
            if (tBox_icralar_kisino.Text != "")
                result = true;
            if (tBox_icralar_esaso.Text != "")
                result = true;
            if (cBox_IcraTuru.SelectedIndex != 0)
                result = true;
            if (checkBoxBitmisDosya.Checked)
                result = true;
            if (cBox_icralar_oncelik.Checked)
                result = true;

            return result;
        }
        private NpgsqlCommand getFilters_icralar(NpgsqlCommand input)
        {
            try
            {
                if (hasFilter())
                {
                    input.CommandText += "WHERE ";
                    if(tBox_icralar_kisino.Text != "")
                    {
                        input.CommandText = getSearchAnd(input.CommandText);
                        input.CommandText += "P.kisi_no = @kisino  ";
                        input.Parameters.AddWithValue("@kisino", NpgsqlTypes.NpgsqlDbType.Integer, Convert.ToInt32(tBox_icralar_kisino.Text));
                    }
                    else if(tBox_icralar_kimlikNo.Text != "")
                    {
                        input.CommandText = getSearchAnd(input.CommandText);
                        input.CommandText += "P.tc_no = @kimlikno  ";
                        input.Parameters.AddWithValue("@kimlikno", NpgsqlTypes.NpgsqlDbType.Bigint, Convert.ToDecimal(tBox_icralar_kimlikNo.Text));

                    }

                    if(tBox_icralar_esaso.Text != "")
                    {
                        input.CommandText = getSearchAnd(input.CommandText);
                        input.CommandText += "i.esasno ILIKE @esasno  ";
                        input.Parameters.AddWithValue("@esasno", NpgsqlTypes.NpgsqlDbType.Text, tBox_icralar_esaso.Text);
                    }

                    if(cBox_icralar_oncelik.Checked)
                    {
                        input.CommandText = getSearchAnd(input.CommandText);
                        input.CommandText += "i.oncelik = true  ";

                    }
                    if (checkBoxBitmisDosya.Checked)
                    {
                        input.CommandText = getSearchAnd(input.CommandText);
                        input.CommandText += " i.tutar > cast(0 as money)  ";

                    }
                    if (cBox_IcraTuru.SelectedIndex != 0)
                    {
                        input.CommandText = getSearchAnd(input.CommandText);
                        input.CommandText += "i.icraturu = @icraturu  ";
                        input.Parameters.AddWithValue("@icraturu", NpgsqlTypes.NpgsqlDbType.Integer, cBox_IcraTuru.SelectedValue);

                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
            return input;
      
        }
        private void getIcralar()
        {
            try
            {
                NpgsqlCommand command = new NpgsqlCommand();
                command.CommandText = "SELECT i.kayitno AS\"Kayıt No\",P.tc_no as \"TC Kimlik No\", P.adı as \"Adı\", P.soyadı as \"Soyadı\",  i.esasno\"Esas Numarası\", i.tarih AS \"Tarih\", IC.adı AS \"İcra Dairesi\" , i.tutar AS \"Tutar\", T.turadi AS \"Dosya Türü\", i.oncelik as \"Öncelik Var Mı?\" FROM public.tb_icralar i " +
            "INNER JOIN public.tb_icradairesi IC on IC.kurumno=i.icradairesi " +
            "INNER JOIN public.tb_icra_turleri T on T.kayitno=i.icraturu " +
            "INNER JOIN public.tb_borclular B on B.icra=i.kayitno " +
            "INNER JOIN public.tb_personel P on P.kisi_no=B.kisi ";
                command = getFilters_icralar(command);
                command.CommandText += " ORDER BY i.tarih ASC";
                dataGV_Icralar.DataSource = dbConnection.getData(command);

            }
            catch (Exception)
            {

                throw;
            }
        }

        private void görüntüleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int iNo = Convert.ToInt32(dataGV_Icralar.Rows[dataGV_Icralar.SelectedRows[0].Index].Cells[0].Value);
            addIcra form = new addIcra(iNo);
            form.ShowDialog();
            getIcralar();
        }

        private void müzekkereleriAçToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int iNo = Convert.ToInt32(dataGV_Icralar.Rows[dataGV_Icralar.SelectedRows[0].Index].Cells[0].Value);
            frmMuzekkereler form = new frmMuzekkereler(iNo);
            form.ShowDialog();
            getIcralar();
        }
        private void btnIcralar_search_Click(object sender, EventArgs e)
        {
            try
            {
                getIcralar();
            }
            catch (Exception ex)
            {
                MessageBoxs.ErrorMessage(ex);
            }
        }



        #endregion


        #region KesintiSorgulama
        private bool hasFilter_Kesinti()
        {
            bool result = false;
            if (tBox_kesinti_kisino.Text != "")
                result = true;
            else if (tBox_kesinti_tcno.Text != "")
                result = true;
           else if (tBox_kesinti_esasno.Text != "")
                result = true;
           else  if (cBox_İcraTuru_Kesinti.SelectedIndex != 0)
                result = true;
           else if (cBoxAlacak.SelectedIndex != 0)
                result = true;

         return result;
        }
        private NpgsqlCommand getFilters_Kesinti(NpgsqlCommand input)
        {
            try
            {
                if (hasFilter_Kesinti())
                {
                    input.CommandText += "WHERE ";
                    if (tBox_kesinti_kisino.Text != "")
                    {
                        input.CommandText = getSearchAnd(input.CommandText);
                        input.CommandText += "P.kisi_no = @kisino ";
                        input.Parameters.AddWithValue("@kisino", NpgsqlTypes.NpgsqlDbType.Integer, Convert.ToInt32(tBox_kesinti_kisino.Text));
                    }
                    else if (tBox_kesinti_tcno.Text != "")
                    {
                        input.CommandText = getSearchAnd(input.CommandText);
                        input.CommandText += "P.tc_no = @kimlikno ";
                        input.Parameters.AddWithValue("@kimlikno", NpgsqlTypes.NpgsqlDbType.Bigint, Convert.ToDecimal(tBox_kesinti_tcno.Text));

                    }

                    if (tBox_kesinti_esasno.Text != "")
                    {
                        input.CommandText = getSearchAnd(input.CommandText);
                        input.CommandText += "IC.esasno ILIKE @esasno  ";
                        input.Parameters.AddWithValue("@esasno", NpgsqlTypes.NpgsqlDbType.Text, tBox_kesinti_esasno.Text);
                    }
                    if (cBox_İcraTuru_Kesinti.SelectedIndex != 0)
                    {
                        input.CommandText = getSearchAnd(input.CommandText);
                        input.CommandText += " IC.icraturu = @icraturu  ";
                        input.Parameters.AddWithValue("@icraturu", NpgsqlTypes.NpgsqlDbType.Integer, cBox_IcraTuru.SelectedValue);
                    }
                    if (cBoxAlacak.SelectedIndex != 0)
                    {
                        input.CommandText = getSearchAnd(input.CommandText);
                        input.CommandText += " T.kayitno = @alacakturu  ";
                        input.Parameters.AddWithValue("@alacakturu", NpgsqlTypes.NpgsqlDbType.Integer,  cBoxAlacak.SelectedValue);

                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
            return input;

        }

        private void loadKesintiler()
        {
            try
            {
                NpgsqlCommand command = new NpgsqlCommand();
                command.CommandText = "select KE.\"kayitno\" as \"Kayıt No\", P.adı as \"adı\", P.soyadı as \"Soyadı\", IC.\"esasno\" as \"Esas Numarası\", IT.turadi AS \"Dosya Türü\", KE.\"tarih\" as \"Tarih\",  T.\"turadi\" as \"Ücret Türü\", KE.\"tutar\" as \"Tutar\" FROM tb_kesintiler KE " +
                                        "inner join tb_icralar IC on IC.\"kayitno\" = KE.\"icra\"  " +
                                        "inner join tb_alacak_turleri T on KE.tur = T.kayitno  " +
                                        "INNER JOIN public.tb_personel P on P.kisi_no=KE.kisi  " +
                                        "inner join tb_icra_turleri IT on IT.kayitno=IC.icraturu  ";
                command = getFilters_Kesinti(command);
                command.CommandText += " ORDER BY KE.tarih ASC";
               dgv_Kesintiler.DataSource = dbConnection.getData(command);
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
        private void btn_Kesinti_sorgula_Click(object sender, EventArgs e)
        {
            try
            {
                loadKesintiler();
            }
            catch (Exception ex)
            {
                MessageBoxs.ErrorMessage(ex);
            }
        }
        #endregion
    }
}
