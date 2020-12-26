using Emgu.CV;
using Emgu.CV.Structure;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AOCI1
{
    public partial class Form1 : Form
    {
        ImageEditor imgEditor = new ImageEditor();
        Image<Bgr, byte> image, defaultImage;
        public Form1()
        {
            InitializeComponent();
            button1.Click += new EventHandler(button1_Click);
            

        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            defaultImage = imgEditor.SetSourceImage(OpenImageFile());
            imgEditor.ShowImage(imageBox1, defaultImage);
            //FillImage2();
        }

        private string OpenImageFile()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Файлы изображений (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif*.png";
            var result = openFileDialog.ShowDialog(); // открытие диалога выбора файла
            if (result == DialogResult.OK) // открытие выбранного файла
            {
                string fileName = openFileDialog.FileName;
                return fileName;
            }
            return null;
        }

        

        
        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void buttonChannel_Click(object sender, EventArgs e)
        {
            if(radioButtonB.Checked)
            {
                image = imgEditor.ReturnColorChannel(defaultImage, "b");
            }
            else if(radioButtonG.Checked)
            {
                image = imgEditor.ReturnColorChannel(defaultImage, "g");
            }
            else if (radioButtonR.Checked)
            {
                image = imgEditor.ReturnColorChannel(defaultImage, "r");
            }
             if(image != null)
            {
                FillImage2();
            }
        }

        

        private void buttonBW_Click(object sender, EventArgs e)
        {
            image = imgEditor.ReturnBW(defaultImage);
            if (image != null)
            {
                FillImage2();
            }
        }

        private void buttonSepia_Click(object sender, EventArgs e)
        {
            image = imgEditor.ReturnSepia(defaultImage);
            if (image != null)
            {
                FillImage2();
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            imgEditor.SetAddtionalImage(OpenImageFile());
            image = imgEditor.ReturnAddition(defaultImage, trackBarCoeff.Value);
            if (image != null)
            {
                FillImage2();
            }
        }

        private void buttonSub_Click(object sender, EventArgs e)
        {
            imgEditor.SetAddtionalImage(OpenImageFile());
            image = imgEditor.ReturnSubstraction(defaultImage);
            if (image != null)
            {
                FillImage2();
            }
        }

        private void buttonIntersect_Click(object sender, EventArgs e)
        {
            imgEditor.SetAddtionalImage(OpenImageFile());
            image = imgEditor.ReturnIntersection(defaultImage);
            if (image != null)
            {
                FillImage2();
            }
        }

        private void trackBarBrightness_Scroll(object sender, EventArgs e)
        {
           
            image = imgEditor.ReturnBrightness(defaultImage, trackBarBrightness.Value*4);
            if (image != null)
            {
                FillImage2();
            }
        }

        private void trackBarContrast_Scroll(object sender, EventArgs e)
        {
            image = imgEditor.ReturnContrast(defaultImage, trackBarContrast.Value);
            if (image != null)
            {
                FillImage2();
            }
        }

        private void trackBarHue_Scroll(object sender, EventArgs e)
        {
            var imageHsv = imgEditor.ReturnH(defaultImage, trackBarHue.Value*25);
            imgEditor.ShowImage(imageBox2, imageHsv);
        }

        private void trackBarSat_Scroll(object sender, EventArgs e)
        {
            var imageHsv = imgEditor.ReturnS(defaultImage, trackBarSat.Value * 25);
            imgEditor.ShowImage(imageBox2, imageHsv);
        }

        private void trackBarValue_Scroll(object sender, EventArgs e)
        {
            var imageHsv = imgEditor.ReturnV(defaultImage, trackBarValue.Value * 25);
            imgEditor.ShowImage(imageBox2, imageHsv);
        }

        private void buttonBlur_Click(object sender, EventArgs e)
        {
            image = imgEditor.ReturnBlur(defaultImage);
            if (image != null)
            {
                FillImage2();
            }
        }

        private void buttonSharpen_Click(object sender, EventArgs e)
        {
            int[,] mat = new int[3, 3] {
                { (int)numericUpDown1.Value, (int)numericUpDown2.Value, (int)numericUpDown3.Value },
                { (int)numericUpDown4.Value, (int)numericUpDown5.Value, (int)numericUpDown6.Value },
                { (int)numericUpDown7.Value, (int)numericUpDown8.Value, (int)numericUpDown9.Value }
            };
            
            image = imgEditor.ReturnSharpen(defaultImage, mat);
            if (image != null)
            {
                FillImage2();
            }
        }

        private void buttonAquarel_Click(object sender, EventArgs e)
        {
            imgEditor.SetAddtionalImage(OpenImageFile());
            image = imgEditor.ReturnAquarel(defaultImage, trackBarBrightness.Value, trackBarContrast.Value, trackBarCoeff.Value);
            if (image != null)
            {
                FillImage2();
            }
        }

        private void trackBarCoeff_Scroll(object sender, EventArgs e)
        {
            image = imgEditor.ReturnAquarel(defaultImage, trackBarBrightness.Value, trackBarContrast.Value, trackBarCoeff.Value);
            if (image != null)
            {
                FillImage2();
            }
        }

        private void buttonCartoon_Click(object sender, EventArgs e)
        {
            image = imgEditor.ReturnCartoon(defaultImage, trackBarCartoon.Value);
            if (image != null)
            {
                FillImage2();
            }
        }

        private void buttonEmbos_Click(object sender, EventArgs e)
        {
            int[,] mat = new int[3, 3]
            {
                {-4, -2, 0 },
                {-2, 1, 2 },
                {0, 2, 4 }
            };
            image = imgEditor.ReturnSharpen(defaultImage, mat);
            if (image != null)
            {
                FillImage2();
            }
        }

        private void buttonEdges_Click(object sender, EventArgs e)
        {
            int[,] mat = new int[3, 3]
            {
                {-1, -1, -1 },
                {-1, 9, -1 },
                {-1, -1, -1 }
            };
            image = imgEditor.ReturnSharpen(defaultImage, mat);
            if (image != null)
            {
                FillImage2();
            }
        }

        private void trackBarCartoon_Scroll(object sender, EventArgs e)
        {
            image = imgEditor.ReturnCartoon(defaultImage, trackBarCartoon.Value);
            if (image != null)
            {
                FillImage2();
            }
        }

        private void matrix1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown7_ValueChanged(object sender, EventArgs e)
        {

        }

        private void FillImage2()
        {
            
            imgEditor.ShowImage(imageBox2, image);
        }

        
    }
}
