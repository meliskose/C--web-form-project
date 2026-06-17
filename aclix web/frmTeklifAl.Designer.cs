namespace aclix_web
{
    partial class frmTeklifAl
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
            this.lblTeklifBaslik = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAdSoyad = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbHizmet = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMesaj = new System.Windows.Forms.TextBox();
            this.btnGonder = new System.Windows.Forms.Button();
            this.pnlArkaPlan = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // lblTeklifBaslik
            // 
            this.lblTeklifBaslik.AutoSize = true;
            this.lblTeklifBaslik.Font = new System.Drawing.Font("Century Gothic", 30F, System.Drawing.FontStyle.Bold);
            this.lblTeklifBaslik.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(113)))), ((int)(((byte)(150)))));
            this.lblTeklifBaslik.Location = new System.Drawing.Point(489, 100);
            this.lblTeklifBaslik.Name = "lblTeklifBaslik";
            this.lblTeklifBaslik.Size = new System.Drawing.Size(364, 47);
            this.lblTeklifBaslik.TabIndex = 0;
            this.lblTeklifBaslik.Text = "Teklif Talep Formu";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 20F);
            this.label1.Location = new System.Drawing.Point(497, 178);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ad - Soyad";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtAdSoyad
            // 
            this.txtAdSoyad.Location = new System.Drawing.Point(503, 214);
            this.txtAdSoyad.Multiline = true;
            this.txtAdSoyad.Name = "txtAdSoyad";
            this.txtAdSoyad.Size = new System.Drawing.Size(312, 39);
            this.txtAdSoyad.TabIndex = 2;
            this.txtAdSoyad.TextChanged += new System.EventHandler(this.txtAdSoyad_TextChanged_1);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(503, 312);
            this.txtEmail.Multiline = true;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(312, 39);
            this.txtEmail.TabIndex = 4;
            this.txtEmail.TextChanged += new System.EventHandler(this.txtEmail_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 20F);
            this.label2.Location = new System.Drawing.Point(497, 276);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 33);
            this.label2.TabIndex = 3;
            this.label2.Text = "E-Posta";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 20F);
            this.label3.Location = new System.Drawing.Point(497, 364);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(212, 33);
            this.label3.TabIndex = 5;
            this.label3.Text = "Hizmet Seçiniz: ";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // cmbHizmet
            // 
            this.cmbHizmet.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbHizmet.Font = new System.Drawing.Font("Century", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbHizmet.FormattingEnabled = true;
            this.cmbHizmet.ItemHeight = 28;
            this.cmbHizmet.Items.AddRange(new object[] {
            "Bulut Altyapı",
            "Web Yazılım",
            "Mobil Uygulama",
            "Siber Güvenlik",
            "Kurumsal Otomasyon",
            "Teknik Destek"});
            this.cmbHizmet.Location = new System.Drawing.Point(503, 413);
            this.cmbHizmet.Name = "cmbHizmet";
            this.cmbHizmet.Size = new System.Drawing.Size(312, 36);
            this.cmbHizmet.TabIndex = 6;
            this.cmbHizmet.SelectedIndexChanged += new System.EventHandler(this.cmbHizmet_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 20F);
            this.label4.Location = new System.Drawing.Point(497, 458);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 33);
            this.label4.TabIndex = 7;
            this.label4.Text = "Mesajınız";
            // 
            // txtMesaj
            // 
            this.txtMesaj.Location = new System.Drawing.Point(503, 504);
            this.txtMesaj.Multiline = true;
            this.txtMesaj.Name = "txtMesaj";
            this.txtMesaj.Size = new System.Drawing.Size(312, 72);
            this.txtMesaj.TabIndex = 8;
            // 
            // btnGonder
            // 
            this.btnGonder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(113)))), ((int)(((byte)(150)))));
            this.btnGonder.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGonder.ForeColor = System.Drawing.Color.White;
            this.btnGonder.Location = new System.Drawing.Point(577, 603);
            this.btnGonder.Name = "btnGonder";
            this.btnGonder.Size = new System.Drawing.Size(173, 57);
            this.btnGonder.TabIndex = 9;
            this.btnGonder.Text = "Teklifi Gönder";
            this.btnGonder.UseVisualStyleBackColor = false;
            this.btnGonder.Click += new System.EventHandler(this.btnGonder_Click);
            // 
            // pnlArkaPlan
            // 
            this.pnlArkaPlan.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlArkaPlan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlArkaPlan.Location = new System.Drawing.Point(444, 65);
            this.pnlArkaPlan.Name = "pnlArkaPlan";
            this.pnlArkaPlan.Size = new System.Drawing.Size(445, 644);
            this.pnlArkaPlan.TabIndex = 10;
            // 
            // frmTeklifAl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1384, 761);
            this.Controls.Add(this.btnGonder);
            this.Controls.Add(this.txtMesaj);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbHizmet);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtAdSoyad);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTeklifBaslik);
            this.Controls.Add(this.pnlArkaPlan);
            this.Name = "frmTeklifAl";
            this.Text = "Teklif Al";
            this.Load += new System.EventHandler(this.frmTeklifAl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTeklifBaslik;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAdSoyad;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbHizmet;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMesaj;
        private System.Windows.Forms.Button btnGonder;
        private System.Windows.Forms.Panel pnlArkaPlan;
    }
}