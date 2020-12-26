using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;
using Emgu.CV.UI;
using Emgu.CV.Util;

namespace AOCI1
{

    class ImageEditor
    {
        private Image<Bgr, byte> sourceImage;
        private Image<Bgr, byte> additionalImage;
        private VideoCapture capture;

        public Image<Bgr, byte> SetSourceImage(string fileName)
        {
            sourceImage = new Image<Bgr, byte>(fileName);
            return sourceImage;
        }

        public Image<Bgr, byte> SetAddtionalImage(string fileName)
        {
            additionalImage = new Image<Bgr, byte>(fileName);
            return additionalImage;
        }

        public void OpenVideo(string fileName)
        {
            capture = new VideoCapture(fileName);

        }

        public Image<Bgr, byte> GetVideoFrame()
        {
            if (capture != null)
            {
                var frame = capture.QueryFrame();
                var image = frame.ToImage<Bgr, byte>();
                return image;
            }
            return null;
        }

        public void ShowImage(ImageBox imageBox, Image<Bgr, byte> image)
        {
            imageBox.Image = image.Resize(imageBox.Width, imageBox.Height, Inter.Linear);
            //imageBox.Image = image.Resize(imageBox.Width, image.Width / imageBox.Width * image.Height, Inter.Linear);
        }

        public void ShowImage(ImageBox imageBox, Image<Hsv, byte> image)
        {
            imageBox.Image = image.Resize(imageBox.Width, imageBox.Height, Inter.Linear);
            //imageBox.Image = image.Resize(imageBox.Width, image.Width / imageBox.Width * image.Height, Inter.Linear);
        }

        public Image<Bgr, byte> EditImage(Image<Bgr, byte> image, double threshold, double linking, int colorCoeff, bool colorEffect, bool canny)
        {
            if (colorEffect == false && canny == false) return image;
            Image<Gray, byte> grayImage = image.Convert<Gray, byte>();
            grayImage = grayImage.PyrDown();
            grayImage = grayImage.PyrUp();
            double cannyThreshold = threshold;
            double cannyThresholdLinking = linking;
            var cannyEdges = grayImage.Canny(cannyThreshold, cannyThresholdLinking);
            var cannyEdgesBgr = cannyEdges.Convert<Bgr, byte>();
            if (canny == true)
            {
                return cannyEdgesBgr;
            }
            cannyEdgesBgr = cannyEdgesBgr.Resize(image.Width, image.Height, Inter.Linear);
            var resultImage = image.Sub(cannyEdgesBgr);
            if (colorEffect == true)
            {
                for (int channel = 0; channel < resultImage.NumberOfChannels; channel++)
                    for (int x = 0; x < resultImage.Width; x++)
                        for (int y = 0; y < resultImage.Height; y++)
                        {
                            byte color = resultImage.Data[y, x, channel];
                            color = Convert.ToByte((int)color / colorCoeff * colorCoeff);
                            resultImage.Data[y, x, channel] = color;
                        }
            }
            return resultImage;
        }

        public Image<Bgr, byte> ReturnColorChannel(Image<Bgr, byte> image, string channelName)
        {
            int channelIndex = 0;
            if (channelName == "r") channelIndex = 2;
            if (channelName == "g") channelIndex = 1;
            if (channelName == "b") channelIndex = 0;
            var channel = sourceImage.Split()[channelIndex];
            VectorOfMat vm = new VectorOfMat();
            for (int i = 0; i < 3; i++)
            {
                if (i == channelIndex)
                {
                    vm.Push(channel);
                }
                else
                {
                    vm.Push(channel.CopyBlank());
                }
            }

            Image<Bgr, byte> destImage = sourceImage.CopyBlank();
            CvInvoke.Merge(vm, destImage);

            return destImage;
        }

        public Image<Bgr, byte> ReturnBW(Image<Bgr, byte> image)
        {
            var grayImage = new Image<Gray, byte>(sourceImage.Size);
            for (int x = 0; x < image.Width; x++)
                for (int y = 0; y < image.Height; y++)
                {
                    grayImage.Data[y, x, 0] = Convert.ToByte(0.299 * image.Data[y, x, 2] + 0.587 *
                    image.Data[y, x, 1] + 0.114 * image.Data[y, x, 0]);
                }

            return grayImage.Convert<Bgr, byte>();
        }

        private double FitsByte(double value)
        {
            if (value > 255) return 255;
            if (value < 0) return 0;
            return value;
        }

        public Image<Bgr, byte> ReturnSepia(Image<Bgr, byte> image)
        {
            for (int x = 0; x < image.Width; x++)
                for (int y = 0; y < image.Height; y++)
                {
                    
                    image.Data[y, x, 2] = Convert.ToByte(FitsByte(0.393 * image.Data[y, x, 2] + 0.769 * image.Data[y, x, 1] + 0.189 * image.Data[y, x, 0]));
                    image.Data[y, x, 1] = Convert.ToByte(FitsByte(0.349 * image.Data[y, x, 2] + 0.686 * image.Data[y, x, 1] + 0.168 * image.Data[y, x, 0]));
                    image.Data[y, x, 0] = Convert.ToByte(FitsByte(0.272 * image.Data[y, x, 2] + 0.534 * image.Data[y, x, 1] + 0.131 * image.Data[y, x, 0]));
                }
            return image;
        }

        public Image<Bgr, byte> ReturnContrast(Image<Bgr, byte> image, int contrast)
        {
            var resultImage = image.Copy();
            for (int x = 0; x < image.Width; x++)
                for (int y = 0; y < image.Height; y++)
                {

                    resultImage.Data[y, x, 2] = Convert.ToByte(FitsByte(image.Data[y, x, 2] * contrast));
                    resultImage.Data[y, x, 1] = Convert.ToByte(FitsByte(image.Data[y, x, 1] * contrast));
                    resultImage.Data[y, x, 0] = Convert.ToByte(FitsByte(image.Data[y, x, 0] * contrast));
                }
            return resultImage;
        }

        public Image<Bgr, byte> ReturnBrightness(Image<Bgr, byte> image, int brightness)
        {
            var resultImage = image.Copy();
            for (int x = 0; x < image.Width; x++)
                for (int y = 0; y < image.Height; y++)
                {

                    resultImage.Data[y, x, 2] = Convert.ToByte(FitsByte(image.Data[y, x, 2] + brightness));
                    resultImage.Data[y, x, 1] = Convert.ToByte(FitsByte(image.Data[y, x, 1] + brightness));
                    resultImage.Data[y, x, 0] = Convert.ToByte(FitsByte(image.Data[y, x, 0] + brightness));
                }
            return resultImage;
        }

        public Image<Bgr, byte> ReturnAddition(Image<Bgr, byte> image, double coeff)
        {
            var resultImage = image.Copy();
            additionalImage = additionalImage.Resize(image.Width, image.Height, Inter.Linear);
            coeff /= 10;

            for (int x = 0; x < image.Width; x++)
                for (int y = 0; y < image.Height; y++)
                {

                    resultImage.Data[y, x, 2] = Convert.ToByte(FitsByte(image.Data[y, x, 2] * coeff + additionalImage.Data[y, x, 2] * (1 - coeff)));
                    resultImage.Data[y, x, 1] = Convert.ToByte(FitsByte(image.Data[y, x, 1] * coeff + additionalImage.Data[y, x, 1] * (1 - coeff)));
                    resultImage.Data[y, x, 0] = Convert.ToByte(FitsByte(image.Data[y, x, 0] * coeff + additionalImage.Data[y, x, 0] * (1 - coeff)));
                }
            return resultImage;
        }

        public Image<Bgr, byte> ReturnSubstraction(Image<Bgr, byte> image)
        {
            var resultImage = image.Copy();
            additionalImage = additionalImage.Resize(image.Width, image.Height, Inter.Linear);
            for (int x = 0; x < image.Width; x++)
                for (int y = 0; y < image.Height; y++)
                {
                    bool isWhite = true;
                    for (int channel = 0; channel < 3; channel++)
                    {
                        if (additionalImage.Data[y, x, channel] < 250)
                        {
                            isWhite = false;
                        }
                    }
                    if (isWhite)
                    {
                        resultImage.Data[y, x, 0] = 0;
                        resultImage.Data[y, x, 1] = 0;
                        resultImage.Data[y, x, 2] = 0;
                    }
                }
            return resultImage;
        }

        public Image<Bgr, byte> ReturnIntersection(Image<Bgr, byte> image)
        {
            var resultImage = image.Copy();
            additionalImage = additionalImage.Resize(image.Width, image.Height, Inter.Linear);
            for (int x = 0; x < image.Width; x++)
                for (int y = 0; y < image.Height; y++)
                {
                    bool isBlack = true;
                    for(int channel = 0; channel<3; channel++)
                    {
                        if(additionalImage.Data[y,x,channel] > 10)
                        {
                            isBlack = false;
                        }
                    }
                    if(isBlack)
                    {
                        resultImage.Data[y, x, 0] = 0;
                        resultImage.Data[y, x, 1] = 0;
                        resultImage.Data[y, x, 2] = 0;
                    }
                }
            return resultImage;
        }

        public Image<Hsv, byte> ReturnH(Image<Bgr, byte> image, int hue)
        {
            var hsvImage = image.Convert<Hsv, byte>();
            for (int y = 0; y < hsvImage.Height; y++)
                for (int x = 0; x < hsvImage.Width; x++)
                {
                    hsvImage.Data[y, x, 0] = Convert.ToByte(hue);
                }
            
            return hsvImage;
        }

        public Image<Hsv, byte> ReturnS(Image<Bgr, byte> image, int saturation)
        {
            var hsvImage = image.Convert<Hsv, byte>();
            for (int y = 0; y < hsvImage.Height; y++)
                for (int x = 0; x < hsvImage.Width; x++)
                {
                    hsvImage.Data[y, x, 1] = Convert.ToByte(saturation);
                }

            return hsvImage;
        }

        public Image<Hsv, byte> ReturnV(Image<Bgr, byte> image,int value)
        {
            var hsvImage = image.Convert<Hsv, byte>();
            for (int y = 0; y < hsvImage.Height; y++)
                for (int x = 0; x < hsvImage.Width; x++)
                {
                    hsvImage.Data[y, x, 2] = Convert.ToByte(value);
                }

            return hsvImage;
        }

        public Image<Bgr, byte> ReturnBlur(Image<Bgr, byte> image)
        {
            var grayImage = image.Convert<Gray, byte>();
            List<byte> list = new List<byte>();
            int sh = 4;
            int N = 9;

            for(int y = sh; y < grayImage.Height-sh; y++)
                for(int x = sh; x< grayImage.Width-sh; x++)
                {
                    list.Clear();
                    for(int i = -1; i < 2; i++)
                        for(int j = -1; j < 2; j++)
                        {
                            list.Add(grayImage.Data[i + y, j + x, 0]);
                        }
                    list.Sort();
                    grayImage.Data[y, x, 0] = list[N / 2];

                }
            image = grayImage.Convert<Bgr, byte>();
            return image;
        }

        public Image<Bgr, byte> ReturnSharpen(Image<Bgr, byte> image, int[,] mat)
        {
            var grayImage = image.Convert<Gray, byte>();
            var result = grayImage.CopyBlank();
            

            for (int y = 1; y < grayImage.Height - 1; y++)
                for (int x = 1; x < grayImage.Width - 1; x++)
                {
                    int res = 0;
                    for (int i = -1; i < 2; i++)
                        for (int j = -1; j < 2; j++)
                        {
                            res += grayImage.Data[i + y, j + x, 0] * mat[i + 1, j + 1];
                        }
                    if (res > 255) res = 255;
                    if (res < 0) res = 0;
                    result.Data[y, x, 0] = (byte)res;

                }
            image = result.Convert<Bgr, byte>();
            return image;
        }

        public Image<Bgr, byte> ReturnAquarel(Image<Bgr, byte> image, int brightness, int contrast, double coeff)
        {
            additionalImage = additionalImage.Resize(image.Width, image.Height, Inter.Linear);
            var resultImage = image.Copy();
            resultImage = ReturnBrightness(image, brightness);
            resultImage = ReturnContrast(resultImage, contrast);
            resultImage = ReturnAddition(resultImage, coeff);
            return resultImage;
        }

        public Image<Bgr, byte> ReturnCartoon(Image<Bgr, byte> image, double coeff)
        {
            //additionalImage = additionalImage.Resize(image.Width, image.Height, Inter.Linear);
            var resultImage = image.Copy();
            var edges = sourceImage.Convert<Gray, byte>();
            edges = edges.ThresholdBinaryInv(new Gray(100),new Gray(255));
            additionalImage = edges.Convert<Bgr, byte>();
            resultImage = ReturnAddition(resultImage, coeff);
            return resultImage;
        }
    }
}
