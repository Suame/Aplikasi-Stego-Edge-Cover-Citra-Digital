using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;

namespace APLIKASI_STEGO_EDGE_COVER_CITRA_DIGITAL
{
    public class PGMImageIO
    {
        #region Fields
        private String _fileName = null;
        private Bitmap _image = null;
        #endregion

        #region Properties
        public String FileName
        {
            get { return _fileName; }
            set { _fileName = value; }
        }
        public Bitmap Image
        {
            get { return _image; }
            set { _image = value; }
        }
        #endregion

        #region Constructors
        public PGMImageIO(String fileName)
        {
            this._fileName = fileName;
        }
        public PGMImageIO(String fileName, Bitmap image)
        {
            this._fileName = fileName;
            this._image = new Bitmap(image);
        }
        #endregion

        #region interface methods implementation
        /// <summary>
        /// load PGM image
        /// support P2 and P5 format
        /// whitespace limits in ' ' and '\n'
        /// </summary>
        public void LoadImage()
        {
            int width;
            int height;

            // Determine whether ASCII or BINARY PGM file - read 'Magic' number
            FileStream fin = new FileStream(_fileName, FileMode.Open);

            // read in "magic number"
            char[] chReadIn = new char[10];
            for (int i = 0; i < 10; i++)
            {
                chReadIn[i] = Convert.ToChar(fin.ReadByte());
                //iReadInLength ++;
                if ((chReadIn[i] == '\n') || (chReadIn[i] == ' '))
                    break;
            }
            string szMagicNumber = new string(chReadIn);

            // detect the type of PGM file ASCII or BINARY
            char iChar;

            if (Convert.ToChar(fin.ReadByte()) == '#')
            {
                // skip the comment
                do
                    iChar = Convert.ToChar(fin.ReadByte());
                while (iChar != '\n');
            }
            else
            {
                fin.Seek(-1, SeekOrigin.Current);
            }

            // read in Width of image;
            for (int i = 0; i < 10; i++)
                chReadIn[i] = '\0';
            do
                iChar = Convert.ToChar(fin.ReadByte());
            while ((iChar == '\n') || (iChar == ' '));
            fin.Seek(-1, SeekOrigin.Current);
            for (int i = 0; i < 10; i++)
            {
                chReadIn[i] = Convert.ToChar(fin.ReadByte());
                //iReadInLength ++;
                if ((chReadIn[i] == ' ') || (chReadIn[i] == '\n'))
                    break;
            }
            // conver char[] -> string -> int
            string szWidth = new string(chReadIn);
            width = Convert.ToInt32(szWidth);

            // read in Height of image;
            for (int i = 0; i < 10; i++)
                chReadIn[i] = '\0';
            do
                iChar = Convert.ToChar(fin.ReadByte());
            while ((iChar == '\n') || (iChar == ' '));
            fin.Seek(-1, SeekOrigin.Current);
            for (int i = 0; i < 10; i++)
            {
                chReadIn[i] = Convert.ToChar(fin.ReadByte());
                //iReadInLength ++;
                if ((chReadIn[i] == ' ') || (chReadIn[i] == '\n'))
                    break;
            }
            // conver char[] -> string -> int
            string szHeight = new string(chReadIn);
            height = Convert.ToInt32(szHeight);

            // read in the max gray level
            for (int i = 0; i < 10; i++)
                chReadIn[i] = '\0';
            do
                iChar = Convert.ToChar(fin.ReadByte());
            while ((iChar == '\n') || (iChar == ' '));
            fin.Seek(-1, SeekOrigin.Current);
            for (int i = 0; i < 10; i++)
            {
                chReadIn[i] = Convert.ToChar(fin.ReadByte());
                //iReadInLength ++;
                if ((chReadIn[i] == ' ') || (chReadIn[i] == '\n'))
                    break;
            }
            // conver char[] -> string -> int
            string szMaxGrayLevel = new string(chReadIn);
            int MaxGrayLevel = Convert.ToInt32(szMaxGrayLevel);
            if (MaxGrayLevel != 255)
            {
                // only process 8 bits images
                throw new ApplicationException("PGMImageIO::LoadImage(), Can't now handle less than 8 bits images");
            }

            #region P2
            if (szMagicNumber.IndexOf("P2") > -1)
            {
                // ASCII type
                // read in ASCII type image data
                // intialize dest image 24bits RBG Bitmap image
                _image = new Bitmap(width, height, PixelFormat.Format24bppRgb);
                // lock dstImge data
                BitmapData dstData = _image.LockBits(
                    new Rectangle(0, 0, width, height),
                    ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);
                int dstOffset = dstData.Stride - 3 * width;

                // using unsafe code
                unsafe
                {
                    byte* dst = (byte*)dstData.Scan0.ToPointer();
                    for (int y = 0; y < height; y++)
                    {
                        for (int x = 0; x < width; x++, dst += 3)
                        {
                            // read in image data pixel by pixel
                            for (int i = 0; i < 10; i++)
                                chReadIn[i] = '\0';
                            do
                                iChar = Convert.ToChar(fin.ReadByte());
                            while ((iChar == '\n') || (iChar == ' '));
                            fin.Seek(-1, SeekOrigin.Current);
                            for (int i = 0; i < 10; i++)
                            {
                                chReadIn[i] = Convert.ToChar(fin.ReadByte());
                                //iReadInLength ++;
                                if ((chReadIn[i] == ' ') || (chReadIn[i] == '\n'))
                                    break;
                            }
                            // conver char[] -> string -> int
                            string szPixelValue = new string(chReadIn);
                            byte intensity = Convert.ToByte(szPixelValue);
                            *dst = intensity;
                            *(dst + 1) = *dst;
                            *(dst + 2) = *dst;
                        }
                        dst += dstOffset;
                    }
                }
                _image.UnlockBits(dstData);
                // close file stream
                fin.Close();
            }
            #endregion

            #region P5
            else if (szMagicNumber.IndexOf("P5") > -1)
            {
                // BINARY type
                // read in BINARY type image data        
                // read in image data
                _image = new Bitmap(width, height, PixelFormat.Format24bppRgb);
                // lock dstImge data
                BitmapData dstData = _image.LockBits(
                    new Rectangle(0, 0, width, height),
                    ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);
                int dstOffset = dstData.Stride - 3 * width;
                // using unsafe code
                unsafe
                {
                    byte* dst = (byte*)dstData.Scan0.ToPointer();
                    for (int y = 0; y < height; y++)
                    {
                        for (int x = 0; x < width; x++, dst += 3)
                        {
                            // read in image data pixel by pixel
                            byte intensity = Convert.ToByte(fin.ReadByte());
                            *dst = intensity;
                            *(dst + 1) = *dst;
                            *(dst + 2) = *dst;
                        }
                        dst += dstOffset;
                    }
                }
                _image.UnlockBits(dstData);
                // close file stream
                fin.Close();
            }
            #endregion

            else
            {
                // not valid PGM file
                throw new ApplicationException("PGMImageIO::LoadImage(), Not valid PGM file");
            }
        } // LoadImage()
        #endregion
    }
}
