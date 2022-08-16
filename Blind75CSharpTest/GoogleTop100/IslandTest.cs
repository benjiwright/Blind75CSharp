using Blind75CSharp.GoogleTop100;
using FluentAssertions;
using Xunit;

namespace Blind75CSharpTest.GoogleTop100;

public class IslandTest
{
   [Fact]
   public void LargestIsland_ThreeIslands()
   {
      var grid = new[]
      {
         //     0  1  2  3
         new[] {0, 0, 0, 1}, // 0
         new[] {0, 1, 0, 1}, // 1
         new[] {1, 1, 0, 1}, // 2
         new[] {0, 0, 0, 0}, // 3
         new[] {0, 1, 1, 0}, // 4
      };

      var testObj = new Island();
      testObj.LargestIsland(grid).Should().Be(7);
   }


   [Fact]
   public void LargestIsland_SmallTwoIslands()
   {
      var grid = new[]
      {
         new[] {1, 0},
         new[] {0, 1},
      };

      var testObj = new Island();
      testObj.LargestIsland(grid).Should().Be(3);
   }
   
   [Fact]
   public void LargestIsland_EverythingIsAnIsland()
   {
      var grid = new[]
      {
         new[] {1, 1},
         new[] {0, 1},
      };

      var testObj = new Island();
      testObj.LargestIsland(grid).Should().Be(4);
   }
   
   [Fact]
   public void LargestIsland_EverythingStartedAsAnIsland()
   {
      var grid = new[]
      {
         new[] {1, 1},
         new[] {1, 1},
      };

      var testObj = new Island();
      testObj.LargestIsland(grid).Should().Be(4);
   }
   
   [Fact]
   public void LargestIsland_NowWhat()
   {
      var grid = new[]
      {
         new [] {0,0,0,0,0,0,0},
         new [] {0,1,1,1,1,0,0},
         new [] {0,1,0,0,1,0,0},
         new [] {1,0,1,0,1,0,0},
         new [] {0,1,0,0,1,0,0},
         new [] {0,1,0,0,1,0,0},
         new [] {0,1,1,1,1,0,0}
      };

      var testObj = new Island();
      testObj.LargestIsland(grid).Should().Be(18);
   }
   
   

}