using Blind75CSharp.Week03;
using FluentAssertions;
using Xunit;

namespace Blind75CSharpTest.Week03;

public class CourseScheduleTest
{
   [Fact]
   public void CanFinish_Handles_Simple_Schedule()
   {
      var testObj = new CourseSchedule();
      var prereqs = new int[][]
      {
         new int[] {1, 0},
         new int[] {2, 0},
         new int[] {3, 2},
         new int[] {3, 1}
      };

      testObj.CanFinish(4, prereqs).Should().BeTrue();
   }
}