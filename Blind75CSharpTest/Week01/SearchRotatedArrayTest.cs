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

   [Fact]
   public void SearchRotatedArray_FindMin_When_Valid()
   {
      var input = new int[] {3,4,5,1,2};
      var testObject = new SearchRotatedArray();
      var actual = testObject.FindMin(input);
      actual.Should().Be(1);
   }
   
   [Fact]
   public void SearchRotatedArray_FindMin_When_Valid_Sorted()
   {
      var input = new int[] { 11,13,15,17};
      var testObject = new SearchRotatedArray();
      var actual = testObject.FindMin(input);
      actual.Should().Be(11);
   }
   
   
   [Fact]
   public void SearchRotatedArray_FindMin_When_Valid_Again()
   {
      var input = new int[] { 5,1,2,3,4};
      var testObject = new SearchRotatedArray();
      var actual = testObject.FindMin(input);
      actual.Should().Be(1);
   }
  
}