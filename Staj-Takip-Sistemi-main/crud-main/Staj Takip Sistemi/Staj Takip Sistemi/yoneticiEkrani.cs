﻿using System;
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
    public partial class yoneticiEkrani : Form
    {
        public yoneticiEkrani()
        {
            InitializeComponent();
        }
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-QFS3MJA\SQLEXPRESS;Initial Catalog=""crud"";Integrated Security=True");
        private void lblmesaj_Click(object sender, EventArgs e)
        {

        }
        private void kayitGetirStajyer()
        {
            baglanti.Open();
            string kayit = "SELECT  s.DepartmanID, s.personelID, s.stajyerNo,  s.bitisTarih , s.baslangicTarih  , s.stajyerSoyad , s.stajyerAd ,s.stajyerID  from Stajyer as s WITH(NOLOCK) ";
            //musteriler tablosundaki tüm kayıtları çekecek olan sql sorgusu.
            SqlCommand komut = new SqlCommand(kayit, baglanti);
            //Sorgumuzu ve baglantimizi parametre olarak alan bir SqlCommand nesnesi oluşturuyoruz.
            SqlDataAdapter da = new SqlDataAdapter(komut);
            //SqlDataAdapter sınıfı verilerin databaseden aktarılması işlemini gerçekleştirir.
            DataTable dt = new DataTable();
            da.Fill(dt);
            //Bir DataTable oluşturarak DataAdapter ile getirilen verileri tablo içerisine dolduruyoruz.
            stajyerData.DataSource = dt;
            //Formumuzdaki DataGridViewin veri kaynağını oluşturduğumuz tablo olarak gösteriyoruz.
            baglanti.Close();
        }
        private void kayıtsilButon_Click(object sender, EventArgs e)
        {
            baglanti.Open();

            string kayit = "delete from Stajyer WITH(NOLOCK) where stajyerID = @silID ";
            cmd = new SqlCommand(kayit, baglanti);
            cmd.Parameters.AddWithValue("@silID", stajyerIDtxt.Text);
            cmd.ExecuteNonQuery();
            baglanti.Close();
            kayitGetirStajyer();
            MessageBox.Show("Kayıt Silindi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void yoneticiEkrani_Load(object sender, EventArgs e)
        {
            saatlabel.Text = DateTime.Now.ToLongDateString();  
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}
