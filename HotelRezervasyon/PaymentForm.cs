using System;
using System.IO;
using System.Windows.Forms;

namespace OtelRezervasyonSistemi
{
    public partial class PaymentForm : Form
    {
        private Rezervasyon rezervasyon;
        private string dosyaYolu = "C:\\Users\\aslan\\OneDrive\\Masaüstü\\HotelRezervasyon.txt";

        public PaymentForm(Rezervasyon rezervasyon)
        {
            InitializeComponent();
            this.rezervasyon = rezervasyon;
        }

        private void btnTamamla_Click(object sender, EventArgs e)
        {
            rezervasyon.KrediKartiNo = txtKrediKartiNo.Text;

            File.AppendAllText(dosyaYolu, rezervasyon.ToString() + Environment.NewLine);
            MessageBox.Show("Ödeme tamamlandı ve rezervasyon kaydedildi.");
            this.Close();
        }
    }
}
