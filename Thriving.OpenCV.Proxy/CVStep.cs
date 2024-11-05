using System.Runtime.InteropServices;

namespace Thriving.OpenCV
{
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public struct CVStep
    {

        [FieldOffset(0)] IntPtr p;

        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
        [FieldOffset(8)] long[] buf;

    }
}