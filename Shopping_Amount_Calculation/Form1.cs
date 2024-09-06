using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shopping_Amount_Calculation
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{
			int kitap_sayi;
			int fiyat = 8;
		
			double indirimli_fiyat;

			kitap_sayi = Convert.ToInt16(textBox1.Text);

			 if(kitap_sayi >= 0 && kitap_sayi <= 20)
			{
				
				indirimli_fiyat = (kitap_sayi * fiyat)  - (kitap_sayi * fiyat * 0.20);
				label3.Text = indirimli_fiyat.ToString();
			}
		 if (kitap_sayi >= 21 && kitap_sayi <= 40)
			{

				indirimli_fiyat = (kitap_sayi * fiyat) - (kitap_sayi * fiyat * 0.40);
				label3.Text = indirimli_fiyat.ToString();
			}
			if (kitap_sayi >= 41)
			{

				indirimli_fiyat = (kitap_sayi * fiyat) - (kitap_sayi * fiyat * 0.50);
				label3.Text = indirimli_fiyat.ToString();
			}


		}
	}
}
//0-20 ==> %20
//21-40==> %40
//41++==> %50
//kitap=8
