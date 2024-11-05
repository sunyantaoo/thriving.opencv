#include "opencv.h"

extern "C" {

	/// <summary>
/// 释放资源
/// </summary>
/// <param name="img"></param>
	_declspec(dllexport) void matRelease(cv::Mat* img) {
		img->release();
		delete img;
	}

	_declspec(dllexport) cv::Mat* matRead(const char* imgPath, int flags) {
		cv::Mat img = cv::imread(cv::String(imgPath), flags);
		return new cv::Mat(img);
	}

	_declspec(dllexport) cv::Mat* matNew(int rows, int cols, int channels, int depth, void* data, size_t step) {
		int type = CV_MAKETYPE(depth, channels);
		return new cv::Mat(rows, cols, type, data, step);
	}

	_declspec(dllexport) cv::Mat* matEmpty(int rows, int cols, int channels, int depth) {
		int type = CV_MAKETYPE(depth, channels);
		return new cv::Mat(rows, cols, type);
	}

	_declspec(dllexport) cv::Mat* matConvertColor(cv::Mat& img, int code, int destC) {
		cv::Mat dest;
		cv::cvtColor(img, dest, code, destC);
		return new cv::Mat(dest);
	}


	/// <summary>
	/// 每个像素第一个通道为1，其余为0
	/// </summary>
	/// <param name="rows"></param>
	/// <param name="cols"></param>
	/// <param name="type"></param>
	/// <returns></returns>
	_declspec(dllexport) cv::Mat* matOnes(int rows, int cols, int type) {
		cv::Mat img = cv::Mat::ones(rows, cols, type);
		return new cv::Mat(img);
	}

	/// <summary>
	/// 每个像素的所有通道均为0，即黑色图
	/// </summary>
	/// <param name="rows"></param>
	/// <param name="cols"></param>
	/// <param name="type"></param>
	/// <returns></returns>
	_declspec(dllexport) cv::Mat* matZeros(int rows, int cols, int type) {
		cv::Mat img = cv::Mat::zeros(rows, cols, type);
		return new cv::Mat(img);
	}

	/// <summary>
	/// 数据类型
	/// </summary>
	/// <param name="img"></param>
	/// <returns></returns>
	_declspec(dllexport) int matDepth(cv::Mat& img) {
		return img.depth();
	}

	/// <summary>
	/// 通道数
	/// </summary>
	/// <param name="img"></param>
	/// <returns></returns>
	_declspec(dllexport) int matChannels(cv::Mat& img) {
		return img.channels();
	}

	/// <summary>
	/// 数据是否为空
	/// </summary>
	/// <param name="img"></param>
	/// <returns></returns>
	_declspec(dllexport) bool matIsEmpty(cv::Mat& img) {
		return	img.empty();
	}

	/// <summary>
	/// 数据是否连续
	/// </summary>
	/// <param name="img"></param>
	/// <returns></returns>
	_declspec(dllexport) bool matIsContinuous(cv::Mat& img) {
		return	img.isContinuous();
	}

	/// <summary>
	/// 截取范围
	/// </summary>
	/// <param name="img"></param>
	/// <param name="rowStart"></param>
	/// <param name="rowEnd"></param>
	/// <param name="colStart"></param>
	/// <param name="colEnd"></param>
	/// <returns></returns>
	_declspec(dllexport) cv::Mat* matRegion(cv::Mat& img, int rowStart, int rowEnd, int colStart, int colEnd) {
		return	new cv::Mat(img, cv::Range(rowStart, rowEnd), cv::Range(colStart, colEnd));
	}


	_declspec(dllexport) cv::Mat* matResize(cv::Mat& img, cv::Size size, double fx, double fy, int interpolation) {
		cv::Mat dest;
		cv::resize(img, dest, size, fx, fy, interpolation);
		return	new cv::Mat(dest);
	}

	/// <summary>
	/// 拆分通道
	/// </summary>
	/// <param name="img"></param>
	/// <returns></returns>
	_declspec(dllexport) cv::Mat* matSplit(cv::Mat& img) {
		int size = img.channels();
		cv::Mat* channels = new cv::Mat[size];

		cv::split(img, channels);
		return channels;
	}

	/// <summary>
	/// 合并通道
	/// </summary>
	/// <param name="channels"></param>
	/// <param name="count"></param>
	/// <returns></returns>
	_declspec(dllexport) cv::Mat* matMerge(cv::Mat channels[], int count) {
		cv::Mat dest;
		cv::merge(channels, count, dest);
		return new cv::Mat(dest);
	}

	/// <summary>
	/// 写文件
	/// </summary>
	/// <param name="img"></param>
	/// <param name="imgPath"></param>
	/// <param name="paramPtr"></param>
	/// <param name="pCount"></param>
	/// <returns></returns>
	_declspec(dllexport) bool matWrite(cv::Mat& img, const char* imgPath, int* paramPtr, int pCount) {
		std::vector<int> inParams;
		for (size_t i = 0; i < pCount; i++)
		{
			inParams.push_back(paramPtr[i]);
		}
		return	cv::imwrite(cv::String(imgPath), img, inParams);
	}




	/// <summary>
	/// 卷积操作 Convolution
	/// </summary>
	/// <param name="img">原始图像</param>
	/// <param name="kernel">卷积矩阵</param>
	/// /// <param name="ddepth"></param>
	/// <param name="anchor">锚点</param>
	/// <param name="delta"></param>
	/// <param name="borderType"></param>
	/// <returns></returns>
	_declspec(dllexport) cv::Mat* matFilter2D(cv::Mat& img, cv::Mat& kernel, int ddepth, cv::Point anchor = cv::Point(-1, -1), double delta = 0, int borderType = cv::BorderTypes::BORDER_DEFAULT) {
		cv::Mat dest;
		cv::filter2D(img, dest, ddepth, kernel, anchor, delta, borderType);
		return	new cv::Mat(dest);
	}

	/// <summary>
	/// 均值滤波：当前像素值取为卷积（卷积矩阵的值全为1）后各个值的平均值
	/// </summary>
	/// <returns></returns>
	_declspec(dllexport) cv::Mat* matBlur(cv::Mat& img, cv::Size ksize, cv::Point anchor = cv::Point(-1, -1), int borderType = 4)
	{
		cv::Mat dest;
		cv::blur(img, dest, ksize, anchor, borderType);
		return new cv::Mat(dest);
	}

	/// <summary>
	/// 高斯滤波：卷积矩阵为高斯矩阵
	/// </summary>
	/// <returns></returns>
	_declspec(dllexport) cv::Mat* matGaussianBlur(cv::Mat& img, cv::Size ksize, double sigmaX, double sigmaY = 0, int borderType = 4, cv::AlgorithmHint hint = cv::ALGO_HINT_DEFAULT)
	{
		cv::Mat dest;
		cv::GaussianBlur(img, dest, ksize, sigmaX, sigmaY, borderType, hint);
		return new cv::Mat(dest);
	}
	/// <summary>
	/// 中值滤波：当前像素值取为卷积（卷积矩阵的值全为1）后各个值的中间值
	/// </summary>
	/// <returns></returns>
	_declspec(dllexport) cv::Mat* matMedianBlur(cv::Mat& img, int ksize)
	{
		cv::Mat	dest;
		cv::medianBlur(img, dest, ksize);
		return	 new cv::Mat(dest);
	}

	/// <summary>
	/// 方框滤波：同均值滤波，normalize表示是否求平均值，结果越界后取为255
	/// </summary>
	/// <returns></returns>
	_declspec(dllexport) cv::Mat* matBoxFilter(cv::Mat& img, int ddepth, cv::Size ksize, cv::Point anchor = cv::Point(-1, -1), bool normalize = true, int borderType = 4)
	{
		cv::Mat	dest;
		cv::boxFilter(img, dest, ddepth, ksize, anchor, normalize, borderType);
		return	 new cv::Mat(dest);
	}

	/// <summary>
	/// 阈值操作
	/// </summary>
	/// <returns></returns>
	_declspec(dllexport) cv::Mat* matThreshold(cv::Mat& img, double thresh, double maxval, int type, double* threshold)
	{
		cv::Mat	dest;
		*threshold = cv::threshold(img, dest, thresh, maxval, type);
		return	 new cv::Mat(dest);
	}

	/// <summary>
	/// 腐蚀
	/// </summary>
	/// <returns></returns>
	_declspec(dllexport) cv::Mat* matErode(cv::Mat& img, cv::Mat& kernel, cv::Point anchor = cv::Point(-1, -1), int iterations = 1, int borderType = 4, const  cv::Scalar& borderValue = cv::morphologyDefaultBorderValue())
	{
		cv::Mat	dest;
		cv::erode(img, dest, kernel, anchor, iterations, borderType, borderValue);
		return	 new cv::Mat(dest);
	}

	/// <summary>
	/// 膨胀
	/// </summary>
	/// <returns></returns>
	_declspec(dllexport) cv::Mat* matDilate(cv::Mat& img, cv::Mat& kernel, cv::Point anchor = cv::Point(-1, -1), int iterations = 1, int borderType = 4, const cv::Scalar& borderValue = cv::morphologyDefaultBorderValue())
	{
		cv::Mat	dest;
		cv::dilate(img, dest, kernel, anchor, iterations, borderType, borderValue);
		return	 new cv::Mat(dest);
	}

	/// <summary>
	/// 形态学
	/// </summary>
	/// <returns></returns>
	_declspec(dllexport) cv::Mat* matMorphologyEx(cv::Mat& img, int operation, cv::Mat& kernel, cv::Point anchor = cv::Point(-1, -1), int iterations = 1, int borderType = 4, const cv::Scalar& borderValue = cv::morphologyDefaultBorderValue())
	{
		cv::Mat	dest;
		cv::morphologyEx(img, dest, operation, kernel, anchor, iterations, borderType, borderValue);
		return	 new cv::Mat(dest);
	}

	/// <summary>
	/// 卷积核 x轴[[-1,0,1],[-2,0,2],[-1,0,1]] y轴[[-1,-1,-1],[0,0,0],[1,2,1]]
	/// </summary>
	/// <returns></returns>
	_declspec(dllexport) cv::Mat* matSobel(cv::Mat& img, int ddepth, int dx, int dy, int ksize = 3, double scale = 1.0, double delta = 0.0, int borderType = 4)
	{
		cv::Mat	dest;
		cv::Sobel(img, dest, ddepth, dx, dy, ksize, scale, delta, borderType);
		return	 new cv::Mat(dest);
	}

	/// <summary>
	/// 卷积核 x轴[[-3,0,3],[-10,0,10],[-3,0,3]] y轴[[-3,-10,-3],[0,0,0],[3,10,3]]
	/// </summary>
	/// <returns></returns>
	_declspec(dllexport) cv::Mat* matScharr(cv::Mat& img, int ddepth, int dx, int dy, double scale = 1.0, double delta = 0.0, int borderType = 4)
	{
		cv::Mat	dest;
		cv::Scharr(img, dest, ddepth, dx, dy, scale, delta, borderType);
		return	 new cv::Mat(dest);
	}

	/// <summary>
	/// 卷积核[[0,1,0],[1,-4,1],[0,1,0]]
	/// </summary>
	/// <returns></returns>
	_declspec(dllexport) cv::Mat* matLaplacian(cv::Mat& img, int ddepth, int ksize = 1, double scale = 1.0, double delta = 0.0, int borderType = 4)
	{
		cv::Mat	dest;
		cv::Laplacian(img, dest, ddepth,ksize, scale, delta, borderType);
		return	 new cv::Mat(dest);
	}

	/// <summary>
	/// 匹配模板
	/// </summary>
	/// <param name="img"></param>
	/// <param name="templ"></param>
	/// <param name="method"></param>
	/// <param name="mask"></param>
	/// <returns></returns>
	_declspec(dllexport) cv::Mat* matMatchTemplate(cv::Mat& img, cv::Mat& templ, int method, cv::Mat& mask)
	{
		cv::Mat dest;
		cv::matchTemplate(img, templ, dest, method, mask);
		return new cv::Mat(dest);
	}

	_declspec(dllexport) cv::Mat* matFindContours(cv::Mat& img, int mode, int method, cv::Point& offset)
	{
		std::vector<cv::Vec4i>  hierarchy;
		std::vector<std::vector<cv::Point>> contours;

		cv::findContours(img, contours, hierarchy, mode, method, offset);
		return	 new cv::Mat(hierarchy);
	}

}