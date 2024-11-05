using System.Runtime.InteropServices;

namespace Thriving.OpenCV
{

    [StructLayout(LayoutKind.Sequential)]
    public readonly struct CVSize
    {
        private readonly int width, height;

        public CVSize(int width, int height)
        {
            this.width = width;
            this.height = height;
        }
        public int Width { get => width; }
        public int Height { get => height; }
    }
}