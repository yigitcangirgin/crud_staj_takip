using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Staj_Takip_Sistemi
{
	public partial class personelPanel : Form
	{
		public personelPanel()
		{
			InitializeComponent();
		}

		private void personelPanel_Load(object sender, EventArgs e)
		{

		}


		private void exitBtn_MouseHover(object sender, EventArgs e)
		{
			toolTip1.SetToolTip(exitBtn, "Kapat");
		}

		private void minimizeBtn_MouseHover(object sender, EventArgs e)
		{
			toolTip1.SetToolTip(minimizeBtn, "Küçült");
		}

		private void pictureBox3_MouseHover(object sender, EventArgs e)
		{
			toolTip1.SetToolTip(pictureBox3, "Geri");
		}

		private void pictureBox3_Click(object sender, EventArgs e)
		{
			kullaniciGiris kGiris = new kullaniciGiris();
			kGiris.Show();
			this.Hide();
		}

		private void exitBtn_Click(object sender, EventArgs e)
		{
			System.Windows.Forms.Application.Exit(); //ekranda sağ üstteki çarpı butonuna basınca ekranı kapatma kodu

		}

		private void minimizeBtn_Click(object sender, EventArgs e)
		{
			WindowState = FormWindowState.Minimized; //ekranda sağ üstte eksi butonuna basınca ekranı alt sekmeye alma kodu
		}

		private void button2_Click(object sender, EventArgs e)
		{
			stajyerBilgi sBilgi = new stajyerBilgi();
			sBilgi.Show();
			this.Hide();
		}

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
