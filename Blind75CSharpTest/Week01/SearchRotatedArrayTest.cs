using Blind75CSharp.Week01;
using FluentAssertions;
using Xunit;

namespace Blind75CSharpTest.Week01;

public class SearchRotatedArrayTest
{
   [Fact]
   public void SearchRotatedArray_When_Valid()
   {
      var input = new int[] {4, 5, 6, 7, 0, 1, 2};
      var target = 0;
      var testObject = new SearchRotatedArray();
      var actual = testObject.Search(input, target);
      actual.Should().Be(4);
   }
}