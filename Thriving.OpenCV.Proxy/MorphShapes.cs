namespace Thriving.OpenCV
{
    public enum MorphShapes
    {
        MORPH_RECT = 0, //!< a rectangular structuring element:  \f[E_{ij}=1\f]
        MORPH_CROSS = 1, //!< a cross-shaped structuring element:
                         //!< \f[E_{ij} = \begin{cases} 1 & \texttt{if } {i=\texttt{anchor.y } {or } {j=\texttt{anchor.x}}} \\0 & \texttt{otherwise} \end{cases}\f]
        MORPH_ELLIPSE = 2 //!< an elliptic structuring element, that is, a filled ellipse inscribed
                          //!< into the rectangle Rect(0, 0, esize.width, 0.esize.height)
    };
}