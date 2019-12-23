namespace Personel_Icra_Takip_Programı.Forms
{
    partial class frmKesintiYap
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnaddKesinti = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.cBoxAlacak = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.kryptonLabel9 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.tBoxBakiye = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel4 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.Date_date = new ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker();
            this.kryptonLabel3 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
       
            ((System.ComponentModel.ISupportInitialize)(this.cBoxAlacak)).BeginInit();
            this.SuspendLayout();
        
            this.Controls.Add(this.btnaddKesinti);
            this.Controls.Add(this.cBoxAlacak);
            this.Controls.Add(this.kryptonLabel9);
            this.Controls.Add(this.tBoxBakiye);
            this.Controls.Add(this.kryptonLabel4);
            this.Controls.Add(this.Date_date);
            this.Controls.Add(this.kryptonLabel3);
            // 
            // btnaddKesinti
            // 
            this.btnaddKesinti.Location = new System.Drawing.Point(292, 131);
            this.btnaddKesinti.Margin = new System.Windows.Forms.Padding(2);
            this.btnaddKesinti.Name = "btnaddKesinti";
            this.btnaddKesinti.Size = new System.Drawing.Size(103, 37);
            this.btnaddKesinti.TabIndex = 37;
            this.btnaddKesinti.Values.Text = "Kesinti Ekle";
            this.btnaddKesinti.Click += new System.EventHandler(this.btnaddKesinti_Click);
            // 
            // cBoxAlacak
            // 
            this.cBoxAlacak.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cBoxAlacak.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cBoxAlacak.DropDownWidth = 238;
            this.cBoxAlacak.Location = new System.Drawing.Point(172, 36);
            this.cBoxAlacak.Name = "cBoxAlacak";
            this.cBoxAlacak.Size = new System.Drawing.Size(238, 21);
            this.cBoxAlacak.TabIndex = 36;
            // 
            // kryptonLabel9
            // 
            this.kryptonLabel9.Location = new System.Drawing.Point(10, 37);
            this.kryptonLabel9.Name = "kryptonLabel9";
            this.kryptonLabel9.Size = new System.Drawing.Size(156, 20);
            this.kryptonLabel9.TabIndex = 35;
            this.kryptonLabel9.Values.Text = "Kesinti Yapılabilecek Ücret:";
            // 
            // tBoxBakiye
            // 
            this.tBoxBakiye.Location = new System.Drawing.Point(172, 89);
            this.tBoxBakiye.MaxLength = 10;
            this.tBoxBakiye.Name = "tBoxBakiye";
            this.tBoxBakiye.Size = new System.Drawing.Size(127, 23);
            this.tBoxBakiye.TabIndex = 34;
            // 
            // kryptonLabel4
            // 
            this.kryptonLabel4.Location = new System.Drawing.Point(116, 92);
            this.kryptonLabel4.Name = "kryptonLabel4";
            this.kryptonLabel4.Size = new System.Drawing.Size(41, 20);
            this.kryptonLabel4.TabIndex = 33;
            this.kryptonLabel4.Values.Text = "Tutar:";
            // 
            // Date_date
            // 
            this.Date_date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Date_date.Location = new System.Drawing.Point(172, 63);
            this.Date_date.Name = "Date_date";
            this.Date_date.Size = new System.Drawing.Size(127, 21);
            this.Date_date.TabIndex = 32;
            // 
            // kryptonLabel3
            // 
            this.kryptonLabel3.Location = new System.Drawing.Point(116, 63);
            this.kryptonLabel3.Name = "kryptonLabel3";
            this.kryptonLabel3.Size = new System.Drawing.Size(40, 20);
            this.kryptonLabel3.TabIndex = 31;
            this.kryptonLabel3.Values.Text = "Tarih:";
            // 
            // frmKesintiYap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 187);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmKesintiYap";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Kesinti Yap";
          
            ((System.ComponentModel.ISupportInitialize)(this.cBoxAlacak)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel4;
        private ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker Date_date;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel3;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox cBoxAlacak;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel9;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnaddKesinti;
        public ComponentFactory.Krypton.Toolkit.KryptonTextBox tBoxBakiye;
    }
}