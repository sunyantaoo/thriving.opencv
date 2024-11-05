using System.Runtime.InteropServices;

namespace Thriving.OpenCV
{
    internal class CV
    {
        private const string _libraryPath = "Thriving.OpenCV.dll";

        [DllImport(_libraryPath)]
        public static extern void matRelease(IntPtr img);

        [DllImport(_libraryPath)]
        public static extern IntPtr matRead([MarshalAs(UnmanagedType.LPStr)] string imgPath, ImreadMode modes);

        [DllImport(_libraryPath)]
        public static extern IntPtr matNew(int rows, int cols, int channels, DataType type, IntPtr data, uint step);

        [DllImport(_libraryPath)]
        public static extern IntPtr matZeros(int rows, int cols,  DataType type);

        [DllImport(_libraryPath)]
        public static extern IntPtr matOnes(int rows, int cols,  DataType type);


        [DllImport(_libraryPath)]
        public static extern DataType matDepth(IntPtr img);

        [DllImport(_libraryPath)]
        public static extern int matChannels(IntPtr img);

        [DllImport(_libraryPath)]
        public static extern bool matIsEmpty(IntPtr img);

        [DllImport(_libraryPath)]
        public static extern bool matIsContinuous(IntPtr img);

        [DllImport(_libraryPath)]
        public static extern IntPtr matConvertColor(IntPtr img, ColorConversionCode code, int channels);

         [DllImport(_libraryPath)]
        public static extern bool matWrite(IntPtr img, string imgPath, int[] paramPtr, int pCount);

        [DllImport(_libraryPath)]
        public static extern IntPtr matRegion(IntPtr img, int rowStart, int rowEnd, int colStart, int colEnd);

        [DllImport(_libraryPath)]
        public static extern IntPtr matResize(IntPtr img, CVSize size, double fx, double fy, InterpolationFlag interpolation);

        [DllImport(_libraryPath)]
        public static extern IntPtr matFilter2D(IntPtr img, IntPtr kernel, int ddepth, CVPoint anchor, double delta, BorderType borderType);

        [DllImport(_libraryPath)]
        public static extern IntPtr matBlur(IntPtr img, CVSize ksize, CVPoint anchor, BorderType borderType);

        [DllImport(_libraryPath)]
        public static extern IntPtr matGaussianBlur(IntPtr img, CVSize ksize, double sigmaX, double sigmaY, BorderType borderType, AlgorithmHint hint);

        [DllImport(_libraryPath)]
        public static extern IntPtr matMedianBlur(IntPtr img, int ksize);

        [DllImport(_libraryPath)]
        public static extern IntPtr matBoxFilter(IntPtr img, int ddepth, CVSize ksize, CVPoint anchor, bool normalize, BorderType borderType);

        [DllImport(_libraryPath)]
        public static extern IntPtr matThreshold(IntPtr img, double thresh, double maxval, ThresholdType type, IntPtr threshold);

        [DllImport(_libraryPath)]
        public static extern IntPtr matErode(IntPtr img, IntPtr kernel, CVPoint anchor, int iterations, BorderType borderType, CVScalar borderValue);

        [DllImport(_libraryPath)]
        public static extern IntPtr matDilate(IntPtr img, IntPtr kernel, CVPoint anchor, int iterations, BorderType borderType, CVScalar borderValue);

        [DllImport(_libraryPath)]
        public static extern IntPtr matMorphologyEx(IntPtr img, MorphTypes operation, IntPtr kernel, CVPoint anchor, int iterations, BorderType borderType, CVScalar borderValue);

        [DllImport(_libraryPath)]
        public static extern IntPtr matSobel(IntPtr img, int ddepth, int dx, int dy, int ksize, double scale, double delta, BorderType borderType);

        [DllImport(_libraryPath)]
        public static extern IntPtr matScharr(IntPtr img, int ddepth, int dx, int dy, double scale, double delta, BorderType borderType);

        [DllImport(_libraryPath)]
        public static extern IntPtr matLaplacian(IntPtr img, int ddepth, int ksize, double scale, double delta, BorderType borderType);

        [DllImport(_libraryPath)]
        public static extern IntPtr matMatchTemplate(IntPtr img, IntPtr template, TemplateMatchMode method, IntPtr mask);
    }
}