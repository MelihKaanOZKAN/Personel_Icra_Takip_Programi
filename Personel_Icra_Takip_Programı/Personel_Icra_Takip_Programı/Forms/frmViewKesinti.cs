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
    public partial class frmViewKesinti : Form
    {
        private int kisiNo;
        public frmViewKesinti(int kisiNo)
        {
            try
            {
                InitializeComponent();
                this.kisiNo = kisiNo;
                loadKesintiler();
            }
            catch (Exception ex)
            {
                MessageBoxs.ErrorMessage(ex);
            }
        }
        private void loadKesintiler()
        {
            try
            {
                NpgsqlCommand command = new NpgsqlCommand();
                command.CommandText = "select KE.\"kayitno\" as \"Kayıt No\", IC.\"esasno\" as \"Esas Numarası\", T.\"turadi\" as \"Alacak Türü\", KE.\"tarih\" as \"Tarih\", KE.\"tutar\" as \"Tutar\" from tb_kesintiler KE " +
                                        "inner join tb_icralar IC on IC.\"kayitno\" = KE.\"icra\" " +
                                        "inner join tb_alacak_turleri T on KE.tur = T.kayitno " +
                                        "WHERE KE.kisi = @kisino ORDER BY KE.tarih ASC";
                command.Parameters.AddWithValue("@kisino", NpgsqlTypes.NpgsqlDbType.Integer, kisiNo);
                dataGV_kesintiler.DataSource = dbConnection.getData(command);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
