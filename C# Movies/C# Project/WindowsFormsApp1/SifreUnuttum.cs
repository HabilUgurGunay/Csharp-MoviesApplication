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
    public partial class SifreUnuttum : Form
    {
        SqlConnection baglan = new SqlConnection("Data Source=HABILUGUR\\SQLEXPRESS;Initial Catalog=Gorsel-Proje;Integrated Security=True");
        SqlCommand cmd;
        SqlDataReader dr;
        SqlCommand cmd2;

        public SifreUnuttum()
        {
            InitializeComponent();
        }

        private void kayitButonu_Click(object sender, EventArgs e)
        {
            string k_ad=kullaniciadi.Text;
            string g_soru = guvenlik.Text;
            string g_cevap = cevap.Text;
            string sifre1 = yeni1.Text;
            string sifre2=yeni2.Text;

            string sorgu = "SELECT * FROM kullanici where kullanici_adi=@kullanici_adi and k_guvenlik=@k_guvenlik and k_gcevap=@k_gcevap";
            string sorgu2 = "UPDATE kullanici SET k_sifre = @k_sifre WHERE kullanici_adi=@kullanici_adi";
            cmd = new SqlCommand(sorgu, baglan);
            cmd2=new SqlCommand(sorgu2, baglan);
            cmd.Parameters.AddWithValue("@kullanici_adi", k_ad);
            cmd.Parameters.AddWithValue("@k_guvenlik", g_soru);
            cmd.Parameters.AddWithValue("@k_gcevap", g_cevap);
            cmd2.Parameters.AddWithValue("k_sifre", sifre2);
            cmd2.Parameters.AddWithValue("kullanici_adi", k_ad);
            baglan.Open();
            dr = cmd.ExecuteReader();

            if (dr.Read())
            {
            dr.Close();
                if (sifre1 == sifre2)
                {
                    cmd2.ExecuteNonQuery();
                    mesaj.Text = "Şifre Değiştirme İşlemi Başarılı";
                    Giris giris= new Giris();
                    this.Hide();
                    giris.Show();
                    
                }

                else
                {
                    mesaj.Text = "Şifreler Uyuşmuyor!";
                }
            }

            else
            {
                mesaj.Text = "Bilgleri Kontrol Ediniz ";
            }
            baglan.Close();

        }

        private void SifreUnuttum_Load(object sender, EventArgs e)
        {

        }
    }
}
