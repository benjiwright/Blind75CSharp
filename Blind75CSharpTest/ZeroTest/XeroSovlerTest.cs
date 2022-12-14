using Blind75CSharp.Xero;
using FluentAssertions;
using Xunit;

namespace Blind75CSharpTest.ZeroTest;

public class XeroSovlerTest
{
   [Theory]
   [InlineData(new int[] {2, 1, 2}, 5)]
   public void FindDistanceToOrigin(int[] input, int expected)
   {
      var testObj = new XeroSolver();
   }
}