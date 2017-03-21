using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageConverter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            imageToByteArray(pictureBox1.Image);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        //private void btn_restoreImage_Click(object sender, EventArgs e)
        //{
        //    SQLConectionHelper sqcH = new SQLConectionHelper();
        //    pbox_previewImage.Image = byteArrayToImage(sqcH.GetImage());
        //}
        void functionBox()
        {
            //tbx_productName.Text = "";
            //tbx_material.Text = "";
            //tbx_stackable.Text = "";
            //tbx_adjustable.Text = "";
            //tbx_price.Text = "";
            //tbx_description.Text = "";
            //tbx_summray.Text = "";
            //tbx_catergory.Text = "";
            //tbx_brand.Text = "";
            //pbox_previewImage.Image = null;
        }
        //imageToByteArray(pbox_previewImage.Image)
        public Image byteArrayToImage(byte[] byteArrayIn)
        {
            MemoryStream ms = new MemoryStream(byteArrayIn);
            Image returnImage = Image.FromStream(ms);
            return returnImage;
        }
        public byte[] imageToByteArray(System.Drawing.Image imageIn)
        {
            MemoryStream ms = new MemoryStream();
            imageIn.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
            var sb = new StringBuilder("new byte[] { ");
            tbOutput.Text = sb.ToString();
            foreach (var b in ms.ToArray())
            {
                tbOutput.Text += b + ", ";
            }
            return ms.ToArray();
        }
    }
}
