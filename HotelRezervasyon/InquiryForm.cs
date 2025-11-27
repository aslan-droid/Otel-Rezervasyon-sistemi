using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace OtelRezervasyonSistemi
{
    public partial class InquiryForm : Form
    {
        private string dosyaYolu = "C:\\Users\\aslan\\OneDrive\\Masaüstü\\HotelRezervasyon.txt";

        public InquiryForm()
        {
            InitializeComponent();
        }

        private void btnSorgula_Click(object sender, EventArgs e)
        {
            string tcKimlikNo = txtTcKimlikNo.Text;
            var rezervasyonlar = File.ReadAllLines(dosyaYolu)
                .Select(line => Rezervasyon.Parse(line))
                .Where(r => r.TcKimlikNo == tcKimlikNo)
                .ToList();

            lstRezervasyonlar.Items.Clear();
            foreach (var rezervasyon in rezervasyonlar)
            {
                lstRezervasyonlar.Items.Add(rezervasyon);
            }
        }
    }
}