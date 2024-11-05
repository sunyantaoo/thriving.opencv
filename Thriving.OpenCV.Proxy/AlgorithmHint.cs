namespace Thriving.OpenCV
{
    public enum AlgorithmHint
    {
        ALGO_HINT_DEFAULT = 0, //!< Default algorithm behaviour defined during OpenCV build
        ALGO_HINT_ACCURATE = 1, //!< Use generic portable implementation
        ALGO_HINT_APPROX = 2, //!< Allow alternative approximations to get faster implementation. Behaviour and result depends on a platform
    };
}