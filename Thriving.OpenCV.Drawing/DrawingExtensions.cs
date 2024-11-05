using System.Drawing;
using System.Runtime.InteropServices;

namespace Thriving.OpenCV
{
    public static class DrawingExtensions
    {
        public static System.Drawing.Bitmap Convert2Bitmap(this CVImage img)
        {
            Bitmap bitmap = new Bitmap(img.Width, img.Height, System.Drawing.Imaging.PixelFormat.Format32bppRgb);
            for (int i = 0; i < img.Width; i++)
            {
                for (int j = 0; j < img.Height; j++)
                {
                    var offst = j * img.Width * img.Channels + i * img.Channels;

                    var b = Marshal.ReadByte(img.Data, offst);
                    var g = Marshal.ReadByte(img.Data, offst + 1);
                    var r = Marshal.ReadByte(img.Data, offst + 2);
                    var color = System.Drawing.Color.FromArgb(r, g, b);
                    bitmap.SetPixel(i, j, color);
                }
            }
            return bitmap;
        }

        public unsafe static CVImage Convert2CVImage(this Bitmap bitmap)
        {
            var data = new byte[bitmap.Width * bitmap.Height * 3];
            for (int i = 0; i < bitmap.Width; i++)
            {
                for (int j = 0; j < bitmap.Height; j++)
                {
                    var color = bitmap.GetPixel(i, j);

                    var index = j * bitmap.Width * 3 + i * 3;
                    data[index] = color.B;
                    data[index + 1] = color.G;
                    data[index + 2] = color.R;
                }
            }
            return CVImage.Create(bitmap.Height, bitmap.Width, 3, data,DataType.CV_8U,  (uint)(bitmap.Width * 3));
        }
    }
}
