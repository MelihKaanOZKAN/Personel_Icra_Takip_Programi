using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;

namespace Personel_Icra_Takip_Programı.Class
{
    static class MessageBoxs
    {
        public static void SuccessMessage(String message)
        {
            System.Windows.Forms.MessageBox.Show(message, "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static void ErrorMessage(Exception ex)
        {
            System.Windows.Forms.MessageBox.Show("Hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        public static void WarningMessage(String text)
        {
            System.Windows.Forms.MessageBox.Show(text, "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        public static DialogResult DeleteQuestion(String text)
        {
          return  System.Windows.Forms.MessageBox.Show(text, "Dikkat", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }
    }
}
