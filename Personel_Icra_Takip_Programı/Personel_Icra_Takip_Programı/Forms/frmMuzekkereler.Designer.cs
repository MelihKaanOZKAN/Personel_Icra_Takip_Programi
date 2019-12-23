namespace Personel_Icra_Takip_Programı.Forms
{
    partial class frmMuzekkereler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMuzekkereler));
            this.btnSave = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.pdfViewer = new Spire.PdfViewer.Forms.PdfViewer();
            this.btnAdd = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnOpenFile = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.Date_date = new ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker();
            this.kryptonLabel3 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.dgv_muzekkereler = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_muzekkereler)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(449, 169);
            this.btnSave.Margin = new System.Windows.Forms.Padding(2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(89, 40);
            this.btnSave.TabIndex = 12;
            this.btnSave.Values.Text = "Farklı Kaydet";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // pdfViewer
            // 
            this.pdfViewer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pdfViewer.FindTextHighLightColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(153)))), ((int)(((byte)(193)))), ((int)(((byte)(218)))));
            this.pdfViewer.IgnoreCase = false;
            this.pdfViewer.IsToolBarVisible = true;
            this.pdfViewer.Location = new System.Drawing.Point(550, 2);
            this.pdfViewer.Margin = new System.Windows.Forms.Padding(2);
            this.pdfViewer.MultiPagesThreshold = 60;
            this.pdfViewer.Name = "pdfViewer";
            this.pdfViewer.Size = new System.Drawing.Size(459, 670);
            this.pdfViewer.TabIndex = 11;
            this.pdfViewer.Text = "pdfViewer1";
            this.pdfViewer.Threshold = 60;
            this.pdfViewer.ViewerBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(368, 91);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(170, 35);
            this.btnAdd.TabIndex = 10;
            this.btnAdd.Values.Text = "Müzekkereyi Sisteme Ekle";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnOpenFile
            // 
            this.btnOpenFile.Location = new System.Drawing.Point(414, 58);
            this.btnOpenFile.Margin = new System.Windows.Forms.Padding(2);
            this.btnOpenFile.Name = "btnOpenFile";
            this.btnOpenFile.Size = new System.Drawing.Size(124, 28);
            this.btnOpenFile.TabIndex = 9;
            this.btnOpenFile.Values.Text = "Aç";
            this.btnOpenFile.Click += new System.EventHandler(this.btnOpenFile_Click);
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(346, 58);
            this.kryptonLabel1.Margin = new System.Windows.Forms.Padding(2);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(69, 20);
            this.kryptonLabel1.TabIndex = 8;
            this.kryptonLabel1.Values.Text = "Dosya Seç:";
            // 
            // Date_date
            // 
            this.Date_date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Date_date.Location = new System.Drawing.Point(396, 18);
            this.Date_date.Name = "Date_date";
            this.Date_date.Size = new System.Drawing.Size(127, 21);
            this.Date_date.TabIndex = 7;
            // 
            // kryptonLabel3
            // 
            this.kryptonLabel3.Location = new System.Drawing.Point(346, 19);
            this.kryptonLabel3.Name = "kryptonLabel3";
            this.kryptonLabel3.Size = new System.Drawing.Size(40, 20);
            this.kryptonLabel3.TabIndex = 6;
            this.kryptonLabel3.Values.Text = "Tarih:";
            // 
            // dgv_muzekkereler
            // 
            this.dgv_muzekkereler.AllowUserToAddRows = false;
            this.dgv_muzekkereler.AllowUserToDeleteRows = false;
            this.dgv_muzekkereler.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgv_muzekkereler.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_muzekkereler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_muzekkereler.Location = new System.Drawing.Point(2, 2);
            this.dgv_muzekkereler.Margin = new System.Windows.Forms.Padding(2);
            this.dgv_muzekkereler.MultiSelect = false;
            this.dgv_muzekkereler.Name = "dgv_muzekkereler";
            this.dgv_muzekkereler.ReadOnly = true;
            this.dgv_muzekkereler.RowHeadersVisible = false;
            this.dgv_muzekkereler.RowTemplate.Height = 24;
            this.dgv_muzekkereler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_muzekkereler.Size = new System.Drawing.Size(310, 670);
            this.dgv_muzekkereler.TabIndex = 0;
            this.dgv_muzekkereler.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_muzekkereler_CellClick);
            // 
            // frmMuzekkereler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1009, 676);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.pdfViewer);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnOpenFile);
            this.Controls.Add(this.kryptonLabel1);
            this.Controls.Add(this.Date_date);
            this.Controls.Add(this.kryptonLabel3);
            this.Controls.Add(this.dgv_muzekkereler);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(1025, 715);
            this.Name = "frmMuzekkereler";
            this.Text = "Müzekkereler";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_muzekkereler)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        
        private  System.Windows.Forms.DataGridView dgv_muzekkereler;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnOpenFile;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker Date_date;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel3;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnAdd;
        private Spire.PdfViewer.Forms.PdfViewer pdfViewer;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnSave;
    }
}