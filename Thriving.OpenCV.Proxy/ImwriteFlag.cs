namespace Thriving.OpenCV
{
    public enum ImwriteFlag
    {
        /// <summary>
        /// For JPEG, it can be a quality from 0 to 100 (the higher is the better). Default value is 95
        /// </summary>
        IMWRITE_JPEG_QUALITY = 1,
        /// <summary>
        /// Enable JPEG features, 0 or 1, default is False
        /// </summary>
        IMWRITE_JPEG_PROGRESSIVE = 2,
        /// <summary>
        /// Enable JPEG features, 0 or 1, default is False
        /// </summary>
        IMWRITE_JPEG_OPTIMIZE = 3,
        /// <summary>
        /// JPEG restart interval, 0 - 65535, default is 0 - no restart
        /// </summary>
        IMWRITE_JPEG_RST_INTERVAL = 4,
        /// <summary>
        /// Separate luma quality level, 0 - 100, default is -1 - don't use. If JPEG_LIB_VERSION < 70, Not supported
        /// </summary>
        IMWRITE_JPEG_LUMA_QUALITY = 5,
        /// <summary>
        /// Separate chroma quality level, 0 - 100, default is -1 - don't use. If JPEG_LIB_VERSION < 70, Not supported
        /// </summary>
        IMWRITE_JPEG_CHROMA_QUALITY = 6,
        /// <summary>
        /// For JPEG, set sampling factor. <see cref="ImwriteJPEGSamplingFactorParams"/>
        /// </summary>
        IMWRITE_JPEG_SAMPLING_FACTOR = 7,
        /// <summary>
        /// For PNG, it can be the compression level from 0 to 9. A higher value means a smaller size and longer compression time. 
        /// If specified, strategy is changed to IMWRITE_PNG_STRATEGY_DEFAULT (Z_DEFAULT_STRATEGY). Default value is 1 (best speed setting)
        /// </summary>
        IMWRITE_PNG_COMPRESSION = 16,
        /// <summary>
        /// One of  <see cref="ImwritePNGFlags"/> default is IMWRITE_PNG_STRATEGY_RLE 
        /// </summary>
        IMWRITE_PNG_STRATEGY = 17,
        /// <summary>
        /// Binary level PNG, 0 or 1, default is 0
        /// </summary>
        IMWRITE_PNG_BILEVEL = 18,
        /// <summary>
        /// For PPM, PGM, or PBM, it can be a binary format flag, 0 or 1. Default value is 1
        /// </summary>
        IMWRITE_PXM_BINARY = 32,
        /// <summary>
        /// override EXR storage type (FLOAT (FP32) is default) <see cref="ImwriteEXRTypeFlags"/>
        /// </summary>
        IMWRITE_EXR_TYPE = (3 << 4) + 0,/* 48 */
        /// <summary>
        /// override EXR compression type (ZIP_COMPRESSION = 3 is default) <see cref="ImwriteEXRCompressionFlags"/>
        /// </summary>
        IMWRITE_EXR_COMPRESSION = (3 << 4) + 1, /* 49 */
        /// <summary>
        /// override EXR DWA compression level (45 is default)
        /// </summary>
        IMWRITE_EXR_DWA_COMPRESSION_LEVEL = (3 << 4) + 2,/* 50 */
        /// <summary>
        /// For WEBP, it can be a quality from 1 to 100 (the higher is the better). 
        /// By default (without any parameter) and for quality above 100 the lossless compression is used
        /// </summary>
        IMWRITE_WEBP_QUALITY = 64,
        /// <summary>
        ///  specify HDR compression,<see cref="ImwriteHDRCompressionFlags"/>
        /// </summary>
        IMWRITE_HDR_COMPRESSION = (5 << 4) + 0,/* 80 */
        /// <summary>
        /// For PAM, sets the TUPLETYPE field to the corresponding string value that is defined for the format <see cref=" ImwritePAMFlags"/>
        /// </summary>
        IMWRITE_PAM_TUPLETYPE = 128,
        /// <summary>
        /// For TIFF, use to specify which DPI resolution unit to set; see libtiff documentation for valid values
        /// </summary>
        IMWRITE_TIFF_RESUNIT = 256,
        /// <summary>
        /// For TIFF, use to specify the X direction DPI
        /// </summary>
        IMWRITE_TIFF_XDPI = 257,
        /// <summary>
        /// For TIFF, use to specify the Y direction DPI
        /// </summary>
        IMWRITE_TIFF_YDPI = 258,
        /// <summary>
        /// For TIFF, use to specify the image compression scheme. <see cref="ImwriteTiffCompressionFlags"/> 
        /// Note, for images whose depth is CV_32F, only libtiff's SGILOG compression scheme is used. 
        /// For other supported depths, the compression scheme can be specified by this flag; LZW compression is the default.
        /// </summary>
        IMWRITE_TIFF_COMPRESSION = 259,
        /// <summary>
        /// For TIFF, use to specify the number of rows per strip
        /// </summary>
        IMWRITE_TIFF_ROWSPERSTRIP = 278,
        /// <summary>
        /// For TIFF, use to specify predictor. <see cref="ImwriteTiffPredictorFlags"/>
        /// </summary>
        IMWRITE_TIFF_PREDICTOR = 317,
        /// <summary>
        /// For JPEG2000, use to specify the target compression rate (multiplied by 1000). The value can be from 0 to 1000. Default is 1000
        /// </summary>
        IMWRITE_JPEG2000_COMPRESSION_X1000 = 272,
        /// <summary>
        /// For AVIF, it can be a quality between 0 and 100 (the higher the better). Default is 95
        /// </summary>
        IMWRITE_AVIF_QUALITY = 512,
        /// <summary>
        /// For AVIF, it can be 8, 10 or 12. If >8, it is stored/read as CV_32F. Default is 8
        /// </summary>
        IMWRITE_AVIF_DEPTH = 513,
        /// <summary>
        /// For AVIF, it is between 0 (slowest) and (fastest). Default is 9
        /// </summary>
        IMWRITE_AVIF_SPEED = 514
    };

    public enum ImwriteEXRCompressionFlags
    {
        IMWRITE_EXR_COMPRESSION_NO = 0, //!< no compression
        IMWRITE_EXR_COMPRESSION_RLE = 1, //!< run length encoding
        IMWRITE_EXR_COMPRESSION_ZIPS = 2, //!< zlib compression, one scan line at a time
        IMWRITE_EXR_COMPRESSION_ZIP = 3, //!< zlib compression, in blocks of 16 scan lines
        IMWRITE_EXR_COMPRESSION_PIZ = 4, //!< piz-based wavelet compression
        IMWRITE_EXR_COMPRESSION_PXR24 = 5, //!< lossy 24-bit float compression
        IMWRITE_EXR_COMPRESSION_B44 = 6, //!< lossy 4-by-4 pixel block compression, fixed compression rate
        IMWRITE_EXR_COMPRESSION_B44A = 7, //!< lossy 4-by-4 pixel block compression, flat fields are compressed more
        IMWRITE_EXR_COMPRESSION_DWAA = 8, //!< lossy DCT based compression, in blocks of 32 scanlines. More efficient for partial buffer access. Supported since OpenEXR 2.2.0.
        IMWRITE_EXR_COMPRESSION_DWAB = 9, //!< lossy DCT based compression, in blocks of 256 scanlines. More efficient space wise and faster to decode full frames than DWAA_COMPRESSION. Supported since OpenEXR 2.2.0.
    };

    public enum ImwriteEXRTypeFlags
    {
        /*IMWRITE_EXR_TYPE_UNIT = 0, //!< not supported */
        IMWRITE_EXR_TYPE_HALF = 1, //!< store as HALF (FP16)
        IMWRITE_EXR_TYPE_FLOAT = 2  //!< store as FP32 (default)
    }

    //! Imwrite HDR specific values for IMWRITE_HDR_COMPRESSION parameter key
    public enum ImwriteHDRCompressionFlags
    {
        IMWRITE_HDR_COMPRESSION_NONE = 0,
        IMWRITE_HDR_COMPRESSION_RLE = 1
    }

    public enum ImwriteJPEGSamplingFactorParams
    {
        IMWRITE_JPEG_SAMPLING_FACTOR_411 = 0x411111, //!< 4x1,1x1,1x1
        IMWRITE_JPEG_SAMPLING_FACTOR_420 = 0x221111, //!< 2x2,1x1,1x1(Default)
        IMWRITE_JPEG_SAMPLING_FACTOR_422 = 0x211111, //!< 2x1,1x1,1x1
        IMWRITE_JPEG_SAMPLING_FACTOR_440 = 0x121111, //!< 1x2,1x1,1x1
        IMWRITE_JPEG_SAMPLING_FACTOR_444 = 0x111111  //!< 1x1,1x1,1x1(No subsampling)
    }

    //! Imwrite PAM specific tupletype flags used to define the 'TUPLETYPE' field of a PAM file.
    public enum ImwritePAMFlags
    {
        IMWRITE_PAM_FORMAT_NULL = 0,
        IMWRITE_PAM_FORMAT_BLACKANDWHITE = 1,
        IMWRITE_PAM_FORMAT_GRAYSCALE = 2,
        IMWRITE_PAM_FORMAT_GRAYSCALE_ALPHA = 3,
        IMWRITE_PAM_FORMAT_RGB = 4,
        IMWRITE_PAM_FORMAT_RGB_ALPHA = 5
    }

    //! Imwrite PNG specific flags used to tune the compression algorithm.
    /** These flags will be modify the way of PNG image compression and will be passed to the underlying zlib processing stage.

-   The effect of IMWRITE_PNG_STRATEGY_FILTERED is to force more Huffman coding and less string matching; it is somewhat intermediate between IMWRITE_PNG_STRATEGY_DEFAULT and IMWRITE_PNG_STRATEGY_HUFFMAN_ONLY.
-   IMWRITE_PNG_STRATEGY_RLE is designed to be almost as fast as IMWRITE_PNG_STRATEGY_HUFFMAN_ONLY, but give better compression for PNG image data.
-   The strategy parameter only affects the compression ratio but not the correctness of the compressed output even if it is not set appropriately.
-   IMWRITE_PNG_STRATEGY_FIXED prevents the use of dynamic Huffman codes, allowing for a simpler decoder for special applications.
*/
    public enum ImwritePNGFlags
    {
        IMWRITE_PNG_STRATEGY_DEFAULT = 0, //!< Use this value for normal data.
        IMWRITE_PNG_STRATEGY_FILTERED = 1, //!< Use this value for data produced by a filter (or predictor).Filtered data consists mostly of small values with a somewhat random distribution. In this case, the compression algorithm is tuned to compress them better.
        IMWRITE_PNG_STRATEGY_HUFFMAN_ONLY = 2, //!< Use this value to force Huffman encoding only (no string match).
        IMWRITE_PNG_STRATEGY_RLE = 3, //!< Use this value to limit match distances to one (run-length encoding).
        IMWRITE_PNG_STRATEGY_FIXED = 4  //!< Using this value prevents the use of dynamic Huffman codes, allowing for a simpler decoder for special applications.
    }

    public enum ImwriteTiffCompressionFlags
    {
        IMWRITE_TIFF_COMPRESSION_NONE = 1,            //!< dump mode
        IMWRITE_TIFF_COMPRESSION_CCITTRLE = 2,        //!< CCITT modified Huffman RLE
        IMWRITE_TIFF_COMPRESSION_CCITTFAX3 = 3,       //!< CCITT Group 3 fax encoding
        IMWRITE_TIFF_COMPRESSION_CCITT_T4 = 3,        //!< CCITT T.4 (TIFF 6 name)
        IMWRITE_TIFF_COMPRESSION_CCITTFAX4 = 4,       //!< CCITT Group 4 fax encoding
        IMWRITE_TIFF_COMPRESSION_CCITT_T6 = 4,        //!< CCITT T.6 (TIFF 6 name)
        IMWRITE_TIFF_COMPRESSION_LZW = 5,             //!< Lempel-Ziv  & Welch
        IMWRITE_TIFF_COMPRESSION_OJPEG = 6,           //!< !6.0 JPEG
        IMWRITE_TIFF_COMPRESSION_JPEG = 7,            //!< %JPEG DCT compression
        IMWRITE_TIFF_COMPRESSION_T85 = 9,             //!< !TIFF/FX T.85 JBIG compression
        IMWRITE_TIFF_COMPRESSION_T43 = 10,            //!< !TIFF/FX T.43 colour by layered JBIG compression
        IMWRITE_TIFF_COMPRESSION_NEXT = 32766,        //!< NeXT 2-bit RLE
        IMWRITE_TIFF_COMPRESSION_CCITTRLEW = 32771,   //!< #1 w/ word alignment
        IMWRITE_TIFF_COMPRESSION_PACKBITS = 32773,    //!< Macintosh RLE
        IMWRITE_TIFF_COMPRESSION_THUNDERSCAN = 32809, //!< ThunderScan RLE
        IMWRITE_TIFF_COMPRESSION_IT8CTPAD = 32895,    //!< IT8 CT w/padding
        IMWRITE_TIFF_COMPRESSION_IT8LW = 32896,       //!< IT8 Linework RLE
        IMWRITE_TIFF_COMPRESSION_IT8MP = 32897,       //!< IT8 Monochrome picture
        IMWRITE_TIFF_COMPRESSION_IT8BL = 32898,       //!< IT8 Binary line art
        IMWRITE_TIFF_COMPRESSION_PIXARFILM = 32908,   //!< Pixar companded 10bit LZW
        IMWRITE_TIFF_COMPRESSION_PIXARLOG = 32909,    //!< Pixar companded 11bit ZIP
        IMWRITE_TIFF_COMPRESSION_DEFLATE = 32946,     //!< Deflate compression, legacy tag
        IMWRITE_TIFF_COMPRESSION_ADOBE_DEFLATE = 8,   //!< Deflate compression, as recognized by Adobe
        IMWRITE_TIFF_COMPRESSION_DCS = 32947,         //!< Kodak DCS encoding
        IMWRITE_TIFF_COMPRESSION_JBIG = 34661,        //!< ISO JBIG
        IMWRITE_TIFF_COMPRESSION_SGILOG = 34676,      //!< SGI Log Luminance RLE
        IMWRITE_TIFF_COMPRESSION_SGILOG24 = 34677,    //!< SGI Log 24-bit packed
        IMWRITE_TIFF_COMPRESSION_JP2000 = 34712,      //!< Leadtools JPEG2000
        IMWRITE_TIFF_COMPRESSION_LERC = 34887,        //!< ESRI Lerc codec: https://github.com/Esri/lerc
        IMWRITE_TIFF_COMPRESSION_LZMA = 34925,        //!< LZMA2
        IMWRITE_TIFF_COMPRESSION_ZSTD = 50000,        //!< ZSTD: WARNING not registered in Adobe-maintained registry
        IMWRITE_TIFF_COMPRESSION_WEBP = 50001,        //!< WEBP: WARNING not registered in Adobe-maintained registry
        IMWRITE_TIFF_COMPRESSION_JXL = 50002          //!< JPEGXL: WARNING not registered in Adobe-maintained registry
    }

    public enum ImwriteTiffPredictorFlags
    {
        IMWRITE_TIFF_PREDICTOR_NONE = 1,              //!< no prediction scheme used
        IMWRITE_TIFF_PREDICTOR_HORIZONTAL = 2,        //!< horizontal differencing
        IMWRITE_TIFF_PREDICTOR_FLOATINGPOINT = 3      //!< floating point predictor
    }


}