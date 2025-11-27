namespace OtelRezervasyonSistemi
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblSehir = new System.Windows.Forms.Label();
            this.cmbSehir = new System.Windows.Forms.ComboBox();
            this.lblBolge = new System.Windows.Forms.Label();
            this.cmbBolge = new System.Windows.Forms.ComboBox();
            this.lblOtel = new System.Windows.Forms.Label();
            this.cmbOtel = new System.Windows.Forms.ComboBox();
            this.lblGirisTarihi = new System.Windows.Forms.Label();
            this.dtpGirisTarihi = new System.Windows.Forms.DateTimePicker();
            this.lblCikisTarihi = new System.Windows.Forms.Label();
            this.dtpCikisTarihi = new System.Windows.Forms.DateTimePicker();
            this.lblOdalar = new System.Windows.Forms.Label();
            this.lstOdalar = new System.Windows.Forms.ListBox();
            this.lblTcKimlikNo = new System.Windows.Forms.Label();
            this.txtTcKimlikNo = new System.Windows.Forms.TextBox();
            this.lblIsim = new System.Windows.Forms.Label();
            this.txtIsim = new System.Windows.Forms.TextBox();
            this.lblSoyisim = new System.Windows.Forms.Label();
            this.txtSoyisim = new System.Windows.Forms.TextBox();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnSorgulama = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblSehir
            // 
            this.lblSehir.AutoSize = true;
            this.lblSehir.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSehir.Location = new System.Drawing.Point(62, 15);
            this.lblSehir.Name = "lblSehir";
            this.lblSehir.Size = new System.Drawing.Size(47, 19);
            this.lblSehir.TabIndex = 0;
            this.lblSehir.Text = "Şehir:";
            // 
            // cmbSehir
            // 
            this.cmbSehir.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSehir.FormattingEnabled = true;
            this.cmbSehir.Location = new System.Drawing.Point(126, 12);
            this.cmbSehir.Name = "cmbSehir";
            this.cmbSehir.Size = new System.Drawing.Size(200, 24);
            this.cmbSehir.TabIndex = 1;
            this.cmbSehir.SelectedIndexChanged += new System.EventHandler(this.cmbSehir_SelectedIndexChanged);
            // 
            // lblBolge
            // 
            this.lblBolge.AutoSize = true;
            this.lblBolge.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBolge.Location = new System.Drawing.Point(57, 42);
            this.lblBolge.Name = "lblBolge";
            this.lblBolge.Size = new System.Drawing.Size(52, 19);
            this.lblBolge.TabIndex = 2;
            this.lblBolge.Text = "Bölge:";
            // 
            // cmbBolge
            // 
            this.cmbBolge.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBolge.FormattingEnabled = true;
            this.cmbBolge.Location = new System.Drawing.Point(126, 39);
            this.cmbBolge.Name = "cmbBolge";
            this.cmbBolge.Size = new System.Drawing.Size(200, 24);
            this.cmbBolge.TabIndex = 3;
            this.cmbBolge.SelectedIndexChanged += new System.EventHandler(this.cmbBolge_SelectedIndexChanged);
            // 
            // lblOtel
            // 
            this.lblOtel.AutoSize = true;
            this.lblOtel.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblOtel.Location = new System.Drawing.Point(68, 69);
            this.lblOtel.Name = "lblOtel";
            this.lblOtel.Size = new System.Drawing.Size(41, 19);
            this.lblOtel.TabIndex = 4;
            this.lblOtel.Text = "Otel:";
            // 
            // cmbOtel
            // 
            this.cmbOtel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOtel.FormattingEnabled = true;
            this.cmbOtel.Location = new System.Drawing.Point(126, 66);
            this.cmbOtel.Name = "cmbOtel";
            this.cmbOtel.Size = new System.Drawing.Size(200, 24);
            this.cmbOtel.TabIndex = 5;
            this.cmbOtel.SelectedIndexChanged += new System.EventHandler(this.cmbOtel_SelectedIndexChanged);
            // 
            // lblGirisTarihi
            // 
            this.lblGirisTarihi.AutoSize = true;
            this.lblGirisTarihi.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblGirisTarihi.Location = new System.Drawing.Point(377, 22);
            this.lblGirisTarihi.Name = "lblGirisTarihi";
            this.lblGirisTarihi.Size = new System.Drawing.Size(85, 19);
            this.lblGirisTarihi.TabIndex = 6;
            this.lblGirisTarihi.Text = "Giriş Tarihi:";
            // 
            // dtpGirisTarihi
            // 
            this.dtpGirisTarihi.Location = new System.Drawing.Point(465, 19);
            this.dtpGirisTarihi.Name = "dtpGirisTarihi";
            this.dtpGirisTarihi.Size = new System.Drawing.Size(200, 22);
            this.dtpGirisTarihi.TabIndex = 7;
            // 
            // lblCikisTarihi
            // 
            this.lblCikisTarihi.AutoSize = true;
            this.lblCikisTarihi.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCikisTarihi.Location = new System.Drawing.Point(377, 48);
            this.lblCikisTarihi.Name = "lblCikisTarihi";
            this.lblCikisTarihi.Size = new System.Drawing.Size(82, 19);
            this.lblCikisTarihi.TabIndex = 8;
            this.lblCikisTarihi.Text = "Çıkış Tarihi";
            // 
            // dtpCikisTarihi
            // 
            this.dtpCikisTarihi.Location = new System.Drawing.Point(465, 45);
            this.dtpCikisTarihi.Name = "dtpCikisTarihi";
            this.dtpCikisTarihi.Size = new System.Drawing.Size(200, 22);
            this.dtpCikisTarihi.TabIndex = 9;
            // 
            // lblOdalar
            // 
            this.lblOdalar.AutoSize = true;
            this.lblOdalar.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblOdalar.Location = new System.Drawing.Point(324, 117);
            this.lblOdalar.Name = "lblOdalar";
            this.lblOdalar.Size = new System.Drawing.Size(67, 24);
            this.lblOdalar.TabIndex = 10;
            this.lblOdalar.Text = "Odalar";
            // 
            // lstOdalar
            // 
            this.lstOdalar.FormattingEnabled = true;
            this.lstOdalar.ItemHeight = 16;
            this.lstOdalar.Location = new System.Drawing.Point(412, 114);
            this.lstOdalar.Name = "lstOdalar";
            this.lstOdalar.Size = new System.Drawing.Size(249, 84);
            this.lstOdalar.TabIndex = 11;
            // 
            // lblTcKimlikNo
            // 
            this.lblTcKimlikNo.AutoSize = true;
            this.lblTcKimlikNo.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTcKimlikNo.Location = new System.Drawing.Point(13, 208);
            this.lblTcKimlikNo.Name = "lblTcKimlikNo";
            this.lblTcKimlikNo.Size = new System.Drawing.Size(100, 19);
            this.lblTcKimlikNo.TabIndex = 12;
            this.lblTcKimlikNo.Text = "TC Kimlik No:";
            // 
            // txtTcKimlikNo
            // 
            this.txtTcKimlikNo.Location = new System.Drawing.Point(131, 203);
            this.txtTcKimlikNo.MaxLength = 11;
            this.txtTcKimlikNo.Name = "txtTcKimlikNo";
            this.txtTcKimlikNo.Size = new System.Drawing.Size(200, 22);
            this.txtTcKimlikNo.TabIndex = 13;
            // 
            // lblIsim
            // 
            this.lblIsim.AutoSize = true;
            this.lblIsim.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIsim.Location = new System.Drawing.Point(73, 234);
            this.lblIsim.Name = "lblIsim";
            this.lblIsim.Size = new System.Drawing.Size(40, 19);
            this.lblIsim.TabIndex = 14;
            this.lblIsim.Text = "İsim:";
            // 
            // txtIsim
            // 
            this.txtIsim.Location = new System.Drawing.Point(131, 228);
            this.txtIsim.Name = "txtIsim";
            this.txtIsim.Size = new System.Drawing.Size(200, 22);
            this.txtIsim.TabIndex = 15;
            // 
            // lblSoyisim
            // 
            this.lblSoyisim.AutoSize = true;
            this.lblSoyisim.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSoyisim.Location = new System.Drawing.Point(49, 260);
            this.lblSoyisim.Name = "lblSoyisim";
            this.lblSoyisim.Size = new System.Drawing.Size(64, 19);
            this.lblSoyisim.TabIndex = 16;
            this.lblSoyisim.Text = "Soyisim:";
            // 
            // txtSoyisim
            // 
            this.txtSoyisim.Location = new System.Drawing.Point(131, 254);
            this.txtSoyisim.Name = "txtSoyisim";
            this.txtSoyisim.Size = new System.Drawing.Size(200, 22);
            this.txtSoyisim.TabIndex = 17;
            // 
            // btnKaydet
            // 
            this.btnKaydet.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKaydet.Location = new System.Drawing.Point(370, 239);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(78, 37);
            this.btnKaydet.TabIndex = 18;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnSorgulama
            // 
            this.btnSorgulama.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnSorgulama.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSorgulama.Location = new System.Drawing.Point(499, 239);
            this.btnSorgulama.Name = "btnSorgulama";
            this.btnSorgulama.Size = new System.Drawing.Size(105, 37);
            this.btnSorgulama.TabIndex = 19;
            this.btnSorgulama.Text = "Sorgulama";
            this.btnSorgulama.UseVisualStyleBackColor = false;
            this.btnSorgulama.Click += new System.EventHandler(this.btnSorgulama_Click);
            // 
            // MainForm
            // 
            this.ClientSize = new System.Drawing.Size(708, 390);
            this.Controls.Add(this.btnSorgulama);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.txtSoyisim);
            this.Controls.Add(this.lblSoyisim);
            this.Controls.Add(this.txtIsim);
            this.Controls.Add(this.lblIsim);
            this.Controls.Add(this.txtTcKimlikNo);
            this.Controls.Add(this.lblTcKimlikNo);
            this.Controls.Add(this.lstOdalar);
            this.Controls.Add(this.lblOdalar);
            this.Controls.Add(this.dtpCikisTarihi);
            this.Controls.Add(this.lblCikisTarihi);
            this.Controls.Add(this.dtpGirisTarihi);
            this.Controls.Add(this.lblGirisTarihi);
            this.Controls.Add(this.cmbOtel);
            this.Controls.Add(this.lblOtel);
            this.Controls.Add(this.cmbBolge);
            this.Controls.Add(this.lblBolge);
            this.Controls.Add(this.cmbSehir);
            this.Controls.Add(this.lblSehir);
            this.Name = "MainForm";
            this.Text = "Otel Rezervasyon Sistemi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label lblSehir;
        private System.Windows.Forms.ComboBox cmbSehir;
        private System.Windows.Forms.Label lblBolge;
        private System.Windows.Forms.ComboBox cmbBolge;
        private System.Windows.Forms.Label lblOtel;
        private System.Windows.Forms.ComboBox cmbOtel;
        private System.Windows.Forms.Label lblGirisTarihi;
        private System.Windows.Forms.DateTimePicker dtpGirisTarihi;
        private System.Windows.Forms.Label lblCikisTarihi;
        private System.Windows.Forms.DateTimePicker dtpCikisTarihi;
        private System.Windows.Forms.Label lblOdalar;
        private System.Windows.Forms.ListBox lstOdalar;
        private System.Windows.Forms.Label lblTcKimlikNo;
        private System.Windows.Forms.TextBox txtTcKimlikNo;
        private System.Windows.Forms.Label lblIsim;
        private System.Windows.Forms.TextBox txtIsim;
        private System.Windows.Forms.Label lblSoyisim;
        private System.Windows.Forms.TextBox txtSoyisim;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnSorgulama;
    }
}