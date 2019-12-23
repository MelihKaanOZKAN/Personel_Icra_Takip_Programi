using Npgsql;
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
    public partial class CreateConnection : Form
    {
        private bool saved = false;
        public CreateConnection()
        {
            InitializeComponent();
        }

        private void CreateConnection_Load(object sender, EventArgs e)
        {

        }
        private NpgsqlConnection getConnection()
        {
            NpgsqlConnection con = new NpgsqlConnection();

            try
            {
                con.ConnectionString = "Server=" + txtServer.Text +";" +
                                                   "Port="+txtPort.Text+";" +
                                                   "User Id="+txtUsername.Text+";" +
                                                   "Password="+txtPassword.Text+";" +
                                                   "Database="+txtDatabase.Text+";";


            }
            catch (Exception)
            {

                throw;
            }
            return con;
        }
        private void btnTest_Click(object sender, EventArgs e)
        {
            try
            {
                NpgsqlConnection con = this.getConnection();
                con.Open();
                if (con.State == ConnectionState.Open)
                {
                    MessageBox.Show("Başarılı", "Bağlantı Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Başarısız", "Bağlantı Başarısız", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Başarısız", "Bağlantı Başarısız", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Ayarlar Kaydedilecek Onaylıyor Musunuz?", "Kayıt", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if(dr == DialogResult.Yes)
            {

                NpgsqlConnection con = this.getConnection();
                xmlops xml = new xmlops();
                xml.writeDBInfo(con);
                saved = true;
                Application.Restart();
            }
        }

        private void CreateConnection_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(!saved)
            {
                Application.Exit();
            }
        }
    }
}
