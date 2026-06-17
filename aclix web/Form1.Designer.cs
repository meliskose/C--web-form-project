namespace aclix_web
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ustPanel = new System.Windows.Forms.Panel();
            this.pnlIletisimMenu = new System.Windows.Forms.Panel();
            this.lblIletisimBaslik = new System.Windows.Forms.Label();
            this.sekil2 = new System.Windows.Forms.PictureBox();
            this.sekil1 = new System.Windows.Forms.PictureBox();
            this.logoKutusu = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.menuPanel = new System.Windows.Forms.Panel();
            this.btnIletisim = new System.Windows.Forms.Button();
            this.btnMusterilerimiz = new System.Windows.Forms.Button();
            this.btnKurumsalMenu = new System.Windows.Forms.Button();
            this.btnHizmetlerimiz = new System.Windows.Forms.Button();
            this.searchPix = new System.Windows.Forms.PictureBox();
            this.personPix = new System.Windows.Forms.PictureBox();
            this.navPix = new System.Windows.Forms.PictureBox();
            this.btnTeklifAl = new System.Windows.Forms.Button();
            this.pnlHero = new System.Windows.Forms.Panel();
            this.pnlBulutDetay = new System.Windows.Forms.Panel();
            this.pnlHizmetlerMenu = new System.Windows.Forms.Panel();
            this.lblHizmetlerimiz = new System.Windows.Forms.Label();
            this.pnlKurumsalMenu = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlMusterilerMenu = new System.Windows.Forms.Panel();
            this.lblMusterilerListe = new System.Windows.Forms.Label();
            this.lblAciklama = new System.Windows.Forms.Label();
            this.lblnelerSuny = new System.Windows.Forms.Label();
            this.lblNelerSunuyoruz = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblDetayAciklama = new System.Windows.Forms.Label();
            this.lnkGeri = new System.Windows.Forms.LinkLabel();
            this.lblBulutDetayBaslik = new System.Windows.Forms.Label();
            this.pnlBulutKart = new System.Windows.Forms.Panel();
            this.lnkDetaylar = new System.Windows.Forms.LinkLabel();
            this.lblBulutAciklama = new System.Windows.Forms.Label();
            this.lblBulutBaslik = new System.Windows.Forms.Label();
            this.picBulut = new System.Windows.Forms.PictureBox();
            this.lblBaslik = new System.Windows.Forms.Label();
            this.ustPanel.SuspendLayout();
            this.pnlIletisimMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sekil2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sekil1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoKutusu)).BeginInit();
            this.menuPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchPix)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personPix)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.navPix)).BeginInit();
            this.pnlHero.SuspendLayout();
            this.pnlBulutDetay.SuspendLayout();
            this.pnlHizmetlerMenu.SuspendLayout();
            this.pnlKurumsalMenu.SuspendLayout();
            this.pnlMusterilerMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlBulutKart.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBulut)).BeginInit();
            this.SuspendLayout();
            // 
            // ustPanel
            // 
            this.ustPanel.Controls.Add(this.pnlIletisimMenu);
            this.ustPanel.Controls.Add(this.sekil2);
            this.ustPanel.Controls.Add(this.sekil1);
            this.ustPanel.Controls.Add(this.logoKutusu);
            this.ustPanel.Controls.Add(this.label1);
            this.ustPanel.Location = new System.Drawing.Point(0, 30);
            this.ustPanel.Name = "ustPanel";
            this.ustPanel.Size = new System.Drawing.Size(1383, 170);
            this.ustPanel.TabIndex = 0;
            this.ustPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.ustPanel_Paint);
            // 
            // pnlIletisimMenu
            // 
            this.pnlIletisimMenu.BackColor = System.Drawing.Color.AliceBlue;
            this.pnlIletisimMenu.Controls.Add(this.lblIletisimBaslik);
            this.pnlIletisimMenu.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.pnlIletisimMenu.Location = new System.Drawing.Point(898, 37);
            this.pnlIletisimMenu.Name = "pnlIletisimMenu";
            this.pnlIletisimMenu.Size = new System.Drawing.Size(321, 433);
            this.pnlIletisimMenu.TabIndex = 15;
            this.pnlIletisimMenu.Visible = false;
            // 
            // lblIletisimBaslik
            // 
            this.lblIletisimBaslik.AutoSize = true;
            this.lblIletisimBaslik.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.lblIletisimBaslik.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(113)))), ((int)(((byte)(150)))));
            this.lblIletisimBaslik.Location = new System.Drawing.Point(6, 3);
            this.lblIletisimBaslik.Name = "lblIletisimBaslik";
            this.lblIletisimBaslik.Size = new System.Drawing.Size(278, 399);
            this.lblIletisimBaslik.TabIndex = 0;
            this.lblIletisimBaslik.Text = resources.GetString("lblIletisimBaslik.Text");
            this.lblIletisimBaslik.Click += new System.EventHandler(this.label3_Click_2);
            // 
            // sekil2
            // 
            this.sekil2.BackColor = System.Drawing.Color.Transparent;
            this.sekil2.Image = ((System.Drawing.Image)(resources.GetObject("sekil2.Image")));
            this.sekil2.Location = new System.Drawing.Point(1093, 37);
            this.sekil2.Name = "sekil2";
            this.sekil2.Size = new System.Drawing.Size(151, 98);
            this.sekil2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.sekil2.TabIndex = 3;
            this.sekil2.TabStop = false;
            // 
            // sekil1
            // 
            this.sekil1.BackColor = System.Drawing.Color.Transparent;
            this.sekil1.Image = ((System.Drawing.Image)(resources.GetObject("sekil1.Image")));
            this.sekil1.Location = new System.Drawing.Point(356, 37);
            this.sekil1.Name = "sekil1";
            this.sekil1.Size = new System.Drawing.Size(151, 98);
            this.sekil1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.sekil1.TabIndex = 2;
            this.sekil1.TabStop = false;
            // 
            // logoKutusu
            // 
            this.logoKutusu.Image = ((System.Drawing.Image)(resources.GetObject("logoKutusu.Image")));
            this.logoKutusu.Location = new System.Drawing.Point(49, 14);
            this.logoKutusu.Name = "logoKutusu";
            this.logoKutusu.Size = new System.Drawing.Size(232, 131);
            this.logoKutusu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logoKutusu.TabIndex = 2;
            this.logoKutusu.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 30F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(113)))), ((int)(((byte)(148)))));
            this.label1.Location = new System.Drawing.Point(497, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(612, 98);
            this.label1.TabIndex = 2;
            this.label1.Text = "KODLUYORUZ, GELİŞTİRİYORUZ,\nGELECEĞİ BİRLİKTE YAZIYORUZ.";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // menuPanel
            // 
            this.menuPanel.BackColor = System.Drawing.Color.AliceBlue;
            this.menuPanel.Controls.Add(this.btnIletisim);
            this.menuPanel.Controls.Add(this.btnMusterilerimiz);
            this.menuPanel.Controls.Add(this.btnKurumsalMenu);
            this.menuPanel.Controls.Add(this.btnHizmetlerimiz);
            this.menuPanel.Controls.Add(this.searchPix);
            this.menuPanel.Controls.Add(this.personPix);
            this.menuPanel.Controls.Add(this.navPix);
            this.menuPanel.Controls.Add(this.btnTeklifAl);
            this.menuPanel.Location = new System.Drawing.Point(0, 195);
            this.menuPanel.Name = "menuPanel";
            this.menuPanel.Size = new System.Drawing.Size(1400, 71);
            this.menuPanel.TabIndex = 1;
            this.menuPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.menuPanel_Paint_1);
            // 
            // btnIletisim
            // 
            this.btnIletisim.FlatAppearance.BorderSize = 0;
            this.btnIletisim.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIletisim.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnIletisim.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(113)))), ((int)(((byte)(148)))));
            this.btnIletisim.Location = new System.Drawing.Point(871, 18);
            this.btnIletisim.Name = "btnIletisim";
            this.btnIletisim.Size = new System.Drawing.Size(140, 37);
            this.btnIletisim.TabIndex = 9;
            this.btnIletisim.Text = "İLETİŞİM ▼";
            this.btnIletisim.UseVisualStyleBackColor = true;
            this.btnIletisim.Click += new System.EventHandler(this.btnIletisim_Click);
            // 
            // btnMusterilerimiz
            // 
            this.btnMusterilerimiz.FlatAppearance.BorderSize = 0;
            this.btnMusterilerimiz.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMusterilerimiz.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMusterilerimiz.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(113)))), ((int)(((byte)(148)))));
            this.btnMusterilerimiz.Location = new System.Drawing.Point(699, 19);
            this.btnMusterilerimiz.Name = "btnMusterilerimiz";
            this.btnMusterilerimiz.Size = new System.Drawing.Size(173, 37);
            this.btnMusterilerimiz.TabIndex = 8;
            this.btnMusterilerimiz.Text = "MÜŞTERİLERİMİZ ▼";
            this.btnMusterilerimiz.UseVisualStyleBackColor = true;
            this.btnMusterilerimiz.Click += new System.EventHandler(this.btnMusterilerimiz_Click);
            // 
            // btnKurumsalMenu
            // 
            this.btnKurumsalMenu.FlatAppearance.BorderSize = 0;
            this.btnKurumsalMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKurumsalMenu.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKurumsalMenu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(113)))), ((int)(((byte)(148)))));
            this.btnKurumsalMenu.Location = new System.Drawing.Point(553, 18);
            this.btnKurumsalMenu.Name = "btnKurumsalMenu";
            this.btnKurumsalMenu.Size = new System.Drawing.Size(140, 37);
            this.btnKurumsalMenu.TabIndex = 7;
            this.btnKurumsalMenu.Text = "KURUMSAL ▼";
            this.btnKurumsalMenu.UseVisualStyleBackColor = true;
            this.btnKurumsalMenu.Click += new System.EventHandler(this.btnKurumsal_Click);
            // 
            // btnHizmetlerimiz
            // 
            this.btnHizmetlerimiz.FlatAppearance.BorderSize = 0;
            this.btnHizmetlerimiz.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHizmetlerimiz.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnHizmetlerimiz.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(113)))), ((int)(((byte)(148)))));
            this.btnHizmetlerimiz.Location = new System.Drawing.Point(407, 18);
            this.btnHizmetlerimiz.Name = "btnHizmetlerimiz";
            this.btnHizmetlerimiz.Size = new System.Drawing.Size(154, 38);
            this.btnHizmetlerimiz.TabIndex = 6;
            this.btnHizmetlerimiz.Text = "HİZMETLERİMİZ ▼";
            this.btnHizmetlerimiz.UseVisualStyleBackColor = true;
            this.btnHizmetlerimiz.Click += new System.EventHandler(this.btnHizmetlerimiz_Click);
            // 
            // searchPix
            // 
            this.searchPix.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.searchPix.Image = ((System.Drawing.Image)(resources.GetObject("searchPix.Image")));
            this.searchPix.Location = new System.Drawing.Point(1050, 11);
            this.searchPix.Name = "searchPix";
            this.searchPix.Size = new System.Drawing.Size(33, 45);
            this.searchPix.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.searchPix.TabIndex = 3;
            this.searchPix.TabStop = false;
            // 
            // personPix
            // 
            this.personPix.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.personPix.Image = ((System.Drawing.Image)(resources.GetObject("personPix.Image")));
            this.personPix.Location = new System.Drawing.Point(1254, 11);
            this.personPix.Name = "personPix";
            this.personPix.Size = new System.Drawing.Size(57, 45);
            this.personPix.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.personPix.TabIndex = 4;
            this.personPix.TabStop = false;
            // 
            // navPix
            // 
            this.navPix.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.navPix.Image = ((System.Drawing.Image)(resources.GetObject("navPix.Image")));
            this.navPix.Location = new System.Drawing.Point(1317, 11);
            this.navPix.Name = "navPix";
            this.navPix.Size = new System.Drawing.Size(48, 45);
            this.navPix.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.navPix.TabIndex = 5;
            this.navPix.TabStop = false;
            this.navPix.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // btnTeklifAl
            // 
            this.btnTeklifAl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(113)))), ((int)(((byte)(148)))));
            this.btnTeklifAl.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTeklifAl.ForeColor = System.Drawing.Color.White;
            this.btnTeklifAl.Location = new System.Drawing.Point(78, 21);
            this.btnTeklifAl.Name = "btnTeklifAl";
            this.btnTeklifAl.Size = new System.Drawing.Size(130, 35);
            this.btnTeklifAl.TabIndex = 0;
            this.btnTeklifAl.Text = "TEKLİF AL!";
            this.btnTeklifAl.UseVisualStyleBackColor = false;
            this.btnTeklifAl.Click += new System.EventHandler(this.button1_Click);
            // 
            // pnlHero
            // 
            this.pnlHero.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(113)))), ((int)(((byte)(148)))));
            this.pnlHero.Controls.Add(this.pnlBulutDetay);
            this.pnlHero.Controls.Add(this.pnlBulutKart);
            this.pnlHero.Controls.Add(this.lblBaslik);
            this.pnlHero.Location = new System.Drawing.Point(0, 264);
            this.pnlHero.Name = "pnlHero";
            this.pnlHero.Size = new System.Drawing.Size(1397, 520);
            this.pnlHero.TabIndex = 2;
            // 
            // pnlBulutDetay
            // 
            this.pnlBulutDetay.BackColor = System.Drawing.Color.White;
            this.pnlBulutDetay.Controls.Add(this.pnlHizmetlerMenu);
            this.pnlBulutDetay.Controls.Add(this.lblAciklama);
            this.pnlBulutDetay.Controls.Add(this.lblnelerSuny);
            this.pnlBulutDetay.Controls.Add(this.lblNelerSunuyoruz);
            this.pnlBulutDetay.Controls.Add(this.pictureBox1);
            this.pnlBulutDetay.Controls.Add(this.lblDetayAciklama);
            this.pnlBulutDetay.Controls.Add(this.lnkGeri);
            this.pnlBulutDetay.Controls.Add(this.lblBulutDetayBaslik);
            this.pnlBulutDetay.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.pnlBulutDetay.Location = new System.Drawing.Point(0, 3);
            this.pnlBulutDetay.Name = "pnlBulutDetay";
            this.pnlBulutDetay.Size = new System.Drawing.Size(1383, 514);
            this.pnlBulutDetay.TabIndex = 4;
            this.pnlBulutDetay.Visible = false;
            this.pnlBulutDetay.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlBulutDetay_Paint);
            // 
            // pnlHizmetlerMenu
            // 
            this.pnlHizmetlerMenu.BackColor = System.Drawing.Color.AliceBlue;
            this.pnlHizmetlerMenu.Controls.Add(this.lblHizmetlerimiz);
            this.pnlHizmetlerMenu.Controls.Add(this.pnlKurumsalMenu);
            this.pnlHizmetlerMenu.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.pnlHizmetlerMenu.Location = new System.Drawing.Point(431, 55);
            this.pnlHizmetlerMenu.Name = "pnlHizmetlerMenu";
            this.pnlHizmetlerMenu.Size = new System.Drawing.Size(275, 261);
            this.pnlHizmetlerMenu.TabIndex = 12;
            this.pnlHizmetlerMenu.Visible = false;
            this.pnlHizmetlerMenu.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlHizmetlerMenu_Paint);
            // 
            // lblHizmetlerimiz
            // 
            this.lblHizmetlerimiz.AutoSize = true;
            this.lblHizmetlerimiz.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.lblHizmetlerimiz.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(113)))), ((int)(((byte)(150)))));
            this.lblHizmetlerimiz.Location = new System.Drawing.Point(3, 6);
            this.lblHizmetlerimiz.Name = "lblHizmetlerimiz";
            this.lblHizmetlerimiz.Size = new System.Drawing.Size(205, 231);
            this.lblHizmetlerimiz.TabIndex = 0;
            this.lblHizmetlerimiz.Text = "Bulut Altyapı                    →\r\n\r\nWeb Yazılım                     →\r\n\r\nMobil " +
    "Uygulama             →\r\n\r\nSiber Güvenlik                 →\r\n\r\nKurumsal Otomasyon" +
    "   →\r\n\r\nTeknik Destek                 →";
            this.lblHizmetlerimiz.Click += new System.EventHandler(this.label2_Click_2);
            // 
            // pnlKurumsalMenu
            // 
            this.pnlKurumsalMenu.BackColor = System.Drawing.Color.AliceBlue;
            this.pnlKurumsalMenu.Controls.Add(this.label2);
            this.pnlKurumsalMenu.Controls.Add(this.pnlMusterilerMenu);
            this.pnlKurumsalMenu.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.pnlKurumsalMenu.Location = new System.Drawing.Point(0, 137);
            this.pnlKurumsalMenu.Name = "pnlKurumsalMenu";
            this.pnlKurumsalMenu.Size = new System.Drawing.Size(275, 261);
            this.pnlKurumsalMenu.TabIndex = 13;
            this.pnlKurumsalMenu.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(113)))), ((int)(((byte)(150)))));
            this.label2.Location = new System.Drawing.Point(3, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(188, 252);
            this.label2.TabIndex = 0;
            this.label2.Text = "Hakkımızda                 →\r\n\r\nMisyonumuz                →\r\n\r\nVizyonumuz        " +
    "         →\r\n\r\nEkibimiz                        →\r\n\r\nReferanslarımız            →\r" +
    "\n\r\nKariyer Fırsatları          →\r\n\r\n";
            // 
            // pnlMusterilerMenu
            // 
            this.pnlMusterilerMenu.BackColor = System.Drawing.Color.AliceBlue;
            this.pnlMusterilerMenu.Controls.Add(this.lblMusterilerListe);
            this.pnlMusterilerMenu.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.pnlMusterilerMenu.Location = new System.Drawing.Point(0, 64);
            this.pnlMusterilerMenu.Name = "pnlMusterilerMenu";
            this.pnlMusterilerMenu.Size = new System.Drawing.Size(275, 261);
            this.pnlMusterilerMenu.TabIndex = 14;
            this.pnlMusterilerMenu.Visible = false;
            // 
            // lblMusterilerListe
            // 
            this.lblMusterilerListe.AutoSize = true;
            this.lblMusterilerListe.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.lblMusterilerListe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(113)))), ((int)(((byte)(150)))));
            this.lblMusterilerListe.Location = new System.Drawing.Point(3, 9);
            this.lblMusterilerListe.Name = "lblMusterilerListe";
            this.lblMusterilerListe.Size = new System.Drawing.Size(206, 252);
            this.lblMusterilerListe.TabIndex = 0;
            this.lblMusterilerListe.Text = resources.GetString("lblMusterilerListe.Text");
            this.lblMusterilerListe.Click += new System.EventHandler(this.label3_Click_1);
            // 
            // lblAciklama
            // 
            this.lblAciklama.AutoSize = true;
            this.lblAciklama.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.lblAciklama.Location = new System.Drawing.Point(735, 415);
            this.lblAciklama.Name = "lblAciklama";
            this.lblAciklama.Size = new System.Drawing.Size(490, 38);
            this.lblAciklama.TabIndex = 11;
            this.lblAciklama.Text = "Bulut teknolojileri sayesinde işletmenizin tüm verilerini güvenle yönetin, \r\nsüre" +
    "çlerinizi hızlandırın ve maliyetlerinizi optimize edin.";
            // 
            // lblnelerSuny
            // 
            this.lblnelerSuny.AutoSize = true;
            this.lblnelerSuny.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblnelerSuny.Location = new System.Drawing.Point(12, 98);
            this.lblnelerSuny.Name = "lblnelerSuny";
            this.lblnelerSuny.Size = new System.Drawing.Size(238, 32);
            this.lblnelerSuny.TabIndex = 10;
            this.lblnelerSuny.Text = "Neler Sunuyoruz?";
            this.lblnelerSuny.Click += new System.EventHandler(this.lblnelerSuny_Click);
            // 
            // lblNelerSunuyoruz
            // 
            this.lblNelerSunuyoruz.AutoSize = true;
            this.lblNelerSunuyoruz.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblNelerSunuyoruz.Location = new System.Drawing.Point(14, 143);
            this.lblNelerSunuyoruz.Name = "lblNelerSunuyoruz";
            this.lblNelerSunuyoruz.Size = new System.Drawing.Size(465, 294);
            this.lblNelerSunuyoruz.TabIndex = 9;
            this.lblNelerSunuyoruz.Text = resources.GetString("lblNelerSunuyoruz.Text");
            this.lblNelerSunuyoruz.Click += new System.EventHandler(this.lblNelerSunuyoruz_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(712, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(551, 448);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // lblDetayAciklama
            // 
            this.lblDetayAciklama.AutoSize = true;
            this.lblDetayAciklama.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDetayAciklama.Location = new System.Drawing.Point(14, 56);
            this.lblDetayAciklama.Name = "lblDetayAciklama";
            this.lblDetayAciklama.Size = new System.Drawing.Size(533, 22);
            this.lblDetayAciklama.TabIndex = 7;
            this.lblDetayAciklama.Text = "İşletmeniz için güvenli, hızlı ve ölçeklenebilir bulut sistemleri.";
            this.lblDetayAciklama.Click += new System.EventHandler(this.label2_Click);
            // 
            // lnkGeri
            // 
            this.lnkGeri.ActiveLinkColor = System.Drawing.Color.DarkBlue;
            this.lnkGeri.AutoSize = true;
            this.lnkGeri.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lnkGeri.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(113)))), ((int)(((byte)(148)))));
            this.lnkGeri.Location = new System.Drawing.Point(14, 472);
            this.lnkGeri.Name = "lnkGeri";
            this.lnkGeri.Size = new System.Drawing.Size(59, 20);
            this.lnkGeri.TabIndex = 6;
            this.lnkGeri.TabStop = true;
            this.lnkGeri.Text = "← Geri";
            this.lnkGeri.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkGeri_LinkClicked_1);
            // 
            // lblBulutDetayBaslik
            // 
            this.lblBulutDetayBaslik.AutoSize = true;
            this.lblBulutDetayBaslik.Font = new System.Drawing.Font("Century Gothic", 30F, System.Drawing.FontStyle.Bold);
            this.lblBulutDetayBaslik.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(113)))), ((int)(((byte)(148)))));
            this.lblBulutDetayBaslik.Location = new System.Drawing.Point(8, 5);
            this.lblBulutDetayBaslik.Name = "lblBulutDetayBaslik";
            this.lblBulutDetayBaslik.Size = new System.Drawing.Size(468, 47);
            this.lblBulutDetayBaslik.TabIndex = 5;
            this.lblBulutDetayBaslik.Text = "Bulut Altyapı Çözümleri";
            // 
            // pnlBulutKart
            // 
            this.pnlBulutKart.BackColor = System.Drawing.Color.White;
            this.pnlBulutKart.Controls.Add(this.lnkDetaylar);
            this.pnlBulutKart.Controls.Add(this.lblBulutAciklama);
            this.pnlBulutKart.Controls.Add(this.lblBulutBaslik);
            this.pnlBulutKart.Controls.Add(this.picBulut);
            this.pnlBulutKart.Location = new System.Drawing.Point(871, 40);
            this.pnlBulutKart.Name = "pnlBulutKart";
            this.pnlBulutKart.Size = new System.Drawing.Size(357, 432);
            this.pnlBulutKart.TabIndex = 3;
            // 
            // lnkDetaylar
            // 
            this.lnkDetaylar.ActiveLinkColor = System.Drawing.Color.DarkBlue;
            this.lnkDetaylar.AutoSize = true;
            this.lnkDetaylar.BackColor = System.Drawing.Color.Transparent;
            this.lnkDetaylar.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.lnkDetaylar.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(113)))), ((int)(((byte)(148)))));
            this.lnkDetaylar.Location = new System.Drawing.Point(22, 399);
            this.lnkDetaylar.Name = "lnkDetaylar";
            this.lnkDetaylar.Size = new System.Drawing.Size(90, 20);
            this.lnkDetaylar.TabIndex = 4;
            this.lnkDetaylar.TabStop = true;
            this.lnkDetaylar.Text = "Detaylar →";
            this.lnkDetaylar.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkDetaylar_LinkClicked);
            // 
            // lblBulutAciklama
            // 
            this.lblBulutAciklama.AutoSize = true;
            this.lblBulutAciklama.Font = new System.Drawing.Font("Century Gothic", 9.5F);
            this.lblBulutAciklama.Location = new System.Drawing.Point(22, 365);
            this.lblBulutAciklama.Name = "lblBulutAciklama";
            this.lblBulutAciklama.Size = new System.Drawing.Size(316, 34);
            this.lblBulutAciklama.TabIndex = 3;
            this.lblBulutAciklama.Text = "Güvenli, hızlı ve ölçeklenebilir bulut çözümleriyle\r\niş süreçlerinizi her yerden " +
    "kolayca yönetin.";
            // 
            // lblBulutBaslik
            // 
            this.lblBulutBaslik.AutoSize = true;
            this.lblBulutBaslik.BackColor = System.Drawing.Color.Transparent;
            this.lblBulutBaslik.Font = new System.Drawing.Font("Century Gothic", 19F);
            this.lblBulutBaslik.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(113)))), ((int)(((byte)(148)))));
            this.lblBulutBaslik.Location = new System.Drawing.Point(21, 262);
            this.lblBulutBaslik.Name = "lblBulutBaslik";
            this.lblBulutBaslik.Size = new System.Drawing.Size(310, 96);
            this.lblBulutBaslik.TabIndex = 2;
            this.lblBulutBaslik.Text = "İşinizi Her Yerden\r\nYönetebileceğiniz Bulut\r\nAltyapı A{CLIX}\'TE";
            // 
            // picBulut
            // 
            this.picBulut.BackColor = System.Drawing.Color.Transparent;
            this.picBulut.Image = ((System.Drawing.Image)(resources.GetObject("picBulut.Image")));
            this.picBulut.Location = new System.Drawing.Point(-32, 0);
            this.picBulut.Name = "picBulut";
            this.picBulut.Size = new System.Drawing.Size(424, 245);
            this.picBulut.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBulut.TabIndex = 1;
            this.picBulut.TabStop = false;
            // 
            // lblBaslik
            // 
            this.lblBaslik.AutoSize = true;
            this.lblBaslik.BackColor = System.Drawing.Color.Transparent;
            this.lblBaslik.Font = new System.Drawing.Font("Century Gothic", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBaslik.ForeColor = System.Drawing.Color.White;
            this.lblBaslik.Location = new System.Drawing.Point(115, 81);
            this.lblBaslik.Name = "lblBaslik";
            this.lblBaslik.Size = new System.Drawing.Size(471, 308);
            this.lblBaslik.TabIndex = 1;
            this.lblBaslik.Text = "İster Büyük Bir Şirket Olun,\n\nİster Küçük Bir Girişim\n\nİhtiyaçlarınıza Özel Dijit" +
    "al\n\nÇözümler!";
            this.lblBaslik.Click += new System.EventHandler(this.lblBaslik_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1384, 781);
            this.Controls.Add(this.menuPanel);
            this.Controls.Add(this.pnlHero);
            this.Controls.Add(this.ustPanel);
            this.Name = "Form1";
            this.Tag = "p";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ustPanel.ResumeLayout(false);
            this.ustPanel.PerformLayout();
            this.pnlIletisimMenu.ResumeLayout(false);
            this.pnlIletisimMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sekil2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sekil1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoKutusu)).EndInit();
            this.menuPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.searchPix)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personPix)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.navPix)).EndInit();
            this.pnlHero.ResumeLayout(false);
            this.pnlHero.PerformLayout();
            this.pnlBulutDetay.ResumeLayout(false);
            this.pnlBulutDetay.PerformLayout();
            this.pnlHizmetlerMenu.ResumeLayout(false);
            this.pnlHizmetlerMenu.PerformLayout();
            this.pnlKurumsalMenu.ResumeLayout(false);
            this.pnlKurumsalMenu.PerformLayout();
            this.pnlMusterilerMenu.ResumeLayout(false);
            this.pnlMusterilerMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlBulutKart.ResumeLayout(false);
            this.pnlBulutKart.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBulut)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel ustPanel;
        private System.Windows.Forms.PictureBox logoKutusu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel menuPanel;
        private System.Windows.Forms.Button btnTeklifAl;
        private System.Windows.Forms.PictureBox sekil1;
        private System.Windows.Forms.PictureBox sekil2;
        private System.Windows.Forms.PictureBox searchPix;
        private System.Windows.Forms.PictureBox personPix;
        private System.Windows.Forms.PictureBox navPix;
        private System.Windows.Forms.Panel pnlHero;
        private System.Windows.Forms.Label lblBaslik;
        private System.Windows.Forms.Panel pnlBulutKart;
        private System.Windows.Forms.PictureBox picBulut;
        private System.Windows.Forms.Label lblBulutAciklama;
        private System.Windows.Forms.Label lblBulutBaslik;
        private System.Windows.Forms.Panel pnlBulutDetay;
        private System.Windows.Forms.LinkLabel lnkDetaylar;
        private System.Windows.Forms.Label lblBulutDetayBaslik;
        private System.Windows.Forms.LinkLabel lnkGeri;
        private System.Windows.Forms.Label lblDetayAciklama;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblNelerSunuyoruz;
        private System.Windows.Forms.Label lblnelerSuny;
        private System.Windows.Forms.Label lblAciklama;
        private System.Windows.Forms.Button btnHizmetlerimiz;
        private System.Windows.Forms.Button btnIletisim;
        private System.Windows.Forms.Button btnMusterilerimiz;
        private System.Windows.Forms.Button btnKurumsalMenu;
        private System.Windows.Forms.Panel pnlHizmetlerMenu;
        private System.Windows.Forms.Label lblHizmetlerimiz;
        private System.Windows.Forms.Panel pnlKurumsalMenu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pnlMusterilerMenu;
        private System.Windows.Forms.Label lblMusterilerListe;
        private System.Windows.Forms.Panel pnlIletisimMenu;
        private System.Windows.Forms.Label lblIletisimBaslik;
    }
}

