namespace OtelRezervasyonSistemi
{
    partial class InquiryForm
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
            this.txtTcKimlikNo = new System.Windows.Forms.TextBox();
            this.lblTcKimlikNo = new System.Windows.Forms.Label();
            this.btnSorgula = new System.Windows.Forms.Button();
            this.lstRezervasyonlar = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // txtTcKimlikNo
            // 
            this.txtTcKimlikNo.Location = new System.Drawing.Point(12, 29);
            this.txtTcKimlikNo.MaxLength = 11;
            this.txtTcKimlikNo.Name = "txtTcKimlikNo";
            this.txtTcKimlikNo.Size = new System.Drawing.Size(260, 22);
            this.txtTcKimlikNo.TabIndex = 0;
            // 
            // lblTcKimlikNo
            // 
            this.lblTcKimlikNo.AutoSize = true;
            this.lblTcKimlikNo.Location = new System.Drawing.Point(12, 9);
            this.lblTcKimlikNo.Name = "lblTcKimlikNo";
            this.lblTcKimlikNo.Size = new System.Drawing.Size(84, 16);
            this.lblTcKimlikNo.TabIndex = 1;
            this.lblTcKimlikNo.Text = "TC Kimlik No";
            // 
            // btnSorgula
            // 
            this.btnSorgula.Location = new System.Drawing.Point(294, 12);
            this.btnSorgula.Name = "btnSorgula";
            this.btnSorgula.Size = new System.Drawing.Size(94, 40);
            this.btnSorgula.TabIndex = 2;
            this.btnSorgula.Text = "Sorgula";
            this.btnSorgula.UseVisualStyleBackColor = true;
            this.btnSorgula.Click += new System.EventHandler(this.btnSorgula_Click);
            // 
            // lstRezervasyonlar
            // 
            this.lstRezervasyonlar.FormattingEnabled = true;
            this.lstRezervasyonlar.ItemHeight = 16;
            this.lstRezervasyonlar.Location = new System.Drawing.Point(15, 122);
            this.lstRezervasyonlar.Name = "lstRezervasyonlar";
            this.lstRezervasyonlar.Size = new System.Drawing.Size(475, 132);
            this.lstRezervasyonlar.TabIndex = 3;
            // 
            // InquiryForm
            // 
            this.ClientSize = new System.Drawing.Size(502, 286);
            this.Controls.Add(this.lstRezervasyonlar);
            this.Controls.Add(this.btnSorgula);
            this.Controls.Add(this.lblTcKimlikNo);
            this.Controls.Add(this.txtTcKimlikNo);
            this.Name = "InquiryForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.TextBox txtTcKimlikNo;
        private System.Windows.Forms.Label lblTcKimlikNo;
        private System.Windows.Forms.Button btnSorgula;
        private System.Windows.Forms.ListBox lstRezervasyonlar;
    }
}