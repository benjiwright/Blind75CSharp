namespace Blind75CSharp.Week05;

public class SlidingMaze
{
   private int[][] _maze;
   private int[] _dest;

   public bool HasPath(int[][] maze, int[] start, int[] destination)
   {
      _maze = maze;
      _dest = destination;

      return Move(start[0], start[1], new HashSet<string>());
   }

   private bool Move(int row, int col, HashSet<string> visited)
   {
      var location = $"{row},${col}";
      if (visited.Contains(location)) return false;

      if (row == _dest[0] && col == _dest[1]) return true;

      visited.Add(location);

      var right = col + 1;
      while (right < _maze[0].Length && _maze[row][right] == 0) right++;
      if (Move(row, right - 1, visited)) return true;

      var left = col - 1;
      while (left >= 0 && _maze[row][left] == 0) left--;
      if (Move(row, left + 1, visited)) return true;

      var up = row - 1;
      while (up >= 0 && _maze[up][col] == 0) up--;
      if (Move(up + 1, col, visited)) return true;

      var down = row + 1;
      while (down < _maze.Length && _maze[down][col] == 0) down++;
      if (Move(down - 1, col, visited)) return true;

      return false;
   }

   // Runtime: 159 ms, faster than 78.38% of C# online submissions for The Maze.
   // Memory Usage: 53 MB, less than 5.40% of C# online submissions for The Maze. - lazy not passing as variables
}