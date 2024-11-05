using System.Runtime.InteropServices;

namespace Thriving.OpenCV
{
    public class CVImage
    {
        public IntPtr Handle { get; }

        internal CVImage(IntPtr handle)
        {
            this.Handle = handle;
        }

        /// <summary>
        /// 读取图像
        /// </summary>
        /// <param name="imgPath"></param>
        /// <param name="modes"></param>
        public static CVImage Read(string imgPath, ImreadMode modes = ImreadMode.IMREAD_COLOR)
        {
            var handle = CV.matRead(imgPath, modes);
            return new CVImage(handle);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="rows">行数</param>
        /// <param name="cols">列数</param>
        /// <param name="channels">通道数</param>
        /// <param name="data">数据，类型必须与数据类型一致</param>
        /// <param name="type">数据类型</param>
        /// <param name="step">每行占用的字节数 等于cols*channels*(type占用字节)</param>
        /// <returns></returns>
        public static unsafe CVImage Create<T>(int rows, int cols, int channels, T[] data, DataType type, uint step = 0) where T : struct
        {
            var ptr = Marshal.UnsafeAddrOfPinnedArrayElement(data, 0);
            var handle = CV.matNew(rows, cols, channels, type, ptr, step);
            return new CVImage(handle);
        }

        /// <summary>
        /// 单通道 值全为0的矩阵
        /// </summary>
        /// <param name="rows"></param>
        /// <param name="cols"></param>
        /// <param name="type"></param>
        /// <returns></returns>
        public static CVImage Zeros(int rows, int cols, DataType type)
        {
            var handle = CV.matZeros(rows, cols, type);
            return new CVImage(handle);
        }

        /// <summary>
        /// 单通道 值全为1的矩阵
        /// </summary>
        /// <param name="rows"></param>
        /// <param name="cols"></param>
        /// <param name="type"></param>
        /// <returns></returns>
        public static CVImage Ones(int rows, int cols, DataType type)
        {
            var handle = CV.matOnes(rows, cols, type);
            return new CVImage(handle);
        }


        ~CVImage()
        {
            if (this.Handle != IntPtr.Zero)
            {
                CV.matRelease(Handle);
            }
        }

        #region 属性

        /// <summary>
        /// 像素地址 
        /// </summary>
        public IntPtr Data { get => Marshal.ReadIntPtr(Handle, Marshal.OffsetOf<Internal>(nameof(Internal.data)).ToInt32()); }

        public IntPtr DataStart { get => Marshal.ReadIntPtr(Handle, Marshal.OffsetOf<Internal>(nameof(Internal.datastart)).ToInt32()); }

        public IntPtr DataEnd { get => Marshal.ReadIntPtr(Handle, Marshal.OffsetOf<Internal>(nameof(Internal.dataend)).ToInt32()); }

        public IntPtr DataLimit { get => Marshal.ReadIntPtr(Handle, Marshal.OffsetOf<Internal>(nameof(Internal.datalimit)).ToInt32()); }

        /// <summary>
        /// 高度
        /// </summary>
        public int Height { get => Marshal.ReadInt32(Handle, Marshal.OffsetOf<Internal>(nameof(Internal.rows)).ToInt32()); }

        /// <summary>
        /// 宽度
        /// </summary>
        public int Width { get => Marshal.ReadInt32(Handle, Marshal.OffsetOf<Internal>(nameof(Internal.cols)).ToInt32()); }

        /// <summary>
        /// 维度
        /// </summary>
        public int Dimension { get => Marshal.ReadInt32(Handle, Marshal.OffsetOf<Internal>(nameof(Internal.dims)).ToInt32()); }

        #endregion

        /// <summary>
        /// 组成图像的数据类型
        /// </summary>
        public DataType DataType { get => CV.matDepth(Handle); }

        /// <summary>
        /// 通道
        /// </summary>
        public int Channels
        {
            get => CV.matChannels(Handle);
        }

        /// <summary>
        /// 数据是否为空
        /// </summary>
        /// <returns></returns>
        public bool IsEmpty()
        {
            return CV.matIsEmpty(Handle);
        }

        public bool IsContinuous()
        {
            return CV.matIsContinuous(Handle);
        }


        /// <summary>
        /// 改变颜色空间
        /// </summary>
        /// <param name="code"></param>
        /// <param name="channels">默认为0，根据原始图像和code参数自动设置</param>
        /// <returns></returns>
        public CVImage ConvertColor(ColorConversionCode code, int channels = 0)
        {
            var handle = CV.matConvertColor(Handle, code, channels);
            return new CVImage(handle);
        }

        /// <summary>
        /// 另存为
        /// </summary>
        /// <param name="imgPath"></param>
        /// <param name="param"></param>
        /// <returns></returns>
        public bool Write(string imgPath, IDictionary<ImwriteFlag, int> param)
        {
            var dir = System.IO.Path.GetDirectoryName(imgPath);
            if (!System.IO.Directory.Exists(dir)) System.IO.Directory.CreateDirectory(dir);

            int[] array = Array.Empty<int>();
            int count = 0;
            if (param != null)
            {
                count = param.Count * 2;
                array = new int[count];
                for (int i = 0; i < param.Count; i++)
                {
                    var item = param.ElementAt(i);
                    array[i * 2] = (int)item.Key;
                    array[i * 2 + 1] = item.Value;
                }
            }

            return CV.matWrite(Handle, imgPath, array, count);
        }

        /// <summary>
        /// 截取范围
        /// </summary>
        /// <param name="rowStart"></param>
        /// <param name="rowEnd"></param>
        /// <param name="colStart"></param>
        /// <param name="colEnd"></param>
        /// <returns></returns>
        public CVImage Region(int rowStart, int rowEnd, int colStart, int colEnd)
        {
            var handle = CV.matRegion(Handle, rowStart, rowEnd, colStart, colEnd);
            return new CVImage(handle);
        }

        /// <summary>
        /// 调整尺寸，固定尺寸
        /// </summary>
        /// <param name="size"></param>
        /// <param name="interpolation">插值方式</param>
        /// <returns></returns>
        public CVImage Resize(CVSize size, InterpolationFlag interpolation = InterpolationFlag.INTER_LINEAR)
        {
            var handle = CV.matResize(Handle, size, 0.0, 0.0, interpolation);
            return new CVImage(handle);
        }

        /// <summary>
        /// 调整尺寸，比例
        /// </summary>
        public CVImage Resize(double fx, double fy, InterpolationFlag interpolation = InterpolationFlag.INTER_LINEAR)
        {
            var handle = CV.matResize(Handle, new CVSize(), fx, fy, interpolation);
            return new CVImage(handle);
        }

        /// <summary>
        /// 卷积
        /// </summary>
        /// <param name="kernel"></param>
        /// <param name="ddepth"></param>
        /// <returns></returns>
        public CVImage Filter2D(CVImage kernel, int ddepth, CVPoint anchor, double delta = 0, BorderType borderType = BorderType.BORDER_DEFAULT)
        {
            var handle = CV.matFilter2D(Handle, kernel.Handle, ddepth, anchor, delta, borderType);
            return new CVImage(handle);
        }

        /// <summary>
        /// 均值滤波：当前像素值取为卷积（卷积矩阵的值全为1）后各个值的平均值
        /// </summary>
        /// <returns></returns>
        public CVImage Blur(CVSize ksize, CVPoint anchor, BorderType borderType = BorderType.BORDER_DEFAULT)
        {
            var handle = CV.matBlur(Handle, ksize, anchor, borderType);
            return new CVImage(handle);
        }

        /// <summary>
        /// 高斯滤波：卷积矩阵为高斯矩阵
        /// </summary>
        /// <returns></returns>
        public CVImage GaussianBlur(CVSize ksize, double sigmaX, double sigmaY = 0, BorderType borderType = BorderType.BORDER_DEFAULT, AlgorithmHint hint = AlgorithmHint.ALGO_HINT_DEFAULT)
        {
            var handle = CV.matGaussianBlur(Handle, ksize, sigmaX, sigmaY, borderType, hint);
            return new CVImage(handle);
        }
        /// <summary>
        /// 中值滤波：当前像素值取为卷积（卷积矩阵的值全为1）后各个值的中间值
        /// </summary>
        /// <returns></returns>
        public CVImage MedianBlur(int ksize)
        {
            var handle = CV.matMedianBlur(Handle, ksize);
            return new CVImage(handle);
        }

        /// <summary>
        /// 方框滤波：同均值滤波，normalize表示是否求平均值，结果越界后取为255
        /// </summary>
        /// <returns></returns>
        public CVImage BoxFilter(int ddepth, CVSize ksize, CVPoint anchor, bool normalize = true, BorderType borderType = BorderType.BORDER_DEFAULT)
        {
            var handle = CV.matBoxFilter(Handle, ddepth, ksize, anchor, normalize, borderType);
            return new CVImage(handle);
        }

        /// <summary>
        /// 阈值操作
        /// </summary>
        /// <returns></returns>
        public CVImage Threshold(double thresh, double maxval, ThresholdType type, out double threshold)
        {
            var ptr = Marshal.AllocHGlobal(sizeof(double));
            var handle = CV.matThreshold(Handle, thresh, maxval, type, ptr);
            threshold = Marshal.PtrToStructure<double>(ptr);
            Marshal.FreeHGlobal(ptr);
            return new CVImage(handle);
        }

        /// <summary>
        /// 腐蚀
        /// </summary>
        /// <returns></returns>
        public CVImage Erode(CVImage kernel, CVPoint anchor, int iterations, BorderType borderType, CVScalar borderValue)
        {
            var handle = CV.matErode(Handle, kernel.Handle, anchor, iterations, borderType, borderValue);
            return new CVImage(handle);
        }

        /// <summary>
        /// 膨胀
        /// </summary>
        /// <returns></returns>
        public CVImage Dilate(CVImage kernel, CVPoint anchor, int iterations, BorderType borderType, CVScalar borderValue)
        {
            var handle = CV.matDilate(Handle, kernel.Handle, anchor, iterations, borderType, borderValue);
            return new CVImage(handle);
        }

        /// <summary>
        /// 形态学
        /// </summary>
        /// <returns></returns>
        public CVImage MorphologyEx(MorphTypes operation, CVImage kernel, CVPoint anchor, int iterations, BorderType borderType, CVScalar borderValue)
        {
            var handle = CV.matMorphologyEx(Handle, operation, kernel.Handle, anchor, iterations, borderType, borderValue);
            return new CVImage(handle);
        }

        /// <summary>
        /// 卷积核 x轴[[-1,0,1],[-2,0,2],[-1,0,1]] y轴[[-1,-1,-1],[0,0,0],[1,2,1]]
        /// </summary>
        /// <returns></returns>
        public CVImage Sobel(int ddepth, int dx, int dy, int ksize = 3, double scale = 1.0, double delta = 0.0, BorderType borderType = BorderType.BORDER_DEFAULT)
        {
            var handle = CV.matSobel(Handle, ddepth, dx, dy, ksize, scale, delta, borderType);
            return new CVImage(handle);
        }

        /// <summary>
        /// 卷积核 x轴[[-3,0,3],[-10,0,10],[-3,0,3]] y轴[[-3,-10,-3],[0,0,0],[3,10,3]]
        /// </summary>
        /// <returns></returns>
        public CVImage Scharr(int ddepth, int dx, int dy, double scale = 1.0, double delta = 0.0, BorderType borderType = BorderType.BORDER_DEFAULT)
        {
            var handle = CV.matScharr(Handle, ddepth, dx, dy, scale, delta, borderType);
            return new CVImage(handle);
        }

        /// <summary>
        /// 卷积核[[0,1,0],[1,-4,1],[0,1,0]]
        /// </summary>
        /// <returns></returns>
        public CVImage Laplacian(int ddepth, int ksize = 1, double scale = 1.0, double delta = 0.0, BorderType borderType = BorderType.BORDER_DEFAULT)
        {
            var handle = CV.matLaplacian(Handle, ddepth, ksize, scale, delta, borderType);
            return new CVImage(handle);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="template">模板</param>
        /// <param name="method">匹配方式</param>
        /// <param name="mask">蒙版</param>
        /// <returns></returns>
        public CVImage MatchTemplate(CVImage template, TemplateMatchMode method, CVImage mask)
        {
            var handle = CV.matMatchTemplate(Handle, template.Handle, method, mask.Handle);
            return new CVImage(handle);
        }


        [StructLayout(LayoutKind.Explicit, Size = 96)]
        struct Internal
        {
            [FieldOffset(0)] internal int flags;
            [FieldOffset(4)] internal int dims;
            [FieldOffset(8)] internal int rows;
            [FieldOffset(12)] internal int cols;
            [FieldOffset(16)] internal IntPtr data;
            [FieldOffset(24)] internal IntPtr datastart;
            [FieldOffset(32)] internal IntPtr dataend;
            [FieldOffset(40)] internal IntPtr datalimit;
            [FieldOffset(48)] internal IntPtr allocator;
            [FieldOffset(56)] internal IntPtr udata;
            [FieldOffset(64)] internal CVSize size;
            [FieldOffset(72)] internal CVStep step;
        }
    }
}