using Blind75CSharp.FangPopular.Google;
using FluentAssertions;
using Xunit;

namespace Blind75CSharpTest.FangPopularTest.Google;

public class GoogleTest
{
   [Fact]
   public void Cards_MaxScore()
   {
      var testObj = new Cards();
      var cards = new int[] { 1, 2, 3, 4, 5, 6, 1};
      testObj.MaxScore(cards,3).Should().Be(12);

   }
}