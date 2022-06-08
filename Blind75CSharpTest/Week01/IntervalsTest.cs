using Blind75CSharp.Week01;
using FluentAssertions;
using Xunit;

namespace Blind75CSharpTest.Week01;

public class IntervalsTest
{
   [Fact]
   public void Intervals_Merge_When_Valid()
   {
      {
         int[][] jaggedArrayIsBad =
         {
            new[] {8, 10},
            new[] {1, 3},
            new[] {15, 18},
            new[] {2, 6},
         };

         var expected = new[]
         {
            new[] {1, 6},
            new[] {8, 10},
            new[] {15, 18}
         };

         var testObject = new Intervals();
         var actuals = testObject.Merge(jaggedArrayIsBad);

         for (var i = 0; i < expected.Length; i++)
         {
            actuals[i].Should().Contain(expected[i]);
         }
      }
   }
}