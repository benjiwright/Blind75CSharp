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

   [Fact]
   public void Intervals_Insert_When_Valid()
   {
      int[][] intervals =
      {
         new[] {1, 2},
         new[] {3, 4},
         new[] {6, 7},
         new[] {8, 10},
         new[] {12, 16}
      };

      var expected = new[]
      {
         new[] {1, 2},
         new[] {3, 10},
         new[] {12, 16}
      };

      var testObject = new Intervals();
      var actuals = testObject.Insert(intervals, new[] {4, 8});

      actuals.Should().HaveCount(3);

      for (var i = 0; i < expected.Length; i++)
      {
         actuals[i].Should().Contain(expected[i]);
      }
   }

   [Fact]
   public void Intervals_Insert_When_NewInterval_Comes_Last()
   {
      int[][] intervals =
      {
         new[] {1, 5},
      };

      int[] newInterval = new[] {4, 8};

      var expected = new[]
      {
         new[] {1, 8},
      };

      var testObject = new Intervals();
      var actuals = testObject.Insert(intervals, newInterval);

      actuals.Should().HaveCount(1);

      for (var i = 0; i < expected.Length; i++)
      {
         actuals[i].Should().Contain(expected[i]);
      }
   }
}