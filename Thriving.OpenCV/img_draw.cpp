#include "opencv2/imgproc.hpp"


extern "C" {

	_declspec(dllexport) void drawLine(cv::Mat& img, cv::Point start, cv::Point end, const cv::Scalar& color, int thickness, int lineType, int shift) {
		cv::line(img, start, end, color, thickness, lineType, shift);
	}

	_declspec(dllexport) void drawArrowedLine(cv::Mat& img, cv::Point start, cv::Point end, const cv::Scalar& color, int thickness, int lineType, int shift, double tipLength) {
		cv::arrowedLine(img, start, end, color, thickness, lineType, shift, tipLength);
	}

	_declspec(dllexport) void drawRectangle(cv::Mat& img, cv::Rect rect, const cv::Scalar& color, int thickness, int lineType, int shift) {
		cv::rectangle(img, rect, color, thickness, lineType, shift);
	}

	_declspec(dllexport) void drawCircle(cv::Mat& img, cv::Point center, int radius, const cv::Scalar& color, int thickness, int lineType, int shift) {
		cv::circle(img, center, radius, color, thickness, lineType, shift);
	}

	_declspec(dllexport) void drawEllipse(cv::Mat& img, cv::Point center, cv::Size axes, double angle, double startAngle, double endAngle, const cv::Scalar& color, int thickness, int lineType, int shift) {
		cv::ellipse(img, center, axes, angle, startAngle, endAngle, color, thickness, lineType, shift);
	}

	_declspec(dllexport) void drawPolylines(cv::Mat& img, const cv::Point* const* pts, const int* npts, int ncountours, bool isclosed, const cv::Scalar& color, int thickness, int lineType, int shift) {
		cv::polylines(img, pts, npts, ncountours, isclosed, color, thickness, lineType, shift);
	}

	_declspec(dllexport) void drawText(cv::Mat& img, const cv::String& text, cv::Point org, int fontFace, double fontScale, cv::Scalar color, int thickness, int lineType, bool bottomLeftOrigin = false) {
		cv::putText(img, text, org, fontFace, fontScale, color, thickness, lineType, bottomLeftOrigin);
	}

	_declspec(dllexport) void drawMaker(cv::Mat& img, cv::Point position, cv::Scalar color, int makerType, int thickness, int lineType) {
		cv::drawMarker(img, position, color, makerType, thickness, lineType);
	}

	_declspec(dllexport) void drawContours(cv::Mat& img, std::vector<std::vector<cv::Point>> contours,
		int contourIdx, const cv::Scalar& color,
		int thickness = 1, int lineType = cv::LINE_8,
		cv::InputArray hierarchy = cv::noArray(),
		int maxLevel = INT_MAX, cv::Point offset = cv::Point())
	{
		cv::drawContours(img, contours, contourIdx, color, thickness, lineType, hierarchy, maxLevel, offset);
	}
}