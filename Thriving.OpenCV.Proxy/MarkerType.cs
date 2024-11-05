namespace Thriving.OpenCV
{
    public  enum MarkerType
    {
        /// <summary>
        /// A crosshair marker shape
        /// </summary>
        MARKER_CROSS = 0,
        /// <summary>
        /// A 45 degree tilted crosshair marker shape
        /// </summary>
        MARKER_TILTED_CROSS = 1,
        /// <summary>
        /// A star marker shape, combination of cross and tilted cross
        /// </summary>
        MARKER_STAR = 2,
        /// <summary>
        /// A diamond marker shape
        /// </summary>
        MARKER_DIAMOND = 3,
        /// <summary>
        /// A square marker shape
        /// </summary>
        MARKER_SQUARE = 4,
        /// <summary>
        ///  An upwards pointing triangle marker shape
        /// </summary>
        MARKER_TRIANGLE_UP = 5,
        /// <summary>
        /// A downwards pointing triangle marker shape
        /// </summary>
        MARKER_TRIANGLE_DOWN = 6   
    }
}