namespace Personel_Icra_Takip_Programı.Forms
{
    partial class frmCevapYaziları
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCevapYaziları));
            this.kryptonGroupBox2 = new ComponentFactory.Krypton.Toolkit.KryptonGroupBox();
            this.richTox_ek_aciklama = new ComponentFactory.Krypton.Toolkit.KryptonRichTextBox();
            this.kryptonLabel6 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.btnAddEk = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnOpenEk = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonLabel8 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonGroupBox1 = new ComponentFactory.Krypton.Toolkit.KryptonGroupBox();
            this.kryptonLabel5 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.tBox_evrak_sayısı = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.Date_date = new ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker();
            this.btnAdd = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonLabel4 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.btnOpenFile = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonLabel3 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.dgv_ekler = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip_ekler = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.kryptonLabel2 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.dgv_cevaplar = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip_cevaplar = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.evrakıAçToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox2.Panel)).BeginInit();
            this.kryptonGroupBox2.Panel.SuspendLayout();
            this.kryptonGroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox1.Panel)).BeginInit();
            this.kryptonGroupBox1.Panel.SuspendLayout();
            this.kryptonGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ekler)).BeginInit();
            this.contextMenuStrip_ekler.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_cevaplar)).BeginInit();
            this.contextMenuStrip_cevaplar.SuspendLayout();
            this.SuspendLayout();
            // 
            // kryptonGroupBox2
            // 
            this.kryptonGroupBox2.Location = new System.Drawing.Point(623, 37);
            this.kryptonGroupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.kryptonGroupBox2.Name = "kryptonGroupBox2";
            // 
            // kryptonGroupBox2.Panel
            // 
            this.kryptonGroupBox2.Panel.Controls.Add(this.richTox_ek_aciklama);
            this.kryptonGroupBox2.Panel.Controls.Add(this.kryptonLabel6);
            this.kryptonGroupBox2.Panel.Controls.Add(this.btnAddEk);
            this.kryptonGroupBox2.Panel.Controls.Add(this.btnOpenEk);
            this.kryptonGroupBox2.Panel.Controls.Add(this.kryptonLabel8);
            this.kryptonGroupBox2.Size = new System.Drawing.Size(310, 180);
            this.kryptonGroupBox2.TabIndex = 17;
            this.kryptonGroupBox2.Values.Heading = "Yazı Eki Bİlgileri";
            // 
            // richTox_ek_aciklama
            // 
            this.richTox_ek_aciklama.Location = new System.Drawing.Point(64, 2);
            this.richTox_ek_aciklama.Margin = new System.Windows.Forms.Padding(2);
            this.richTox_ek_aciklama.Name = "richTox_ek_aciklama";
            this.richTox_ek_aciklama.Size = new System.Drawing.Size(202, 50);
            this.richTox_ek_aciklama.TabIndex = 17;
            this.richTox_ek_aciklama.Text = "";
            // 
            // kryptonLabel6
            // 
            this.kryptonLabel6.Location = new System.Drawing.Point(2, 10);
            this.kryptonLabel6.Margin = new System.Windows.Forms.Padding(2);
            this.kryptonLabel6.Name = "kryptonLabel6";
            this.kryptonLabel6.Size = new System.Drawing.Size(62, 20);
            this.kryptonLabel6.TabIndex = 16;
            this.kryptonLabel6.Values.Text = "Açıklama:";
            // 
            // btnAddEk
            // 
            this.btnAddEk.Enabled = false;
            this.btnAddEk.Location = new System.Drawing.Point(110, 104);
            this.btnAddEk.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddEk.Name = "btnAddEk";
            this.btnAddEk.Size = new System.Drawing.Size(170, 35);
            this.btnAddEk.TabIndex = 15;
            this.btnAddEk.Values.Text = "Sisteme Ekle";
            this.btnAddEk.Click += new System.EventHandler(this.btnAddEk_Click);
            // 
            // btnOpenEk
            // 
            this.btnOpenEk.Location = new System.Drawing.Point(69, 58);
            this.btnOpenEk.Margin = new System.Windows.Forms.Padding(2);
            this.btnOpenEk.Name = "btnOpenEk";
            this.btnOpenEk.Size = new System.Drawing.Size(124, 28);
            this.btnOpenEk.TabIndex = 14;
            this.btnOpenEk.Values.Text = "Aç";
            this.btnOpenEk.Click += new System.EventHandler(this.btnOpenEk_Click);
            // 
            // kryptonLabel8
            // 
            this.kryptonLabel8.Location = new System.Drawing.Point(2, 58);
            this.kryptonLabel8.Margin = new System.Windows.Forms.Padding(2);
            this.kryptonLabel8.Name = "kryptonLabel8";
            this.kryptonLabel8.Size = new System.Drawing.Size(69, 20);
            this.kryptonLabel8.TabIndex = 13;
            this.kryptonLabel8.Values.Text = "Dosya Seç:";
            // 
            // kryptonGroupBox1
            // 
            this.kryptonGroupBox1.Location = new System.Drawing.Point(324, 246);
            this.kryptonGroupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.kryptonGroupBox1.Name = "kryptonGroupBox1";
            // 
            // kryptonGroupBox1.Panel
            // 
            this.kryptonGroupBox1.Panel.Controls.Add(this.kryptonLabel5);
            this.kryptonGroupBox1.Panel.Controls.Add(this.tBox_evrak_sayısı);
            this.kryptonGroupBox1.Panel.Controls.Add(this.Date_date);
            this.kryptonGroupBox1.Panel.Controls.Add(this.btnAdd);
            this.kryptonGroupBox1.Panel.Controls.Add(this.kryptonLabel4);
            this.kryptonGroupBox1.Panel.Controls.Add(this.btnOpenFile);
            this.kryptonGroupBox1.Panel.Controls.Add(this.kryptonLabel3);
            this.kryptonGroupBox1.Size = new System.Drawing.Size(310, 180);
            this.kryptonGroupBox1.TabIndex = 16;
            this.kryptonGroupBox1.Values.Heading = "Resmi Yazı Bilgileri";
            // 
            // kryptonLabel5
            // 
            this.kryptonLabel5.Location = new System.Drawing.Point(20, 9);
            this.kryptonLabel5.Name = "kryptonLabel5";
            this.kryptonLabel5.Size = new System.Drawing.Size(35, 20);
            this.kryptonLabel5.TabIndex = 17;
            this.kryptonLabel5.Values.Text = "Sayı:";
            // 
            // tBox_evrak_sayısı
            // 
            this.tBox_evrak_sayısı.Location = new System.Drawing.Point(68, 6);
            this.tBox_evrak_sayısı.Margin = new System.Windows.Forms.Padding(2);
            this.tBox_evrak_sayısı.Name = "tBox_evrak_sayısı";
            this.tBox_evrak_sayısı.Size = new System.Drawing.Size(127, 23);
            this.tBox_evrak_sayısı.TabIndex = 16;
            // 
            // Date_date
            // 
            this.Date_date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Date_date.Location = new System.Drawing.Point(68, 34);
            this.Date_date.Name = "Date_date";
            this.Date_date.Size = new System.Drawing.Size(127, 21);
            this.Date_date.TabIndex = 12;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(128, 120);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(170, 35);
            this.btnAdd.TabIndex = 15;
            this.btnAdd.Values.Text = "Yazıyı Sisteme Ekle";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // kryptonLabel4
            // 
            this.kryptonLabel4.Location = new System.Drawing.Point(19, 35);
            this.kryptonLabel4.Name = "kryptonLabel4";
            this.kryptonLabel4.Size = new System.Drawing.Size(40, 20);
            this.kryptonLabel4.TabIndex = 11;
            this.kryptonLabel4.Values.Text = "Tarih:";
            // 
            // btnOpenFile
            // 
            this.btnOpenFile.Location = new System.Drawing.Point(86, 75);
            this.btnOpenFile.Margin = new System.Windows.Forms.Padding(2);
            this.btnOpenFile.Name = "btnOpenFile";
            this.btnOpenFile.Size = new System.Drawing.Size(124, 28);
            this.btnOpenFile.TabIndex = 14;
            this.btnOpenFile.Values.Text = "Aç";
            this.btnOpenFile.Click += new System.EventHandler(this.btnOpenFile_Click);
            // 
            // kryptonLabel3
            // 
            this.kryptonLabel3.Location = new System.Drawing.Point(19, 75);
            this.kryptonLabel3.Margin = new System.Windows.Forms.Padding(2);
            this.kryptonLabel3.Name = "kryptonLabel3";
            this.kryptonLabel3.Size = new System.Drawing.Size(69, 20);
            this.kryptonLabel3.TabIndex = 13;
            this.kryptonLabel3.Values.Text = "Dosya Seç:";
            // 
            // dgv_ekler
            // 
            this.dgv_ekler.AllowUserToAddRows = false;
            this.dgv_ekler.AllowUserToDeleteRows = false;
            this.dgv_ekler.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgv_ekler.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_ekler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ekler.ContextMenuStrip = this.contextMenuStrip_ekler;
            this.dgv_ekler.Location = new System.Drawing.Point(302, 53);
            this.dgv_ekler.Margin = new System.Windows.Forms.Padding(2);
            this.dgv_ekler.MultiSelect = false;
            this.dgv_ekler.Name = "dgv_ekler";
            this.dgv_ekler.ReadOnly = true;
            this.dgv_ekler.RowHeadersVisible = false;
            this.dgv_ekler.RowTemplate.Height = 24;
            this.dgv_ekler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_ekler.Size = new System.Drawing.Size(310, 164);
            this.dgv_ekler.TabIndex = 3;
            // 
            // contextMenuStrip_ekler
            // 
            this.contextMenuStrip_ekler.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.contextMenuStrip_ekler.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip_ekler.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.contextMenuStrip_ekler.Name = "contextMenuStrip1";
            this.contextMenuStrip_ekler.Size = new System.Drawing.Size(123, 26);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(122, 22);
            this.toolStripMenuItem1.Text = "Evrakı Aç";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.Location = new System.Drawing.Point(302, 28);
            this.kryptonLabel2.Margin = new System.Windows.Forms.Padding(2);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(37, 20);
            this.kryptonLabel2.TabIndex = 2;
            this.kryptonLabel2.Values.Text = "Ekler";
            // 
            // dgv_cevaplar
            // 
            this.dgv_cevaplar.AllowUserToAddRows = false;
            this.dgv_cevaplar.AllowUserToDeleteRows = false;
            this.dgv_cevaplar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgv_cevaplar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_cevaplar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_cevaplar.ContextMenuStrip = this.contextMenuStrip_cevaplar;
            this.dgv_cevaplar.Location = new System.Drawing.Point(9, 37);
            this.dgv_cevaplar.Margin = new System.Windows.Forms.Padding(2);
            this.dgv_cevaplar.MultiSelect = false;
            this.dgv_cevaplar.Name = "dgv_cevaplar";
            this.dgv_cevaplar.ReadOnly = true;
            this.dgv_cevaplar.RowHeadersVisible = false;
            this.dgv_cevaplar.RowTemplate.Height = 24;
            this.dgv_cevaplar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_cevaplar.Size = new System.Drawing.Size(280, 520);
            this.dgv_cevaplar.TabIndex = 1;
            this.dgv_cevaplar.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_cevaplar_CellClick);
            // 
            // contextMenuStrip_cevaplar
            // 
            this.contextMenuStrip_cevaplar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.contextMenuStrip_cevaplar.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip_cevaplar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.evrakıAçToolStripMenuItem});
            this.contextMenuStrip_cevaplar.Name = "contextMenuStrip_cevaplar";
            this.contextMenuStrip_cevaplar.Size = new System.Drawing.Size(123, 26);
            // 
            // evrakıAçToolStripMenuItem
            // 
            this.evrakıAçToolStripMenuItem.Name = "evrakıAçToolStripMenuItem";
            this.evrakıAçToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.evrakıAçToolStripMenuItem.Text = "Evrakı Aç";
            this.evrakıAçToolStripMenuItem.Click += new System.EventHandler(this.evrakıAçToolStripMenuItem_Click);
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(9, 12);
            this.kryptonLabel1.Margin = new System.Windows.Forms.Padding(2);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(58, 20);
            this.kryptonLabel1.TabIndex = 0;
            this.kryptonLabel1.Values.Text = "Cevaplar";
            // 
            // frmCevapYaziları
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(943, 556);
            this.Controls.Add(this.kryptonGroupBox2);
            this.Controls.Add(this.kryptonGroupBox1);
            this.Controls.Add(this.dgv_ekler);
            this.Controls.Add(this.kryptonLabel2);
            this.Controls.Add(this.dgv_cevaplar);
            this.Controls.Add(this.kryptonLabel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmCevapYaziları";
            this.Text = "Cevap Yazıları";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmCevapYaziları_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox2.Panel)).EndInit();
            this.kryptonGroupBox2.Panel.ResumeLayout(false);
            this.kryptonGroupBox2.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox2)).EndInit();
            this.kryptonGroupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox1.Panel)).EndInit();
            this.kryptonGroupBox1.Panel.ResumeLayout(false);
            this.kryptonGroupBox1.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox1)).EndInit();
            this.kryptonGroupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ekler)).EndInit();
            this.contextMenuStrip_ekler.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_cevaplar)).EndInit();
            this.contextMenuStrip_cevaplar.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private  System.Windows.Forms.DataGridView dgv_cevaplar;
        private  System.Windows.Forms.DataGridView dgv_ekler;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip_ekler;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip_cevaplar;
        private System.Windows.Forms.ToolStripMenuItem evrakıAçToolStripMenuItem;
        private ComponentFactory.Krypton.Toolkit.KryptonGroupBox kryptonGroupBox2;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnAddEk;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnOpenEk;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel8;
        private ComponentFactory.Krypton.Toolkit.KryptonGroupBox kryptonGroupBox1;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel5;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox tBox_evrak_sayısı;
        private ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker Date_date;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnAdd;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel4;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnOpenFile;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel3;
        private ComponentFactory.Krypton.Toolkit.KryptonRichTextBox richTox_ek_aciklama;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel6;
    }
}