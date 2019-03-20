using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace qrCreateZen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOlustur_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtValue.Text))
                {
                    MessageBox.Show("LÜTFEN GEÇERLİ BİR TEXT DEĞERİ GİRİNİZ");
                    txtValue.Focus();
                    return;
                }

                // Barkodu pictureboxta gösterebilmek için
                Zen.Barcode.CodeQrBarcodeDraw qrCode = Zen.Barcode.BarcodeDrawFactory.CodeQr;
                pcQR.Image = qrCode.Draw(txtValue.Text, 50);
                pcQR.SizeMode = PictureBoxSizeMode.StretchImage;


            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.StackTrace);
            }

        }

        private void txtValue_KeyDown(object sender, KeyEventArgs e)
        {
            try {
                if (e.KeyCode == Keys.Enter)
                    btnOlustur.PerformClick();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.StackTrace);
            }    
        }

        private void btnMasaustuKaydet_Click(object sender, EventArgs e)
        {
            MessageBox.Show("YAPIM AŞAMASINDADIR");
        }
    }
}
