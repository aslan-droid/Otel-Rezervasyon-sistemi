namespace OtelRezervasyonSistemi
{
    partial class PaymentForm
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
            this.txtKrediKartiNo = new System.Windows.Forms.TextBox();
            this.lblKrediKartiNo = new System.Windows.Forms.Label();
            this.btnTamamla = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtKrediKartiNo
            // 
            this.txtKrediKartiNo.Location = new System.Drawing.Point(12, 29);
            this.txtKrediKartiNo.MaxLength = 16;
            this.txtKrediKartiNo.Name = "txtKrediKartiNo";
            this.txtKrediKartiNo.Size = new System.Drawing.Size(260, 25);
            this.txtKrediKartiNo.TabIndex = 0;
            // 
            // lblKrediKartiNo
            // 
            this.lblKrediKartiNo.AutoSize = true;
            this.lblKrediKartiNo.Location = new System.Drawing.Point(12, 9);
            this.lblKrediKartiNo.Name = "lblKrediKartiNo";
            this.lblKrediKartiNo.Size = new System.Drawing.Size(105, 19);
            this.lblKrediKartiNo.TabIndex = 1;
            this.lblKrediKartiNo.Text = "Kredi Kartı No";
            // 
            // btnTamamla
            // 
            this.btnTamamla.Location = new System.Drawing.Point(105, 72);
            this.btnTamamla.Name = "btnTamamla";
            this.btnTamamla.Size = new System.Drawing.Size(75, 23);
            this.btnTamamla.TabIndex = 2;
            this.btnTamamla.Text = "Tamamla";
            this.btnTamamla.UseVisualStyleBackColor = true;
            this.btnTamamla.Click += new System.EventHandler(this.btnTamamla_Click);
            // 
            // PaymentForm
            // 
            this.ClientSize = new System.Drawing.Size(318, 135);
            this.Controls.Add(this.btnTamamla);
            this.Controls.Add(this.lblKrediKartiNo);
            this.Controls.Add(this.txtKrediKartiNo);
            this.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Name = "PaymentForm";
            this.Text = "ÖDEME BİLGİLERİ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.TextBox txtKrediKartiNo;
        private System.Windows.Forms.Label lblKrediKartiNo;
        private System.Windows.Forms.Button btnTamamla;
    }
}