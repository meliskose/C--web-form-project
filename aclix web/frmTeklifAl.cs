using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aclix_web
{
    // ---------------------------------------------------------------
    // TEKLİF AL FORMU
    // Kullanıcının ad-soyad, e-posta, hizmet seçimi ve mesaj bilgilerini
    // girerek teklif talebi gönderdiği ikinci form ekranıdır.
    // ---------------------------------------------------------------
    public partial class frmTeklifAl : Form
    {
        public frmTeklifAl()
        {
            // Form bileşenlerini başlat
            InitializeComponent();

            // Arka plan panelinin köşelerini yuvarlatıyoruz (estetik görünüm için)
            YuvarlatPanel(pnlArkaPlan, 25);
        }

        // ---------------------------------------------------------------
        // PANEL YUVARLAMA METODU
        // Verilen Panel kontrolünün köşelerini belirtilen yarıçap değerine
        // göre yuvarlatır. GraphicsPath ile köşe yayları çizilir ve
        // panelin Region'ı bu yola göre ayarlanır.
        // ---------------------------------------------------------------
        private void YuvarlatPanel(Panel panel, int radius)
        {
            GraphicsPath path = new GraphicsPath();

            path.StartFigure();
            path.AddArc(0, 0, radius, radius, 180, 90);                                     // Sol üst köşe
            path.AddArc(panel.Width - radius, 0, radius, radius, 270, 90);                  // Sağ üst köşe
            path.AddArc(panel.Width - radius, panel.Height - radius, radius, radius, 0, 90); // Sağ alt köşe
            path.AddArc(0, panel.Height - radius, radius, radius, 90, 90);                  // Sol alt köşe
            path.CloseFigure();

            // Panelin görünür bölgesini yuvarlak şekle göre ayarla
            panel.Region = new Region(path);
        }

        // ---------------------------------------------------------------
        // GÖNDER BUTONU
        // Kullanıcı formu doldurduktan sonra "Gönder" butonuna tıkladığında:
        // 1. Başarılı gönderim mesajı gösterilir.
        // 2. Tüm form alanları temizlenir.
        // ---------------------------------------------------------------
        private void btnGonder_Click(object sender, EventArgs e)
        {
            // Kullanıcıya bilgilendirme mesajı göster
            MessageBox.Show(
                "Teklif talebiniz başarıyla gönderildi.",
                "Başarılı",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            // Gönderim sonrası tüm form alanlarını temizle
            txtAdSoyad.Clear();          // Ad-soyad alanını temizle
            txtEmail.Clear();            // E-posta alanını temizle
            txtMesaj.Clear();            // Mesaj alanını temizle
            cmbHizmet.SelectedIndex = -1; // Hizmet seçimini sıfırla
        }

        // --- Aşağıdaki event handler'lar Designer tarafından bağlanmış, içleri boştur ---
        private void label1_Click(object sender, EventArgs e) { }
        private void label3_Click(object sender, EventArgs e) { }
        private void frmTeklifAl_Load(object sender, EventArgs e) { }
        private void txtAdSoyad_TextChanged(object sender, EventArgs e) { }
        private void txtAdSoyad_TextChanged_1(object sender, EventArgs e) { }
        private void txtEmail_TextChanged(object sender, EventArgs e) { }
        private void cmbHizmet_SelectedIndexChanged(object sender, EventArgs e) { }
        private void pnlArkaPlan_Paint(object sender, PaintEventArgs e) { }
    }
}
