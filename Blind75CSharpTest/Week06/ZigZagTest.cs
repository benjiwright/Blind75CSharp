using Blind75CSharp.Week06;
using FluentAssertions;
using Xunit;

namespace Blind75CSharpTest.Week06;

public class ZigZagTest
{
   [Theory]
   [InlineData("PAYPALISHIRING", 3, "PAHNAPLSIIGYIR")]
   [InlineData("PAYPALISHIRING", 4, "PINALSIGYAHRPI")]
   [InlineData("AB", 1, "AB")]
   [InlineData("AB", 2, "AB")]
   [InlineData("ABC", 2, "ACB")]
   public void Convert_When_OriginalAnswerWithoutCleanUp(string input, int numRows, string result)
   {
      var testObj = new ZigZag();
      var actual = testObj.ConvertBeforeRefactor(input, numRows);
      actual.Should().Be(result);
   }
   
   [Theory]
   [InlineData("PAYPALISHIRING", 3, "PAHNAPLSIIGYIR")]
   [InlineData("PAYPALISHIRING", 4, "PINALSIGYAHRPI")]
   [InlineData("AB", 1, "AB")]
   [InlineData("AB", 2, "AB")]
   [InlineData("ABC", 2, "ACB")]
   public void Convert_When_Refactored(string input, int numRows, string result)
   {
      var testObj = new ZigZag();
      var actual = testObj.Convert(input, numRows);
      actual.Should().Be(result);
   }
   
}