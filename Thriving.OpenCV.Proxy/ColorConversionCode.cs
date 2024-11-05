namespace Thriving.OpenCV
{
    public enum ColorConversionCode
    {
        COLOR_BGR2BGRA = 0, //!< add alpha channel to RGB or BGR image
        COLOR_RGB2RGBA = COLOR_BGR2BGRA,

        COLOR_BGRA2BGR = 1, //!< remove alpha channel from RGB or BGR image
        COLOR_RGBA2RGB = COLOR_BGRA2BGR,

        COLOR_BGR2RGBA = 2, //!< convert between RGB and BGR color spaces (with or without alpha channel)
        COLOR_RGB2BGRA = COLOR_BGR2RGBA,

        COLOR_RGBA2BGR = 3,
        COLOR_BGRA2RGB = COLOR_RGBA2BGR,

        COLOR_BGR2RGB = 4,
        COLOR_RGB2BGR = COLOR_BGR2RGB,

        COLOR_BGRA2RGBA = 5,
        COLOR_RGBA2BGRA = COLOR_BGRA2RGBA,

        COLOR_BGR2GRAY = 6, //!< convert between RGB/BGR and grayscale, @ref color_convert_rgb_gray "color conversions"
        COLOR_RGB2GRAY = 7,
        COLOR_GRAY2BGR = 8,
        COLOR_GRAY2RGB = COLOR_GRAY2BGR,
        COLOR_GRAY2BGRA = 9,
        COLOR_GRAY2RGBA = COLOR_GRAY2BGRA,
        COLOR_BGRA2GRAY = 10,
        COLOR_RGBA2GRAY = 11,

        COLOR_BGR2BGR565 = 12, //!< convert between RGB/BGR and BGR565 (16-bit images)
        COLOR_RGB2BGR565 = 13,
        COLOR_BGR5652BGR = 14,
        COLOR_BGR5652RGB = 15,
        COLOR_BGRA2BGR565 = 16,
        COLOR_RGBA2BGR565 = 17,
        COLOR_BGR5652BGRA = 18,
        COLOR_BGR5652RGBA = 19,

        COLOR_GRAY2BGR565 = 20, //!< convert between grayscale to BGR565 (16-bit images)
        COLOR_BGR5652GRAY = 21,

        COLOR_BGR2BGR555 = 22,  //!< convert between RGB/BGR and BGR555 (16-bit images)
        COLOR_RGB2BGR555 = 23,
        COLOR_BGR5552BGR = 24,
        COLOR_BGR5552RGB = 25,
        COLOR_BGRA2BGR555 = 26,
        COLOR_RGBA2BGR555 = 27,
        COLOR_BGR5552BGRA = 28,
        COLOR_BGR5552RGBA = 29,

        COLOR_GRAY2BGR555 = 30, //!< convert between grayscale and BGR555 (16-bit images)
        COLOR_BGR5552GRAY = 31,

        COLOR_BGR2XYZ = 32, //!< convert RGB/BGR to CIE XYZ, @ref color_convert_rgb_xyz "color conversions"
        COLOR_RGB2XYZ = 33,
        COLOR_XYZ2BGR = 34,
        COLOR_XYZ2RGB = 35,

        COLOR_BGR2YCrCb = 36, //!< convert RGB/BGR to luma-chroma (aka YCC), @ref color_convert_rgb_ycrcb "color conversions"
        COLOR_RGB2YCrCb = 37,
        COLOR_YCrCb2BGR = 38,
        COLOR_YCrCb2RGB = 39,

        COLOR_BGR2HSV = 40, //!< convert RGB/BGR to HSV (hue saturation value) with H range 0..180 if 8 bit image, @ref color_convert_rgb_hsv "color conversions"
        COLOR_RGB2HSV = 41,

        COLOR_BGR2Lab = 44, //!< convert RGB/BGR to CIE Lab, @ref color_convert_rgb_lab "color conversions"
        COLOR_RGB2Lab = 45,

        COLOR_BGR2Luv = 50, //!< convert RGB/BGR to CIE Luv, @ref color_convert_rgb_luv "color conversions"
        COLOR_RGB2Luv = 51,
        COLOR_BGR2HLS = 52, //!< convert RGB/BGR to HLS (hue lightness saturation) with H range 0..180 if 8 bit image, @ref color_convert_rgb_hls "color conversions"
        COLOR_RGB2HLS = 53,

        COLOR_HSV2BGR = 54, //!< backward conversions HSV to RGB/BGR with H range 0..180 if 8 bit image
        COLOR_HSV2RGB = 55,

        COLOR_Lab2BGR = 56,
        COLOR_Lab2RGB = 57,
        COLOR_Luv2BGR = 58,
        COLOR_Luv2RGB = 59,
        COLOR_HLS2BGR = 60, //!< backward conversions HLS to RGB/BGR with H range 0..180 if 8 bit image
        COLOR_HLS2RGB = 61,

        COLOR_BGR2HSV_FULL = 66, //!< convert RGB/BGR to HSV (hue saturation value) with H range 0..255 if 8 bit image, @ref color_convert_rgb_hsv "color conversions"
        COLOR_RGB2HSV_FULL = 67,
        COLOR_BGR2HLS_FULL = 68, //!< convert RGB/BGR to HLS (hue lightness saturation) with H range 0..255 if 8 bit image, @ref color_convert_rgb_hls "color conversions"
        COLOR_RGB2HLS_FULL = 69,

        COLOR_HSV2BGR_FULL = 70, //!< backward conversions HSV to RGB/BGR with H range 0..255 if 8 bit image
        COLOR_HSV2RGB_FULL = 71,
        COLOR_HLS2BGR_FULL = 72, //!< backward conversions HLS to RGB/BGR with H range 0..255 if 8 bit image
        COLOR_HLS2RGB_FULL = 73,

        COLOR_LBGR2Lab = 74,
        COLOR_LRGB2Lab = 75,
        COLOR_LBGR2Luv = 76,
        COLOR_LRGB2Luv = 77,

        COLOR_Lab2LBGR = 78,
        COLOR_Lab2LRGB = 79,
        COLOR_Luv2LBGR = 80,
        COLOR_Luv2LRGB = 81,

        COLOR_BGR2YUV = 82, //!< convert between RGB/BGR and YUV
        COLOR_RGB2YUV = 83,
        COLOR_YUV2BGR = 84,
        COLOR_YUV2RGB = 85,

        COLOR_YUV2RGB_NV12 = 90, //!< convert between 4:2:0-subsampled YUV NV12 and RGB, two planes (in one or separate arrays): Y and U/V interleaved, see @ref color_convert_rgb_yuv_42x
        COLOR_YUV2BGR_NV12 = 91, //!< convert between 4:2:0-subsampled YUV NV12 and BGR, two planes (in one or separate arrays): Y and U/V interleaved, see @ref color_convert_rgb_yuv_42x
        COLOR_YUV2RGB_NV21 = 92, //!< convert between 4:2:0-subsampled YUV NV21 and RGB, two planes (in one or separate arrays): Y and V/U interleaved, see @ref color_convert_rgb_yuv_42x
        COLOR_YUV2BGR_NV21 = 93, //!< convert between 4:2:0-subsampled YUV NV21 and BGR, two planes (in one or separate arrays): Y and V/U interleaved, see @ref color_convert_rgb_yuv_42x
        COLOR_YUV420sp2RGB = COLOR_YUV2RGB_NV21, //!< synonym to NV21
        COLOR_YUV420sp2BGR = COLOR_YUV2BGR_NV21, //!< synonym to NV21

        COLOR_YUV2RGBA_NV12 = 94, //!< convert between 4:2:0-subsampled YUV NV12 and RGBA, two planes (in one or separate arrays): Y and U/V interleaved, see @ref color_convert_rgb_yuv_42x
        COLOR_YUV2BGRA_NV12 = 95, //!< convert between 4:2:0-subsampled YUV NV12 and BGRA, two planes (in one or separate arrays): Y and U/V interleaved, see @ref color_convert_rgb_yuv_42x
        COLOR_YUV2RGBA_NV21 = 96, //!< convert between 4:2:0-subsampled YUV NV21 and RGBA, two planes (in one or separate arrays): Y and V/U interleaved, see @ref color_convert_rgb_yuv_42x
        COLOR_YUV2BGRA_NV21 = 97, //!< convert between 4:2:0-subsampled YUV NV21 and BGRA, two planes (in one or separate arrays): Y and V/U interleaved, see @ref color_convert_rgb_yuv_42x
        COLOR_YUV420sp2RGBA = COLOR_YUV2RGBA_NV21, //!< synonym to NV21
        COLOR_YUV420sp2BGRA = COLOR_YUV2BGRA_NV21, //!< synonym to NV21

        COLOR_YUV2RGB_YV12 = 98, //!< convert between 4:2:0-subsampled YUV YV12 and RGB, three planes in one array: Y, V and U, see @ref color_convert_rgb_yuv_42x
        COLOR_YUV2BGR_YV12 = 99, //!< convert between 4:2:0-subsampled YUV YV12 and BGR, three planes in one array: Y, V and U, see @ref color_convert_rgb_yuv_42x
        COLOR_YUV2RGB_IYUV = 100, //!< convert between 4:2:0-subsampled YUV IYUV and RGB, three planes in one array: Y, U and V, see @ref color_convert_rgb_yuv_42x
        COLOR_YUV2BGR_IYUV = 101, //!< convert between 4:2:0-subsampled YUV IYUV and BGR, three planes in one array: Y, U and V, see @ref color_convert_rgb_yuv_42x
        COLOR_YUV2RGB_I420 = COLOR_YUV2RGB_IYUV, //!< synonym to IYUV
        COLOR_YUV2BGR_I420 = COLOR_YUV2BGR_IYUV, //!< synonym to IYUV
        COLOR_YUV420p2RGB = COLOR_YUV2RGB_YV12, //!< synonym to YV12
        COLOR_YUV420p2BGR = COLOR_YUV2BGR_YV12, //!< synonym to YV12

        COLOR_YUV2RGBA_YV12 = 102, //!< convert between 4:2:0-subsampled YUV YV12 and RGBA, three planes in one array: Y, V and U, see @ref color_convert_rgb_yuv_42x
        COLOR_YUV2BGRA_YV12 = 103, //!< convert between 4:2:0-subsampled YUV YV12 and BGRA, three planes in one array: Y, V and U, see @ref color_convert_rgb_yuv_42x
        COLOR_YUV2RGBA_IYUV = 104, //!< convert between 4:2:0-subsampled YUV YV12 and RGBA, three planes in one array: Y, U and V, see @ref color_convert_rgb_yuv_42x
        COLOR_YUV2BGRA_IYUV = 105, //!< convert between 4:2:0-subsampled YUV YV12 and BGRA, three planes in one array: Y, U and V, see @ref color_convert_rgb_yuv_42x
        COLOR_YUV2RGBA_I420 = COLOR_YUV2RGBA_IYUV, //!< synonym to IYUV
        COLOR_YUV2BGRA_I420 = COLOR_YUV2BGRA_IYUV, //!< synonym to IYUV
        COLOR_YUV420p2RGBA = COLOR_YUV2RGBA_YV12, //!< synonym to YV12
        COLOR_YUV420p2BGRA = COLOR_YUV2BGRA_YV12, //!< synonym to YV12

        COLOR_YUV2GRAY_420 = 106, //!< extract Y channel from YUV 4:2:0 image
        COLOR_YUV2GRAY_NV21 = COLOR_YUV2GRAY_420, //!< synonym to COLOR_YUV2GRAY_420
        COLOR_YUV2GRAY_NV12 = COLOR_YUV2GRAY_420, //!< synonym to COLOR_YUV2GRAY_420
        COLOR_YUV2GRAY_YV12 = COLOR_YUV2GRAY_420, //!< synonym to COLOR_YUV2GRAY_420
        COLOR_YUV2GRAY_IYUV = COLOR_YUV2GRAY_420, //!< synonym to COLOR_YUV2GRAY_420
        COLOR_YUV2GRAY_I420 = COLOR_YUV2GRAY_420, //!< synonym to COLOR_YUV2GRAY_420
        COLOR_YUV420sp2GRAY = COLOR_YUV2GRAY_420, //!< synonym to COLOR_YUV2GRAY_420
        COLOR_YUV420p2GRAY = COLOR_YUV2GRAY_420, //!< synonym to COLOR_YUV2GRAY_420

        COLOR_YUV2RGB_UYVY = 107, //!< convert between YUV UYVY and RGB, YUV is 4:2:2-subsampled and interleaved as U/Y1/V/Y2, see @ref color_convert_rgb_yuv_42x
        COLOR_YUV2BGR_UYVY = 108, //!< convert between YUV UYVY and BGR, YUV is 4:2:2-subsampled and interleaved as U/Y1/V/Y2, see @ref color_convert_rgb_yuv_42x
                                  //COLOR_YUV2RGB_VYUY = 109, //!< convert between YUV VYUY and RGB, YUV is 4:2:2-subsampled and interleaved as V/Y1/U/Y2, see @ref color_convert_rgb_yuv_42x
                                  //COLOR_YUV2BGR_VYUY = 110, //!< convert between YUV VYUY and BGR, YUV is 4:2:2-subsampled and interleaved as V/Y1/U/Y2, see @ref color_convert_rgb_yuv_42x
        COLOR_YUV2RGB_Y422 = COLOR_YUV2RGB_UYVY, //!< synonym to UYVY
        COLOR_YUV2BGR_Y422 = COLOR_YUV2BGR_UYVY, //!< synonym to UYVY
        COLOR_YUV2RGB_UYNV = COLOR_YUV2RGB_UYVY, //!< synonym to UYVY
        COLOR_YUV2BGR_UYNV = COLOR_YUV2BGR_UYVY, //!< synonym to UYVY

        COLOR_YUV2RGBA_UYVY = 111, //!< convert between YUV UYVY and RGBA, YUV is 4:2:2-subsampled and interleaved as U/Y1/V/Y2, see @ref color_convert_rgb_yuv_42x
        COLOR_YUV2BGRA_UYVY = 112, //!< convert between YUV UYVY and BGRA, YUV is 4:2:2-subsampled and interleaved as U/Y1/V/Y2, see @ref color_convert_rgb_yuv_42x
                                   //COLOR_YUV2RGBA_VYUY = 113, //!< convert between YUV VYUY and RGBA, YUV is 4:2:2-subsampled and interleaved as V/Y1/U/Y2, see @ref color_convert_rgb_yuv_42x
                                   //COLOR_YUV2BGRA_VYUY = 114, //!< convert between YUV VYUY and BGRA, YUV is 4:2:2-subsampled and interleaved as V/Y1/U/Y2, see @ref color_convert_rgb_yuv_42x
        COLOR_YUV2RGBA_Y422 = COLOR_YUV2RGBA_UYVY, //!< synonym to UYVY
        COLOR_YUV2BGRA_Y422 = COLOR_YUV2BGRA_UYVY, //!< synonym to UYVY
        COLOR_YUV2RGBA_UYNV = COLOR_YUV2RGBA_UYVY, //!< synonym to UYVY
        COLOR_YUV2BGRA_UYNV = COLOR_YUV2BGRA_UYVY, //!< synonym to UYVY

        COLOR_YUV2RGB_YUY2 = 115, //!< convert between YUV YUY2 and RGB, YUV is 4:2:2-subsampled and interleaved as Y1/U/Y2/V, see @ref color_convert_rgb_yuv_42x
        COLOR_YUV2BGR_YUY2 = 116, //!< convert between YUV YUY2 and BGR, YUV is 4:2:2-subsampled and interleaved as Y1/U/Y2/V, see @ref color_convert_rgb_yuv_42x
        COLOR_YUV2RGB_YVYU = 117, //!< convert between YUV YVYU and RGB, YUV is 4:2:2-subsampled and interleaved as Y1/V/Y2/U, see @ref color_convert_rgb_yuv_42x
        COLOR_YUV2BGR_YVYU = 118, //!< convert between YUV YVYU and BGR, YUV is 4:2:2-subsampled and interleaved as Y1/V/Y2/U, see @ref color_convert_rgb_yuv_42x
        COLOR_YUV2RGB_YUYV = COLOR_YUV2RGB_YUY2, //!< synonym to YUY2
        COLOR_YUV2BGR_YUYV = COLOR_YUV2BGR_YUY2, //!< synonym to YUY2
        COLOR_YUV2RGB_YUNV = COLOR_YUV2RGB_YUY2, //!< synonym to YUY2
        COLOR_YUV2BGR_YUNV = COLOR_YUV2BGR_YUY2, //!< synonym to YUY2

        COLOR_YUV2RGBA_YUY2 = 119, //!< convert between YUV YUY2 and RGBA, YUV is 4:2:2-subsampled and interleaved as Y1/U/Y2/V, see @ref color_convert_rgb_yuv_42x
        COLOR_YUV2BGRA_YUY2 = 120, //!< convert between YUV YUY2 and BGRA, YUV is 4:2:2-subsampled and interleaved as Y1/U/Y2/V, see @ref color_convert_rgb_yuv_42x
        COLOR_YUV2RGBA_YVYU = 121, //!< convert between YUV YVYU and RGBA, YUV is 4:2:2-subsampled and interleaved as Y1/V/Y2/U, see @ref color_convert_rgb_yuv_42x
        COLOR_YUV2BGRA_YVYU = 122, //!< convert between YUV YVYU and BGRA, YUV is 4:2:2-subsampled and interleaved as Y1/V/Y2/U, see @ref color_convert_rgb_yuv_42x
        COLOR_YUV2RGBA_YUYV = COLOR_YUV2RGBA_YUY2, //!< synonym to YUY2
        COLOR_YUV2BGRA_YUYV = COLOR_YUV2BGRA_YUY2, //!< synonym to YUY2
        COLOR_YUV2RGBA_YUNV = COLOR_YUV2RGBA_YUY2, //!< synonym to YUY2
        COLOR_YUV2BGRA_YUNV = COLOR_YUV2BGRA_YUY2, //!< synonym to YUY2

        COLOR_YUV2GRAY_UYVY = 123, //!< extract Y channel from YUV 4:2:2 image
        COLOR_YUV2GRAY_YUY2 = 124, //!< extract Y channel from YUV 4:2:2 image
                                   //CV_YUV2GRAY_VYUY  = CV_YUV2GRAY_UYVY, //!< synonym to COLOR_YUV2GRAY_UYVY
        COLOR_YUV2GRAY_Y422 = COLOR_YUV2GRAY_UYVY, //!< synonym to COLOR_YUV2GRAY_UYVY
        COLOR_YUV2GRAY_UYNV = COLOR_YUV2GRAY_UYVY, //!< synonym to COLOR_YUV2GRAY_UYVY
        COLOR_YUV2GRAY_YVYU = COLOR_YUV2GRAY_YUY2, //!< synonym to COLOR_YUV2GRAY_YUY2
        COLOR_YUV2GRAY_YUYV = COLOR_YUV2GRAY_YUY2, //!< synonym to COLOR_YUV2GRAY_YUY2
        COLOR_YUV2GRAY_YUNV = COLOR_YUV2GRAY_YUY2, //!< synonym to COLOR_YUV2GRAY_YUY2

        //! alpha premultiplication
        COLOR_RGBA2mRGBA = 125,
        COLOR_mRGBA2RGBA = 126,

        COLOR_RGB2YUV_I420 = 127, //!< convert between RGB and 4:2:0-subsampled YUV I420, three planes in one array: Y, U and V, see @ref color_convert_rgb_yuv_42x
        COLOR_BGR2YUV_I420 = 128, //!< convert between BGR and 4:2:0-subsampled YUV I420, three planes in one array: Y, U and V, see @ref color_convert_rgb_yuv_42x
        COLOR_RGB2YUV_IYUV = COLOR_RGB2YUV_I420, //!< synonym to I420
        COLOR_BGR2YUV_IYUV = COLOR_BGR2YUV_I420, //!< synonym to I420

        COLOR_RGBA2YUV_I420 = 129, //!< convert between RGBA and 4:2:0-subsampled YUV I420, three planes in one array: Y, U and V, see @ref color_convert_rgb_yuv_42x
        COLOR_BGRA2YUV_I420 = 130, //!< convert between BGRA and 4:2:0-subsampled YUV I420, three planes in one array: Y, U and V, see @ref color_convert_rgb_yuv_42x
        COLOR_RGBA2YUV_IYUV = COLOR_RGBA2YUV_I420, //!< synonym to I420
        COLOR_BGRA2YUV_IYUV = COLOR_BGRA2YUV_I420, //!< synonym to I420
        COLOR_RGB2YUV_YV12 = 131, //!< convert between RGB and 4:2:0-subsampled YUV YV12, three planes in one array: Y, V and U, see @ref color_convert_rgb_yuv_42x
        COLOR_BGR2YUV_YV12 = 132, //!< convert between BGR and 4:2:0-subsampled YUV YV12, three planes in one array: Y, V and U, see @ref color_convert_rgb_yuv_42x
        COLOR_RGBA2YUV_YV12 = 133, //!< convert between RGBA and 4:2:0-subsampled YUV YV12, three planes in one array: Y, V and U, see @ref color_convert_rgb_yuv_42x
        COLOR_BGRA2YUV_YV12 = 134, //!< convert between BGRA and 4:2:0-subsampled YUV YV12, three planes in one array: Y, V and U, see @ref color_convert_rgb_yuv_42x

        //! Demosaicing, see @ref color_convert_bayer "color conversions" for additional information
        COLOR_BayerBG2BGR = 46, //!< equivalent to RGGB Bayer pattern
        COLOR_BayerGB2BGR = 47, //!< equivalent to GRBG Bayer pattern
        COLOR_BayerRG2BGR = 48, //!< equivalent to BGGR Bayer pattern
        COLOR_BayerGR2BGR = 49, //!< equivalent to GBRG Bayer pattern

        COLOR_BayerRGGB2BGR = COLOR_BayerBG2BGR,
        COLOR_BayerGRBG2BGR = COLOR_BayerGB2BGR,
        COLOR_BayerBGGR2BGR = COLOR_BayerRG2BGR,
        COLOR_BayerGBRG2BGR = COLOR_BayerGR2BGR,

        COLOR_BayerRGGB2RGB = COLOR_BayerBGGR2BGR,
        COLOR_BayerGRBG2RGB = COLOR_BayerGBRG2BGR,
        COLOR_BayerBGGR2RGB = COLOR_BayerRGGB2BGR,
        COLOR_BayerGBRG2RGB = COLOR_BayerGRBG2BGR,

        COLOR_BayerBG2RGB = COLOR_BayerRG2BGR, //!< equivalent to RGGB Bayer pattern
        COLOR_BayerGB2RGB = COLOR_BayerGR2BGR, //!< equivalent to GRBG Bayer pattern
        COLOR_BayerRG2RGB = COLOR_BayerBG2BGR, //!< equivalent to BGGR Bayer pattern
        COLOR_BayerGR2RGB = COLOR_BayerGB2BGR, //!< equivalent to GBRG Bayer pattern

        COLOR_BayerBG2GRAY = 86, //!< equivalent to RGGB Bayer pattern
        COLOR_BayerGB2GRAY = 87, //!< equivalent to GRBG Bayer pattern
        COLOR_BayerRG2GRAY = 88, //!< equivalent to BGGR Bayer pattern
        COLOR_BayerGR2GRAY = 89, //!< equivalent to GBRG Bayer pattern

        COLOR_BayerRGGB2GRAY = COLOR_BayerBG2GRAY,
        COLOR_BayerGRBG2GRAY = COLOR_BayerGB2GRAY,
        COLOR_BayerBGGR2GRAY = COLOR_BayerRG2GRAY,
        COLOR_BayerGBRG2GRAY = COLOR_BayerGR2GRAY,

        //! Demosaicing using Variable Number of Gradients
        COLOR_BayerBG2BGR_VNG = 62, //!< equivalent to RGGB Bayer pattern
        COLOR_BayerGB2BGR_VNG = 63, //!< equivalent to GRBG Bayer pattern
        COLOR_BayerRG2BGR_VNG = 64, //!< equivalent to BGGR Bayer pattern
        COLOR_BayerGR2BGR_VNG = 65, //!< equivalent to GBRG Bayer pattern

        COLOR_BayerRGGB2BGR_VNG = COLOR_BayerBG2BGR_VNG,
        COLOR_BayerGRBG2BGR_VNG = COLOR_BayerGB2BGR_VNG,
        COLOR_BayerBGGR2BGR_VNG = COLOR_BayerRG2BGR_VNG,
        COLOR_BayerGBRG2BGR_VNG = COLOR_BayerGR2BGR_VNG,

        COLOR_BayerRGGB2RGB_VNG = COLOR_BayerBGGR2BGR_VNG,
        COLOR_BayerGRBG2RGB_VNG = COLOR_BayerGBRG2BGR_VNG,
        COLOR_BayerBGGR2RGB_VNG = COLOR_BayerRGGB2BGR_VNG,
        COLOR_BayerGBRG2RGB_VNG = COLOR_BayerGRBG2BGR_VNG,

        COLOR_BayerBG2RGB_VNG = COLOR_BayerRG2BGR_VNG, //!< equivalent to RGGB Bayer pattern
        COLOR_BayerGB2RGB_VNG = COLOR_BayerGR2BGR_VNG, //!< equivalent to GRBG Bayer pattern
        COLOR_BayerRG2RGB_VNG = COLOR_BayerBG2BGR_VNG, //!< equivalent to BGGR Bayer pattern
        COLOR_BayerGR2RGB_VNG = COLOR_BayerGB2BGR_VNG, //!< equivalent to GBRG Bayer pattern

        //! Edge-Aware Demosaicing
        COLOR_BayerBG2BGR_EA = 135, //!< equivalent to RGGB Bayer pattern
        COLOR_BayerGB2BGR_EA = 136, //!< equivalent to GRBG Bayer pattern
        COLOR_BayerRG2BGR_EA = 137, //!< equivalent to BGGR Bayer pattern
        COLOR_BayerGR2BGR_EA = 138, //!< equivalent to GBRG Bayer pattern

        COLOR_BayerRGGB2BGR_EA = COLOR_BayerBG2BGR_EA,
        COLOR_BayerGRBG2BGR_EA = COLOR_BayerGB2BGR_EA,
        COLOR_BayerBGGR2BGR_EA = COLOR_BayerRG2BGR_EA,
        COLOR_BayerGBRG2BGR_EA = COLOR_BayerGR2BGR_EA,

        COLOR_BayerRGGB2RGB_EA = COLOR_BayerBGGR2BGR_EA,
        COLOR_BayerGRBG2RGB_EA = COLOR_BayerGBRG2BGR_EA,
        COLOR_BayerBGGR2RGB_EA = COLOR_BayerRGGB2BGR_EA,
        COLOR_BayerGBRG2RGB_EA = COLOR_BayerGRBG2BGR_EA,

        COLOR_BayerBG2RGB_EA = COLOR_BayerRG2BGR_EA, //!< equivalent to RGGB Bayer pattern
        COLOR_BayerGB2RGB_EA = COLOR_BayerGR2BGR_EA, //!< equivalent to GRBG Bayer pattern
        COLOR_BayerRG2RGB_EA = COLOR_BayerBG2BGR_EA, //!< equivalent to BGGR Bayer pattern
        COLOR_BayerGR2RGB_EA = COLOR_BayerGB2BGR_EA, //!< equivalent to GBRG Bayer pattern

        //! Demosaicing with alpha channel
        COLOR_BayerBG2BGRA = 139, //!< equivalent to RGGB Bayer pattern
        COLOR_BayerGB2BGRA = 140, //!< equivalent to GRBG Bayer pattern
        COLOR_BayerRG2BGRA = 141, //!< equivalent to BGGR Bayer pattern
        COLOR_BayerGR2BGRA = 142, //!< equivalent to GBRG Bayer pattern

        COLOR_BayerRGGB2BGRA = COLOR_BayerBG2BGRA,
        COLOR_BayerGRBG2BGRA = COLOR_BayerGB2BGRA,
        COLOR_BayerBGGR2BGRA = COLOR_BayerRG2BGRA,
        COLOR_BayerGBRG2BGRA = COLOR_BayerGR2BGRA,

        COLOR_BayerRGGB2RGBA = COLOR_BayerBGGR2BGRA,
        COLOR_BayerGRBG2RGBA = COLOR_BayerGBRG2BGRA,
        COLOR_BayerBGGR2RGBA = COLOR_BayerRGGB2BGRA,
        COLOR_BayerGBRG2RGBA = COLOR_BayerGRBG2BGRA,

        COLOR_BayerBG2RGBA = COLOR_BayerRG2BGRA, //!< equivalent to RGGB Bayer pattern
        COLOR_BayerGB2RGBA = COLOR_BayerGR2BGRA, //!< equivalent to GRBG Bayer pattern
        COLOR_BayerRG2RGBA = COLOR_BayerBG2BGRA, //!< equivalent to BGGR Bayer pattern
        COLOR_BayerGR2RGBA = COLOR_BayerGB2BGRA, //!< equivalent to GBRG Bayer pattern

        COLOR_RGB2YUV_UYVY = 143, //!< convert between RGB and YUV UYVU, YUV is 4:2:2 and interleaved as U/Y1/V/Y2, see @ref color_convert_rgb_yuv_42x
        COLOR_BGR2YUV_UYVY = 144, //!< convert between BGR and YUV UYVU, YUV is 4:2:2 and interleaved as U/Y1/V/Y2, see @ref color_convert_rgb_yuv_42x
        COLOR_RGB2YUV_Y422 = COLOR_RGB2YUV_UYVY, //!< synonym to UYVY
        COLOR_BGR2YUV_Y422 = COLOR_BGR2YUV_UYVY, //!< synonym to UYVY
        COLOR_RGB2YUV_UYNV = COLOR_RGB2YUV_UYVY, //!< synonym to UYVY
        COLOR_BGR2YUV_UYNV = COLOR_BGR2YUV_UYVY, //!< synonym to UYVY

        COLOR_RGBA2YUV_UYVY = 145, //!< convert between RGBA and YUV UYVU, YUV is 4:2:2 and interleaved as U/Y1/V/Y2, see @ref color_convert_rgb_yuv_42x
        COLOR_BGRA2YUV_UYVY = 146, //!< convert between BGRA and YUV UYVU, YUV is 4:2:2 and interleaved as U/Y1/V/Y2, see @ref color_convert_rgb_yuv_42x
        COLOR_RGBA2YUV_Y422 = COLOR_RGBA2YUV_UYVY, //!< synonym to UYVY
        COLOR_BGRA2YUV_Y422 = COLOR_BGRA2YUV_UYVY, //!< synonym to UYVY
        COLOR_RGBA2YUV_UYNV = COLOR_RGBA2YUV_UYVY, //!< synonym to UYVY
        COLOR_BGRA2YUV_UYNV = COLOR_BGRA2YUV_UYVY, //!< synonym to UYVY

        COLOR_RGB2YUV_YUY2 = 147, //!< convert between RGB and YUV YUY2, YUV is 4:2:2 and interleaved as Y1/U/Y2/V, see @ref color_convert_rgb_yuv_42x
        COLOR_BGR2YUV_YUY2 = 148, //!< convert between BGR and YUV YUY2, YUV is 4:2:2 and interleaved as Y1/U/Y2/V, see @ref color_convert_rgb_yuv_42x
        COLOR_RGB2YUV_YVYU = 149, //!< convert between RGB and YUV YVYU, YUV is 4:2:2 and interleaved as Y1/V/Y2/U, see @ref color_convert_rgb_yuv_42x
        COLOR_BGR2YUV_YVYU = 150, //!< convert between BGR and YUV YVYU, YUV is 4:2:2 and interleaved as Y1/V/Y2/U, see @ref color_convert_rgb_yuv_42x
        COLOR_RGB2YUV_YUYV = COLOR_RGB2YUV_YUY2, //!< synonym to YUY2
        COLOR_BGR2YUV_YUYV = COLOR_BGR2YUV_YUY2, //!< synonym to YUY2
        COLOR_RGB2YUV_YUNV = COLOR_RGB2YUV_YUY2, //!< synonym to YUY2
        COLOR_BGR2YUV_YUNV = COLOR_BGR2YUV_YUY2, //!< synonym to YUY2

        COLOR_RGBA2YUV_YUY2 = 151, //!< convert between RGBA and YUV YUY2, YUV is 4:2:2 and interleaved as Y1/U/Y2/V, see @ref color_convert_rgb_yuv_42x
        COLOR_BGRA2YUV_YUY2 = 152, //!< convert between BGRA and YUV YUY2, YUV is 4:2:2 and interleaved as Y1/U/Y2/V, see @ref color_convert_rgb_yuv_42x
        COLOR_RGBA2YUV_YVYU = 153, //!< convert between RGBA and YUV YVYU, YUV is 4:2:2 and interleaved as Y1/V/Y2/U, see @ref color_convert_rgb_yuv_42x
        COLOR_BGRA2YUV_YVYU = 154, //!< convert between BGRA and YUV YVYU, YUV is 4:2:2 and interleaved as Y1/V/Y2/U, see @ref color_convert_rgb_yuv_42x
        COLOR_RGBA2YUV_YUYV = COLOR_RGBA2YUV_YUY2, //!< synonym to YUY2
        COLOR_BGRA2YUV_YUYV = COLOR_BGRA2YUV_YUY2, //!< synonym to YUY2
        COLOR_RGBA2YUV_YUNV = COLOR_RGBA2YUV_YUY2, //!< synonym to YUY2
        COLOR_BGRA2YUV_YUNV = COLOR_BGRA2YUV_YUY2, //!< synonym to YUY2

        COLOR_COLORCVT_MAX = 155
    };
}