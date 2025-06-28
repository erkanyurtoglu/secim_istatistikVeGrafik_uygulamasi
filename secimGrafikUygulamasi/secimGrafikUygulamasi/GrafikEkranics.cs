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
using Microsoft.SqlServer.Server;

namespace secimGrafikUygulamasi
{
    public partial class GrafikEkranics : Form
    {
        public GrafikEkranics()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection(@"Data Source = EXCALIBUR\SQLEXPRESS; Initial Catalog = SecimProjeDB; Integrated Security = True;");

        private void grpBoxİlceDegerleri_Enter(object sender, EventArgs e)
        {

        }

        private void GrafikEkranics_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select ilceAd from TBLILCE", baglanti);
            SqlDataReader rdr = komut.ExecuteReader();

            while (rdr.Read())
            {
                cmbBoxİlceSec.Items.Add(rdr[0]);
            }
            baglanti.Close();

            //Grafiğe Toplam Sonuçları Getirme
            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("Select SUM(aParti), SUM(bParti), SUM(cParti), SUM(dParti), SUM(eParti) " +
                "From TBLILCE", baglanti);

            SqlDataReader rdr2 = komut2.ExecuteReader();

            while (rdr2.Read())
            {
                chart1.Series["Partiler"].Points.AddXY("A Parti", rdr2[0]);
                chart1.Series["Partiler"].Points.AddXY("B Parti", rdr2[1]);
                chart1.Series["Partiler"].Points.AddXY("C Parti", rdr2[2]);
                chart1.Series["Partiler"].Points.AddXY("D Parti", rdr2[3]);
                chart1.Series["Partiler"].Points.AddXY("E Parti", rdr2[4]);
            }

            baglanti.Close();


        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void cmbBoxİlceSec_SelectedIndexChanged(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut3 = new SqlCommand("Select * From TBLILCE Where ilceAd=@P1", baglanti);
            komut3.Parameters.AddWithValue("@P1", cmbBoxİlceSec.Text);
            SqlDataReader rdr = komut3.ExecuteReader();
            while (rdr.Read())
            { 
                progressBar1.Value = int.Parse(rdr[2].ToString());
                progressBar2.Value = int.Parse(rdr[3].ToString());
                progressBar3.Value = int.Parse(rdr[4].ToString());
                progressBar4.Value = int.Parse(rdr[5].ToString());
                progressBar5.Value = int.Parse(rdr[6].ToString());

                label7.Text = rdr[2].ToString();
                label8.Text = rdr[3].ToString();
                label9.Text = rdr[4].ToString();
                label10.Text = rdr[5].ToString();
                label11.Text = rdr[6].ToString();
            }

            baglanti.Close();
        }
    }
}
