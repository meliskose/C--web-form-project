using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace aclix_web
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            // Form bileşenlerini başlat (Designer tarafından oluşturulmuş kontroller yüklenir)
            InitializeComponent();

            // Tasarım modunda bazı kodlar hata verebilir, bu yüzden çalışma zamanı kontrolü yapıyoruz
            if (LicenseManager.UsageMode != LicenseUsageMode.Designtime)
            {
                BaslangicAyarlari();
            }
        }

        // ---------------------------------------------------------------
        // BAŞLANGIÇ AYARLARI
        // Uygulama ilk açıldığında çalışır.
        // Panellerin köşelerini yuvarlatır, açılır menüleri ana forma bağlar
        // ve tüm menüleri kapalı konuma getirir.
        // ---------------------------------------------------------------
        private void BaslangicAyarlari()
        {
            // Belirtilen panellerin köşelerini yuvarlatıyoruz (estetik görünüm için)
            YuvarlatPanel(pnlBulutKart, 30);
            YuvarlatPanel(pnlHizmetlerMenu, 20);
            YuvarlatPanel(pnlKurumsalMenu, 20);
            YuvarlatPanel(pnlMusterilerMenu, 20);
            YuvarlatPanel(pnlIletisimMenu, 20);

            // Açılır menü panellerini doğrudan ana forma ekliyoruz.
            // Böylece paneller diğer kontrollerin üzerinde görünebiliyor.
            this.Controls.Add(pnlHizmetlerMenu);
            this.Controls.Add(pnlKurumsalMenu);
            this.Controls.Add(pnlMusterilerMenu);
            this.Controls.Add(pnlIletisimMenu);

            // Uygulama açılırken tüm açılır menüler kapalı olsun
            TumMenuleriKapat();

            // Detay paneli de başlangıçta gizli olsun
            pnlBulutDetay.Visible = false;
        }

        // ---------------------------------------------------------------
        // PANEL YUVARLAMA METODU
        // Verilen Panel kontrolünün köşelerini belirtilen yarıçap değerine
        // göre yuvarlatır. GraphicsPath ile köşe yayları çizilir ve
        // panelin Region'ı bu yola göre ayarlanır.
        // ---------------------------------------------------------------
        private void YuvarlatPanel(Panel panel, int radius)
        {
            // Yuvarlak köşeli şekil için grafik yolu oluşturuluyor
            GraphicsPath path = new GraphicsPath();

            path.StartFigure();
            path.AddArc(0, 0, radius, radius, 180, 90);                                    // Sol üst köşe
            path.AddArc(panel.Width - radius, 0, radius, radius, 270, 90);                 // Sağ üst köşe
            path.AddArc(panel.Width - radius, panel.Height - radius, radius, radius, 0, 90); // Sağ alt köşe
            path.AddArc(0, panel.Height - radius, radius, radius, 90, 90);                 // Sol alt köşe
            path.CloseFigure();

            // Panelin görünür bölgesini yuvarlak şekle göre ayarlıyoruz
            panel.Region = new Region(path);
        }

        // ---------------------------------------------------------------
        // TÜM MENÜLERİ KAPAT
        // Açık olan tüm açılır menü panellerini gizler ve
        // menü butonlarının arka plan renklerini varsayılana döndürür.
        // ---------------------------------------------------------------
        private void TumMenuleriKapat()
        {
            // Tüm açılır menü panellerini gizle
            pnlHizmetlerMenu.Visible = false;
            pnlKurumsalMenu.Visible = false;
            pnlMusterilerMenu.Visible = false;
            pnlIletisimMenu.Visible = false;

            // Tüm menü butonlarının rengini varsayılana döndür
            btnHizmetlerimiz.BackColor = Color.AliceBlue;
            btnKurumsalMenu.BackColor = Color.AliceBlue;
            btnMusterilerimiz.BackColor = Color.AliceBlue;
            btnIletisim.BackColor = Color.AliceBlue;
        }

        // ---------------------------------------------------------------
        // MENÜ AÇ
        // Belirtilen menü panelini tıklanan butonun hemen altında açar.
        // Önce diğer tüm menüler kapatılır, ardından ilgili panel
        // butonun konumuna göre yerleştirilip görünür yapılır.
        // ---------------------------------------------------------------
        private void MenuyuAc(Panel menuPaneli, Button aktifButon)
        {
            // Diğer açık menüleri kapat
            TumMenuleriKapat();

            // Menü açılırken detay paneli varsa gizle (üst üste binmesin)
            pnlBulutDetay.Visible = false;
            pnlHero.BringToFront();

            // Tıklanan butonun ekran üzerindeki konumunu bul, forma göre hesapla
            Point btnKonum = aktifButon.PointToScreen(Point.Empty);
            Point formKonum = this.PointToClient(btnKonum);

            // Menü panelini butonun hemen altına konumlandır
            menuPaneli.Location = new Point(
                formKonum.X,
                formKonum.Y + aktifButon.Height + 16
            );

            // Paneli görünür yap ve diğer kontrollerin önüne getir
            menuPaneli.Visible = true;
            menuPaneli.BringToFront();

            // Aktif butonun arka plan rengini vurgulu hale getir
            aktifButon.BackColor = Color.FromArgb(220, 235, 245);
        }

        // ---------------------------------------------------------------
        // HİZMETLERİMİZ MENÜSÜ BUTONU
        // Menü zaten açıksa kapatır, kapalıysa açar (toggle davranışı).
        // ---------------------------------------------------------------
        private void btnHizmetlerimiz_Click(object sender, EventArgs e)
        {
            if (pnlHizmetlerMenu.Visible)
            {
                TumMenuleriKapat(); // Menü açıksa kapat
                return;
            }
            MenuyuAc(pnlHizmetlerMenu, btnHizmetlerimiz); // Menü kapalıysa aç
        }

        // ---------------------------------------------------------------
        // KURUMSAL MENÜSÜ BUTONU
        // ---------------------------------------------------------------
        private void btnKurumsal_Click(object sender, EventArgs e)
        {
            if (pnlKurumsalMenu.Visible)
            {
                TumMenuleriKapat();
                return;
            }
            MenuyuAc(pnlKurumsalMenu, btnKurumsalMenu);
        }

        // ---------------------------------------------------------------
        // MÜŞTERİLERİMİZ MENÜSÜ BUTONU
        // ---------------------------------------------------------------
        private void btnMusterilerimiz_Click(object sender, EventArgs e)
        {
            if (pnlMusterilerMenu.Visible)
            {
                TumMenuleriKapat();
                return;
            }
            MenuyuAc(pnlMusterilerMenu, btnMusterilerimiz);
        }

        // ---------------------------------------------------------------
        // İLETİŞİM MENÜSÜ BUTONU
        // ---------------------------------------------------------------
        private void btnIletisim_Click(object sender, EventArgs e)
        {
            if (pnlIletisimMenu.Visible)
            {
                TumMenuleriKapat();
                return;
            }
            MenuyuAc(pnlIletisimMenu, btnIletisim);
        }

        // ---------------------------------------------------------------
        // DETAYLAR LİNKİ
        // Ana sayfadaki "Detaylar" linkine tıklandığında detay paneli açılır.
        // ---------------------------------------------------------------
        private void lnkDetaylar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            TumMenuleriKapat();           // Açık menü varsa kapat
            pnlBulutDetay.Visible = true; // Detay panelini göster
            pnlBulutDetay.BringToFront(); // Öne getir
        }

        // ---------------------------------------------------------------
        // GERİ LİNKİ
        // Detay panelindeki "Geri" linkine tıklandığında ana sayfa gösterilir.
        // ---------------------------------------------------------------
        private void lnkGeri_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            TumMenuleriKapat();            // Açık menü varsa kapat
            pnlBulutDetay.Visible = false; // Detay panelini gizle
            pnlHero.BringToFront();        // Ana içerik alanını öne getir
        }

        // İkinci geri linki de aynı işlemi yapar
        private void lnkGeri_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            lnkGeri_LinkClicked(sender, e);
        }

        // ---------------------------------------------------------------
        // TEKLİF AL BUTONU
        // Tıklandığında teklif formu yeni bir pencere olarak açılır.
        // ---------------------------------------------------------------
        private void button1_Click(object sender, EventArgs e)
        {
            frmTeklifAl frm = new frmTeklifAl(); // Teklif formu nesnesi oluştur
            frm.Show();                           // Formu göster
        }

        // Hizmetlerimiz etiketine tıklandığında menü butonu ile aynı işlevi çalıştırır
        private void lblHizmetlerimiz_Click(object sender, EventArgs e)
        {
            btnHizmetlerimiz_Click(sender, e);
        }

        // --- Aşağıdaki event handler'lar Designer tarafından bağlanmış, içleri boştur ---
        private void Form1_Load(object sender, EventArgs e) { }
        private void ustPanel_Paint(object sender, PaintEventArgs e) { }
        private void menuPanel_Paint(object sender, PaintEventArgs e) { }
        private void menuPanel_Paint_1(object sender, PaintEventArgs e) { }
        private void pnlHero_Paint(object sender, PaintEventArgs e) { }
        private void pnlBulutDetay_Paint(object sender, PaintEventArgs e) { }
        private void pnlHizmetlerMenu_Paint(object sender, PaintEventArgs e) { }
        private void btnTeklifAl_Click(object sender, EventArgs e) { }
        private void lblUrunler_Click(object sender, EventArgs e) { }
        private void lblMusterilerimiz_Click(object sender, EventArgs e) { }
        private void lblBaslik_Click(object sender, EventArgs e) { }
        private void lblNelerSunuyoruz_Click(object sender, EventArgs e) { }
        private void lblnelerSuny_Click(object sender, EventArgs e) { }
        private void lblHizmetlerListesi_Click(object sender, EventArgs e) { }
        private void lblOtomasyon_Click(object sender, EventArgs e) { }
        private void label1_Click(object sender, EventArgs e) { }
        private void label2_Click(object sender, EventArgs e) { }
        private void label2_Click_1(object sender, EventArgs e) { }
        private void label2_Click_2(object sender, EventArgs e) { }
        private void label3_Click(object sender, EventArgs e) { }
        private void label3_Click_1(object sender, EventArgs e) { }
        private void label3_Click_2(object sender, EventArgs e) { }
        private void pictureBox1_Click(object sender, EventArgs e) { }
        private void pictureBox4_Click(object sender, EventArgs e) { }
        private void kart1_Paint(object sender, PaintEventArgs e) { }
        private void kart2_Paint(object sender, PaintEventArgs e) { }
        private void kart3_Paint(object sender, PaintEventArgs e) { }
        private void kart4_Paint(object sender, PaintEventArgs e) { }
        private void kart5_Paint(object sender, PaintEventArgs e) { }
        private void kart6_Paint(object sender, PaintEventArgs e) { }
    }
}
