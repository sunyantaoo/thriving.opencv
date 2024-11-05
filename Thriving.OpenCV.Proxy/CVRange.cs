using System.Runtime.InteropServices;

namespace Thriving.OpenCV
{
    [StructLayout(LayoutKind.Sequential)]
    public readonly struct CVRange
    {
        private readonly int start, end;

        public CVRange(int start, int end)
        {
            this.start = start;
            this.end = end;
        }

        public int Start { get => start; }
        public int End { get => end; }
    }
}