using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Anasayfa : Form
    {
        string fdad;
        string fdtur;
        string fdkategori;
        string fdyil;
        string fdkullanicipuan;

        private Timer myTimer;

        public string k;
        public string id;
        public string isim;
        SqlConnection baglan = new SqlConnection("Data Source=HABILUGUR\\SQLEXPRESS;Initial Catalog=Gorsel-Proje;Integrated Security=True;");
        SqlCommand cmd;
        SqlDataAdapter da;

        public Anasayfa()
        {
            InitializeComponent();
            myTimer = new Timer();
            myTimer.Interval = 2500;
            myTimer.Tick += timer1_Tick;

        }

        private void Anasayfa_Load(object sender, EventArgs e)
        {
            listBox1.Visible = false;
            listBox1.BringToFront();//nesnelerin katman özelliği
            kategoripanel.BringToFront();
            profilpanel.BringToFront();
            dizipanel.BringToFront();
            filmpanel.BringToFront();
            belgeselpanel.BringToFront();
            sitcompanel.BringToFront();
            kategoripanel.Visible = false;
            dizipanel.Visible = false;
            filmpanel.Visible = false;
            belgeselpanel.Visible = false;
            sitcompanel.Visible = false;
            profilpanel.Visible = false;
            kullanici_adi_label.Text = k;

            baglan.Open();
            string sorgu = ("Select fdad AS Adı, fdtur as Türü, fdimdb as IMDB_Puanı, fdkategori as Kategorisi,fdyil as Çıkış_Yılı,fdkullanicipuan as İzleyen_Puanı from filmdizi ");
            da = new SqlDataAdapter(sorgu, baglan);
            DataTable dt=   new DataTable();
            da.Fill(dt);
            guna2DataGridView1.DataSource=dt;
            baglan.Close();

            
            

            

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (var listBoxItem in listBox1.Items)
            {
                listBox1.Visible = false;
            }

            if (listBox1.SelectedIndex == 0)
            {
                baglan.Open();
                string sorgu = ("Select fdad AS Film_Dizi_Adı, fdtur as Türü, fdimdb as IMDB_Puanı, fdkategori as Kategorisi,fdyil as Çıkış_Yılı,fdkullanicipuan as İzleyen_Puanı from filmdizi ORDER BY fdyil DESC ");
                da = new SqlDataAdapter(sorgu, baglan);
                DataTable dt = new DataTable();
                da.Fill(dt);
                guna2DataGridView1.DataSource = dt;
                baglan.Close();
                kategoripanel.Visible = false;
            }

            if (listBox1.SelectedIndex == 1)
            {
                baglan.Open();
                string sorgu = ("Select fdad AS Film_Dizi_Adı, fdtur as Türü, fdimdb as IMDB_Puanı, fdkategori as Kategorisi,fdyil as Çıkış_Yılı,fdkullanicipuan as İzleyen_Puanı from filmdizi ORDER BY fdimdb DESC ");
                da = new SqlDataAdapter(sorgu, baglan);
                DataTable dt = new DataTable();
                da.Fill(dt);
                guna2DataGridView1.DataSource = dt;
                baglan.Close();
                kategoripanel.Visible = false;
            }

            if (listBox1.SelectedIndex == 2)
            {
                baglan.Open();
                string sorgu = ("Select fdad AS Film_Dizi_Adı, fdtur as Türü, fdimdb as IMDB_Puanı, fdkategori as Kategorisi,fdyil as Çıkış_Yılı,fdkullanicipuan as İzleyen_Puanı from filmdizi ORDER BY fdad ASC ");
                da = new SqlDataAdapter(sorgu, baglan);
                DataTable dt = new DataTable();
                da.Fill(dt);
                guna2DataGridView1.DataSource = dt;
                baglan.Close();
                kategoripanel.Visible = false;
            }

            if (listBox1.SelectedIndex == 3)
            {
                baglan.Open();
                string sorgu = ("Select fdad AS Film_Dizi_Adı, fdtur as Türü, fdimdb as IMDB_Puanı, fdkategori as Kategorisi,fdyil as Çıkış_Yılı,fdkullanicipuan as İzleyen_Puanı from filmdizi ORDER BY fdkategori ASC ");
                da = new SqlDataAdapter(sorgu, baglan);
                DataTable dt = new DataTable();
                da.Fill(dt);
                guna2DataGridView1.DataSource = dt;
                baglan.Close();
                kategoripanel.Visible = false;

            }
            if (listBox1.SelectedIndex == 4)
            {
                baglan.Open();
                string sorgu = ("Select fdad AS Film_Dizi_Adı, fdtur as Türü, fdimdb as IMDB_Puanı, fdkategori as Kategorisi,fdyil as Çıkış_Yılı,fdkullanicipuan as İzleyen_Puanı from filmdizi ORDER BY fdkullanicipuan DESC ");
                da = new SqlDataAdapter(sorgu, baglan);
                DataTable dt = new DataTable();
                da.Fill(dt);
                guna2DataGridView1.DataSource = dt;
                baglan.Close();
                kategoripanel.Visible = false;

            }
        }

        private void guna2ImageButton2_Click(object sender, EventArgs e)
        {
            if(listBox1.Visible == true)
            {
                listBox1.Visible = false;
            }
            else
            {
                listBox1.Visible = true;
            }
        }

        private void guna2ImageButton3_Click(object sender, EventArgs e)
        {
            baglan.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT fdad AS Film_Dizi_Adı, fdtur as Türü, fdimdb as IMDB_Puanı, fdkategori as Kategorisi,fdyil as Çıkış_Yılı,fdkullanicipuan as İzleyen_Puanı FROM filmdizi WHERE fdad LIKE @search", baglan);
            da.SelectCommand.Parameters.AddWithValue("@search", "%" + guna2TextBox1.Text + "%");
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            guna2DataGridView1.DataSource = tablo;
            baglan.Close();
        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {

        }

        private void cıkısbutton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            kategoripanel.Visible = true;
            dizipanel.Visible = false;
            filmpanel.Visible = false;
            belgeselpanel.Visible = false;
            sitcompanel.Visible = false;

            baglan.Open();
            string sorgu = ("Select fdad AS Film_Dizi_Adı, fdtur as Türü, fdimdb as IMDB_Puanı, fdkategori as Kategorisi,fdyil as Çıkış_Yılı,fdkullanicipuan as İzleyen_Puanı from filmdizi ");
            da = new SqlDataAdapter(sorgu, baglan);
            DataTable dt = new DataTable();
            da.Fill(dt);
            guna2DataGridView1.DataSource = dt;
            baglan.Close();
            kategoripanel.Visible=false;

        }

        private void dizibuton_Click(object sender, EventArgs e)
        {
            kategoripanel.Visible = false;
            dizipanel.Visible = true;
            filmpanel.Visible = false;
            belgeselpanel.Visible = false;
            sitcompanel.Visible = false;

            baglan.Open();
            string sorgu = ("Select fdad AS Film_Dizi_Adı, fdtur as Türü, fdimdb as IMDB_Puanı, fdkategori as Kategorisi,fdyil as Çıkış_Yılı,fdkullanicipuan as İzleyen_Puanı from filmdizi where fdtur='dizi' ");
            da = new SqlDataAdapter(sorgu, baglan);
            DataTable dt = new DataTable();
            da.Fill(dt);
            guna2DataGridView1.DataSource = dt;
            baglan.Close();

            dizipanel.Visible = false;

        }

        private void filmbuton_Click(object sender, EventArgs e)
        {
            kategoripanel.Visible = false;
            dizipanel.Visible = false;
            filmpanel.Visible = true;
            belgeselpanel.Visible = false;
            sitcompanel.Visible = false;

            baglan.Open();
            string sorgu = ("Select fdad AS Film_Dizi_Adı, fdtur as Türü, fdimdb as IMDB_Puanı, fdkategori as Kategorisi,fdyil as Çıkış_Yılı,fdkullanicipuan as İzleyen_Puanı from filmdizi where fdtur='film' ");
            da = new SqlDataAdapter(sorgu, baglan);
            DataTable dt = new DataTable();
            da.Fill(dt);
            guna2DataGridView1.DataSource = dt;
            baglan.Close();

        }

        private void belgeselbuton_Click(object sender, EventArgs e)
        {
            kategoripanel.Visible = false;
            dizipanel.Visible = false;
            filmpanel.Visible = false;
            belgeselpanel.Visible = true;
            sitcompanel.Visible = false;

            baglan.Open();
            string sorgu = ("Select fdad AS Film_Dizi_Adı, fdtur as Türü, fdimdb as IMDB_Puanı, fdkategori as Kategorisi,fdyil as Çıkış_Yılı,fdkullanicipuan as İzleyen_Puanı from filmdizi where fdtur='belgesel' ");
            da = new SqlDataAdapter(sorgu, baglan);
            DataTable dt = new DataTable();
            da.Fill(dt);
            guna2DataGridView1.DataSource = dt;
            baglan.Close();
        }

        private void sitcombuton_Click(object sender, EventArgs e)
        {
            kategoripanel.Visible = false;
            dizipanel.Visible = false;
            filmpanel.Visible = false;
            belgeselpanel.Visible = false;
            sitcompanel.Visible = true;

            baglan.Open();
            string sorgu = ("Select fdad AS Film_Dizi_Adı, fdtur as Türü, fdimdb as IMDB_Puanı, fdkategori as Kategorisi,fdyil as Çıkış_Yılı,fdkullanicipuan as İzleyen_Puanı from filmdizi where fdtur='sitcom' ");
            da = new SqlDataAdapter(sorgu, baglan);
            DataTable dt = new DataTable();
            da.Fill(dt);
            guna2DataGridView1.DataSource = dt;
            baglan.Close();

        }

        private void cıkısbutton_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void kullanici_adi_label_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button7_MouseHover(object sender, EventArgs e)
        {
            kategoripanel.Visible = true;
        }

        private void guna2Button6_MouseHover(object sender, EventArgs e)
        {

            if (dizipanel.Visible == false)
            {
                myTimer.Stop();
            }
            if (filmpanel.Visible == false)
            {
                myTimer.Stop();
            }
            if (belgeselpanel.Visible == false)
            {
                myTimer.Stop();
            }
            if (sitcompanel.Visible == false)
            {
                myTimer.Stop();
            }

            kategoripanel.Visible = true;
            dizipanel.Visible = false;
            filmpanel.Visible = false;
            belgeselpanel.Visible = false;
            sitcompanel.Visible = false;
            myTimer.Start();
        }

        private void guna2Button6_MouseLeave(object sender, EventArgs e)
        {

        }

        private void kategoripanel_MouseLeave(object sender, EventArgs e)
        {
        }

        private void kategoripanel_MouseHover(object sender, EventArgs e)
        {
            kategoripanel.Visible = true;
        }

        private void sitcombuton_MouseHover(object sender, EventArgs e)
        {
            if (kategoripanel.Visible == false)
            {
                myTimer.Stop();
            }
            if (dizipanel.Visible == false)
            {
                myTimer.Stop();
            }
            if (filmpanel.Visible == false)
            {
                myTimer.Stop();
            }
            if (belgeselpanel.Visible == false)
            {
                myTimer.Stop();
            }

            kategoripanel.Visible = false;
            dizipanel.Visible = false;
            filmpanel.Visible = false;
            belgeselpanel.Visible = false;
            sitcompanel.Visible = true;
            myTimer.Start();
        }

        private void kategorikomedi_MouseHover(object sender, EventArgs e)
        {
        }

        private void kategorikorku_MouseHover(object sender, EventArgs e)
        {
        }

        private void kategorigerilim_Click(object sender, EventArgs e)
        {
            baglan.Open();
            string sorgu = ("Select fdad AS Film_Dizi_Adı, fdtur as Türü, fdimdb as IMDB_Puanı, fdkategori as Kategorisi,fdyil as Çıkış_Yılı,fdkullanicipuan as İzleyen_Puanı from filmdizi where fdkategori='gerilim' ");
            da = new SqlDataAdapter(sorgu, baglan);
            DataTable dt = new DataTable();
            da.Fill(dt);
            guna2DataGridView1.DataSource = dt;
            baglan.Close();
            kategoripanel.Visible = false;
        }

        private void kategorigerilim_MouseHover(object sender, EventArgs e)
        {
        }

        private void kategoriromantik_MouseHover(object sender, EventArgs e)
        {
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            kategoripanel.Visible = false;
            if (kategoripanel.Visible==false)
            {
                myTimer.Stop();
            }

            dizipanel.Visible = false;
            if (dizipanel.Visible == false)
            {
                myTimer.Stop();
            }

            filmpanel.Visible = false;
            if (filmpanel.Visible == false)
            {
                myTimer.Stop();
            }

            belgeselpanel.Visible = false;
            if (belgeselpanel.Visible == false)
            {
                myTimer.Stop();
            }

            sitcompanel.Visible = false;
            if (sitcompanel.Visible == false)
            {
                myTimer.Stop();
            }
            
        }

        private void dizibuton_MouseHover(object sender, EventArgs e)
        {

            if (kategoripanel.Visible == false)
            {
                myTimer.Stop();
            }
            if (filmpanel.Visible == false)
            {
                myTimer.Stop();
            }
            if (belgeselpanel.Visible == false)
            {
                myTimer.Stop();
            }
            if (sitcompanel.Visible == false)
            {
                myTimer.Stop();
            }

            kategoripanel.Visible = false;
            dizipanel.Visible = true;
            filmpanel.Visible = false;
            belgeselpanel.Visible = false;
            sitcompanel.Visible = false;
            myTimer.Start();
        }

        private void filmbuton_MouseHover(object sender, EventArgs e)
        {
            if (kategoripanel.Visible == false)
            {
                myTimer.Stop();
            }
            if (dizipanel.Visible == false)
            {
                myTimer.Stop();
            }
            if (belgeselpanel.Visible == false)
            {
                myTimer.Stop();
            }
            if (sitcompanel.Visible == false)
            {
                myTimer.Stop();
            }

            kategoripanel.Visible = false;
            dizipanel.Visible = false;
            filmpanel.Visible = true;
            belgeselpanel.Visible = false;
            sitcompanel.Visible = false;
            myTimer.Start();
        }

        private void belgeselbuton_MouseHover(object sender, EventArgs e)
        {
            if (kategoripanel.Visible == false)
            {
                myTimer.Stop();
            }
            if (dizipanel.Visible == false)
            {
                myTimer.Stop();
            }
            if (filmpanel.Visible == false)
            {
                myTimer.Stop();
            }
            if (sitcompanel.Visible == false)
            {
                myTimer.Stop();
            }

            kategoripanel.Visible = false;
            dizipanel.Visible = false;
            filmpanel.Visible = false;
            belgeselpanel.Visible = true;
            sitcompanel.Visible = false;
            myTimer.Start();
        }

        private void katagorikorku_Click(object sender, EventArgs e)
        {
            baglan.Open();
            string sorgu = ("Select fdad AS Film_Dizi_Adı, fdtur as Türü, fdimdb as IMDB_Puanı, fdkategori as Kategorisi,fdyil as Çıkış_Yılı,fdkullanicipuan as İzleyen_Puanı from filmdizi where fdkategori='korku' ");
            da = new SqlDataAdapter(sorgu, baglan);
            DataTable dt = new DataTable();
            da.Fill(dt);
            guna2DataGridView1.DataSource = dt;
            baglan.Close();
            kategoripanel.Visible=false;
        }

        private void kategorikomedi_Click(object sender, EventArgs e)
        {
            baglan.Open();
            string sorgu = ("Select fdad AS Film_Dizi_Adı, fdtur as Türü, fdimdb as IMDB_Puanı, fdkategori as Kategorisi,fdyil as Çıkış_Yılı,fdkullanicipuan as İzleyen_Puanı from filmdizi where fdkategori='Komedi' ");
            da = new SqlDataAdapter(sorgu, baglan);
            DataTable dt = new DataTable();
            da.Fill(dt);
            guna2DataGridView1.DataSource = dt;
            baglan.Close();
            kategoripanel.Visible = false;
        }

        private void kategorikorku_Click(object sender, EventArgs e)
        {
            baglan.Open();
            string sorgu = ("Select fdad AS Film_Dizi_Adı, fdtur as Türü, fdimdb as IMDB_Puanı, fdkategori as Kategorisi,fdyil as Çıkış_Yılı,fdkullanicipuan as İzleyen_Puanı from filmdizi where fdkategori='Korku' ");
            da = new SqlDataAdapter(sorgu, baglan);
            DataTable dt = new DataTable();
            da.Fill(dt);
            guna2DataGridView1.DataSource = dt;
            baglan.Close();
            kategoripanel.Visible = false;
        }

        private void kategoridram_Click(object sender, EventArgs e)
        {
            baglan.Open();
            string sorgu = ("Select fdad AS Film_Dizi_Adı, fdtur as Türü, fdimdb as IMDB_Puanı, fdkategori as Kategorisi,fdyil as Çıkış_Yılı,fdkullanicipuan as İzleyen_Puanı from filmdizi where fdkategori='Dram' ");
            da = new SqlDataAdapter(sorgu, baglan);
            DataTable dt = new DataTable();
            da.Fill(dt);
            guna2DataGridView1.DataSource = dt;
            baglan.Close();
            kategoripanel.Visible = false;
        }

        private void kategoriromantik_Click(object sender, EventArgs e)
        {
            baglan.Open();
            string sorgu = ("Select fdad AS Film_Dizi_Adı, fdtur as Türü, fdimdb as IMDB_Puanı, fdkategori as Kategorisi,fdyil as Çıkış_Yılı,fdkullanicipuan as İzleyen_Puanı from filmdizi where fdkategori='Romantik' ");
            da = new SqlDataAdapter(sorgu, baglan);
            DataTable dt = new DataTable();
            da.Fill(dt);
            guna2DataGridView1.DataSource = dt;
            baglan.Close();
            kategoripanel.Visible = false;
        }

        private void dizilerkorku_Click(object sender, EventArgs e)
        {
            baglan.Open();
            string sorgu = ("Select fdad AS Film_Dizi_Adı, fdtur as Türü, fdimdb as IMDB_Puanı, fdkategori as Kategorisi,fdyil as Çıkış_Yılı,fdkullanicipuan as İzleyen_Puanı from filmdizi where fdtur='Dizi' AND fdkategori='Korku' ");
            da = new SqlDataAdapter(sorgu, baglan);
            DataTable dt = new DataTable();
            da.Fill(dt);
            guna2DataGridView1.DataSource = dt;
            baglan.Close();
            dizipanel.Visible = false;
        }

        private void dizilerkomedi_Click(object sender, EventArgs e)
        {
            baglan.Open();
            string sorgu = ("Select fdad AS Film_Dizi_Adı, fdtur as Türü, fdimdb as IMDB_Puanı, fdkategori as Kategorisi,fdyil as Çıkış_Yılı,fdkullanicipuan as İzleyen_Puanı from filmdizi where fdtur='Dizi' AND fdkategori='Komedi' ");
            da = new SqlDataAdapter(sorgu, baglan);
            DataTable dt = new DataTable();
            da.Fill(dt);
            guna2DataGridView1.DataSource = dt;
            baglan.Close();
            dizipanel.Visible = false;
        }

        private void dizilerdram_Click(object sender, EventArgs e)
        {
            baglan.Open();
            string sorgu = ("Select fdad AS Film_Dizi_Adı, fdtur as Türü, fdimdb as IMDB_Puanı, fdkategori as Kategorisi,fdyil as Çıkış_Yılı,fdkullanicipuan as İzleyen_Puanı from filmdizi where fdtur='Dizi' AND fdkategori='Dram' ");
            da = new SqlDataAdapter(sorgu, baglan);
            DataTable dt = new DataTable();
            da.Fill(dt);
            guna2DataGridView1.DataSource = dt;
            baglan.Close();
            dizipanel.Visible = false;
        }

        private void dizilergerilim_Click(object sender, EventArgs e)
        {
            baglan.Open();
            string sorgu = ("Select fdad AS Film_Dizi_Adı, fdtur as Türü, fdimdb as IMDB_Puanı, fdkategori as Kategorisi,fdyil as Çıkış_Yılı,fdkullanicipuan as İzleyen_Puanı from filmdizi where fdtur='Dizi' AND fdkategori='Gerilim' ");
            da = new SqlDataAdapter(sorgu, baglan);
            DataTable dt = new DataTable();
            da.Fill(dt);
            guna2DataGridView1.DataSource = dt;
            baglan.Close();
            dizipanel.Visible = false;
        }

        private void dizilerromantik_Click(object sender, EventArgs e)
        {
            baglan.Open();
            string sorgu = ("Select fdad AS Film_Dizi_Adı, fdtur as Türü, fdimdb as IMDB_Puanı, fdkategori as Kategorisi,fdyil as Çıkış_Yılı,fdkullanicipuan as İzleyen_Puanı from filmdizi where fdtur='Dizi' AND fdkategori='Romantik' ");
            da = new SqlDataAdapter(sorgu, baglan);
            DataTable dt = new DataTable();
            da.Fill(dt);
            guna2DataGridView1.DataSource = dt;
            baglan.Close();
            dizipanel.Visible = false;
        }

        private void filmkorku_Click(object sender, EventArgs e)
        {
            baglan.Open();
            string sorgu = ("Select fdad AS Film_Dizi_Adı, fdtur as Türü, fdimdb as IMDB_Puanı, fdkategori as Kategorisi,fdyil as Çıkış_Yılı,fdkullanicipuan as İzleyen_Puanı from filmdizi where fdtur='Film' AND fdkategori='Korku' ");
            da = new SqlDataAdapter(sorgu, baglan);
            DataTable dt = new DataTable();
            da.Fill(dt);
            guna2DataGridView1.DataSource = dt;
            baglan.Close();
            filmpanel.Visible = false;
        }

        private void filmkomedi_Click(object sender, EventArgs e)
        {
            baglan.Open();
            string sorgu = ("Select fdad AS Film_Dizi_Adı, fdtur as Türü, fdimdb as IMDB_Puanı, fdkategori as Kategorisi,fdyil as Çıkış_Yılı,fdkullanicipuan as İzleyen_Puanı from filmdizi where fdtur='Film' AND fdkategori='Komedi' ");
            da = new SqlDataAdapter(sorgu, baglan);
            DataTable dt = new DataTable();
            da.Fill(dt);
            guna2DataGridView1.DataSource = dt;
            baglan.Close();
            filmpanel.Visible = false;
        }

        private void filmdram_Click(object sender, EventArgs e)
        {
            baglan.Open();
            string sorgu = ("Select fdad AS Film_Dizi_Adı, fdtur as Türü, fdimdb as IMDB_Puanı, fdkategori as Kategorisi,fdyil as Çıkış_Yılı,fdkullanicipuan as İzleyen_Puanı from filmdizi where fdtur='Film' AND fdkategori='Dram' ");
            da = new SqlDataAdapter(sorgu, baglan);
            DataTable dt = new DataTable();
            da.Fill(dt);
            guna2DataGridView1.DataSource = dt;
            baglan.Close();
            filmpanel.Visible = false;
        }

        private void filmgerilim_Click(object sender, EventArgs e)
        {
            baglan.Open();
            string sorgu = ("Select fdad AS Film_Dizi_Adı, fdtur as Türü, fdimdb as IMDB_Puanı, fdkategori as Kategorisi,fdyil as Çıkış_Yılı,fdkullanicipuan as İzleyen_Puanı from filmdizi where fdtur='Film' AND fdkategori='Gerilim' ");
            da = new SqlDataAdapter(sorgu, baglan);
            DataTable dt = new DataTable();
            da.Fill(dt);
            guna2DataGridView1.DataSource = dt;
            baglan.Close();
            filmpanel.Visible = false;
        }

        private void filmromantik_Click(object sender, EventArgs e)
        {
            baglan.Open();
            string sorgu = ("Select fdad AS Film_Dizi_Adı, fdtur as Türü, fdimdb as IMDB_Puanı, fdkategori as Kategorisi,fdyil as Çıkış_Yılı,fdkullanicipuan as İzleyen_Puanı from filmdizi where fdtur='Film' AND fdkategori='Romantik' ");
            da = new SqlDataAdapter(sorgu, baglan);
            DataTable dt = new DataTable();
            da.Fill(dt);
            guna2DataGridView1.DataSource = dt;
            baglan.Close();
            filmpanel.Visible = false;
        }

        private void belgeselkorku_Click(object sender, EventArgs e)
        {
            baglan.Open();
            string sorgu = ("Select fdad AS Film_Dizi_Adı, fdtur as Türü, fdimdb as IMDB_Puanı, fdkategori as Kategorisi,fdyil as Çıkış_Yılı,fdkullanicipuan as İzleyen_Puanı from filmdizi where fdtur='Belgesel' AND fdkategori='Korku' ");
            da = new SqlDataAdapter(sorgu, baglan);
            DataTable dt = new DataTable();
            da.Fill(dt);
            guna2DataGridView1.DataSource = dt;
            baglan.Close();
            belgeselpanel.Visible = false;
        }

        private void belgeselkomedi_Click(object sender, EventArgs e)
        {
            baglan.Open();
            string sorgu = ("Select fdad AS Film_Dizi_Adı, fdtur as Türü, fdimdb as IMDB_Puanı, fdkategori as Kategorisi,fdyil as Çıkış_Yılı,fdkullanicipuan as İzleyen_Puanı from filmdizi where fdtur='Belgesel' AND fdkategori='Komedi' ");
            da = new SqlDataAdapter(sorgu, baglan);
            DataTable dt = new DataTable();
            da.Fill(dt);
            guna2DataGridView1.DataSource = dt;
            baglan.Close();
            belgeselpanel.Visible = false;
        }

        private void belgeseldram_Click(object sender, EventArgs e)
        {
            baglan.Open();
            string sorgu = ("Select fdad AS Film_Dizi_Adı, fdtur as Türü, fdimdb as IMDB_Puanı, fdkategori as Kategorisi,fdyil as Çıkış_Yılı,fdkullanicipuan as İzleyen_Puanı from filmdizi where fdtur='Belgesel' AND fdkategori='Dram' ");
            da = new SqlDataAdapter(sorgu, baglan);
            DataTable dt = new DataTable();
            da.Fill(dt);
            guna2DataGridView1.DataSource = dt;
            baglan.Close();
            belgeselpanel.Visible = false;
        }

        private void belgeselgerilim_Click(object sender, EventArgs e)
        {
            baglan.Open();
            string sorgu = ("Select fdad AS Film_Dizi_Adı, fdtur as Türü, fdimdb as IMDB_Puanı, fdkategori as Kategorisi,fdyil as Çıkış_Yılı,fdkullanicipuan as İzleyen_Puanı from filmdizi where fdtur='Belgesel' AND fdkategori='Gerilim' ");
            da = new SqlDataAdapter(sorgu, baglan);
            DataTable dt = new DataTable();
            da.Fill(dt);
            guna2DataGridView1.DataSource = dt;
            baglan.Close();
            belgeselpanel.Visible = false;
        }

        private void belgeselromantik_Click(object sender, EventArgs e)
        {
            baglan.Open();
            string sorgu = ("Select fdad AS Film_Dizi_Adı, fdtur as Türü, fdimdb as IMDB_Puanı, fdkategori as Kategorisi,fdyil as Çıkış_Yılı,fdkullanicipuan as İzleyen_Puanı from filmdizi where fdtur='Belgesel' AND fdkategori='Romantik' ");
            da = new SqlDataAdapter(sorgu, baglan);
            DataTable dt = new DataTable();
            da.Fill(dt);
            guna2DataGridView1.DataSource = dt;
            baglan.Close();
            belgeselpanel.Visible = false;
        }

        private void sitcomkorku_Click(object sender, EventArgs e)
        {
            baglan.Open();
            string sorgu = ("Select fdad AS Film_Dizi_Adı, fdtur as Türü, fdimdb as IMDB_Puanı, fdkategori as Kategorisi,fdyil as Çıkış_Yılı,fdkullanicipuan as İzleyen_Puanı from filmdizi where fdtur='Sitcom' AND fdkategori='Korku' ");
            da = new SqlDataAdapter(sorgu, baglan);
            DataTable dt = new DataTable();
            da.Fill(dt);
            guna2DataGridView1.DataSource = dt;
            baglan.Close();
            sitcompanel.Visible = false;
        }

        private void sitcomkomedi_Click(object sender, EventArgs e)
        {
            baglan.Open();
            string sorgu = ("Select fdad AS Film_Dizi_Adı, fdtur as Türü, fdimdb as IMDB_Puanı, fdkategori as Kategorisi,fdyil as Çıkış_Yılı,fdkullanicipuan as İzleyen_Puanı from filmdizi where fdtur='Sitcom' AND fdkategori='Komedi' ");
            da = new SqlDataAdapter(sorgu, baglan);
            DataTable dt = new DataTable();
            da.Fill(dt);
            guna2DataGridView1.DataSource = dt;
            baglan.Close();
            sitcompanel.Visible = false;
        }

        private void sitcomdram_Click(object sender, EventArgs e)
        {
            baglan.Open();
            string sorgu = ("Select fdad AS Film_Dizi_Adı, fdtur as Türü, fdimdb as IMDB_Puanı, fdkategori as Kategorisi,fdyil as Çıkış_Yılı,fdkullanicipuan as İzleyen_Puanı from filmdizi where fdtur='Sitcom' AND fdkategori='Dram' ");
            da = new SqlDataAdapter(sorgu, baglan);
            DataTable dt = new DataTable();
            da.Fill(dt);
            guna2DataGridView1.DataSource = dt;
            baglan.Close();
            sitcompanel.Visible = false;
        }

        private void sitcomgerilim_Click(object sender, EventArgs e)
        {
            baglan.Open();
            string sorgu = ("Select fdad AS Film_Dizi_Adı, fdtur as Türü, fdimdb as IMDB_Puanı, fdkategori as Kategorisi,fdyil as Çıkış_Yılı,fdkullanicipuan as İzleyen_Puanı from filmdizi where fdtur='Sitcom' AND fdkategori='Gerilim' ");
            da = new SqlDataAdapter(sorgu, baglan);
            DataTable dt = new DataTable();
            da.Fill(dt);
            guna2DataGridView1.DataSource = dt;
            baglan.Close();
            sitcompanel.Visible = false;
        }

        private void sitcomromantik_Click(object sender, EventArgs e)
        {
            baglan.Open();
            string sorgu = ("Select fdad AS Film_Dizi_Adı, fdtur as Türü, fdimdb as IMDB_Puanı, fdkategori as Kategorisi,fdyil as Çıkış_Yılı,fdkullanicipuan as İzleyen_Puanı from filmdizi where fdtur='Sitcom' AND fdkategori='Romantik' ");
            da = new SqlDataAdapter(sorgu, baglan);
            DataTable dt = new DataTable();
            da.Fill(dt);
            guna2DataGridView1.DataSource = dt;
            baglan.Close();
            sitcompanel.Visible = false;
        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            if (profilpanel.Visible==true)
            {
                profilpanel.Visible = false;
            }
            else
            {
                profilpanel.Visible = true;
            }
            
            
            
        }

        private void guna2ImageButton1_DoubleClick(object sender, EventArgs e)
        {
        
        }

        private void sifredegistir_Click(object sender, EventArgs e)
        {
            this.Hide();
            SifreDegistir sifreDegistir = new SifreDegistir();
            sifreDegistir.Show();
        }

        private void guna2DataGridView1_Click(object sender, EventArgs e)
        {
            

        }

        private void guna2DataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void profilcikis_Click(object sender, EventArgs e)
        {
            Giris giris = new Giris();
            this.Hide();
            giris.Show();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Profil profil = new Profil();
            profil.adi = isim;
            profil.id = id;

            profil.Show();
        }

        private void guna2ShadowPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2DataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void guna2DataGridView1_CellContentDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void guna2DataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void guna2DataGridView1_CellContentDoubleClick_2(object sender, DataGridViewCellEventArgs e)
        {
            fdad = guna2DataGridView1.CurrentRow.Cells[0].Value.ToString();
            fdtur = guna2DataGridView1.CurrentRow.Cells[1].Value.ToString();
            fdkategori = guna2DataGridView1.CurrentRow.Cells[3].Value.ToString();
            fdyil = guna2DataGridView1.CurrentRow.Cells[4].Value.ToString();
            fdkullanicipuan = guna2DataGridView1.CurrentRow.Cells[5].Value.ToString();

            filmdizidetay filmdizidetay = new filmdizidetay();
            filmdizidetay.kullanici_adi = fdad;
            filmdizidetay.turu = fdtur;
            filmdizidetay.kategorisi = fdkategori;
            filmdizidetay.cikisyili = fdyil;
            filmdizidetay.kullanicipuani = fdkullanicipuan;
            this.Hide();
            filmdizidetay.Show();
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
