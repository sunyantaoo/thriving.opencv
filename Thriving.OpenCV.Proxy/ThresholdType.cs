namespace Thriving.OpenCV
{
    public enum ThresholdType
    {
        /// <summary>
        /// 大于阈值的像素取最大值，否则取0
        /// </summary>
        THRESH_BINARY = 0, //!< \f[\texttt{dst} (x,y) =  \fork{\texttt{maxval}}{if \(\texttt{src}(x,y) > \texttt{thresh}\)}{0}{otherwise}\f]
        /// <summary>
        /// 大于阈值的像素取0，否则取最大值
        /// </summary>
        THRESH_BINARY_INV = 1, //!< \f[\texttt{dst} (x,y) =  \fork{0}{if \(\texttt{src}(x,y) > \texttt{thresh}\)}{\texttt{maxval}}{otherwise}\f]
        /// <summary>
        /// 大于阈值的像素取阈值，否则不变
        /// </summary>
        THRESH_TRUNC = 2, //!< \f[\texttt{dst} (x,y) =  \fork{\texttt{threshold}}{if \(\texttt{src}(x,y) > \texttt{thresh}\)}{\texttt{src}(x,y)}{otherwise}\f]
        /// <summary>
        /// 大于阈值的像素不变，否则取0
        /// </summary>
        THRESH_TOZERO = 3, //!< \f[\texttt{dst} (x,y) =  \fork{\texttt{src}(x,y)}{if \(\texttt{src}(x,y) > \texttt{thresh}\)}{0}{otherwise}\f]
        /// <summary>
        /// 小于阈值的像素不变，否则取最大值
        /// </summary>
        THRESH_TOZERO_INV = 4, //!< \f[\texttt{dst} (x,y) =  \fork{0}{if \(\texttt{src}(x,y) > \texttt{thresh}\)}{\texttt{src}(x,y)}{otherwise}\f]
        /// <summary>
        /// 
        /// </summary>
        THRESH_MASK = 7,
        /// <summary>
        /// 
        /// </summary>
        THRESH_OTSU = 8, //!< flag, use Otsu algorithm to choose the optimal threshold value
        /// <summary>
        /// 
        /// </summary>
        THRESH_TRIANGLE = 16 //!< flag, use Triangle algorithm to choose the optimal threshold value
    };
}