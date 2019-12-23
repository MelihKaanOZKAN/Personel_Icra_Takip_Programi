using Devart.Data.PostgreSql;
using Npgsql;
using Personel_Icra_Takip_Programı.Report;
using Personel_Icra_Takip_Programı.Report.DB_PITPDataSetTableAdapters;
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
    public partial class frmRaporEkranı : Form
    {
        private int kisiNo;
        public frmRaporEkranı(int kisiNo)
        {
            InitializeComponent();
            this.kisiNo = kisiNo;
        }

        private void frmRaporEkranı_Load(object sender, EventArgs e)
        {
            PgSqlCommand command = new PgSqlCommand();
            command.CommandText = "SELECT i.esasno, IC.\"adı\" AS \"idaire\", T.turadi, i.tutar FROM public.tb_icralar i " +
            "INNER JOIN public.tb_icradairesi IC on IC.kurumno=i.icradairesi " +
            "INNER JOIN public.tb_icra_turleri T on T.kayitno=i.icraturu " +
            "INNER JOIN public.tb_borclular B on B.icra=i.kayitno " +
            "INNER JOIN public.tb_personel P on P.kisi_no=B.kisi " +
                  "WHERE P.kisi_no = @kisino AND i.tutar > CAST(0.0 as money)  ORDER BY i.tarih ASC";
            command.Parameters.AddWithValue("@kisino", kisiNo);
            this.pgSqlDataAdapter1.setSelectCommand(command, this.pgSqlDataAdapter1);
            DB_PITPDataSet ds = new DB_PITPDataSet();
            this.pgSqlDataAdapter1.Fill(ds.DataTable1);

            command.CommandText = "SELECT tc_no, adı, soyadı FROM tb_personel WHERE kisi_no = @kisino";
            tb_personelTableAdapter tableAdapter = new tb_personelTableAdapter();
            
            tableAdapter.setSelectCommand(command, tableAdapter);
            tableAdapter.Fill(ds.tb_personel);
            this.bindingSource2.DataSource = ds;
            this.bindingSource2.DataMember = "tb_personel";
            this.bindingSource1.DataSource = ds;
            this.bindingSource1.DataMember = "DataTable1";
            this.reportViewer1.RefreshReport();
        }
    }
}
