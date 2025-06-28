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

namespace secimGrafikUygulamasi
{
    public partial class OyGirisEkrani : Form
    {
        public OyGirisEkrani()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection(@"Data Source = EXCALIBUR\SQLEXPRESS; Initial Catalog = SecimProjeDB; Integrated Security = True;");

        private void btnOyGirisi_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("INSERT INTO TBLILCE (ilceAd, aParti, bParti, cParti, dParti, eParti) " +
                                                  "VALUES (@P1, @P2, @P3, @P4, @P5, @P6)", baglanti);

                komut.Parameters.AddWithValue("@P1", txtBoxİlceGirin.Text);
                komut.Parameters.AddWithValue("@P2", txtBoxAParti.Text);
                komut.Parameters.AddWithValue("@P3", txtBoxBParti.Text);
                komut.Parameters.AddWithValue("@P4", txtBoxCParti.Text);
                komut.Parameters.AddWithValue("@P5", txtBoxDParti.Text);
                komut.Parameters.AddWithValue("@P6", txtBoxEParti.Text);

                komut.ExecuteNonQuery();
                MessageBox.Show("Oy Girişi Gerçekleşti");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
            finally
            {
                baglanti.Close();
            }
        }

        private void btnGrafikler_Click(object sender, EventArgs e)
        {
            GrafikEkranics grafikEkranics = new GrafikEkranics();
            grafikEkranics.Show();
        }
    }
}
