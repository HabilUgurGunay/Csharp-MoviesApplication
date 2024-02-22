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
    public partial class SifreDegistir : Form
    {

        SqlConnection baglan = new SqlConnection("Data Source=HABILUGUR\\SQLEXPRESS;Initial Catalog=Gorsel-Proje;Integrated Security=True");
        SqlCommand cmd;
        SqlDataReader dr;
        SqlDataReader dr2;
        SqlCommand cmd2;

        public SifreDegistir()
        {
            InitializeComponent();
        }

        private void kayitButonu_Click(object sender, EventArgs e)
        {

            string sorgu = "SELECT * FROM kullanici WHERE kullanici_adi=@kullanici_adi AND k_sifre=@k_sifre";
            string sorgu1 = "UPDATE kullanici SET k_sifre=@k_sifre WHERE kullanici_adi=@kullanici_adi";

            cmd = new SqlCommand(sorgu, baglan);
            cmd2=new SqlCommand(sorgu1, baglan);
            cmd.Parameters.AddWithValue("@kullanici_adi", k_ad.Text);
            cmd.Parameters.AddWithValue("@k_sifre", eskisifre.Text);
            cmd2.Parameters.AddWithValue("@kullanici_adi", k_ad.Text);
            cmd2.Parameters.AddWithValue("@k_sifre", yenisifre2.Text);

            baglan.Open();
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                dr.Close();
                if (yenisifre1.Text==yenisifre2.Text)
                {
                    cmd2.ExecuteNonQuery();
                    mesaj.Text = "Şifre Değiştirme İşlemi Başarılı";
                    Giris giris = new Giris();
                    this.Hide();
                    giris.Show();

                }

                else
                {
                    mesaj.Text = "Lütfen Bilgileri Kontrol Ediniz : ";
                }


            }
            else
            {
                mesaj.Text = "Lütfen Bilgileri Kontrol Ediniz : ";
            }
            baglan.Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Anasayfa anasayfa = new Anasayfa();
            anasayfa.Show();
        }
    }
}
