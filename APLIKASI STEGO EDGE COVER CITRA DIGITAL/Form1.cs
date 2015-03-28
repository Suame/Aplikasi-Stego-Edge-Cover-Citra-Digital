using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.IO;

namespace APLIKASI_STEGO_EDGE_COVER_CITRA_DIGITAL
{
    public partial class Form1 : Form
    {
        public OpenFileDialog ofd;
        public SaveFileDialog sfd;
        float threshold, c;
        public Form1()
        {
            InitializeComponent();
            ofd = new OpenFileDialog();
            sfd = new SaveFileDialog();
        }

        private float GetThreshold(Bitmap image, int n)
        {
            float tMax = 255F, tMin = 0F, limit = 0.1F * n, tH, tL;
            int nE, diff;
            bool set = false;

            do
            {
                tH = (float)Math.Ceiling((tMax + tMin) / 2F);
                tL = 0.4F * tH;
                Canny CannyData = new Canny(image, tH, tL);
                nE = CannyData.CountEdges();
                diff = nE - n;

                if (diff > limit)
                {
                    tMin = tH;
                }
                else if (diff < 0)
                {
                    tMax = tH;
                }
                else
                {
                    set = true;
                }
            } while (set == false);

            return tH;
        }

        private Bitmap Embed(Bitmap image, string message, int p)
        {
            int l = message.Length;
            int[,] e;
            float tH, tL;
            Canny CannyData;
            Bitmap stegoImage = (Bitmap)image.Clone();
            string binaryMessage = StringToBinary(message);

            //bitand
            BitmapData bitmapData = image.LockBits(new Rectangle(0, 0, image.Width, image.Height),
                                    ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);
            unsafe
            {
                byte* imagePointer = (byte*)bitmapData.Scan0;

                for (int i = 0; i < image.Height; i++)
                {
                    for (int j = 0; j < image.Width; j++)
                    {
                        int x = imagePointer[0];
                        x = x & 252;
                        imagePointer[0] = (byte)x;
                        imagePointer += 3;
                    }
                    imagePointer += bitmapData.Stride - (bitmapData.Width * 3);
                }
            }
            image.UnlockBits(bitmapData);
            //end bitand

            //add length of the message for C bits before the message
            string binaryL = Convert.ToString(l, 2);
            float C = (float)Math.Ceiling(binaryL.Length / 8F);
            c = C;
            string lengthMessage = Convert.ToString(l, 2).PadLeft((int)C * 8, '0');
            binaryMessage = lengthMessage + binaryMessage;
            l = binaryMessage.Length;   //length of the augmented message

            //l is the length of the binary digit from the message
            //l is divided by 2 because 1 pixel holds 2 bits of the message
            tH = GetThreshold(image, (int)Math.Ceiling(l / 2F));
            threshold = tH;
            tL = 0.4F * tH;

            //obtain e: e is edge map obtained by calling canny edge detection algorithm
            CannyData = new Canny(image, tH, tL);
            e = CannyData.EdgeMap;

            //embed message
            int index = 0;

            BitmapData bitmapData1 = stegoImage.LockBits(new Rectangle(0, 0, stegoImage.Width, stegoImage.Height),
                                    ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);
            unsafe
            {
                byte* imagePointer1 = (byte*)bitmapData1.Scan0;

                for (int i = 0; i < e.GetLength(0); i++)
                {
                    for (int j = 0; j < e.GetLength(1); j++)
                    {
                        if (e[i, j] == 255 && index < l)
                        {
                            int x = imagePointer1[0];
                            x = x & 252;

                            if (index == l)
                            {
                                x = (byte)(x + int.Parse(binaryMessage[index] + ""));
                            }
                            else
                            {
                                x = (byte)(x + (2 * int.Parse(binaryMessage[index + 1] + "")) + int.Parse(binaryMessage[index] + ""));
                            }
                            index += 2;
                            imagePointer1[0] = (byte)x;
                            imagePointer1 += 3;
                        }
                    }
                    imagePointer1 += bitmapData1.Stride - (bitmapData1.Width * 3);
                }
            }
            stegoImage.UnlockBits(bitmapData1);
            //end embed message

            return stegoImage;
        }

        private string Extract(Bitmap image, float t, int p)
        {
            Bitmap stegoImage = (Bitmap)image.Clone();

            //bitand
            Bitmap mask = (Bitmap)stegoImage.Clone();
            BitmapData bitmapData = mask.LockBits(new Rectangle(0, 0, mask.Width, mask.Height),
                                    ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);
            unsafe
            {
                byte* imagePointer = (byte*)bitmapData.Scan0;

                for (int i = 0; i < mask.Height; i++)
                {
                    for (int j = 0; j < mask.Width; j++)
                    {
                        int x = imagePointer[0];
                        x = x & 252;
                        imagePointer[0] = (byte)x;
                        imagePointer += 3;
                    }
                    imagePointer += bitmapData.Stride - (bitmapData.Width * 3);
                }
            }
            mask.UnlockBits(bitmapData);
            //end bitand

            float tH = t, tL = 0.4F * tH;
            Canny CannyData = new Canny(mask, tH, tL);
            int[,] e = CannyData.EdgeMap;

            //extract message
            string extractedMessage = "";
            BitmapData bitmapData1 = stegoImage.LockBits(new Rectangle(0, 0, stegoImage.Width, stegoImage.Height),
                                    ImageLockMode.ReadOnly, PixelFormat.Format24bppRgb);
            unsafe
            {
                byte* imagePointer1 = (byte*)bitmapData1.Scan0;

                for (int i = 0; i < e.GetLength(0); i++)
                {
                    for (int j = 0; j < e.GetLength(1); j++)
                    {
                        if (e[i, j] == 255)
                        {
                            int x = imagePointer1[0];
                            byte value = (byte)(x & 3);

                            extractedMessage += (value % 2).ToString() + (value / 2).ToString();

                            imagePointer1 += 3;
                        }
                    }
                    imagePointer1 += bitmapData1.Stride - (bitmapData1.Width * 3);
                }
            }
            stegoImage.UnlockBits(bitmapData1);
            //end extract message

            //extract first 16 bits to get length of the message
            int l = Convert.ToInt32(extractedMessage.Substring(0, (int)c * 8), 2);
            //extract the main message in binary
            //l * 8 because 1 string represents 8 bits
            string binaryMessage = extractedMessage.Substring((int)c * 8, (l * 8));

            return BinaryToString(binaryMessage);
        }

        private string StringToBinary(string data)
        {
            StringBuilder sb = new StringBuilder();

            foreach (char c in data.ToCharArray())
            {
                sb.Append(Convert.ToString(c, 2).PadLeft(8, '0'));
            }
            return sb.ToString();
        }

        private string BinaryToString(string data)
        {
            List<Byte> byteList = new List<byte>();

            for (int i = 0; i < data.Length; i += 8)
            {
                byteList.Add(Convert.ToByte(data.Substring(i, 8), 2));
            }
            return Encoding.ASCII.GetString(byteList.ToArray());
        }

                    
        private void pcBoxOpen_Click(object sender, EventArgs e)
        {
            ofd.FileName = "";
            ofd.Filter = "File Gambar(*.jpg;*.jpeg;*.png,*.bmp,*.pgm)|*.jpg;*.jpeg;*.png;*.bmp;*.pgm";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string extension = Path.GetExtension(ofd.FileName);
                extension = extension.ToLower();

                if (extension == ".pgm")
                {
                    PGMImageIO pgmImageIO = new PGMImageIO(ofd.FileName);
                    pgmImageIO.LoadImage();
                    Bitmap _image = (Bitmap)pgmImageIO.Image.Clone();
                    pcboxCover.Image = _image;
                }
                else
                pcboxCover.Image = new Bitmap(ofd.FileName);
            }            
        }

        private void btnEmbed_Click(object sender, EventArgs e)
        {
            string message = txtBoxEmbedMessage.Text;
            Bitmap image = (Bitmap)pcboxCover.Image;

            Bitmap stegoImage = Embed(image, message, 10);
            
            pcboxEmbedStego.Image = stegoImage;

            sfd.FileName = "Stego Image.png";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                stegoImage.Save(sfd.FileName, ImageFormat.Png);
            }
        }

        private void pcBoxOpenStego_Click(object sender, EventArgs e)
        {
            ofd.FileName = "";
            ofd.Filter = "File Gambar(*.jpg;*.jpeg;*.png,*.bmp)|*.jpg;*.jpeg;*.png;*.bmp";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pcBoxExtractStegoImage.Image = new Bitmap(ofd.FileName);
            } 
        }

        private void btnExtract_Click(object sender, EventArgs e)
        {
            Bitmap stegoImage = (Bitmap)pcBoxExtractStegoImage.Image;

            float tH = threshold;
            string extractedMessage = Extract(stegoImage, tH, 10);
            txtBoxExtractMessage.Text = extractedMessage;
        }     
    }
}
