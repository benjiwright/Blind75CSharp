using Xunit;
using Blind75CSharp.Week06;
using FluentAssertions;

namespace Blind75CSharpTest.Week06;

public class SlidingWindowMaxTest
{
   [Fact]
   public void SlidingWindowMax_MaxSlidingWindow()
   {
      var testObj = new SlidingWindowMax();
      var expected = new int[] {3, 3, 5, 5, 6, 7};
      var input = new int[] {1, 3, -1, -3, 5, 3, 6, 7};
      testObj.MaxSlidingWindow(input, 3).Should()
         .BeEquivalentTo(expected, cfg
            => cfg.WithStrictOrdering());
   }
}