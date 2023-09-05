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

namespace Staj_Takip_Sistemi
{
    public partial class adminPanel : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;
        SqlConnection baglanti;
        public adminPanel()
        {
            InitializeComponent();
        }

        private void adminPanel_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            adminGiris admingiris = new adminGiris();
            admingiris.Show();
            this.Hide();
        }

        private void minimizeBtn_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                yon2.Visible = true;
                yon3.Visible = true;
                yoneticiEkle.Visible = true;


                yoneticiYazi.Visible = true;
                
                
                yon4.Visible = true;
                yon5.Visible = true;


                personelYazi.Visible = false;

                yoneticiAdTxt.Visible = true;
                yoneticiSoyadTxt.Visible = true;
                yoneticiEpostaTxt.Visible = true;
                yoneticiSifreTxt.Visible = true;

                per2.Visible = false;
                per3.Visible = false;
                per4.Visible = false;
                per5.Visible = false;
                personelAdTxt.Visible = false;
                personelSoyadTxt.Visible = false;
                personelSifreTxt.Visible = false;
                personelNoTxt.Visible = false;

            }
            else if (comboBox1.SelectedIndex == 1)
            {
                per2.Visible = true;
                per3.Visible = true;
                per4.Visible = true;
                per5.Visible = true;


                yoneticiYazi.Visible = false;
                personelYazi.Visible = true;


                personelAdTxt.Visible = true;
                personelSoyadTxt.Visible = true;
                personelSifreTxt.Visible = true;
                personelNoTxt.Visible = true;


                personelEkle.Visible = true;
                yon2.Visible = false;
                yon3.Visible = false;

                yon4.Visible = false;
                yon5.Visible = false;

                yoneticiAdTxt.Visible = false;
                yoneticiSoyadTxt.Visible = false;
                yoneticiEpostaTxt.Visible = false;
                yoneticiSifreTxt.Visible = false;

            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void stajyerAdTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void ekleButton_Click(object sender, EventArgs e)
        {
            string sorgu = "Insert into Personel(personelAd ,personelSoyad ,personelNo , personelSifre) " +
                           "Values (@personelAd , @personelSoyad , @personelNo , @personelSifre)";
            this.con = sqlbaglanti.baglanti;
            con.Open();
            cmd = new SqlCommand(sorgu, con);
            cmd.Parameters.AddWithValue("@personelAd", personelAdTxt.Text);
            cmd.Parameters.AddWithValue("@personelSoyad", personelSoyadTxt.Text);
            cmd.Parameters.AddWithValue("@personelNo", Convert.ToInt32(personelNoTxt.Text));
            cmd.Parameters.AddWithValue("@personelSifre", personelSifreTxt.Text);


            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sorgu = "insert into Yonetici(yoneticiAd , yoneticiSoyad , yoneticiEposta,yoneticiSifre) " +
                          "Values (@yoneticiAd , @yoneticiSoyad , @yoneticiEposta , @yoneticiSifre)";
            this.con = sqlbaglanti.baglanti;
            con.Open();
            cmd = new SqlCommand(sorgu, con);
            cmd.Parameters.AddWithValue("@yoneticiAd", yoneticiAdTxt.Text);
            cmd.Parameters.AddWithValue("@yoneticiSoyad", yoneticiSoyadTxt.Text);
            cmd.Parameters.AddWithValue("@yoneticiEposta", yoneticiEpostaTxt.Text);
            cmd.Parameters.AddWithValue("@yoneticiSifre", yoneticiSifreTxt.Text);


            cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}
