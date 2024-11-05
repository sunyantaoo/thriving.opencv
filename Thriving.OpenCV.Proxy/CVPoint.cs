using System.Runtime.InteropServices;

namespace Thriving.OpenCV
{
    [StructLayout(LayoutKind.Sequential)]
    public readonly struct CVPoint
    {
        private readonly int x, y;

        public CVPoint(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public int X { get => x; }
        public int Y { get => y; }
    }
}