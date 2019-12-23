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
            this.kryptonPanel1 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.tBoxBakiye = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel4 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.Date_date = new ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker();
            this.kryptonLabel3 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.cBoxAlacak = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.kryptonLabel9 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.btnaddKesinti = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cBoxAlacak)).BeginInit();
            this.SuspendLayout();
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.kryptonPanel1.Controls.Add(this.btnaddKesinti);
            this.kryptonPanel1.Controls.Add(this.cBoxAlacak);
            this.kryptonPanel1.Controls.Add(this.kryptonLabel9);
            this.kryptonPanel1.Controls.Add(this.tBoxBakiye);
            this.kryptonPanel1.Controls.Add(this.kryptonLabel4);
            this.kryptonPanel1.Controls.Add(this.Date_date);
            this.kryptonPanel1.Controls.Add(this.kryptonLabel3);
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Size = new System.Drawing.Size(541, 227);
            this.kryptonPanel1.TabIndex = 0;
            // 
            // tBoxBakiye
            // 
            this.tBoxBakiye.Location = new System.Drawing.Point(211, 110);
            this.tBoxBakiye.Margin = new System.Windows.Forms.Padding(4);
            this.tBoxBakiye.MaxLength = 10;
            this.tBoxBakiye.Name = "tBoxBakiye";
            this.tBoxBakiye.Size = new System.Drawing.Size(169, 27);
            this.tBoxBakiye.TabIndex = 34;
            this.tBoxBakiye.Validating += new System.ComponentModel.CancelEventHandler(this.tBoxBakiye_Validating);
            // 
            // kryptonLabel4
            // 
            this.kryptonLabel4.Location = new System.Drawing.Point(154, 113);
            this.kryptonLabel4.Margin = new System.Windows.Forms.Padding(4);
            this.kryptonLabel4.Name = "kryptonLabel4";
            this.kryptonLabel4.Size = new System.Drawing.Size(50, 24);
            this.kryptonLabel4.TabIndex = 33;
            this.kryptonLabel4.Values.Text = "Tutar:";
            // 
            // Date_date
            // 
            this.Date_date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Date_date.Location = new System.Drawing.Point(211, 77);
            this.Date_date.Margin = new System.Windows.Forms.Padding(4);
            this.Date_date.Name = "Date_date";
            this.Date_date.Size = new System.Drawing.Size(169, 25);
            this.Date_date.TabIndex = 32;
            // 
            // kryptonLabel3
            // 
            this.kryptonLabel3.Location = new System.Drawing.Point(154, 77);
            this.kryptonLabel3.Margin = new System.Windows.Forms.Padding(4);
            this.kryptonLabel3.Name = "kryptonLabel3";
            this.kryptonLabel3.Size = new System.Drawing.Size(49, 24);
            this.kryptonLabel3.TabIndex = 31;
            this.kryptonLabel3.Values.Text = "Tarih:";
            // 
            // cBoxAlacak
            // 
            this.cBoxAlacak.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cBoxAlacak.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cBoxAlacak.DropDownWidth = 238;
            this.cBoxAlacak.Location = new System.Drawing.Point(211, 44);
            this.cBoxAlacak.Margin = new System.Windows.Forms.Padding(4);
            this.cBoxAlacak.Name = "cBoxAlacak";
            this.cBoxAlacak.Size = new System.Drawing.Size(317, 25);
            this.cBoxAlacak.TabIndex = 36;
            // 
            // kryptonLabel9
            // 
            this.kryptonLabel9.Location = new System.Drawing.Point(13, 45);
            this.kryptonLabel9.Margin = new System.Windows.Forms.Padding(4);
            this.kryptonLabel9.Name = "kryptonLabel9";
            this.kryptonLabel9.Size = new System.Drawing.Size(201, 24);
            this.kryptonLabel9.TabIndex = 35;
            this.kryptonLabel9.Values.Text = "Kesinti Yapılabilecek Alacak:";
            // 
            // btnaddKesinti
            // 
            this.btnaddKesinti.Location = new System.Drawing.Point(371, 161);
            this.btnaddKesinti.Name = "btnaddKesinti";
            this.btnaddKesinti.Size = new System.Drawing.Size(137, 45);
            this.btnaddKesinti.TabIndex = 37;
            this.btnaddKesinti.Values.Text = "Kesinti Ekle";
            this.btnaddKesinti.Click += new System.EventHandler(this.btnaddKesinti_Click);
            // 
            // frmKesintiYap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 226);
            this.Controls.Add(this.kryptonPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmKesintiYap";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Kesinti Yap";
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            this.kryptonPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cBoxAlacak)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox tBoxBakiye;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel4;
        private ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker Date_date;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel3;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox cBoxAlacak;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel9;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnaddKesinti;
    }
}