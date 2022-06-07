using Blind75CSharp.Week01;
using Xunit;

namespace Blind75CSharpTest.Week01;

public class ThreeSummerTest
{
   [Fact]
   public void ThreeSummer_Valid()
   {

      //var input = new int[] { 2,-3,6,4,1,-3 };
      var input = new int[] {-1, 0, 1, 2, -1, -4};
      var testObject = new ThreeSummer();
      var actual = testObject.ThreeSum(input);

   }

}