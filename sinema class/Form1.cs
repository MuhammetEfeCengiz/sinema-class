using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sinema_class
{
    public partial class Form1 : Form
    {
        bilet b = new bilet();


        public Form1()
        {
            InitializeComponent();

        }

        private void Oluştur_btn_Click(object sender, EventArgs e)
        {

            MessageBox.Show("Başarılı");

            int koltuksayısı= int.Parse(KoltukSayısı_text.Text);
            b.koltuk_sayısı = koltuksayısı;
           
        }

        private void KoltukSorgula_btn_Click(object sender, EventArgs e)
        {


            
            KoltukSorgula_lbl.Text = Convert.ToString(b.koltuk_sayısı);
            if (b.koltuk_sayısı <= 0)
            {
                MessageBox.Show("koltuk Kalmadı");
            }
        }

        private void BiletSat_btn_Click(object sender, EventArgs e)
        {
            b.biletsat();
          
        }

        private void BakiyeSorgula_btn_Click(object sender, EventArgs e)
        {
            BiletSorgula_lbl.Text = Convert.ToString(b.bakiye);
        }

        private void Biletİptal_btn_Click(object sender, EventArgs e)
        {
            b.biletiptal();
        }
    }
}
