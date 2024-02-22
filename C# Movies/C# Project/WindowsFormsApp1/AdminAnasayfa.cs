using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Sql;
using Guna.UI2.WinForms;

namespace WindowsFormsApp1
{
    public partial class AdminAnasayfa : Form
    {

        SqlConnection baglan = new SqlConnection("Data Source=HABILUGUR\\SQLEXPRESS;Initial Catalog=Gorsel-Proje;Integrated Security=True;");
        SqlCommand cmd;
        SqlCommand cmd2;
        SqlCommand cmd3;
        SqlDataReader dr;
        SqlDataAdapter da;
        public string k;
        public string isimm;
        public string idd;



        public AdminAnasayfa()
        {
            InitializeComponent();
        }

        private void dosyasec_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            fdresim.Text = openFileDialog1.FileName;
        }

        private void girisButon_Click(object sender, EventArgs e)
        {
            string sorgu = "Insert into filmdizi (fdad,fdtur,fdyonetmen,fdbasrol,fdimdb,fdkategori,fdyil,fdresim,fdbutce,fdhasilat,fdturkiye,fdamerika,fdkanada,fdrusya,fdazerbaycan,fdukrayna,fdkonusu) values (@fdad,@fdtur,@fdyonetmen,@fdbasrol,@fdimdb,@fdkategori,@fdyil,@fdresim,@fdbutce,@fdhasilat,@fdturkiye,@fdamerika,@fdkanada,@fdrusya,@fdazerbaycan,@fdukrayna,@fdkonusu)";

            cmd= new SqlCommand(sorgu,baglan);
            cmd.Parameters.AddWithValue("@fdad", fdad.Text);
            cmd.Parameters.AddWithValue("@fdtur", fdtur.Text);
            cmd.Parameters.AddWithValue("@fdyonetmen", fdyonetmen.Text);
            cmd.Parameters.AddWithValue("@fdbasrol", fdbasrol.Text);
            cmd.Parameters.AddWithValue("@fdimdb", Convert.ToDouble(fdimdb.Text));
            cmd.Parameters.AddWithValue("@fdkategori", fdkategori.Text);
            cmd.Parameters.AddWithValue("@fdyil", Convert.ToInt32(fdyil.Text));
            cmd.Parameters.AddWithValue("@fdresim", fdresim.Text);
            cmd.Parameters.AddWithValue("@fdbutce", Convert.ToInt32(fdbutce.Text));
            cmd.Parameters.AddWithValue("@fdhasilat", Convert.ToInt32(fdhasilat.Text));
            cmd.Parameters.AddWithValue("@fdturkiye", Convert.ToInt32(fdturkiye.Text));
            cmd.Parameters.AddWithValue("@fdamerika", Convert.ToInt32(fdamerika.Text));
            cmd.Parameters.AddWithValue("@fdkanada", Convert.ToInt32(fdkanada.Text));
            cmd.Parameters.AddWithValue("@fdrusya", Convert.ToInt32(fdrusya.Text));
            cmd.Parameters.AddWithValue("@fdazerbaycan", Convert.ToInt32(fdazerbaycan.Text));
            cmd.Parameters.AddWithValue("@fdukrayna", Convert.ToInt32(fdukrayna.Text));
            cmd.Parameters.AddWithValue("@fdkonusu", konutext.Text);
            baglan.Open();
            cmd.ExecuteNonQuery();
            MessageBox.Show("İşleminiz Başarılıdır!");
            baglan.Close();
            this.Hide();
            AdminAnasayfa adminAnasayfa = new AdminAnasayfa();
            adminAnasayfa.Show();

        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Anasayfa anasayfa = new Anasayfa();
            anasayfa.k = k;
            anasayfa.isim=isimm;
            anasayfa.id = idd;
            anasayfa.Show();
        }

        private void cıkısbutton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void AdminAnasayfa_Load(object sender, EventArgs e)
        {
            baglan.Open();
            string sorgu = ("Select fdad AS Film_Dizi_Adı, fdtur as Türü, fdimdb as IMDB_Puanı, fdkategori as Kategorisi,fdyil as Çıkış_Yılı,fdkullanicipuan as İzleyen_Puanı from filmdizi ");
            da = new SqlDataAdapter(sorgu, baglan);
            DataTable dt = new DataTable();
            da.Fill(dt);
            guna2DataGridView1.DataSource = dt;
            baglan.Close();
            fdıd.Enabled = false;
        }

        private void guna2DataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string fdads = guna2DataGridView1.CurrentRow.Cells[0].Value.ToString();
            string fdturs = guna2DataGridView1.CurrentRow.Cells[1].Value.ToString();
            cmd = new SqlCommand("SELECT * FROM filmdizi WHERE fdad='" + fdads + "' AND fdtur='" + fdturs + "'", baglan);

            baglan.Open();
            dr=cmd.ExecuteReader();

            while(dr.Read()) 
            {
                fdıd.Text=dr.GetValue(0).ToString();
                fdad.Text = dr.GetValue(1).ToString();
                fdtur.Text = dr.GetValue(2).ToString();
                fdyonetmen.Text=dr.GetValue(3).ToString();
                fdbasrol.Text= dr.GetValue(4).ToString();
                fdimdb.Text= dr.GetValue(5).ToString();
                fdkategori.Text= dr.GetValue(6).ToString();
                fdyil.Text= dr.GetValue(7).ToString();
                fdresim.Text= dr.GetValue(8).ToString();
                fdbutce.Text= dr.GetValue(9).ToString();
                fdhasilat.Text= dr.GetValue(10).ToString();
                fdturkiye.Text= dr.GetValue(11).ToString();
                fdamerika.Text= dr.GetValue(12).ToString();
                fdkanada.Text= dr.GetValue(13).ToString();
                fdrusya.Text= dr.GetValue(14).ToString();
                fdazerbaycan.Text= dr.GetValue(15).ToString();
                fdukrayna.Text= dr.GetValue(16).ToString();
                konutext.Text= dr.GetValue(18).ToString();
            }
            baglan.Close();
            
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            string sorgu2 = "UPDATE filmdizi SET fdad=@fdad, fdtur=@fdtur, fdyonetmen=@fdyonetmen, fdbasrol=@fdbasrol, fdimdb=@fdimdb, fdkategori=@fdkategori, fdyil=@fdyil, fdresim=@fdresim, fdbutce=@fdbutce, fdhasilat=@fdhasilat, fdturkiye=@fdturkiye, fdamerika=@fdamerika, fdkanada=@fdkanada, fdrusya=@fdrusya, fdazerbaycan=@fdazerbaycan, fdukrayna=@fdukrayna, fdkonusu=@fdkonusu WHERE fdid=@fdid";

            cmd2=new SqlCommand(sorgu2, baglan);
            cmd2.Parameters.AddWithValue("@fdid", fdıd.Text);
            cmd2.Parameters.AddWithValue("@fdad", fdad.Text);
            cmd2.Parameters.AddWithValue("@fdtur", fdtur.Text);
            cmd2.Parameters.AddWithValue("@fdyonetmen", fdyonetmen.Text);
            cmd2.Parameters.AddWithValue("@fdbasrol", fdbasrol.Text);
            cmd2.Parameters.AddWithValue("@fdimdb", Convert.ToDouble(fdimdb.Text));
            cmd2.Parameters.AddWithValue("@fdkategori",fdkategori.Text);
            cmd2.Parameters.AddWithValue("@fdyil", Convert.ToInt32(fdyil.Text));
            cmd2.Parameters.AddWithValue("@fdresim",fdresim.Text);
            cmd2.Parameters.AddWithValue("@fdbutce", Convert.ToInt32(fdbutce.Text));
            cmd2.Parameters.AddWithValue("@fdhasilat", Convert.ToInt32(fdhasilat.Text));
            cmd2.Parameters.AddWithValue("@fdturkiye", Convert.ToInt32(fdturkiye.Text));
            cmd2.Parameters.AddWithValue("@fdamerika",Convert.ToInt32(fdamerika.Text));
            cmd2.Parameters.AddWithValue("@fdkanada", Convert.ToInt32(fdkanada.Text));
            cmd2.Parameters.AddWithValue("@fdrusya",Convert.ToInt32(fdrusya.Text));
            cmd2.Parameters.AddWithValue("@fdazerbaycan",Convert.ToInt32(fdazerbaycan.Text));
            cmd2.Parameters.AddWithValue("@fdukrayna", Convert.ToInt32(fdukrayna.Text));
            cmd2.Parameters.AddWithValue("@fdkonusu",konutext.Text);
            baglan.Open();
            cmd2.ExecuteNonQuery();
            baglan.Close();
            this.Hide();
            AdminAnasayfa adminAnasayfa = new AdminAnasayfa();
            adminAnasayfa.Show();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            string sorgu3 = "DELETE FROM filmdizi WHERE fdid=@fdid";
            cmd3=new SqlCommand(sorgu3, baglan);
            cmd3.Parameters.AddWithValue("@fdid", fdıd.Text);
            baglan.Open() ;
            cmd3.ExecuteNonQuery();
            baglan.Close() ;
            this.Hide();
            AdminAnasayfa adminAnasayfa = new AdminAnasayfa();
            adminAnasayfa.Show();

        }
    }
}
