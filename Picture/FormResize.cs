using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Picture
{
    public partial class PhotoSharp : Form
    {
        Bitmap bmp;
        string text_scale;

        public PhotoSharp()
        {
            InitializeComponent();
            LoadPicture("aperture-25.jpg");
            text_scale = labelScale.Text;
            TextChanges();
        }

        private void buttonOpenPicture_Click(object sender, EventArgs e)
        {
            
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.InitialDirectory = Environment.CurrentDirectory;
            DialogResult result = ofd.ShowDialog();
            LoadPicture(ofd.FileName);
        }

        public void LoadPicture(string filename)
        {

            try
            {
                bmp = new Bitmap(Image.FromFile(filename));
                textBoxFileName.Text = filename;
                picture.Image = bmp;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                textBoxFileName.Text = "";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBoxMethod.SelectedIndex == 0)
                ResizeNearest();
            else
                if (comboBoxMethod.SelectedIndex == 1)
                ResizeBilinear();
        }

        public void ResizeNearest()
        {
            float coeff = trackBarScale.Value / 100.0f;
            int oldWidth = bmp.Width;
            int oldHeight = bmp.Height;
            int newWidth = Convert.ToInt16(oldWidth * coeff);
            int newHeight = Convert.ToInt16(oldHeight * coeff);

            float coWidth = (float)(oldWidth - 1) / (float)(newWidth - 1);
            float coHeigth = (float)(oldHeight - 1) / (float)(newHeight - 1);

            Bitmap res = new Bitmap(newWidth, newHeight);
            int x0, y0;
            for (int y = 0; y < newHeight; y++)
            {
                y0 = Convert.ToInt16(y * coHeigth);
                for (int x = 0; x < newWidth; x++)
                {
                    x0 = Convert.ToInt16(x * coWidth);
                    Color pixel = bmp.GetPixel(x0, y0);
                    res.SetPixel(x, y, pixel);
                }
            }
            picture.Image = res;
        }

        public void ResizeBilinear()
        {
            float coeff = trackBarScale.Value / 100.0f;
            int oldWidth = bmp.Width;
            int oldHeight = bmp.Height;
            int newWidth = Convert.ToInt16(oldWidth * coeff);
            int newHeight = Convert.ToInt16(oldHeight * coeff);

            float coWidth = (float)(oldWidth - 1) / (float)(newWidth - 1);
            float coHeigth = (float)(oldHeight - 1) / (float)(newHeight - 1);

            Bitmap res = new Bitmap(newWidth, newHeight);
            float x, y;
            int x1, y1;
            int x2, y2;
            for (int newY = 0; newY < newHeight; newY++)
            {               
                for (int newX = 0; newX < newWidth; newX++)
                {
                    x = newX * coWidth;
                    y = newY * coHeigth;
                    x1 = Convert.ToInt16(Math.Floor(x));
                    y1 = Convert.ToInt16(Math.Floor(y));
                    if (x1 > oldWidth - 2) x1 = oldWidth - 2;
                    if (y1 > oldHeight - 2) y1 = oldHeight - 2;
                    x2 = x1 + 1;
                    y2 = y1 + 1;

                    Color Q11 = bmp.GetPixel(x1, y1);
                    Color Q12 = bmp.GetPixel(x1, y2);
                    Color Q21 = bmp.GetPixel(x2, y1);
                    Color Q22 = bmp.GetPixel(x2, y2);
                    int R = BilinearValue(x, y, x1, y1, x2, y2, Q11.R, Q21.R, Q22.R);
                    int G = BilinearValue(x, y, x1, y1, x2, y2, Q11.G, Q21.G, Q22.G);
                    int B = BilinearValue(x, y, x1, y1, x2, y2, Q11.B, Q21.B, Q22.B);
                    Color pixel = Color.FromArgb(R, G, B);
                    res.SetPixel(newX, newY, pixel);
                }
            }
            picture.Image = res;
        }

        private static int BilinearValue(float x, float y, int x1, int y1, int x2, int y2, 
            int Q11, int Q21, int Q22)
        {
            int R1;
            int R2;
            int P;
            R1 = Convert.ToInt16((x2 - x1) * Q11 + (x - x1) * Q21);
            R2 = Convert.ToInt16((x2 - x) * Q11 + (x - x1) * Q22);
            P = Convert.ToInt16((y2 - y) * R1 + (y - y1) * R2);
            if (P < 0) P = 0;
            if (P > 255) P = 255;
            return P;
        }

        private void TextChanges()
        {
            labelScale.Text = text_scale + " " + trackBarScale.Value.ToString() + "%";
        }

        private void trackBarScale_Scroll(object sender, EventArgs e)
        {
            TextChanges();
        }

        
    }
}
