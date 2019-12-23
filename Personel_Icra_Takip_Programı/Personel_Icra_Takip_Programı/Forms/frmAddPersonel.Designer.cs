namespace Personel_Icra_Takip_Programı.Forms
{
    partial class frm_addPersonel
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
            this.btnSave = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.cBoxKurumlar = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.kryptonLabel5 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.tBoxSoyadi = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel3 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.tBoxAdi = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel4 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.tBoxTCNo = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel2 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.tboxKisiNo = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            ((System.ComponentModel.ISupportInitialize)(this.cBoxKurumlar)).BeginInit();
            this.SuspendLayout();
         
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.cBoxKurumlar);
            this.Controls.Add(this.kryptonLabel5);
            this.Controls.Add(this.tBoxSoyadi);
            this.Controls.Add(this.kryptonLabel3);
            this.Controls.Add(this.tBoxAdi);
            this.Controls.Add(this.kryptonLabel4);
            this.Controls.Add(this.tBoxTCNo);
            this.Controls.Add(this.kryptonLabel2);
            this.Controls.Add(this.tboxKisiNo);
            this.Controls.Add(this.kryptonLabel1);
            // 
            // btnSave
            // 
            this.btnSave.Enabled = false;
            this.btnSave.Location = new System.Drawing.Point(417, 17);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(108, 38);
            this.btnSave.TabIndex = 12;
            this.btnSave.Values.Text = "Kaydet";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // cBoxKurumlar
            // 
            this.cBoxKurumlar.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cBoxKurumlar.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cBoxKurumlar.DropDownWidth = 329;
            this.cBoxKurumlar.Location = new System.Drawing.Point(128, 137);
            this.cBoxKurumlar.Name = "cBoxKurumlar";
            this.cBoxKurumlar.Size = new System.Drawing.Size(257, 21);
            this.cBoxKurumlar.TabIndex = 11;
            this.cBoxKurumlar.SelectedValueChanged += new System.EventHandler(this.cBoxKurumlar_SelectedValueChanged);
            // 
            // kryptonLabel5
            // 
            this.kryptonLabel5.Location = new System.Drawing.Point(11, 138);
            this.kryptonLabel5.Name = "kryptonLabel5";
            this.kryptonLabel5.Size = new System.Drawing.Size(95, 20);
            this.kryptonLabel5.TabIndex = 10;
            this.kryptonLabel5.Values.Text = "Çalıştığı Kurum:";
            // 
            // tBoxSoyadi
            // 
            this.tBoxSoyadi.Location = new System.Drawing.Point(127, 104);
            this.tBoxSoyadi.Name = "tBoxSoyadi";
            this.tBoxSoyadi.Size = new System.Drawing.Size(258, 23);
            this.tBoxSoyadi.TabIndex = 7;
            // 
            // kryptonLabel3
            // 
            this.kryptonLabel3.Location = new System.Drawing.Point(11, 104);
            this.kryptonLabel3.Name = "kryptonLabel3";
            this.kryptonLabel3.Size = new System.Drawing.Size(50, 20);
            this.kryptonLabel3.TabIndex = 6;
            this.kryptonLabel3.Values.Text = "Soyadı:";
            // 
            // tBoxAdi
            // 
            this.tBoxAdi.Location = new System.Drawing.Point(127, 75);
            this.tBoxAdi.Name = "tBoxAdi";
            this.tBoxAdi.Size = new System.Drawing.Size(258, 23);
            this.tBoxAdi.TabIndex = 5;
            // 
            // kryptonLabel4
            // 
            this.kryptonLabel4.Location = new System.Drawing.Point(11, 75);
            this.kryptonLabel4.Name = "kryptonLabel4";
            this.kryptonLabel4.Size = new System.Drawing.Size(31, 20);
            this.kryptonLabel4.TabIndex = 4;
            this.kryptonLabel4.Values.Text = "Adı:";
            // 
            // tBoxTCNo
            // 
            this.tBoxTCNo.Location = new System.Drawing.Point(127, 46);
            this.tBoxTCNo.MaxLength = 11;
            this.tBoxTCNo.Name = "tBoxTCNo";
            this.tBoxTCNo.Size = new System.Drawing.Size(258, 23);
            this.tBoxTCNo.TabIndex = 3;
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.Location = new System.Drawing.Point(11, 46);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(84, 20);
            this.kryptonLabel2.TabIndex = 2;
            this.kryptonLabel2.Values.Text = "TC Kimlik No:";
            // 
            // tboxKisiNo
            // 
            this.tboxKisiNo.Location = new System.Drawing.Point(127, 17);
            this.tboxKisiNo.Name = "tboxKisiNo";
            this.tboxKisiNo.Size = new System.Drawing.Size(258, 23);
            this.tboxKisiNo.TabIndex = 1;
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(11, 17);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(110, 20);
            this.kryptonLabel1.TabIndex = 0;
            this.kryptonLabel1.Values.Text = "Saymanlık Kişi No:";
            // 
            // frm_addPersonel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 277);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frm_addPersonel";
            this.ShowIcon = false;
            this.Text = "Personel Bilgileri";
            this.Load += new System.EventHandler(this.frm_addPersonel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cBoxKurumlar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox tBoxSoyadi;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel3;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox tBoxAdi;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel4;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox tBoxTCNo;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox cBoxKurumlar;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel5;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnSave;
        public ComponentFactory.Krypton.Toolkit.KryptonTextBox tboxKisiNo;
    }
}