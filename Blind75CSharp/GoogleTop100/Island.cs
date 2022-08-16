using System.Text;

namespace Blind75CSharp.GoogleTop100;

// 827. Making A Large Island
// https://leetcode.com/problems/making-a-large-island/
public class Island
{
   private Dictionary<int, List<(int, int)>> _islands = new();
   private int[][] _grid;
   private int _rowsMax;
   private int _colsMax;
   private int[] _dx = {0, 1, -1, 0};
   private int[] _dy = {-1, 0, 0, 1};
   private string[] _print;

   public int LargestIsland(int[][] grid)
   {
      // set members to pass less
      _grid = grid;
      _rowsMax = grid.Length;
      _colsMax = grid[0].Length;

      BuildIslands();

      // take 2 steps from island and do we touch different island
      return BuildBridge();
   }

   private int BuildBridge()
   {
      var queue = new Queue<(int, int)>();
      var largestIsland = 0;

      foreach (var islandKp in _islands)
      {
         foreach (var (r, c) in islandKp.Value)
         {
            queue.Enqueue((r, c));
         }

         while (queue.Count > 0)
         {
            var islandId = islandKp.Key;
            var (row, col) = queue.Dequeue();

            for (var i = 0; i < 4; i++)
            {
               var newRow = row + _dx[i];
               var newCol = col + _dy[i];

               if (!IsInbounds(newRow, newCol)) continue;

               for (var j = 0; j < 4; j++)
               {
                  var r = newRow + _dx[j];
                  var c = newCol + _dy[j];
                  if (!IsInbounds(r, c)) continue;

                  var val = _grid[r][c];
                  if (val > 0 && val != islandId)
                  {
                     var combinedSize = _islands[islandId].Count + _islands[val].Count + 1;
                     largestIsland = Math.Max(largestIsland, combinedSize);
                  }
               }
            }
         }
      }

      if (_islands.Count == 0) return 1;

      // stupid edge cases
      if (largestIsland == 0 && _islands.Count > 0)
      {
         // find largest island
         largestIsland = _islands.Values
            .Select(dict => dict.Count)
            .Prepend(largestIsland)
            .Max();

         if (_rowsMax * _colsMax != largestIsland)
         {
            largestIsland++;
         }
      }

      return largestIsland;
   }

   private void PrintGrid()
   {
      _print = new string[_grid.Length];

      for (var row = 0; row < _rowsMax; row++)
      {
         var sb = new StringBuilder();
         for (var col = 0; col < _colsMax; col++)
         {
            sb.Append(_grid[row][col] + " ");
         }

         _print[row] = sb.ToString();
      }
   }

   // find unique islands
   private void BuildIslands()
   {
      var visited = new HashSet<(int, int)>();

      for (var row = 0; row < _rowsMax; row++)
      {
         for (var col = 0; col < _colsMax; col++)
         {
            if (_grid[row][col] == 0)
            {
               visited.Add((row, col));
               continue;
            }

            if (visited.Contains((row, col))) continue; // small optimize to not revisit island explore work

            DfsIsland(row, col, visited, _islands.Count + 2);
         }
      }
   }

   private void DfsIsland(int row, int col, HashSet<(int, int)> visited, int islandId)
   {
      if (!IsInbounds(row, col)) return;
      if (visited.Contains((row, col))) return;

      visited.Add((row, col)); // mark water visited, but don't count towards island

      if (_grid[row][col] == 0) return;

      if (!_islands.ContainsKey(islandId))
      {
         _islands.Add(islandId, new List<(int, int)>());
      }

      _islands[islandId].Add((row, col));

      _grid[row][col] = islandId;

      for (var dir = 0; dir < 4; dir++)
      {
         var newRow = row + _dx[dir];
         var newCol = col + _dy[dir];
         DfsIsland(newRow, newCol, visited, islandId);
      }
   }

   private bool IsInbounds(int row, int col)
   {
      if (row < 0 || col < 0
                  || row >= _rowsMax || col >= _colsMax)
         return false;

      return true;
   }
}