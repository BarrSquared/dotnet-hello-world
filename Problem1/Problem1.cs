using System;

namespace Problem1
{
    public class LoveTests
    {
        public static bool lovefunc(int flower1, int flower2) => ((flower1 % 2 == 0 && flower2 % 2 != 0) || (flower2 % 2 == 0 && flower1 % 2 != 0)) ? true : false;
    }
}


// // Problem from https://www.codewars.com/kata/555086d53eac039a2a000083/train/csharp

// using NUnit.Framework;
//   using System;
//   [TestFixture]
//   public class LoveTests
//   { 
//     [Test]
//     public void Test1()
//     {
//       Assert.AreEqual(true, LoveDetector.lovefunc(1,4));
//     }

//     [Test]
//     public void Test2()
//     {
//       Assert.AreEqual(false, LoveDetector.lovefunc(2,2));
//     }

//     [Test]
//     public void Test3()
//     {
//      Assert.AreEqual(true, LoveDetector.lovefunc(0,1));
//     }

//     [Test]
//     public void Test4()
//     {
//       Assert.AreEqual(false, LoveDetector.lovefunc(0,0));
//     }
// }