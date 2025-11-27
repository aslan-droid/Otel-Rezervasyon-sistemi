using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace OtelRezervasyonSistemi
{
    public partial class MainForm : Form
    {
        private List<Otel> oteller;
        private List<Oda> secilenOdalar;
        private Rezervasyon rezervasyon;

        public MainForm()
        {
            InitializeComponent();
            otelleriYukle();
        }

        private void otelleriYukle()
        {
            oteller = new List<Otel>
            {
                new Otel { Sehir = "Antalya", Bolge = "Belek", Isim = "Rixos Otel,", Odalar = new List<Oda>
                    {
                        new Oda { Isim = "Oda 1", Ucret = 100, Bos = true },
                        new Oda { Isim = "Oda 2", Ucret = 200, Bos = true },
                        new Oda { Isim = "Oda 3", Ucret = 300, Bos = true },
                        new Oda { Isim = "Oda 4", Ucret = 400, Bos = true },
                        new Oda { Isim = "Oda 5", Ucret = 500, Bos = true }
                    }
                },
                new Otel { Sehir = "Antalya", Bolge = "Lara", Isim = "Lara Beach Otel", Odalar = new List<Oda>
                    {
                        new Oda { Isim = "Oda 1", Ucret = 150, Bos = true },
                        new Oda { Isim = "Oda 2", Ucret = 250, Bos = true },
                        new Oda { Isim = "Oda 3", Ucret = 350, Bos = true },
                        new Oda { Isim = "Oda 4", Ucret = 450, Bos = true },
                        new Oda { Isim = "Oda 5", Ucret = 550, Bos = true }
                    }
                },
                new Otel { Sehir = "Antalya", Bolge = "Kemer", Isim = "Vois Kemer Otel", Odalar = new List<Oda>
                    {
                        new Oda { Isim = "Oda 1", Ucret = 120, Bos = true },
                        new Oda { Isim = "Oda 2", Ucret = 220, Bos = true },
                        new Oda { Isim = "Oda 3", Ucret = 320, Bos = true },
                        new Oda { Isim = "Oda 4", Ucret = 420, Bos = true },
                        new Oda { Isim = "Oda 5", Ucret = 520, Bos = true }
                    }
                },
                new Otel { Sehir = "Istanbul", Bolge = "Sultanahmet", Isim = "Hotel Vera" , Odalar = new List<Oda>
                    {
                        new Oda { Isim = "Oda 1", Ucret = 250, Bos = true },
                        new Oda { Isim = "Oda 2", Ucret = 350, Bos = true },
                        new Oda { Isim = "Oda 3", Ucret = 450, Bos = true },
                        new Oda { Isim = "Oda 4", Ucret = 550, Bos = true },
                        new Oda { Isim = "Oda 5", Ucret = 650, Bos = true }
                    }
                },
                new Otel { Sehir = "Istanbul", Bolge = "Kadıköy", Isim = "Kanarya Suit Otel", Odalar = new List<Oda>
                    {
                        new Oda { Isim = "Oda 1", Ucret = 220, Bos = true },
                        new Oda { Isim = "Oda 2", Ucret = 320, Bos = true },
                        new Oda { Isim = "Oda 3", Ucret = 420, Bos = true },
                        new Oda { Isim = "Oda 4", Ucret = 520, Bos = true },
                        new Oda { Isim = "Oda 5", Ucret = 620, Bos = true }
                    }
                },
                 new Otel { Sehir = "Istanbul", Bolge = "Avcılar", Isim = "Green palmiye Otel", Odalar = new List<Oda>
                    {
                        new Oda { Isim = "Oda 1", Ucret = 1000, Bos = true },
                        new Oda { Isim = "Oda 2", Ucret = 3200, Bos = true },
                        new Oda { Isim = "Oda 3", Ucret = 4200, Bos = true },
                        new Oda { Isim = "Oda 4", Ucret = 5200, Bos = true },
                        new Oda { Isim = "Oda 5", Ucret = 6200, Bos = true }
                    }
                },
                 new Otel { Sehir = "Gaziantep", Bolge = "Şehitkamil", Isim = "Shimall Otel", Odalar = new List<Oda>
                    {
                        new Oda { Isim = "Oda 1", Ucret = 1500, Bos = true },
                        new Oda { Isim = "Oda 2", Ucret = 3250, Bos = true },
                        new Oda { Isim = "Oda 3", Ucret = 4250, Bos = true },
                        new Oda { Isim = "Oda 4", Ucret = 5500, Bos = true },
                        new Oda { Isim = "Oda 5", Ucret = 6000, Bos = true }
                    }
                },
                 new Otel { Sehir = "Gaziantep", Bolge = "Şehitkamil", Isim = "Divan Otel", Odalar = new List<Oda>
                    {
                        new Oda { Isim = "Oda 1", Ucret = 2000, Bos = true },
                        new Oda { Isim = "Oda 2", Ucret = 3550, Bos = true },
                        new Oda { Isim = "Oda 3", Ucret = 4350, Bos = true },
                        new Oda { Isim = "Oda 4", Ucret = 5500, Bos = true },
                        new Oda { Isim = "Oda 5", Ucret = 8000, Bos = true }
                    }
                },
            };

            cmbSehir.Items.AddRange(oteller.Select(o => o.Sehir).Distinct().ToArray());
        }

        private void cmbSehir_SelectedIndexChanged(object sender, EventArgs e)
        {
            string secilenSehir = cmbSehir.SelectedItem.ToString();
            cmbBolge.Items.Clear();
            cmbBolge.Items.AddRange(oteller.Where(o => o.Sehir == secilenSehir).Select(o => o.Bolge).Distinct().ToArray());
        }

        private void cmbBolge_SelectedIndexChanged(object sender, EventArgs e)
        {
            string secilenBolge = cmbBolge.SelectedItem.ToString();
            cmbOtel.Items.Clear();
            cmbOtel.Items.AddRange(oteller.Where(o => o.Bolge == secilenBolge).Select(o => o.Isim).ToArray());
        }

        private void cmbOtel_SelectedIndexChanged(object sender, EventArgs e)
        {
            string secilenOtel = cmbOtel.SelectedItem.ToString();
            var otel = oteller.First(o => o.Isim == secilenOtel);
            var bosOdalar = otel.Odalar.Where(o => o.Bos).ToList();
            if (bosOdalar.Count < 3)
            {
                MessageBox.Show("Bu otelde en az 3 boş oda mevcut değil.");
                return;
            }

            secilenOdalar = bosOdalar.Take(3).ToList();
            lstOdalar.Items.Clear();
            foreach (var oda in secilenOdalar)
            {
                lstOdalar.Items.Add($"{oda.Isim} - {oda.Ucret} TL");
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (lstOdalar.SelectedIndex == -1)
            {
                MessageBox.Show("Lütfen bir oda seçin.");
                return;
            }

            rezervasyon = new Rezervasyon
            {
                TcKimlikNo = txtTcKimlikNo.Text,
                Isim = txtIsim.Text,
                Soyisim = txtSoyisim.Text,
                GirisTarihi = dtpGirisTarihi.Value,
                CikisTarihi = dtpCikisTarihi.Value,
                OdaIsmi = secilenOdalar[lstOdalar.SelectedIndex].Isim,
                Ucret = secilenOdalar[lstOdalar.SelectedIndex].Ucret
            };
            


            PaymentForm paymentForm = new PaymentForm(rezervasyon);
            paymentForm.ShowDialog();
        }

        private void btnSorgulama_Click(object sender, EventArgs e)
        {
            InquiryForm inquiryForm = new InquiryForm();
            inquiryForm.ShowDialog();
        }
    }

    public class Otel
    {
        public string Sehir { get; set; }
        public string Bolge { get; set; }
        public string Isim { get; set; }
        public List<Oda> Odalar { get; set; }
    }

    public class Oda
    {
        public string Isim { get; set; }
        public decimal Ucret { get; set; }
        public bool Bos { get; set; }
    }

    public class Rezervasyon
    {
        public string TcKimlikNo { get; set; }
        public string Isim { get; set; }
        public string Soyisim { get; set; }
        public DateTime GirisTarihi { get; set; }
        public DateTime CikisTarihi { get; set; }
        public string OdaIsmi { get; set; }
        public decimal Ucret { get; set; }
        public string KrediKartiNo { get; set; }

        public override string ToString()
        {
            return $"{TcKimlikNo},{Isim},{Soyisim},{GirisTarihi},{CikisTarihi},{OdaIsmi},{Ucret},{KrediKartiNo}";
        }

        public static Rezervasyon Parse(string line)
        {
            var parts = line.Split(',');
            return new Rezervasyon
            {
                TcKimlikNo = parts[0],
                Isim = parts[1],
                Soyisim = parts[2],
                GirisTarihi = DateTime.Parse(parts[3]),
                CikisTarihi = DateTime.Parse(parts[4]),
                OdaIsmi = parts[5],
                Ucret = decimal.Parse(parts[6]),
                KrediKartiNo = parts[7]
            };
        }
    }
}