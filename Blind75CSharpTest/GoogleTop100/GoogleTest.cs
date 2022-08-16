using Blind75CSharp.GoogleTop100;
using FluentAssertions;
using Xunit;

namespace Blind75CSharpTest.GoogleTop100;

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