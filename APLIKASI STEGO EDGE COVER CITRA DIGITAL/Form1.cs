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
        float threshold;
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
                tH = (float)Math.Floor((tMax + tMin) / 2F);
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
            Bitmap e;
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
                        int x = (int)((imagePointer[0] + imagePointer[1] + imagePointer[2]) / 3);
                        x = x & 252;
                        imagePointer[0] = (byte)x;
                        imagePointer[1] = (byte)x;
                        imagePointer[2] = (byte)x;
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
            e = CannyData.DisplayImage(CannyData.EdgeMap);
            
            //shuffle e and stegoImage using stego key P
            randomPermute permute = new randomPermute(p);
            randomPermute permute1 = new randomPermute(p);
            e = permute.Encrypt(e);
            stegoImage = permute1.Encrypt(stegoImage);

            //embed message
            int index = 0;

            BitmapData bitmapData1 = stegoImage.LockBits(new Rectangle(0, 0, stegoImage.Width, stegoImage.Height),
                                    ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);
            unsafe
            {
                byte* imagePointer1 = (byte*)bitmapData1.Scan0;

                for (int i = 0; i < e.Height; i++)
                {
                    for (int j = 0; j < e.Width; j++)
                    {
                        int grey = (int)((e.GetPixel(j, i).R + e.GetPixel(j, i).G + e.GetPixel(j, i).B) / 3);
                        if (grey == 255 && index < l)
                        {
                            int x = (int)((imagePointer1[0] + imagePointer1[1] + imagePointer1[2]) / 3);
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
                            imagePointer1[1] = (byte)x;
                            imagePointer1[2] = (byte)x;
                            imagePointer1 += 3;
                        }
                    }
                    imagePointer1 += bitmapData1.Stride - (bitmapData1.Width * 3);
                }
            }
            stegoImage.UnlockBits(bitmapData1);
            //end embed message

            //reshuffle stegoImage to get stego image
            stegoImage = permute1.Decrypt(stegoImage);

            /*
            CannyData = new Canny(stegoImage, 0.1F, 0F);
            e = CannyData.EdgeMap;
            pictureBox2.Image = CannyData.DisplayImage(e);

            index = 0;

            BitmapData bitmapData2 = stegoImage.LockBits(new Rectangle(0, 0, stegoImage.Width, stegoImage.Height),
                                    ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);
            unsafe
            {
                byte* imagePointer2 = (byte*)bitmapData2.Scan0;

                for (int i = 0; i < e.GetLength(1); i++)
                {
                    for (int j = 0; j < e.GetLength(0); j++)
                    {
                        if (e[j, i] == 0 && index < 16)
                        {
                            int x = imagePointer2[0];
                            x = x & 254;
                            MessageBox.Show("Non-edge ke : " + index.ToString() + " " + j.ToString() + " " + i.ToString() + " " + e[j, i].ToString());
                            index++;
                            imagePointer2[0] = (byte)x;
                            imagePointer2 += 3;
                        }
                        else if (e[j, i] == 0 && index >= 16 && index < 32)
                        {
                            int x = imagePointer2[0];
                            x = x & 254;

                            MessageBox.Show("Non-edge ke : " + index.ToString() + " " + j.ToString() + " " + i.ToString() + " " + e[j, i].ToString());
                            index++;
                            imagePointer2[0] = (byte)x;
                            imagePointer2 += 3;
                        }
                        else
                            break;
                    }
                    imagePointer2 += bitmapData2.Stride - (bitmapData2.Width * 3);
                }
            }
            stegoImage.UnlockBits(bitmapData2);
            */

            return stegoImage;
        }
        
        private string Extract(Bitmap image, float t, int p)
        {
            Canny CannyData;
            Bitmap e;
            Bitmap stegoImage = (Bitmap)image.Clone();
            Bitmap mask = (Bitmap)stegoImage.Clone();

            
            //bitand
            BitmapData bitmapData = mask.LockBits(new Rectangle(0, 0, mask.Width, mask.Height),
                                    ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);
            unsafe
            {
                byte* imagePointer = (byte*)bitmapData.Scan0;

                for (int i = 0; i < mask.Height; i++)
                {
                    for (int j = 0; j < mask.Width; j++)
                    {
                        int x = (int)((imagePointer[0] + imagePointer[1] + imagePointer[2]) / 3);
                        x = x & 252;
                        imagePointer[0] = (byte)x;
                        imagePointer[1] = (byte)x;
                        imagePointer[2] = (byte)x;
                        imagePointer += 3;
                    }
                    imagePointer += bitmapData.Stride - (bitmapData.Width * 3);
                }
            }
            mask.UnlockBits(bitmapData);
            //end bitand
            /*
            CannyData = new Canny(mask, 0.1F, 0F);
            e = CannyData.EdgeMap;
            pictureBox3.Image = CannyData.DisplayImage(e);

            int index = 0;

            BitmapData bitmapData2 = mask.LockBits(new Rectangle(0, 0, mask.Width, mask.Height),
                                    ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);
            unsafe
            {
                byte* imagePointer2 = (byte*)bitmapData2.Scan0;

                for (int i = 0; i < e.GetLength(1); i++)
                {
                    for (int j = 0; j < e.GetLength(0); j++)
                    {
                        if (e[j, i] == 0 && index < 16)
                        {
                            int x = imagePointer2[0];
                            x = x & 1;

                            MessageBox.Show("Non-edge ke : " + index.ToString() + " " + j.ToString() + " " + i.ToString() + " " + e[j, i].ToString());
                            index++;
                            imagePointer2[0] = (byte)x;
                            imagePointer2 += 3;
                        }
                        else if (e[j, i] == 0 && index >= 16 && index < 32)
                        {
                            int x = imagePointer2[0];
                            x = x & 1;

                            MessageBox.Show("Non-edge ke : " + index.ToString() + " " + j.ToString() + " " + i.ToString() + " " + e[j, i].ToString());
                            index++;
                            imagePointer2[0] = (byte)x;
                            imagePointer2 += 3;
                        }
                        else
                            break;
                    }
                    imagePointer2 += bitmapData2.Stride - (bitmapData2.Width * 3);
                }
            }
            mask.UnlockBits(bitmapData2);
            */
            float tH = t, tL = 0.4F * tH;
            CannyData = new Canny(mask, tH, tL);
            e = CannyData.DisplayImage(CannyData.EdgeMap);
            int edge = CannyData.CountEdges();

            //shuffle stegoImage to get order of embedding
            randomPermute permute = new randomPermute(p);
            randomPermute permute1 = new randomPermute(p);
            e = permute.Encrypt(e);
            stegoImage = permute1.Encrypt(stegoImage);

            //extract message
            string extractedMessage = "";
            BitmapData bitmapData1 = stegoImage.LockBits(new Rectangle(0, 0, stegoImage.Width, stegoImage.Height),
                                    ImageLockMode.ReadOnly, PixelFormat.Format24bppRgb);
            unsafe
            {
                byte* imagePointer1 = (byte*)bitmapData1.Scan0;

                for (int i = 0; i < e.Height; i++)
                {
                    for (int j = 0; j < e.Width; j++)
                    {
                        int grey = (int)((e.GetPixel(j, i).R + e.GetPixel(j, i).G + e.GetPixel(j, i).B) / 3);
                        if (grey == 255)
                        {
                            int x = (int)((imagePointer1[0] + imagePointer1[1] + imagePointer1[2]) / 3);
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

            string binaryC = Convert.ToString((int)((edge - (edge * 0.1F)) / 4F), 2);
            int c = (int)Math.Ceiling(binaryC.Length / 8F);

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
            ofd.Filter = "File Gambar(*.png,*.bmp,*.pgm)|*.png;*.bmp;*.pgm";
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
            ALFG prng = new ALFG(11);
            int p = prng.PRNG(5, 7, 2);

            Bitmap stegoImage = Embed(image, message, p);

            txtBoxStegoKey.Text = p.ToString();
            pcboxEmbedStego.Image = stegoImage;
        }

        private void pcBoxSave_Click(object sender, EventArgs e)
        {
            Bitmap stegoImage = (Bitmap)pcboxEmbedStego.Image;
            string p = txtBoxStegoKey.Text;

            sfd.FileName = "Stego Image " + p + ".png";
            sfd.Filter = "File Gambar(*.png)|*.png";
            if (sfd.ShowDialog() == DialogResult.OK)
            {

                stegoImage.Save(sfd.FileName, ImageFormat.Png);
            }
        }

        private void btnResetEmbed_Click(object sender, EventArgs e)
        {
            txtBoxEmbedMessage.Text = "";
            txtBoxStegoKey.Text = "";
            pcboxCover.Image = null;
            pcboxEmbedStego.Image = null;
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
            ALFG prng = new ALFG(11);
            int p = prng.PRNG(5, 7, 2);
            float tH = threshold;

            string extractedMessage = Extract(stegoImage, tH, p);
            txtBoxExtractMessage.Text = extractedMessage;
        }

        private void btnResetExtract_Click(object sender, EventArgs e)
        {
            txtBoxKey.Text = "";
            txtBoxExtractMessage.Text = "";
            pcBoxExtractStegoImage.Image = null;
        }
            
    }
}