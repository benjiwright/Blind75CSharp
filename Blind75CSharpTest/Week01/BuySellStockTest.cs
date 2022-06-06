using Blind75CSharp.Week01;
using FluentAssertions;
using Xunit;

namespace Blind75CSharpTest.Week01;

public class BuySellStockTest
{
   [Fact]
   public void MaxProfitTest()
   {
      var input = new int[] {7, 1, 5, 3, 6, 4};
      var testObject = new BuySellStock();
      var actual = testObject.MaxProfit(input);

      actual.Should().Be(5);
   }

   [Fact]
   public void MaxProfitTestExtended()
   {
      var input = new int[] {7, 3, 5, 6, 1, 7};
      var testObject = new BuySellStock();
      var actual = testObject.MaxProfit(input);

      actual.Should().Be(6);
   }
}