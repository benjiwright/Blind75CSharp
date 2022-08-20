using Blind75CSharp.Week06;
using FluentAssertions;
using Xunit;

namespace Blind75CSharpTest.Week06;

public class SurroundTest
{
   [Fact]
   public void Solve_LcExample()
   {
      var board = new char[][]
      {
         new char[] {'X', 'X', 'X', 'X'},
         new char[] {'X', 'O', 'O', 'X'},
         new char[] {'X', 'X', 'O', 'X'},
         new char[] {'X', 'O', 'X', 'X'}
      };
      var testObj = new Surround();
      var expected = new char[][]
      {
         new char[] {'X', 'X', 'X', 'X'},
         new char[] {'X', 'X', 'X', 'X'},
         new char[] {'X', 'X', 'X', 'X'},
         new char[] {'X', 'O', 'X', 'X'}
      };

      testObj.Solve(board);
      board.Should().BeEquivalentTo(expected,
         cfg => cfg.WithStrictOrdering());
   }

   [Fact]
   public void Solve_LcUnevenSize()
   {
      var board = new char[][]
      {
         new [] {'X','O','X','O','X','O'},
         new [] {'O','X','O','X','O','X'},
         new [] {'X','O','X','O','X','O'},
         new [] {'O','X','O','X','O','X'}
      };
      var testObj = new Surround();
      var expected = new char[][]
      {
         new [] {'X','O','X','O','X','O'},
         new [] {'O','X','X','X','X','X'},
         new [] {'X','X','X','X','X','O'},
         new [] {'O','X','O','X','O','X'}
      };

      testObj.Solve(board);
      board.Should().BeEquivalentTo(expected,
         cfg => cfg.WithStrictOrdering());
   }
}



/*








*/