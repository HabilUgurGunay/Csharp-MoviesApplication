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
    public partial class filmdizidetay : Form
    {
        double puan;
        double toplampuan;
        double kpuan;
        public string kullanici_adi;
        public string turu;
        public string kategorisi;
        public string cikisyili;
        public string kullanicipuani;

        SqlConnection baglan=new SqlConnection("Data Source=HABILUGUR\\SQLEXPRESS;Initial Catalog=Gorsel-Proje;Integrated Security=True");
        SqlCommand cmd;
        SqlDataReader dr;


        public filmdizidetay()
        {
            InitializeComponent();
        }

        private void filmdizidetay_Load(object sender, EventArgs e)
        {
            puanlabel.Visible = false;
            kullanicipuanitextbox.Visible = false;
            puanonay.Visible = false;            
            fdad.Text = kullanici_adi;
            fdtur.Text= turu;
            fdkategorisi.Text= kategorisi;
            fdcikisyili.Text= cikisyili;
            fdkullanicipuan.Text= kullanicipuani;

            cmd = new SqlCommand("SELECT * FROM filmdizi WHERE fdad='" + fdad.Text + "' AND fdtur='"+fdtur.Text+"'", baglan);
            baglan.Open();
            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                fdkonusu.Text=dr.GetValue(18).ToString();
                fdimdb.Text=dr.GetValue(5).ToString();
                fdyonetmen.Text = dr.GetValue(3).ToString();
                fdbasrol.Text=dr.GetValue(4).ToString();
                fdbutce.Text=dr.GetValue(8).ToString();
                fdhasilat.Text=dr.GetValue(10).ToString();
                fdturkiyehasilat.Text = dr.GetValue(11).ToString();
                fdamerikahasilat.Text = dr.GetValue(12).ToString();
                fdkanadahasilat.Text = dr.GetValue(13).ToString();
                fdrusyahasilat.Text = dr.GetValue(14).ToString();
                fdazerbaycanhasilat.Text = dr.GetValue(15).ToString();
                fdukraynahasilat.Text = dr.GetValue(16).ToString();
                guna2PictureBox1.Image=Image.FromFile(dr.GetValue(8).ToString());
                kpuan = Convert.ToDouble(dr.GetValue(17));

                
            }
            baglan.Close();

        }

        private void Kapatbuton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Anasayfa anasayfa = new Anasayfa();
            anasayfa.Hide();
            anasayfa.Show();
        }

        private void evetradio_Click(object sender, EventArgs e)
        {

            puanonay.Visible = true;
            puanlabel.Visible = true;
            kullanicipuanitextbox.Visible = true;

            if (evetradio.Checked)
            {
                Hayırradio.Checked = false;
                
            }

        }

        private void puanonay_Click(object sender, EventArgs e)
        {
            
            puan = Convert.ToDouble(kullanicipuanitextbox.Text);

            if (puan<= 10&& puan>0)
            {
                toplampuan = (puan + kpuan) / 2;

                string sorgu2 = ("UPDATE filmdizi SET fdkullanicipuan=@fdkullanicipuan WHERE fdad=@fdad AND fdtur=@fdtur");


                using (SqlConnection baglan = new SqlConnection("Data Source=HABILUGUR\\SQLEXPRESS;Initial Catalog=Gorsel-Proje;Integrated Security=True"))
                {
                baglan.Open();

                using (SqlCommand cmd2 = new SqlCommand(sorgu2,baglan))
                {
                    cmd2.Parameters.AddWithValue("@fdkullanicipuan", toplampuan);
                    cmd2.Parameters.AddWithValue("@fdad", kullanici_adi);
                    cmd2.Parameters.AddWithValue("@fdtur", turu);
                    cmd2.ExecuteNonQuery();
                }
                baglan.Close();

                }
                puansonuc.Text = "Puan verme işleminiz Başarılıdır!";
                puanonay.Visible = false;
                puanlabel.Visible = false;
                kullanicipuanitextbox.Visible = false;
            }
            else
            {
                puansonuc.Text = "Lütfen 1 İLE 10 arasında sayı giriniz! ";
            }

        }

        private void Hayırradio_CheckedChanged(object sender, EventArgs e)
        {
            if (Hayırradio.Checked)
            {
                evetradio.Checked = false;
                puanonay.Visible = false;
                puanlabel.Visible = false;
                kullanicipuanitextbox.Visible = false;
            }
        }

        private void Hayırradio_Click(object sender, EventArgs e)
        {
            if(Hayırradio.Checked)
            {
                evetradio.Checked = false;
                puanonay.Visible = false;
                puanlabel.Visible = false;
                kullanicipuanitextbox.Visible = false;
            }
        }

        private void evetradio_CheckedChanged(object sender, EventArgs e)
        {
            puanonay.Visible = true;
            puanlabel.Visible = true;
            kullanicipuanitextbox.Visible = true;

            if (evetradio.Checked)
            {
                Hayırradio.Checked = false;

            }
        }
    }
}
