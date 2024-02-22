namespace WindowsFormsApp1
{
    partial class SifreUnuttum
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
            this.components = new System.ComponentModel.Container();
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.guvenlik = new System.Windows.Forms.ComboBox();
            this.kullaniciadi = new Guna.UI2.WinForms.Guna2TextBox();
            this.cevap = new Guna.UI2.WinForms.Guna2TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.yeni1 = new Guna.UI2.WinForms.Guna2TextBox();
            this.kayitButonu = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.yeni2 = new Guna.UI2.WinForms.Guna2TextBox();
            this.mesaj = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.BorderRadius = 30;
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(12, 98);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(94, 25);
            this.label8.TabIndex = 42;
            this.label8.Text = "Cevap : ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(12, 59);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(184, 25);
            this.label7.TabIndex = 41;
            this.label7.Text = "Güvenlik Sorusu :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(12, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(212, 25);
            this.label2.TabIndex = 43;
            this.label2.Text = "Kullanıcı Adı Giriniz :";
            // 
            // guvenlik
            // 
            this.guvenlik.BackColor = System.Drawing.Color.LightGray;
            this.guvenlik.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.guvenlik.FormattingEnabled = true;
            this.guvenlik.Items.AddRange(new object[] {
            "İlk Hayvanınız Nedir",
            "Çocukluk Lakabın",
            "Doğduğun Şehir",
            "Annenin İkinci Adı",
            "Babanın İkinci Adı",
            "İlk Okul Numaran "});
            this.guvenlik.Location = new System.Drawing.Point(232, 59);
            this.guvenlik.Name = "guvenlik";
            this.guvenlik.Size = new System.Drawing.Size(230, 33);
            this.guvenlik.TabIndex = 44;
            this.guvenlik.Text = "--Seçiniz--";
            // 
            // kullaniciadi
            // 
            this.kullaniciadi.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.kullaniciadi.DefaultText = "";
            this.kullaniciadi.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.kullaniciadi.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.kullaniciadi.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.kullaniciadi.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.kullaniciadi.FillColor = System.Drawing.Color.LightGray;
            this.kullaniciadi.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.kullaniciadi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.kullaniciadi.ForeColor = System.Drawing.Color.Black;
            this.kullaniciadi.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.kullaniciadi.Location = new System.Drawing.Point(232, 16);
            this.kullaniciadi.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.kullaniciadi.Name = "kullaniciadi";
            this.kullaniciadi.PasswordChar = '\0';
            this.kullaniciadi.PlaceholderText = "";
            this.kullaniciadi.SelectedText = "";
            this.kullaniciadi.Size = new System.Drawing.Size(230, 36);
            this.kullaniciadi.TabIndex = 45;
            // 
            // cevap
            // 
            this.cevap.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.cevap.DefaultText = "";
            this.cevap.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.cevap.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.cevap.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.cevap.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.cevap.FillColor = System.Drawing.Color.LightGray;
            this.cevap.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cevap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.cevap.ForeColor = System.Drawing.Color.Black;
            this.cevap.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cevap.Location = new System.Drawing.Point(232, 98);
            this.cevap.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cevap.Name = "cevap";
            this.cevap.PasswordChar = '\0';
            this.cevap.PlaceholderText = "";
            this.cevap.SelectedText = "";
            this.cevap.Size = new System.Drawing.Size(230, 36);
            this.cevap.TabIndex = 46;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(9, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(186, 25);
            this.label4.TabIndex = 47;
            this.label4.Text = "Yeni Şifre Giriniz :";
            // 
            // yeni1
            // 
            this.yeni1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.yeni1.DefaultText = "";
            this.yeni1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.yeni1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.yeni1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.yeni1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.yeni1.FillColor = System.Drawing.Color.LightGray;
            this.yeni1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.yeni1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.yeni1.ForeColor = System.Drawing.Color.Black;
            this.yeni1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.yeni1.Location = new System.Drawing.Point(232, 142);
            this.yeni1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.yeni1.Name = "yeni1";
            this.yeni1.PasswordChar = '\0';
            this.yeni1.PlaceholderText = "";
            this.yeni1.SelectedText = "";
            this.yeni1.Size = new System.Drawing.Size(230, 36);
            this.yeni1.TabIndex = 48;
            // 
            // kayitButonu
            // 
            this.kayitButonu.BorderRadius = 20;
            this.kayitButonu.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.kayitButonu.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.kayitButonu.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.kayitButonu.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.kayitButonu.FillColor = System.Drawing.Color.Gray;
            this.kayitButonu.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.kayitButonu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.kayitButonu.Location = new System.Drawing.Point(232, 259);
            this.kayitButonu.Name = "kayitButonu";
            this.kayitButonu.Size = new System.Drawing.Size(210, 56);
            this.kayitButonu.TabIndex = 49;
            this.kayitButonu.Text = "Şifremi Değiştir";
            this.kayitButonu.Click += new System.EventHandler(this.kayitButonu_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(9, 186);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 25);
            this.label1.TabIndex = 50;
            this.label1.Text = "Yeni Şifre Tekrar : ";
            // 
            // yeni2
            // 
            this.yeni2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.yeni2.DefaultText = "";
            this.yeni2.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.yeni2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.yeni2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.yeni2.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.yeni2.FillColor = System.Drawing.Color.LightGray;
            this.yeni2.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.yeni2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.yeni2.ForeColor = System.Drawing.Color.Black;
            this.yeni2.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.yeni2.Location = new System.Drawing.Point(232, 186);
            this.yeni2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.yeni2.Name = "yeni2";
            this.yeni2.PasswordChar = '\0';
            this.yeni2.PlaceholderText = "";
            this.yeni2.SelectedText = "";
            this.yeni2.Size = new System.Drawing.Size(230, 36);
            this.yeni2.TabIndex = 51;
            // 
            // mesaj
            // 
            this.mesaj.AutoSize = true;
            this.mesaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.mesaj.Location = new System.Drawing.Point(12, 235);
            this.mesaj.Name = "mesaj";
            this.mesaj.Size = new System.Drawing.Size(0, 25);
            this.mesaj.TabIndex = 52;
            // 
            // SifreUnuttum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(509, 329);
            this.ControlBox = false;
            this.Controls.Add(this.mesaj);
            this.Controls.Add(this.yeni2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.kayitButonu);
            this.Controls.Add(this.yeni1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cevap);
            this.Controls.Add(this.kullaniciadi);
            this.Controls.Add(this.guvenlik);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SifreUnuttum";
            this.ShowIcon = false;
            this.Load += new System.EventHandler(this.SifreUnuttum_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox guvenlik;
        private Guna.UI2.WinForms.Guna2TextBox kullaniciadi;
        private Guna.UI2.WinForms.Guna2TextBox cevap;
        private Guna.UI2.WinForms.Guna2TextBox yeni1;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2Button kayitButonu;
        private Guna.UI2.WinForms.Guna2TextBox yeni2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label mesaj;
    }
}