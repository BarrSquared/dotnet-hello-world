using System;

namespace Problem1
{
    public class LoveTests
    {
        public static bool lovefunc(int flower1, int flower2) => ((flower1 % 2 == 0 && flower2 % 2 != 0) || (flower2 % 2 == 0 && flower1 % 2 != 0)) ? true : false;
    }
}