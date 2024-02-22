using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    public partial class Kayit : Form
    {
        SqlConnection baglan = new SqlConnection("Data Source=HABILUGUR\\SQLEXPRESS;Initial Catalog=Gorsel-Proje;Integrated Security=True");
        SqlCommand cmd;
        SqlDataReader dr;  

        public Kayit()
        {
            InitializeComponent();
        }

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox5_Click(object sender, EventArgs e)
        {
            monthCalendar1.Visible = true;
            secimOnay.Visible = true;
            kayitButonu.Visible = false;
            Cinsiyet_Combobox.Visible = false;
            Guvenlik_Combobox.Visible=false;
            gcevap_textbox.Visible=false;
        }

        private void secimOnay_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            monthCalendar1.Visible=false;
            secimOnay.Visible=false;
            k_dogum_textbox.Text = " ";
            k_dogum_textbox.Text= monthCalendar1.SelectionRange.Start.ToShortDateString();
            k_dogum_textbox.Enabled=false;
            kayitButonu.Visible = true;
            Cinsiyet_Combobox.Visible = true;
            Guvenlik_Combobox.Visible = true;
            gcevap_textbox.Visible = true;
        }

        private void cıkısButon_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void sifreGoster_CheckedChanged(object sender, EventArgs e)
        {
            if(sifreGoster.Checked==true)
            {
                k_kayitsifre_textbox.PasswordChar = '\0';
            }
            else
            {
                k_kayitsifre_textbox.PasswordChar = '*';
            }
           
        }

        private void sifreGoster_Click(object sender, EventArgs e)
        {
           
        }

        private void Kayit_Load(object sender, EventArgs e)
        {

        }

        private void kayitButonu_Click(object sender, EventArgs e)
        {
            while (true)
            {

                if (k_kayitad_textbox.Text == "")
                {
                    MessageBox.Show("Lütfen Adınızı Giriniz");
                        break;
                    
                }

                else if (k_kayitsoyad_textbox.Text == "")
                {
                    MessageBox.Show("Lütfen Soyadınızı Giriniz ");
                        break;
                }

                else if (kullanicikayitadi_textbox.Text == "")
                {
                    MessageBox.Show("Lütfen Kullanıcı Adı Giriniz ");
                        break;
                }

                else if (k_eposta_textbox.Text == "")
                {
                    MessageBox.Show("Lütfen E-Posta Giriniz ");
                        break;
                }

                else if (k_kayitsifre_textbox.Text == "")
                {
                    MessageBox.Show("Lütfen Şifre Giriniz ");
                        break;
                }

                else if (k_dogum_textbox.Text == "")
                {
                    MessageBox.Show("Lütfen Doğum Tarihi Seçiniz ");
                        break;
                }

                else if (Bolge_Combobox.SelectedIndex<0)
                {
                    MessageBox.Show("Lütfen Yaşadığınız Bölgeyi Seçiniz");
                        break;
                }

                else if (Cinsiyet_Combobox.SelectedIndex<0)
                {
                    MessageBox.Show("Lütfen Cinsiyet Seçiniz ");
                        break;
                }

                else if (Guvenlik_Combobox.SelectedIndex<0)
                {
                    MessageBox.Show("Lütfen Güvenlik Sorusu Seçiniz ");
                        break;
                }

                else if (gcevap_textbox.Text == "")
                {
                    MessageBox.Show("Lütfen Güvenlik Sorusunun Cevabını Giriniz ");
                        break;
                }

                else
                {
                    string sorgu = "Insert into kullanici               (k_adi,k_soyadi,kullanici_adi,k_eposta,k_sifre,k_dogum,k_bolge,k_cinsiyet,k_guvenlik,k_gcevap) values (@k_adi,@k_soyadi,@kullanici_adi,@k_eposta,@k_sifre,@k_dogum,@k_bolge,@k_cinsiyet,@k_guvenlik,@k_gcevap)";

                    cmd = new SqlCommand(sorgu, baglan);
                    cmd.Parameters.AddWithValue("@k_adi", k_kayitad_textbox.Text);
                    cmd.Parameters.AddWithValue("@k_soyadi", k_kayitsoyad_textbox.Text);
                    cmd.Parameters.AddWithValue("@kullanici_adi", kullanicikayitadi_textbox.Text);
                    cmd.Parameters.AddWithValue("@k_eposta", k_eposta_textbox.Text);
                    cmd.Parameters.AddWithValue("@k_sifre", k_kayitsifre_textbox.Text);
                    cmd.Parameters.AddWithValue("@k_dogum", k_dogum_textbox.Text);
                    cmd.Parameters.AddWithValue("@k_bolge", Bolge_Combobox.Text);
                    cmd.Parameters.AddWithValue("@k_cinsiyet", Cinsiyet_Combobox.Text);
                    cmd.Parameters.AddWithValue("@k_guvenlik", Guvenlik_Combobox.Text);
                    cmd.Parameters.AddWithValue("@k_gcevap", gcevap_textbox.Text);
                    baglan.Open();
                    cmd.ExecuteNonQuery();
                    baglan.Close();
                    this.Hide();
                    Giris giris = new Giris();
                    giris.Show();
                        break;
                }
            }







        }
    }
}
