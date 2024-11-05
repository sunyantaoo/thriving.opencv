using System.Runtime.InteropServices;
using Thriving.OpenCV;

namespace Thriving.Proxy.Test
{
    public class OpenCVTest
    {
        [Fact]
        public void TestMethod1()
        {
            var image =  CVImage.Read(@"D:\PixPin_2024-06-21_17-36-58.jpg", ImreadMode.IMREAD_COLOR);
            var data = image.Data;
            Assert.True(image.Height > 0);
            Assert.True(image.Width > 0);

            var size = image.Width * image.Height * image.Channels;
            var datas = new byte[size];

            Assert.False(image.IsEmpty());
            for (int i = 0; i < size; i++)
            {
                var intptr = data + i * Marshal.SizeOf<byte>();
                datas[i] = Marshal.ReadByte(intptr);
            }
            Assert.Null(datas);
        }

        [Fact]
        public void TestMethod2()
        {
            var data = new int[]
            {
                3,3,3, 3,3,3, 3,3,3,
                4,4,4, 4,4,4, 4,4,4,
                5,5,5, 5,5,5, 5,5,5
            };

            var img = CVImage.Create(3, 3, 3, data, OpenCV.DataType.CV_32S, 4 * 9);

            var datas = new List<int>();
            for (int i = 0; i < img.Width * img.Height * img.Channels; i++)
            {
                var t1 = Marshal.ReadInt32(img.Data, i * 4);
                datas.Add(t1);
            }
        }


        [Fact]
        public void TestMethod3()
        {
            var img = CVImage.Zeros(5, 5, OpenCV.DataType.CV_8U);
            Assert.Equal(1, img.Channels);
        }
    }
}
