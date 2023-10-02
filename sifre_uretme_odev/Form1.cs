using System.Runtime.InteropServices;
using System.Text;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace sifre_uretme_odev
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void btnUret_Click(object sender, EventArgs e)
        {
            txtSifre.Text = string.Empty;
            Random rnd = new Random();

           if(chcBoxBuyukHarf.Checked==false && chcBoxKucukHarf.Checked==false && chcBoxOzelKarakter.Checked ==false && chcBoxRakam.Checked==false) 
            { 
            MessageBox.Show("B�t�n kutucuklar bo� olamaz!", "HATA" , MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           else 
            {
                string buyukHarfListesi = "ABC�DEFG�HI�JKLMNO�PQRS�TU�VWXYZ";
                string kucukHarfListesi = "abc�defg�h�ijklmno�pqrs�tu�vwxyz";
                string rakamListesi = "0123456789";
                string ozelKarakterListesi = "!@#$%^&*()-_+=<>?";
                string sifre = " ";

                if (chcBoxBuyukHarf.Checked) { sifre += buyukHarfListesi; }
                    
                if (chcBoxKucukHarf.Checked) { sifre += kucukHarfListesi; }
                    
                if (chcBoxRakam.Checked) { sifre += rakamListesi; }

                if (chcBoxOzelKarakter.Checked) { sifre += ozelKarakterListesi; }

                for(int i = 0; i<numSifreUzunlugu.Value; i++) 
                {
                    txtSifre.Text += sifre[rnd.Next(sifre.Length)] ;
                }

            }

        }
    }
}
