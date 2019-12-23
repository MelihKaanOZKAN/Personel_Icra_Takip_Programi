namespace Personel_Icra_Takip_Programı.Forms
{
    partial class frmIcralar
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
            this.dataGV_Icralar = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.kesintiYapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tBoxSoyadi = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel3 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.tBoxAdi = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel4 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.tBoxTCNo = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel2 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGV_Icralar)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGV_Icralar
            // 
            this.dataGV_Icralar.AllowUserToAddRows = false;
            this.dataGV_Icralar.AllowUserToDeleteRows = false;
            this.dataGV_Icralar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGV_Icralar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGV_Icralar.ContextMenuStrip = this.contextMenuStrip1;
            this.dataGV_Icralar.Location = new System.Drawing.Point(3, 174);
            this.dataGV_Icralar.MultiSelect = false;
            this.dataGV_Icralar.Name = "dataGV_Icralar";
            this.dataGV_Icralar.ReadOnly = true;
            this.dataGV_Icralar.RowHeadersVisible = false;
            this.dataGV_Icralar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGV_Icralar.Size = new System.Drawing.Size(829, 373);
            this.dataGV_Icralar.TabIndex = 14;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kesintiYapToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(132, 26);
            // 
            // kesintiYapToolStripMenuItem
            // 
            this.kesintiYapToolStripMenuItem.Name = "kesintiYapToolStripMenuItem";
            this.kesintiYapToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.kesintiYapToolStripMenuItem.Text = "Kesinti Yap";
            this.kesintiYapToolStripMenuItem.Click += new System.EventHandler(this.kesintiYapToolStripMenuItem_Click);
            // 
            // tBoxSoyadi
            // 
            this.tBoxSoyadi.Enabled = false;
            this.tBoxSoyadi.Location = new System.Drawing.Point(99, 87);
            this.tBoxSoyadi.Name = "tBoxSoyadi";
            this.tBoxSoyadi.Size = new System.Drawing.Size(258, 23);
            this.tBoxSoyadi.TabIndex = 13;
            // 
            // kryptonLabel3
            // 
            this.kryptonLabel3.Location = new System.Drawing.Point(9, 87);
            this.kryptonLabel3.Name = "kryptonLabel3";
            this.kryptonLabel3.Size = new System.Drawing.Size(50, 20);
            this.kryptonLabel3.TabIndex = 12;
            this.kryptonLabel3.Values.Text = "Soyadı:";
            // 
            // tBoxAdi
            // 
            this.tBoxAdi.Enabled = false;
            this.tBoxAdi.Location = new System.Drawing.Point(99, 58);
            this.tBoxAdi.Name = "tBoxAdi";
            this.tBoxAdi.Size = new System.Drawing.Size(258, 23);
            this.tBoxAdi.TabIndex = 11;
            // 
            // kryptonLabel4
            // 
            this.kryptonLabel4.Location = new System.Drawing.Point(9, 58);
            this.kryptonLabel4.Name = "kryptonLabel4";
            this.kryptonLabel4.Size = new System.Drawing.Size(31, 20);
            this.kryptonLabel4.TabIndex = 10;
            this.kryptonLabel4.Values.Text = "Adı:";
            // 
            // tBoxTCNo
            // 
            this.tBoxTCNo.Enabled = false;
            this.tBoxTCNo.Location = new System.Drawing.Point(99, 29);
            this.tBoxTCNo.MaxLength = 11;
            this.tBoxTCNo.Name = "tBoxTCNo";
            this.tBoxTCNo.Size = new System.Drawing.Size(258, 23);
            this.tBoxTCNo.TabIndex = 9;
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.Location = new System.Drawing.Point(9, 29);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(84, 20);
            this.kryptonLabel2.TabIndex = 8;
            this.kryptonLabel2.Values.Text = "TC Kimlik No:";
            // 
            // frmIcralar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 544);
            this.Controls.Add(this.dataGV_Icralar);
            this.Controls.Add(this.tBoxSoyadi);
            this.Controls.Add(this.kryptonLabel3);
            this.Controls.Add(this.tBoxAdi);
            this.Controls.Add(this.kryptonLabel4);
            this.Controls.Add(this.tBoxTCNo);
            this.Controls.Add(this.kryptonLabel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmIcralar";
            this.ShowIcon = false;
            this.Text = "İcralar";
            this.Load += new System.EventHandler(this.frmIcralar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGV_Icralar)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox tBoxSoyadi;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel3;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox tBoxAdi;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel4;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel2;
        public ComponentFactory.Krypton.Toolkit.KryptonTextBox tBoxTCNo;
        private  System.Windows.Forms.DataGridView dataGV_Icralar;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem kesintiYapToolStripMenuItem;
    }
}