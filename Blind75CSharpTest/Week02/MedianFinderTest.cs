using Blind75CSharp.Week02;
using FluentAssertions;
using Xunit;

namespace Blind75CSharpTest.Week02;

public class MedianFinderTest
{
   private readonly MedianFinder _testObject;


   public MedianFinderTest()
   {
      _testObject = new MedianFinder();
   }

   [Fact]
   public void MedianFinder_Handles_OddEven()
   {
      _testObject.AddNum(1);
      _testObject.AddNum(2);
      var actual = _testObject.FindMedian();
      actual.Should().Be(1.5);

      _testObject.AddNum(3);
      actual = _testObject.FindMedian();
      actual.Should().Be(2);


      _testObject.AddNum(4);
      actual = _testObject.FindMedian();
      actual.Should().Be(2.5);
   }
}