namespace Blind75CSharp.Week06;

public class Surround
{
   private int ROW;
   private int COL;

   private char[][] _board;

   public void Solve(char[][] board)
   {
      // modify board in place
      ROW = board.Length;
      COL = board[0].Length;
      _board = board;

      // DFS all the border O's because those are not to be swapped
      var visited = new HashSet<(int, int)>();
      // north
      for (var row = 0; row < ROW; row++)
         Dfs(row, 0, visited);
      // south
      for (var row = 0; row < ROW; row++)
         Dfs(row, COL - 1, visited);
      // west
      for (var col = 0; col < COL; col++)
         Dfs(0, col, visited);
      // east
      for (var col = 0; col < COL; col++)
         Dfs(ROW - 1, col, visited);


      BoardScanSwap();
      // BoardScanSwap('!', 'O');
   }
   // Runtime: 411 ms, faster than 8.82% of C# online submissions for Surrounded Regions.
   // Runtime: 468 ms, faster than 5.08% of C# online submissions for Surrounded Regions.
   // Memory Usage: 46.7 MB, less than 94.65% of C# online submissions for Surrounded Regions.

   private void BoardScanSwap()
   {
      for (var row = 0; row < ROW; row++)
      for (var col = 0; col < COL; col++)
      {
         if (_board[row][col] == 'O')
         {
            _board[row][col] = 'X';
            
         }
         else if (_board[row][col] == '!')
         {
            _board[row][col] = 'O';
         }
      }
   }

   private void Dfs(int row, int col, HashSet<(int, int)> visited)
   {
      if (row < 0 || row >= ROW ||
          col < 0 || col >= COL ||
          visited.Contains((row, col)))
         return;

      visited.Add((row, col));
      if (_board[row][col] == 'X')
         return;

      _board[row][col] = '!';

      var dr = new[] {-1, 0, 0, 1};
      var dc = new[] {0, -1, 1, 0};

      for (var i = 0; i < 4; i++)
      {
         var newRow = row + dr[i];
         var newCol = col + dc[i];

         Dfs(newRow, newCol, visited);
      }
   }
}