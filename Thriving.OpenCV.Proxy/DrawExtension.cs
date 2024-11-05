using System.Runtime.InteropServices;

namespace Thriving.OpenCV
{
    public static class DrawExtension
    {
        public static void DrawLine(this CVImage img, CVPoint start, CVPoint end, CVScalar color, int thickness, LineType lineType, int shift)
        {
            Wrapper.drawLine(img.Handle, start, end, color, thickness, lineType, shift);
        }

        public static void DrawArrowedLine(this CVImage img, CVPoint start, CVPoint end, CVScalar color, int thickness, LineType lineType, int shift, double tipLength)
        {
            Wrapper.drawArrowedLine(img.Handle, start, end, color, thickness, lineType, shift, tipLength);
        }


        public static void DrawRectangle(this CVImage img, CVRect rect, CVScalar color, int thickness, LineType lineType, int shift)
        {
            Wrapper.drawRectangle(img.Handle, rect, color, thickness, lineType, shift);
        }


        public static void DrawCircle(this CVImage img, CVPoint center, int radius, CVScalar color, int thickness, LineType lineType, int shift)
        {
            Wrapper.drawCircle(img.Handle, center, radius, color, thickness, lineType, shift);
        }

        public static void DrawEllipse(this CVImage img, CVPoint center, CVSize axes, double angle, double startAngle, double endAngle, CVScalar color, int thickness, LineType lineType, int shift)
        {
            Wrapper.drawEllipse(img.Handle, center, axes, angle, startAngle, endAngle, color, thickness, lineType, shift);
        }


        public static void DrawPolylines(this CVImage img, IEnumerable<CVPoint> pts, int ncountours, bool isclosed, CVScalar color, int thickness, LineType lineType, int shift)
        {
            var pArray = pts.ToArray();
            int npts = pts.Count();
            Wrapper.drawPolylines(img.Handle, pArray, npts, ncountours, isclosed, color, thickness, lineType, shift);
        }


        public static void DrawText(this CVImage img, string text, CVPoint org, int fontFace, double fontScale, CVScalar color, int thickness, LineType lineType, bool bottomLeftOrigin = false)
        {
            Wrapper.drawText(img.Handle, text, org, fontFace, fontScale, color, thickness, lineType, bottomLeftOrigin);
        }


        public static void DrawMaker(this CVImage img, CVPoint position, CVScalar color, MarkerType makerType, int thickness, LineType lineType)
        {
            Wrapper.drawMaker(img.Handle, position, color, makerType, thickness, lineType);
        }


        private class Wrapper
        {
            [DllImport("Thriving.OpenCV.dll", EntryPoint = "drawLine")]
            public static extern void drawLine(IntPtr img, CVPoint start, CVPoint end, CVScalar color, int thickness, LineType lineType, int shift);

            [DllImport("Thriving.OpenCV.dll", EntryPoint = "drawArrowedLine")]
            public static extern void drawArrowedLine(IntPtr img, CVPoint start, CVPoint end, CVScalar color, int thickness, LineType lineType, int shift, double tipLength);

            [DllImport("Thriving.OpenCV.dll", EntryPoint = "drawRectangle")]
            public static extern void drawRectangle(IntPtr img, CVRect rect, CVScalar color, int thickness, LineType lineType, int shift);

            [DllImport("Thriving.OpenCV.dll", EntryPoint = "drawCircle")]
            public static extern void drawCircle(IntPtr img, CVPoint center, int radius, CVScalar color, int thickness, LineType lineType, int shift);

            [DllImport("Thriving.OpenCV.dll", EntryPoint = "drawEllipse")]
            public static extern void drawEllipse(IntPtr img, CVPoint center, CVSize axes, double angle, double startAngle, double endAngle, CVScalar color, int thickness, LineType lineType, int shift);

            [DllImport("Thriving.OpenCV.dll", EntryPoint = "drawPolylines")]
            public static extern void drawPolylines(IntPtr img, CVPoint[] pts, int npts, int ncountours, bool isclosed, CVScalar color, int thickness, LineType lineType, int shift);

            [DllImport("Thriving.OpenCV.dll", EntryPoint = "drawText")]
            public static extern void drawText(IntPtr img, [MarshalAs(UnmanagedType.LPStr)] string text, CVPoint org, int fontFace, double fontScale, CVScalar color, int thickness, LineType lineType, bool bottomLeftOrigin = false);

            [DllImport("Thriving.OpenCV.dll", EntryPoint = "drawMaker")]
            public static extern void drawMaker(IntPtr img, CVPoint position, CVScalar color, MarkerType makerType, int thickness, LineType lineType);
        }
    }
}