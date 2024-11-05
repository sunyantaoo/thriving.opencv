using System.Runtime.InteropServices;

namespace Thriving.OpenCV
{
    [StructLayout(LayoutKind.Sequential)]
    public readonly struct CVScalar
    {
        private readonly double x, y, z, w;
        public CVScalar(double x, double y, double z, double w)
        {
            this.x = x;
            this.y = y;
            this.z = z;
            this.w = w;
        }


    }
}