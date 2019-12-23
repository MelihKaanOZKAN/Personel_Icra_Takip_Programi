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
    public partial class frmIcralar : Form
    {
        private int kisiNo;
        public frmIcralar(int kisiNo)
        {
            InitializeComponent();
            this.kisiNo = kisiNo;
        }
        private void getIcralar()
        {
            try
            {
                NpgsqlCommand command = new NpgsqlCommand();
                command.CommandText = "SELECT i.kayitno AS\"Kayıt No\", i.esasno\"Esas Numarası\", i.tarih AS \"Tarih\", IC.adı AS \"İcra Dairesi\" , i.tutar AS \"Tutar\", T.turadi AS \"Dosya Türü\", i.oncelik as \"Öncelik Var Mı?\", i.sabit_kesinti as \"Sabit Kesinti\" FROM public.tb_icralar i " +
          "INNER JOIN public.tb_icradairesi IC on IC.kurumno=i.icradairesi " +
          "INNER JOIN public.tb_icra_turleri T on T.kayitno=i.icraturu " +
          "INNER JOIN public.tb_borclular B on B.icra=i.kayitno " +
          "INNER JOIN public.tb_personel P on P.kisi_no=B.kisi "+
                "WHERE P.kisi_no = @kisino AND i.tutar > CAST(0.0 as money)  ORDER BY i.tarih ASC";
                command.Parameters.AddWithValue("@kisino", NpgsqlTypes.NpgsqlDbType.Bigint,kisiNo);
                dataGV_Icralar.DataSource = dbConnection.getData(command);
            }
            catch (Exception)
            {

                throw;
            }
        }
        private void loadPersonel()
        {
            try
            {
                NpgsqlCommand command = new NpgsqlCommand();
                command.CommandText = "SELECT  tc_no, adı, soyadı FROM public.tb_personel WHERE kisi_no=@kisino";
                command.Parameters.AddWithValue("@kisino", NpgsqlTypes.NpgsqlDbType.Bigint,kisiNo);
                DataTable dt = dbConnection.getData(command);
                tBoxTCNo.Text = dt.Rows[0][0].ToString();
                tBoxAdi.Text = dt.Rows[0][1].ToString();
                tBoxSoyadi.Text = dt.Rows[0][2].ToString();

            }
            catch (Exception)
            {

                throw;
            }
        }

        private void frmIcralar_Load(object sender, EventArgs e)
        {
            try
            {
                if(kisiNo != 0)
                {
                    loadPersonel();
                    getIcralar();
                }
            }
            catch ( Exception ex)
            {
                MessageBoxs.ErrorMessage(ex);
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

        private void kesintiYapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            frmKesintiYap frmKesintiYap = new frmKesintiYap(kisiNo, Convert.ToInt32(dataGV_Icralar.SelectedRows[0].Cells[0].Value));
            frmKesintiYap.tBoxBakiye.Text = dataGV_Icralar.SelectedRows[0].Cells[7].Value.ToString();
            frmKesintiYap.ShowDialog();
            getIcralar();
        }

        private void btnViewKesinti_Click(object sender, EventArgs e)
        {
            frmViewKesinti frmViewKesinti = new frmViewKesinti(kisiNo);
            frmViewKesinti.Show();
        }
    }
}
