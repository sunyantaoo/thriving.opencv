namespace Thriving.OpenCV
{
    public enum MorphTypes
    {
        /// <summary>
        /// 腐蚀
        /// </summary>
        MORPH_ERODE = 0, //!< see #erode
        /// <summary>
        /// 膨胀
        /// </summary>
        MORPH_DILATE = 1, //!< see #dilate
        /// <summary>
        /// 开运算，先腐蚀后膨胀
        /// </summary>
        MORPH_OPEN = 2, //!< an opening operation
                        //!< \f[\texttt{dst} = \mathrm{open} ( \texttt{src} , \texttt{element} )= \mathrm{dilate} ( \mathrm{erode} ( \texttt{src} , \texttt{element} ))\f]
        /// <summary>
        /// 闭运算，先膨胀后腐蚀
        /// </summary>
        MORPH_CLOSE = 3, //!< a closing operation
                         //!< \f[\texttt{dst} = \mathrm{close} ( \texttt{src} , \texttt{element} )= \mathrm{erode} ( \mathrm{dilate} ( \texttt{src} , \texttt{element} ))\f]
        /// <summary>
        /// 梯度，膨胀 - 腐蚀
        /// </summary>
        MORPH_GRADIENT = 4, //!< a morphological gradient
                            //!< \f[\texttt{dst} = \mathrm{morph\_grad} ( \texttt{src} , \texttt{element} )= \mathrm{dilate} ( \texttt{src} , \texttt{element} )- \mathrm{erode} ( \texttt{src} , \texttt{element} )\f]
        /// <summary>
        /// 顶帽，原始数据 - 开运算
        /// </summary>
        MORPH_TOPHAT = 5, //!< "top hat"
                          //!< \f[\texttt{dst} = \mathrm{tophat} ( \texttt{src} , \texttt{element} )= \texttt{src} - \mathrm{open} ( \texttt{src} , \texttt{element} )\f]
        /// <summary>
        /// 黑帽，闭运算 - 原始数据
        /// </summary>
        MORPH_BLACKHAT = 6, //!< "black hat"
                            //!< \f[\texttt{dst} = \mathrm{blackhat} ( \texttt{src} , \texttt{element} )= \mathrm{close} ( \texttt{src} , \texttt{element} )- \texttt{src}\f]
        /// <summary>
        /// 
        /// </summary>
        MORPH_HITMISS = 7  //!< "hit or miss"
                           //!<   .- Only supported for CV_8UC1 binary images. A tutorial can be found in the documentation
    };
}