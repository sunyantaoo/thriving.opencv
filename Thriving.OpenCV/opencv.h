#include "opencv2/imgcodecs.hpp"
#include "opencv2/imgproc.hpp"

#pragma once

struct Contour
{
	cv::Point* data;
	size_t size;
};
