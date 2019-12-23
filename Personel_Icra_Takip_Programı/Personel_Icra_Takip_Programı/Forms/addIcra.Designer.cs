namespace Personel_Icra_Takip_Programı.Forms
{
    partial class addIcra
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(addIcra));
            this.tBox_sabit_kesinti = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel12 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.cBox_Oncelik = new ComponentFactory.Krypton.Toolkit.KryptonCheckBox();
            this.tbox_borclu_kisino = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel11 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.tBoxBakiye = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.btn_save = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btn_add_alacakTuru = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btn_add_borclu = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonLabel10 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.cBoxAlacak = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.kryptonLabel9 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.dgvAlacak = new System.Windows.Forms.DataGridView();
            this.cBox_IcraTuru = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.kryptonLabel8 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.dgvBorclular = new System.Windows.Forms.DataGridView();
            this.tBoxSoyadi = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel5 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.tBoxAdi = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel6 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.tBoxTCNo = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel7 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel4 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.Date_date = new ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker();
            this.kryptonLabel3 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.tBoxEsasNo = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel2 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.cBox_İcraDairesi = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            ((System.ComponentModel.ISupportInitialize)(this.cBoxAlacak)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlacak)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cBox_IcraTuru)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBorclular)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cBox_İcraDairesi)).BeginInit();
            this.SuspendLayout();
            // 
            // tBox_sabit_kesinti
            // 
            this.tBox_sabit_kesinti.Enabled = false;
            this.tBox_sabit_kesinti.Location = new System.Drawing.Point(587, 52);
            this.tBox_sabit_kesinti.MaxLength = 10;
            this.tBox_sabit_kesinti.Name = "tBox_sabit_kesinti";
            this.tBox_sabit_kesinti.Size = new System.Drawing.Size(99, 23);
            this.tBox_sabit_kesinti.TabIndex = 35;
            this.tBox_sabit_kesinti.Text = "0";
            // 
            // kryptonLabel12
            // 
            this.kryptonLabel12.Location = new System.Drawing.Point(509, 51);
            this.kryptonLabel12.Name = "kryptonLabel12";
            this.kryptonLabel12.Size = new System.Drawing.Size(80, 20);
            this.kryptonLabel12.TabIndex = 34;
            this.kryptonLabel12.Values.Text = "Sabit Kesinti:";
            // 
            // cBox_Oncelik
            // 
            this.cBox_Oncelik.Location = new System.Drawing.Point(396, 51);
            this.cBox_Oncelik.Margin = new System.Windows.Forms.Padding(2);
            this.cBox_Oncelik.Name = "cBox_Oncelik";
            this.cBox_Oncelik.Size = new System.Drawing.Size(108, 20);
            this.cBox_Oncelik.TabIndex = 33;
            this.cBox_Oncelik.Values.Text = "Öncelik Var mı?";
            this.cBox_Oncelik.CheckedChanged += new System.EventHandler(this.cBox_Oncelik_CheckedChanged);
            // 
            // tbox_borclu_kisino
            // 
            this.tbox_borclu_kisino.Enabled = false;
            this.tbox_borclu_kisino.Location = new System.Drawing.Point(108, 193);
            this.tbox_borclu_kisino.MaxLength = 11;
            this.tbox_borclu_kisino.Name = "tbox_borclu_kisino";
            this.tbox_borclu_kisino.Size = new System.Drawing.Size(258, 23);
            this.tbox_borclu_kisino.TabIndex = 32;
            // 
            // kryptonLabel11
            // 
            this.kryptonLabel11.Location = new System.Drawing.Point(18, 193);
            this.kryptonLabel11.Name = "kryptonLabel11";
            this.kryptonLabel11.Size = new System.Drawing.Size(51, 20);
            this.kryptonLabel11.TabIndex = 31;
            this.kryptonLabel11.Values.Text = "Kişi No:";
            // 
            // tBoxBakiye
            // 
            this.tBoxBakiye.Location = new System.Drawing.Point(110, 104);
            this.tBoxBakiye.MaxLength = 10;
            this.tBoxBakiye.Name = "tBoxBakiye";
            this.tBoxBakiye.Size = new System.Drawing.Size(238, 23);
            this.tBoxBakiye.TabIndex = 30;
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(952, 3);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(125, 68);
            this.btn_save.TabIndex = 29;
            this.btn_save.Values.Text = "Kaydet";
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_add_alacakTuru
            // 
            this.btn_add_alacakTuru.Location = new System.Drawing.Point(731, 142);
            this.btn_add_alacakTuru.Name = "btn_add_alacakTuru";
            this.btn_add_alacakTuru.Size = new System.Drawing.Size(61, 45);
            this.btn_add_alacakTuru.TabIndex = 28;
            this.btn_add_alacakTuru.Values.Text = "Ekle";
            this.btn_add_alacakTuru.Click += new System.EventHandler(this.btn_add_alacakTuru_Click);
            // 
            // btn_add_borclu
            // 
            this.btn_add_borclu.Location = new System.Drawing.Point(374, 163);
            this.btn_add_borclu.Name = "btn_add_borclu";
            this.btn_add_borclu.Size = new System.Drawing.Size(61, 45);
            this.btn_add_borclu.TabIndex = 27;
            this.btn_add_borclu.Values.Text = "Ekle";
            this.btn_add_borclu.Click += new System.EventHandler(this.btn_add_borclu_Click);
            // 
            // kryptonLabel10
            // 
            this.kryptonLabel10.Location = new System.Drawing.Point(20, 137);
            this.kryptonLabel10.Name = "kryptonLabel10";
            this.kryptonLabel10.Size = new System.Drawing.Size(61, 20);
            this.kryptonLabel10.TabIndex = 26;
            this.kryptonLabel10.Values.Text = "Borçlular:";
            // 
            // cBoxAlacak
            // 
            this.cBoxAlacak.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cBoxAlacak.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cBoxAlacak.DropDownWidth = 238;
            this.cBoxAlacak.Location = new System.Drawing.Point(487, 165);
            this.cBoxAlacak.Name = "cBoxAlacak";
            this.cBoxAlacak.Size = new System.Drawing.Size(238, 21);
            this.cBoxAlacak.TabIndex = 25;
            // 
            // kryptonLabel9
            // 
            this.kryptonLabel9.Location = new System.Drawing.Point(485, 139);
            this.kryptonLabel9.Name = "kryptonLabel9";
            this.kryptonLabel9.Size = new System.Drawing.Size(170, 20);
            this.kryptonLabel9.TabIndex = 24;
            this.kryptonLabel9.Values.Text = "Kesinti Yapılabilecek Ücretler:";
            // 
            // dgvAlacak
            // 
            this.dgvAlacak.AllowUserToAddRows = false;
            this.dgvAlacak.AllowUserToResizeRows = false;
            this.dgvAlacak.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAlacak.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAlacak.Location = new System.Drawing.Point(487, 192);
            this.dgvAlacak.MultiSelect = false;
            this.dgvAlacak.Name = "dgvAlacak";
            this.dgvAlacak.ReadOnly = true;
            this.dgvAlacak.RowHeadersVisible = false;
            this.dgvAlacak.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAlacak.Size = new System.Drawing.Size(346, 420);
            this.dgvAlacak.TabIndex = 23;
            // 
            // cBox_IcraTuru
            // 
            this.cBox_IcraTuru.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cBox_IcraTuru.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cBox_IcraTuru.DropDownWidth = 238;
            this.cBox_IcraTuru.Location = new System.Drawing.Point(448, 21);
            this.cBox_IcraTuru.Name = "cBox_IcraTuru";
            this.cBox_IcraTuru.Size = new System.Drawing.Size(238, 21);
            this.cBox_IcraTuru.TabIndex = 22;
            // 
            // kryptonLabel8
            // 
            this.kryptonLabel8.Location = new System.Drawing.Point(381, 23);
            this.kryptonLabel8.Name = "kryptonLabel8";
            this.kryptonLabel8.Size = new System.Drawing.Size(61, 20);
            this.kryptonLabel8.TabIndex = 21;
            this.kryptonLabel8.Values.Text = "İcra Türü:";
            // 
            // dgvBorclular
            // 
            this.dgvBorclular.AllowUserToAddRows = false;
            this.dgvBorclular.AllowUserToResizeRows = false;
            this.dgvBorclular.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBorclular.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBorclular.Location = new System.Drawing.Point(20, 306);
            this.dgvBorclular.MultiSelect = false;
            this.dgvBorclular.Name = "dgvBorclular";
            this.dgvBorclular.ReadOnly = true;
            this.dgvBorclular.RowHeadersVisible = false;
            this.dgvBorclular.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBorclular.Size = new System.Drawing.Size(346, 365);
            this.dgvBorclular.TabIndex = 20;
            // 
            // tBoxSoyadi
            // 
            this.tBoxSoyadi.Enabled = false;
            this.tBoxSoyadi.Location = new System.Drawing.Point(108, 250);
            this.tBoxSoyadi.Name = "tBoxSoyadi";
            this.tBoxSoyadi.Size = new System.Drawing.Size(258, 23);
            this.tBoxSoyadi.TabIndex = 19;
            // 
            // kryptonLabel5
            // 
            this.kryptonLabel5.Location = new System.Drawing.Point(18, 250);
            this.kryptonLabel5.Name = "kryptonLabel5";
            this.kryptonLabel5.Size = new System.Drawing.Size(50, 20);
            this.kryptonLabel5.TabIndex = 18;
            this.kryptonLabel5.Values.Text = "Soyadı:";
            // 
            // tBoxAdi
            // 
            this.tBoxAdi.Enabled = false;
            this.tBoxAdi.Location = new System.Drawing.Point(108, 221);
            this.tBoxAdi.Name = "tBoxAdi";
            this.tBoxAdi.Size = new System.Drawing.Size(258, 23);
            this.tBoxAdi.TabIndex = 17;
            // 
            // kryptonLabel6
            // 
            this.kryptonLabel6.Location = new System.Drawing.Point(18, 221);
            this.kryptonLabel6.Name = "kryptonLabel6";
            this.kryptonLabel6.Size = new System.Drawing.Size(31, 20);
            this.kryptonLabel6.TabIndex = 16;
            this.kryptonLabel6.Values.Text = "Adı:";
            // 
            // tBoxTCNo
            // 
            this.tBoxTCNo.Location = new System.Drawing.Point(110, 163);
            this.tBoxTCNo.MaxLength = 11;
            this.tBoxTCNo.Name = "tBoxTCNo";
            this.tBoxTCNo.Size = new System.Drawing.Size(258, 23);
            this.tBoxTCNo.TabIndex = 15;
            this.tBoxTCNo.TextChanged += new System.EventHandler(this.tBoxTCNo_TextChanged);
            // 
            // kryptonLabel7
            // 
            this.kryptonLabel7.Location = new System.Drawing.Point(20, 163);
            this.kryptonLabel7.Name = "kryptonLabel7";
            this.kryptonLabel7.Size = new System.Drawing.Size(84, 20);
            this.kryptonLabel7.TabIndex = 14;
            this.kryptonLabel7.Values.Text = "TC Kimlik No:";
            // 
            // kryptonLabel4
            // 
            this.kryptonLabel4.Location = new System.Drawing.Point(15, 107);
            this.kryptonLabel4.Name = "kryptonLabel4";
            this.kryptonLabel4.Size = new System.Drawing.Size(48, 20);
            this.kryptonLabel4.TabIndex = 6;
            this.kryptonLabel4.Values.Text = "Bakiye:";
            // 
            // Date_date
            // 
            this.Date_date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Date_date.Location = new System.Drawing.Point(110, 77);
            this.Date_date.Name = "Date_date";
            this.Date_date.Size = new System.Drawing.Size(127, 21);
            this.Date_date.TabIndex = 5;
            // 
            // kryptonLabel3
            // 
            this.kryptonLabel3.Location = new System.Drawing.Point(15, 78);
            this.kryptonLabel3.Name = "kryptonLabel3";
            this.kryptonLabel3.Size = new System.Drawing.Size(40, 20);
            this.kryptonLabel3.TabIndex = 4;
            this.kryptonLabel3.Values.Text = "Tarih:";
            // 
            // tBoxEsasNo
            // 
            this.tBoxEsasNo.Location = new System.Drawing.Point(110, 48);
            this.tBoxEsasNo.Name = "tBoxEsasNo";
            this.tBoxEsasNo.Size = new System.Drawing.Size(238, 23);
            this.tBoxEsasNo.TabIndex = 3;
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.Location = new System.Drawing.Point(15, 52);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(89, 20);
            this.kryptonLabel2.TabIndex = 2;
            this.kryptonLabel2.Values.Text = "Esas Numarası";
            // 
            // cBox_İcraDairesi
            // 
            this.cBox_İcraDairesi.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cBox_İcraDairesi.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cBox_İcraDairesi.DropDownWidth = 238;
            this.cBox_İcraDairesi.Location = new System.Drawing.Point(110, 22);
            this.cBox_İcraDairesi.Name = "cBox_İcraDairesi";
            this.cBox_İcraDairesi.Size = new System.Drawing.Size(238, 21);
            this.cBox_İcraDairesi.TabIndex = 1;
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(15, 22);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(73, 20);
            this.kryptonLabel1.TabIndex = 0;
            this.kryptonLabel1.Values.Text = "İcra Dairesi:";
            // 
            // addIcra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1086, 682);
            this.Controls.Add(this.tBox_sabit_kesinti);
            this.Controls.Add(this.kryptonLabel12);
            this.Controls.Add(this.cBox_Oncelik);
            this.Controls.Add(this.tbox_borclu_kisino);
            this.Controls.Add(this.kryptonLabel11);
            this.Controls.Add(this.tBoxBakiye);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.btn_add_alacakTuru);
            this.Controls.Add(this.btn_add_borclu);
            this.Controls.Add(this.kryptonLabel10);
            this.Controls.Add(this.cBoxAlacak);
            this.Controls.Add(this.kryptonLabel9);
            this.Controls.Add(this.dgvAlacak);
            this.Controls.Add(this.cBox_IcraTuru);
            this.Controls.Add(this.kryptonLabel8);
            this.Controls.Add(this.dgvBorclular);
            this.Controls.Add(this.tBoxSoyadi);
            this.Controls.Add(this.kryptonLabel5);
            this.Controls.Add(this.tBoxAdi);
            this.Controls.Add(this.kryptonLabel6);
            this.Controls.Add(this.tBoxTCNo);
            this.Controls.Add(this.kryptonLabel7);
            this.Controls.Add(this.kryptonLabel4);
            this.Controls.Add(this.Date_date);
            this.Controls.Add(this.kryptonLabel3);
            this.Controls.Add(this.tBoxEsasNo);
            this.Controls.Add(this.kryptonLabel2);
            this.Controls.Add(this.cBox_İcraDairesi);
            this.Controls.Add(this.kryptonLabel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(-3, -1);
            this.Name = "addIcra";
            this.Text = "İcra Ekranı";
            ((System.ComponentModel.ISupportInitialize)(this.cBoxAlacak)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlacak)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cBox_IcraTuru)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBorclular)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cBox_İcraDairesi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

    
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox cBox_İcraDairesi;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel3;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox tBoxEsasNo;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel4;
        private ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker Date_date;
        private System.Windows.Forms.DataGridView dgvBorclular;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox tBoxSoyadi;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel5;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox tBoxAdi;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel6;
        public ComponentFactory.Krypton.Toolkit.KryptonTextBox tBoxTCNo;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel7;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox cBox_IcraTuru;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel8;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel10;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox cBoxAlacak;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel9;
        private System.Windows.Forms.DataGridView dgvAlacak;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_add_alacakTuru;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_add_borclu;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_save;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox tBoxBakiye;
        public ComponentFactory.Krypton.Toolkit.KryptonTextBox tbox_borclu_kisino;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel11;
        private ComponentFactory.Krypton.Toolkit.KryptonCheckBox cBox_Oncelik;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox tBox_sabit_kesinti;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel12;
    }
}