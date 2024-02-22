namespace WindowsFormsApp1
{
    partial class Giris
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
            this.cıkısButon = new Guna.UI2.WinForms.Guna2Button();
            this.sifreunutButonu = new System.Windows.Forms.LinkLabel();
            this.k_sifre_textbox = new Guna.UI2.WinForms.Guna2TextBox();
            this.k_ad_textbox = new Guna.UI2.WinForms.Guna2TextBox();
            this.kayitButonu = new Guna.UI2.WinForms.Guna2Button();
            this.girisButon = new Guna.UI2.WinForms.Guna2Button();
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.guna2ToggleSwitch1 = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cıkısButon
            // 
            this.cıkısButon.BorderRadius = 20;
            this.cıkısButon.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.cıkısButon.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.cıkısButon.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.cıkısButon.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.cıkısButon.FillColor = System.Drawing.Color.Gray;
            this.cıkısButon.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.cıkısButon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.cıkısButon.Location = new System.Drawing.Point(484, 315);
            this.cıkısButon.Name = "cıkısButon";
            this.cıkısButon.Size = new System.Drawing.Size(156, 39);
            this.cıkısButon.TabIndex = 17;
            this.cıkısButon.Text = "Çıkış";
            this.cıkısButon.Click += new System.EventHandler(this.cıkısButon_Click);
            // 
            // sifreunutButonu
            // 
            this.sifreunutButonu.AutoSize = true;
            this.sifreunutButonu.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sifreunutButonu.LinkColor = System.Drawing.Color.Black;
            this.sifreunutButonu.Location = new System.Drawing.Point(374, 139);
            this.sifreunutButonu.Name = "sifreunutButonu";
            this.sifreunutButonu.Size = new System.Drawing.Size(152, 21);
            this.sifreunutButonu.TabIndex = 16;
            this.sifreunutButonu.TabStop = true;
            this.sifreunutButonu.Text = "Şifremi Unuttum";
            this.sifreunutButonu.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.sifreunutButonu_LinkClicked);
            // 
            // k_sifre_textbox
            // 
            this.k_sifre_textbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.k_sifre_textbox.DefaultText = "";
            this.k_sifre_textbox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.k_sifre_textbox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.k_sifre_textbox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.k_sifre_textbox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.k_sifre_textbox.FillColor = System.Drawing.Color.LightGray;
            this.k_sifre_textbox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.k_sifre_textbox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.k_sifre_textbox.ForeColor = System.Drawing.Color.Black;
            this.k_sifre_textbox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.k_sifre_textbox.Location = new System.Drawing.Point(297, 76);
            this.k_sifre_textbox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.k_sifre_textbox.Name = "k_sifre_textbox";
            this.k_sifre_textbox.PasswordChar = '*';
            this.k_sifre_textbox.PlaceholderText = "";
            this.k_sifre_textbox.SelectedText = "";
            this.k_sifre_textbox.Size = new System.Drawing.Size(229, 48);
            this.k_sifre_textbox.TabIndex = 12;
            // 
            // k_ad_textbox
            // 
            this.k_ad_textbox.BackColor = System.Drawing.Color.Teal;
            this.k_ad_textbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.k_ad_textbox.DefaultText = "";
            this.k_ad_textbox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.k_ad_textbox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.k_ad_textbox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.k_ad_textbox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.k_ad_textbox.FillColor = System.Drawing.Color.LightGray;
            this.k_ad_textbox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.k_ad_textbox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.k_ad_textbox.ForeColor = System.Drawing.Color.Black;
            this.k_ad_textbox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.k_ad_textbox.Location = new System.Drawing.Point(297, 20);
            this.k_ad_textbox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.k_ad_textbox.Name = "k_ad_textbox";
            this.k_ad_textbox.PasswordChar = '\0';
            this.k_ad_textbox.PlaceholderText = "";
            this.k_ad_textbox.SelectedText = "";
            this.k_ad_textbox.Size = new System.Drawing.Size(229, 48);
            this.k_ad_textbox.TabIndex = 11;
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
            this.kayitButonu.Location = new System.Drawing.Point(262, 264);
            this.kayitButonu.Name = "kayitButonu";
            this.kayitButonu.Size = new System.Drawing.Size(140, 34);
            this.kayitButonu.TabIndex = 10;
            this.kayitButonu.Text = "Kayıt Ol";
            this.kayitButonu.Click += new System.EventHandler(this.kayitButonu_Click);
            // 
            // girisButon
            // 
            this.girisButon.BorderRadius = 20;
            this.girisButon.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.girisButon.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.girisButon.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.girisButon.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.girisButon.FillColor = System.Drawing.Color.Gray;
            this.girisButon.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Bold);
            this.girisButon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.girisButon.Location = new System.Drawing.Point(297, 175);
            this.girisButon.Name = "girisButon";
            this.girisButon.Size = new System.Drawing.Size(229, 49);
            this.girisButon.TabIndex = 9;
            this.girisButon.Text = "Giriş Yap";
            this.girisButon.Click += new System.EventHandler(this.girisButon_Click);
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.BorderRadius = 30;
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(7, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(269, 29);
            this.label3.TabIndex = 27;
            this.label3.Text = "Kullanıcı Adı Giriniz :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(7, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 29);
            this.label1.TabIndex = 28;
            this.label1.Text = "Şifre Giriniz : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(8, 278);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(215, 20);
            this.label2.TabIndex = 29;
            this.label2.Text = "Hala Hesabınız Yok Mu?";
            // 
            // guna2ToggleSwitch1
            // 
            this.guna2ToggleSwitch1.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ToggleSwitch1.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ToggleSwitch1.CheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.guna2ToggleSwitch1.CheckedState.InnerColor = System.Drawing.Color.White;
            this.guna2ToggleSwitch1.Location = new System.Drawing.Point(532, 104);
            this.guna2ToggleSwitch1.Name = "guna2ToggleSwitch1";
            this.guna2ToggleSwitch1.Size = new System.Drawing.Size(35, 20);
            this.guna2ToggleSwitch1.TabIndex = 30;
            this.guna2ToggleSwitch1.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2ToggleSwitch1.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2ToggleSwitch1.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.guna2ToggleSwitch1.UncheckedState.InnerColor = System.Drawing.Color.White;
            this.guna2ToggleSwitch1.CheckedChanged += new System.EventHandler(this.guna2ToggleSwitch1_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(528, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 20);
            this.label4.TabIndex = 31;
            this.label4.Text = "Şifreyi Göster";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(12, 154);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 17);
            this.label5.TabIndex = 32;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(40, 478);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 16);
            this.label6.TabIndex = 33;
            this.label6.Text = "label6";
            // 
            // Giris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(674, 371);
            this.ControlBox = false;
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.guna2ToggleSwitch1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cıkısButon);
            this.Controls.Add(this.sifreunutButonu);
            this.Controls.Add(this.k_sifre_textbox);
            this.Controls.Add(this.k_ad_textbox);
            this.Controls.Add(this.kayitButonu);
            this.Controls.Add(this.girisButon);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Giris";
            this.ShowIcon = false;
            this.Text = "Giris";
            this.Load += new System.EventHandler(this.Giris_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button cıkısButon;
        private System.Windows.Forms.LinkLabel sifreunutButonu;
        private Guna.UI2.WinForms.Guna2TextBox k_sifre_textbox;
        private Guna.UI2.WinForms.Guna2TextBox k_ad_textbox;
        private Guna.UI2.WinForms.Guna2Button kayitButonu;
        private Guna.UI2.WinForms.Guna2Button girisButon;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2ToggleSwitch guna2ToggleSwitch1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}