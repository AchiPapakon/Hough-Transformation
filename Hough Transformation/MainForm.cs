using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Hough_Transformation
{
    public partial class MainForm : Form
    {
        Bitmap image;
        Bitmap image2;
        Bitmap imgClone;
        Bitmap img2Clone;
        FunctionsCls functions = new FunctionsCls();
        bool opened, houghed, cloning; Bitmap clonage;

        public MainForm()
        {
            InitializeComponent();
        }

        private void openToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Open("nothing");
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Open("gray");
        }
        
        private void MainForm_Load(object sender, EventArgs e)
        {
            lblzero2.Location = new Point(700, pic_R_Theta.Location.Y + pic_R_Theta.Height / 2 - lblzero2.Height / 2);
            lblzero3.Location = new Point(pic_R_Theta.Location.X + pic_R_Theta.Width / 2 - lblzero3.Width / 2, lblpi.Location.Y);
            this.Size = new Size(710, 600);
        }

        private Image CreateBlackness()
        {
            Image canvas = new Bitmap(pic_R_Theta.Width, pic_R_Theta.Height, PixelFormat.Format24bppRgb);
            Graphics.FromImage(canvas).Clear(Color.Black);
            return canvas;
        }

        public void detection(Bitmap bmp, Bitmap bmp2)
        {
            progHough.Visible = true;
            progHough.Maximum = image.Width * image.Height;

            BitmapData bmData = bmp.LockBits(new Rectangle(0, 0, bmp.Width, bmp.Height),
                    ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);
            int width = bmp.Width, height = bmp.Height, stride = bmData.Stride;
            System.IntPtr Scan0 = bmData.Scan0;

            BitmapData bmData2 = bmp2.LockBits(new Rectangle(0, 0, bmp2.Width, bmp2.Height),
                    ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);
            int width2 = bmp2.Width, height2 = bmp2.Height, stride2 = bmData2.Stride;
            System.IntPtr Scan2 = bmData2.Scan0;

            double rmax = Math.Sqrt(height * height + width * width);
                float ratio = (float)(height2 * 0.5 / rmax);
            int[,] norm = new int[width2, height2]; //Autos o pinakas 8a periexei ola ta pixel ths eikonas
                                                    //prin thn kanonikopoihsh
            unsafe
            {
                byte* p = (byte*)(void*)Scan0;
                byte* p2 = (byte*)(void*)Scan2;
                for (int y = 0; y < height; y++)
                {
                    for (int x = 0; x < width; x++)
                    {
                        int i = y * stride + x * 3;
                        if (p[i] != 0) //gia osa pixel den einai mavra.
                        {
                            double[,] arxontas = functions.theta_ro(x, y, bmp2);

                            //Epanalipsi gia ton pinaka
                            for (int k = 0; k < width2; k++)
                            {
                                double ro = arxontas[k, 1], theta = arxontas[k, 0];

                                ro = height2 / 2 - ro * ratio;
                                theta = width2 / 3 + theta;

                                norm[(int)Math.Round(theta), (int)Math.Round(ro)] += p[i];
                                /*
                                int i2 = (int)Math.Round(ro) * stride2 + (int)Math.Round(theta) * 3;
                                p2[i2] = p2[i2 + 1] = p2[i2 + 2] += p[i];*/
                            }
                        }
                        progHough.Value++;
                    }
                }//Edw gemise o pinakas norm[x, y] anti gia thn eikona.
                //Sth synexeia 8a kanonikopoihsw ton norm[x, y] sto [0,255]
                norm = functions.normalize(norm, bmp2);
                for (int y = 0; y < height2; y++)
                {
                    for (int x = 0; x < width2; x++)
                    {
                        int i2 = y * stride2 + x * 3;
                        p2[i2] = p2[i2 + 1] = p2[i2 + 2] = (byte)norm[x, y];
                    }
                }

            }
            bmp.UnlockBits(bmData);
            bmp2.UnlockBits(bmData2);
            progHough.Visible = false;
            progHough.Value = 0;
        }

        private void findHoughTransformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            houghed = true;
            image2 = (Bitmap)CreateBlackness();
            pic_R_Theta.Image = image2;

            detection(image, image2);
            pic_R_Theta.Refresh();
            grpLines.Visible = true;
            lblpi.Location = new Point(pic_R_Theta.Location.X + image2.Size.Width - 13, lblpi.Location.Y);
            panel1.Visible = false;
            this.Size = new Size(1120, 930);
        }

        private void reverse(Bitmap bmp, Bitmap bmp2)
        {
            progHough.Visible = true;
            progHough.Maximum = image2.Width * image2.Height;

            BitmapData bmData = bmp.LockBits(new Rectangle(0, 0, bmp.Width, bmp.Height),
                    ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);
            int width = bmp.Width, height = bmp.Height, stride = bmData.Stride;
            System.IntPtr Scan0 = bmData.Scan0;

            BitmapData bmData2 = bmp2.LockBits(new Rectangle(0, 0, bmp2.Width, bmp2.Height),
                    ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);
            int width2 = bmp2.Width, height2 = bmp2.Height, stride2 = bmData2.Stride;
            System.IntPtr Scan2 = bmData2.Scan0;

            unsafe
            {
                byte* p = (byte*)(void*)Scan0;
                byte* p2 = (byte*)(void*)Scan2;
                for (int y = 0; y < height2; y++)
                {
                    for (int x = 0; x < width2; x++)
                    {
                        int i = y * stride2 + x * 3;
                        if (p2[i] >= nmrLines.Value)
                        {
                            p2[i] = p2[i + 1] = 0; p2[i + 2] = 255; //Zwgrafizw to aspro pixel kokkino sthn bmp2.

                            double[,] queen = functions.revMatrix(x, y, bmp, bmp2);

                            //Epanalipsi gia ton pinaka
                            for (int k = 0; k < width; k++)
                            {
                                double ya = queen[k, 1], xa = queen[k, 0];
                                if (0 < ya && ya < height)
                                {
                                    {
                                        int i2 = (int)Math.Floor(ya) * stride + (int)Math.Floor(xa) * 3;
                                        p[i2] = p[i2 + 1] = 0;
                                        p[i2 + 2] = (byte)255;
                                    }
                                }
                            }
                        }
                        progHough.Value++;
                    }
                }
            }
            bmp.UnlockBits(bmData);
            bmp2.UnlockBits(bmData2);
            progHough.Visible = false;
            progHough.Value = 0;
        }

        private void invertToolStripMenuItem_Click(object sender, EventArgs e)
        {
            functions.invert(image);
            pictureBox1.Refresh();
        }

        private void btnLines_Click(object sender, EventArgs e)
        {
            cloning = true;
            pictureBox1.Image = image;
            pic_R_Theta.Image = image2;

            imgClone = (Bitmap)image.Clone();
            img2Clone = (Bitmap)image2.Clone();
            reverse(imgClone, img2Clone);

            pictureBox1.Image = imgClone;
            pic_R_Theta.Image = img2Clone;

            pictureBox1.Refresh();
            pic_R_Theta.Refresh();
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            float ratio = 1;
            int temp = 50;
            bool here = false;

            if (opened)
            {
                if (cloning) clonage = imgClone;
                else clonage = image;
                if (clonage.Height > pictureBox1.Height)
                {
                    ratio = (float)clonage.Height / pictureBox1.Height;
                    temp = e.X - (pictureBox1.Width - (int)Math.Round(clonage.Width / ratio)) / 2;
                    here = true;
                }
                else if (clonage.Width > pictureBox1.Width)
                {
                    ratio = (float)clonage.Width / pictureBox1.Width;
                    temp = e.Y - (pictureBox1.Height - (int)Math.Round(clonage.Height / ratio)) / 2;
                    here = false;
                }
                else
                {
                    if ((float)clonage.Height / pictureBox1.Height >= (float)clonage.Width / pictureBox1.Width)
                    {
                        ratio = (float)clonage.Height / pictureBox1.Height;
                        temp = e.X - (pictureBox1.Width - (int)Math.Round(clonage.Width / ratio)) / 2;
                        here = true;
                    }
                    else
                    {
                        ratio = (float)clonage.Width / pictureBox1.Width;
                        temp = e.Y - (pictureBox1.Height - (int)Math.Round(clonage.Height / ratio)) / 2;
                        here = false;
                    }
                }
                if (here)
                {
                    if (temp > 0 && temp < clonage.Width / ratio)
                    {
                        toolx.Text = "X: " + temp;
                        tooly.Text = "Y: " + e.Y;
                    }
                    else
                    {
                        toolx.Text = "X: ";
                        tooly.Text = "Y: ";
                    }
                }
                else
                {
                    if (temp > 0 && temp < clonage.Height / ratio)
                    {
                        toolx.Text = "X: " + e.X;
                        tooly.Text = "Y: " + temp;
                    }
                    else
                    {
                        toolx.Text = "X: ";
                        tooly.Text = "Y: ";
                    }
                }
            }
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            if (opened)
            {
                toolx.Text = "X: ";
                tooly.Text = "Y: ";
                toolR.Text = "   ";
            }
        }

        private void pic_R_Theta_MouseMove(object sender, MouseEventArgs e)
        {
            if (houghed)
            {
                toolx.Text = "X: " + e.X;
                tooly.Text = "Y: " + e.Y;
            }
        }

        private void pic_R_Theta_MouseLeave(object sender, EventArgs e)
        {
            if (houghed)
            {
                toolx.Text = "X: ";
                tooly.Text = "Y: ";
            }
        }

        private void Open(string gray)
        {
            openFileDialog1.InitialDirectory = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName;
            openFileDialog1.InitialDirectory += @"\input images";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                opened = true;
                lblx.Visible = lbly.Visible = lblzero1.Visible = true;

                image = new Bitmap(openFileDialog1.FileName);
                pictureBox1.Image = image;
                this.Text = "Hough Trasformation - " + openFileDialog1.FileName;
                if (gray == "gray")
                {
                    functions.grayscale(image);
                }
                pictureBox1.Refresh();

                processingToolStripMenuItem.Enabled = true;
                panel1.Visible = true; grpLines.Visible = false;
                this.Size = new Size(710, 600);
            }
        }

        private void explanationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                @"What my program does:
Hough transformation (output picture) tries to find the straight lines that are contained in the input picture.

The lines found by Hough transformation are always white. My implementation treats the pixels above a set threshold as white.

If you need to find black lines in a white background, select Processing -> Invert.

Hough transformation has an innate weakness finding vertical lines (90 degrees).", "Explanation");
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                @"Made by Achilleas Papakonstantinou
AM: 4666", "About");
        }

        private void grayscaleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            functions.grayscale(image);
            pictureBox1.Refresh();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
