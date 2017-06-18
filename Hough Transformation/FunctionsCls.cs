using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Drawing.Imaging;

namespace Hough_Transformation
{
    class FunctionsCls
    {
        public void invert(Bitmap bmp)
        {
            BitmapData bmData = bmp.LockBits(new Rectangle(0, 0, bmp.Width, bmp.Height),
                ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);
            int stride = bmData.Stride;
            System.IntPtr Scan0 = bmData.Scan0;
            unsafe
            {
                byte* p = (byte*)(void*)Scan0;
                for (int y = 0; y < bmp.Height; y++)
                {
                    for (int x = 0; x < bmp.Width; x++)
                    {
                        p[y * stride + x * 3] = (byte)(255 - p[y * stride + x * 3]);
                        p[y * stride + x * 3 + 1] = (byte)(255 - p[y * stride + x * 3 + 1]);
                        p[y * stride + x * 3 + 2] = (byte)(255 - p[y * stride + x * 3 + 2]);
                    }
                }
            }
            bmp.UnlockBits(bmData);
        }

        public void grayscale(Bitmap bmp)
        {
            BitmapData bmData = bmp.LockBits(new Rectangle(0, 0, bmp.Width, bmp.Height),
                    ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);
            int width = bmp.Width, height = bmp.Height;
            int stride = bmData.Stride;
            System.IntPtr Scan0 = bmData.Scan0;
            unsafe
            {
                byte* p = (byte*)(void*)Scan0;
                for (int y = 0; y < height; y++)
                {
                    for (int x = 0; x < width; x++)
                    {
                        int i = y * stride + x * 3;
                        byte tone = (byte)(0.114 * p[i] + 0.587 * p[i + 1] + 0.299 * p[i + 2]);

                        p[i] = tone;
                        p[i + 1] = tone;
                        p[i + 2] = tone;
                    }
                }
            }
            bmp.UnlockBits(bmData);
        }

        

        public double[,] theta_ro(int xa, int ya, Bitmap bmp) //bmp: O xwros Hough!
        {
            //Kanonika, to plaisio ths eikonas prepei na exei 270 pixels bmp.Width.
            //Gia auto onomasa etsi tis metablhtes a180, a270 .
            int a180 = 2 * bmp.Width / 3;
            int a270 = bmp.Width;

            double[,] theta_ro = new double[a270, 2]; //matrix was just created.
            double theta = -Math.PI / 2;

            //Filling the matrix /w step pi/a180 .
            for (int check = 0; check < a270; check++)
            {
                theta_ro[check, 0] = theta * a180 / Math.PI;
                theta_ro[check, 1] = xa * Math.Cos(theta) + ya * Math.Sin(theta);
                theta += Math.PI / a180;
            }
            return theta_ro;
        }

        public int[,] normalize(int[,] sungi, Bitmap bmp)  //bmp: O xwros Hough!
        {
            //Diairw ka8e timh me thn Max(ro) tou pinaka kai pollaplasiazw me to 255)
            float max = 0;
            for (int x = 0; x < bmp.Width; x++)
            {
                for (int y = 0; y < bmp.Height; y++)
                {
                    if (sungi[x, y] > max) max = sungi[x, y];
                }
            }

            //Dhmiourgia neou pinaka me tis kanonikopoihmenes times
            for (int x = 0; x < bmp.Width; x++)
            {
                for (int y = 0; y < bmp.Height; y++)
                {
                    float nai = 255 * sungi[x, y] / max;
                    sungi[x, y] = (int)Math.Round(nai);
                }
            }
            return sungi;
        }

        public double[,] revMatrix(int tha, int ra, Bitmap bmp, Bitmap bmp2)   //tha = theta alpha, ra = ro alpha, diladi syntetagmenes
        {
            int a180 = 2 * bmp2.Width / 3;
            double[,] x_y = new double[bmp.Width, 2];
            double temp = -Math.PI / 2 + tha * Math.PI / a180;

            ra = (int)Math.Round(bmp2.Height * 0.5) - ra; //Metatrepei tis syntetagmenes tou r se arnhtikes kai 8etikes times.
            double rmax = Math.Sqrt(bmp.Height * bmp.Height + bmp.Width * bmp.Width);
            double raa = (double)ra / bmp2.Height * rmax; //kanonikopoiei to bmp2.Height stis diastaseis gia -rmax, rmax
            raa = raa * 2;

            for (int i = 0; i < bmp.Width; i++)
            {
                x_y[i, 0] = i;
                if (temp == 0) temp = 0.01;
                x_y[i, 1] = (raa - i * Math.Cos(temp)) / Math.Sin(temp);
            }
            return x_y;
        }

    }
}
