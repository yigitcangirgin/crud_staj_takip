using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Staj_Takip_Sistemi.StajProjeDataSet;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Staj_Takip_Sistemi
{
	public partial class stajyerBilgi : Form
	{
        SqlCommand cmd;
        public stajyerBilgi()
		{
			InitializeComponent();
		}
		SqlDataAdapter da;
		DataSet ds;
		SqlCommand komut;
		SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-QFS3MJA\SQLEXPRESS;Initial Catalog=crud;Integrated Security=True");
		private void kayitGetirStajyer()
		{
			baglanti.Open();
			string kayit = "SELECT  s.DepartmanID, s.personelID, s.stajyerNo,  s.bitisTarih , s.baslangicTarih  , s.stajyerSoyad , s.stajyerAd ,s.stajyerID  from Stajyer as s ";
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
		private void exitBtn_Click(object sender, EventArgs e)
		{
			System.Windows.Forms.Application.Exit(); //ekranda sağ üstteki çarpı butonuna basınca ekranı kapatma kodu

		}

		private void minimizeBtn_Click(object sender, EventArgs e)
		{
			WindowState = FormWindowState.Minimized; //ekranda sağ üstte eksi butonuna basınca ekranı alt sekmeye alma kodu
		}

		private void pictureBox3_Click(object sender, EventArgs e)
		{
			personelPanel pPanel = new personelPanel();
			pPanel.Show();
			this.Hide();
		}

		private void pictureBox3_MouseHover(object sender, EventArgs e)
		{
			toolTip1.SetToolTip(pictureBox3, "Geri");
		}

		private void minimizeBtn_MouseHover(object sender, EventArgs e)
		{
			toolTip1.SetToolTip(minimizeBtn, "Küçült");
		}

		private void exitBtn_MouseHover(object sender, EventArgs e)
		{
			toolTip1.SetToolTip(exitBtn, "Kapat");
		}

		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}

		private void stajyerBilgi_Load(object sender, EventArgs e)
		{
			kayitGetirStajyer();
		}

		private void stajyerBtn_Click(object sender, EventArgs e)
		{

		}

		private void stajyerData_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}

		public void stajyerData_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			stajyerIDtxt.Text = stajyerData.Rows[e.RowIndex].Cells[7].Value.ToString();
			stajyerAdTxt.Text = stajyerData.Rows[e.RowIndex].Cells[6].Value.ToString();
			stajyerSoyadTxt.Text = stajyerData.Rows[e.RowIndex].Cells[5].Value.ToString();
			departmanTxt.Text = stajyerData.Rows[e.RowIndex].Cells[0].Value.ToString();
            baslangicTxt.Text = stajyerData.Rows[e.RowIndex].Cells[3].Value.ToString();
            bitisTxt.Text = stajyerData.Rows[e.RowIndex].Cells[4].Value.ToString();
            stajyerNoTxt.Text = stajyerData.Rows[e.RowIndex].Cells[2].Value.ToString();
            personelTxt.Text = stajyerData.Rows[e.RowIndex].Cells[1].Value.ToString();

        }



        private void guncelleButon_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            string sorgu1 = "Update Stajyer set stajyerAd = @stajyerAd , stajyerSoyad = @stajyerSoyad , baslangicTarih = @stajyerBaslangic , bitisTarih = @stajyerBitis , stajyerNo = @stajyerNo  , DepartmanID = @stajyerDepartmanID  where stajyerID= @stajyerID";
            cmd = new SqlCommand(sorgu1, baglanti);
            cmd.Parameters.AddWithValue("@stajyerAd", stajyerAdTxt.Text);
            cmd.Parameters.AddWithValue("@stajyerID", stajyerIDtxt.Text);
            cmd.Parameters.AddWithValue("@stajyerSoyad", stajyerSoyadTxt.Text);
            cmd.Parameters.AddWithValue("@stajyerBaslangic", Convert.ToDateTime(baslangicTxt.Text));
            cmd.Parameters.AddWithValue("@stajyerBitis", Convert.ToDateTime(bitisTxt.Text));
            cmd.Parameters.AddWithValue("@stajyerNo", stajyerNoTxt.Text);
            cmd.Parameters.AddWithValue("@stajyerDepartmanID", departmanTxt.Text);

            cmd.ExecuteNonQuery();
            string kayit = "SELECT  s.DepartmanID, s.personelID, s.stajyerNo, s.baslangicTarih , s.bitisTarih , s.stajyerSoyad , s.stajyerAd ,s.stajyerID  from Stajyer as s ";
            SqlCommand komut = new SqlCommand(kayit, baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            stajyerData.DataSource = dt;



            baglanti.Close();
        }

        private void kayıtsilButon_Click(object sender, EventArgs e)
        {
            baglanti.Open();

            string kayit = "delete from Stajyer where stajyerID = @silID ";
            cmd = new SqlCommand(kayit, baglanti);
            cmd.Parameters.AddWithValue("@silID", stajyerIDtxt.Text);
            cmd.ExecuteNonQuery();
            string kayit1 = "SELECT  s.DepartmanID, s.personelID, s.stajyerNo, s.baslangicTarih , s.bitisTarih , s.stajyerSoyad , s.stajyerAd ,s.stajyerID  from Stajyer as s ";
            SqlCommand komut = new SqlCommand(kayit1, baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            stajyerData.DataSource = dt;

            baglanti.Close();
        }
    }
}
