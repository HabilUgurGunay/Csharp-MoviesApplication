using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Giris : Form
    {

        string k_Ad;
        string k_id;
        string ad;


        SqlConnection baglan = new SqlConnection("Data Source=HABILUGUR\\SQLEXPRESS;Initial Catalog=Gorsel-Proje;Integrated Security=True");
        SqlCommand cmd;
        SqlDataReader dr;
        public Giris()
        {
            InitializeComponent();
        }

        private void cıkısButon_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void kayitButonu_Click(object sender, EventArgs e)
        {
            this.Hide();
            Kayit kayit = new Kayit();
            kayit.Show();
        }

        private void sifreunutButonu_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            SifreUnuttum sifreUnuttum = new SifreUnuttum();
            sifreUnuttum.Show();
        }

        private void guna2ToggleSwitch1_CheckedChanged(object sender, EventArgs e)
        {
            if (guna2ToggleSwitch1.Checked==true)
            {
                k_sifre_textbox.PasswordChar = '\0';
            }
            else
            {
                k_sifre_textbox.PasswordChar = '*';
            }
        }

        private void girisButon_Click(object sender, EventArgs e)
        {
            String k_ad = k_ad_textbox.Text;
            string k_sifre = k_sifre_textbox.Text;
            string sorgu = "SELECT * FROM kullanici where kullanici_adi=@kullanici_adi AND k_sifre=@k_sifre";
            cmd = new SqlCommand(sorgu, baglan);
            cmd.Parameters.AddWithValue("@kullanici_adi", k_ad_textbox.Text);
            cmd.Parameters.AddWithValue("@k_sifre", k_sifre_textbox.Text);
            baglan.Open();
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                label6.Text=dr.GetValue(11).ToString();

                if (label6.Text == "1")
                {
                    k_Ad = dr.GetValue(1).ToString() + " " + dr.GetValue(2).ToString();
                    k_id=dr.GetValue(0).ToString();
                    ad=dr.GetValue(1).ToString();
                    this.Hide();
                    AdminAnasayfa adminAnasayfa = new AdminAnasayfa();
                    Anasayfa anasayfa = new Anasayfa();
                    anasayfa.k = k_Ad;
                    anasayfa.id= k_id;
                    anasayfa.isim = ad;
                    adminAnasayfa.k = k_Ad;
                    adminAnasayfa.isimm= ad;
                    adminAnasayfa.idd = k_id;
                    adminAnasayfa.Show();
                }

                else
                {
                    k_Ad = dr.GetValue(1).ToString() + " " + dr.GetValue(2).ToString();
                    k_id = dr.GetValue(0).ToString();
                    ad = dr.GetValue(1).ToString();
                    this.Hide();
                    Anasayfa anasayfa = new Anasayfa();
                    anasayfa.id = k_id;
                    anasayfa.k = k_Ad;
                    anasayfa.isim= ad;
                    anasayfa.Show();

                }

            }
            else
            {
                label5.Text = "Kullanici adi ya da Şifre hatalıdır!";
            }
            baglan.Close();
        }

        private void Giris_Load(object sender, EventArgs e)
        {

        }
    }
}
