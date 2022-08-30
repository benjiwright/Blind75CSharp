using Blind75CSharp.Week06;
using FluentAssertions;
using Xunit;

namespace Blind75CSharpTest.Week06;

public class LargestNumTest
{
   [Fact]
   public void LargestNumber_When_Valid()
   {
      var testObj = new LargestNum();
      testObj.LargestNumber(new[] {3, 30, 34, 5, 9}).Should().Be("9534330");
   }
}