namespace Thriving.OpenCV
{
    public enum TemplateMatchMode
    {
        TM_SQDIFF = 0, /*!< \f[R(x,y)= \sum _{x',y'} (T(x',y')-I(x+x',y+y'))^2\f]
                               with mask:
                               \f[R(x,y)= \sum _{x',y'} \left( (T(x',y')-I(x+x',y+y')) \cdot
                                  M(x',y') \right)^2\f] */
        TM_SQDIFF_NORMED = 1, /*!< \f[R(x,y)= \frac{\sum_{x',y'} (T(x',y')-I(x+x',y+y'))^2}{\sqrt{\sum_{
                                  x',y'}T(x',y')^2 \cdot \sum_{x',y'} I(x+x',y+y')^2}}\f]
                               with mask:
                               \f[R(x,y)= \frac{\sum _{x',y'} \left( (T(x',y')-I(x+x',y+y')) \cdot
                                  M(x',y') \right)^2}{\sqrt{\sum_{x',y'} \left( T(x',y') \cdot
                                  M(x',y') \right)^2 \cdot \sum_{x',y'} \left( I(x+x',y+y') \cdot
                                  M(x',y') \right)^2}}\f] */
        TM_CCORR = 2, /*!< \f[R(x,y)= \sum _{x',y'} (T(x',y') \cdot I(x+x',y+y'))\f]
                               with mask:
                               \f[R(x,y)= \sum _{x',y'} (T(x',y') \cdot I(x+x',y+y') \cdot M(x',y')
                                  ^2)\f] */
        TM_CCORR_NORMED = 3, /*!< \f[R(x,y)= \frac{\sum_{x',y'} (T(x',y') \cdot I(x+x',y+y'))}{\sqrt{
                                  \sum_{x',y'}T(x',y')^2 \cdot \sum_{x',y'} I(x+x',y+y')^2}}\f]
                               with mask:
                               \f[R(x,y)= \frac{\sum_{x',y'} (T(x',y') \cdot I(x+x',y+y') \cdot
                                  M(x',y')^2)}{\sqrt{\sum_{x',y'} \left( T(x',y') \cdot M(x',y')
                                  \right)^2 \cdot \sum_{x',y'} \left( I(x+x',y+y') \cdot M(x',y')
                                  \right)^2}}\f] */
        TM_CCOEFF = 4, /*!< \f[R(x,y)= \sum _{x',y'} (T'(x',y') \cdot I'(x+x',y+y'))\f]
                               where
                               \f[\begin{array}{l} T'(x',y')=T(x',y') - 1/(w \cdot h) \cdot \sum _{
                                  x'',y''} T(x'',y'') \\ I'(x+x',y+y')=I(x+x',y+y') - 1/(w \cdot h)
                                  \cdot \sum _{x'',y''} I(x+x'',y+y'') \end{array}\f]
                               with mask:
                               \f[\begin{array}{l} T'(x',y')=M(x',y') \cdot \left( T(x',y') -
                                  \frac{1}{\sum _{x'',y''} M(x'',y'')} \cdot \sum _{x'',y''}
                                  (T(x'',y'') \cdot M(x'',y'')) \right) \\ I'(x+x',y+y')=M(x',y')
                                  \cdot \left( I(x+x',y+y') - \frac{1}{\sum _{x'',y''} M(x'',y'')}
                                  \cdot \sum _{x'',y''} (I(x+x'',y+y'') \cdot M(x'',y'')) \right)
                                  \end{array} \f] */
        TM_CCOEFF_NORMED = 5  /*!< \f[R(x,y)= \frac{ \sum_{x',y'} (T'(x',y') \cdot I'(x+x',y+y')) }{
                                  \sqrt{\sum_{x',y'}T'(x',y')^2 \cdot \sum_{x',y'} I'(x+x',y+y')^2}
                                  }\f] */
    }
}