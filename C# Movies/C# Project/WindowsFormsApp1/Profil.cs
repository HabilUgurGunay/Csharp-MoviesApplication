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
    public partial class Profil : Form
    {
        public string adi;
        public string id;

        SqlConnection baglan = new SqlConnection("Data Source=HABILUGUR\\SQLEXPRESS;Initial Catalog=Gorsel-Proje;Integrated Security=True");
        SqlCommand cmd;
        SqlDataReader dr;
        



        public Profil()
        {
            InitializeComponent();
        }

        private void Profil_Load(object sender, EventArgs e)
        {
            kad.Text = adi;
            label7.Text=id;

            cmd = new SqlCommand("SELECT * FROM kullanici WHERE k_adi='" + kad.Text + "' AND k_id='" + label7.Text + "'", baglan);
            baglan.Open();
            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                kad.Text = dr.GetValue(1).ToString();
                ksoyad.Text= dr.GetValue(2).ToString();
                kkad.Text=dr.GetValue(3).ToString();
                kdogum.Text=dr.GetValue(5).ToString();
                kbolge.Text=dr.GetValue(6).ToString();
                kemail.Text=dr.GetValue(10).ToString();

            }
            baglan.Close();
        }

        private void Kapatbuton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
