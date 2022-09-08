namespace Blind75CSharp.FangPopular.Google;

// 827. Making A Large Island
// https://leetcode.com/problems/making-a-large-island/
public class Island
{
   private int[] dx = {-1, 1, 0, 0};
   private int[] dy = {0, 0, -1, 1};

   private int _maxRow;
   private int _maxCol;

   public int LargestIsland(int[][] grid)
   {
      _maxRow = grid.Length;
      _maxCol = grid[0].Length;

      var islandId = 2;
      var islandSize = new Dictionary<int, int>();

      var max = 0;
      for (var row = 0; row < _maxRow; row++)
      for (var col = 0; col < _maxCol; col++)
      {
         if (grid[row][col] != 1) continue;
         islandSize.Add(islandId, IslandCounter(grid, row, col, islandId)); // could optimize with visited
         max = Math.Max(max, islandSize[islandId]); // case where all nodes are same island  
         islandId++;
      }

      for (var row = 0; row < _maxRow; row++)
      for (var col = 0; col < _maxCol; col++)
      {
         var set = new HashSet<int>();
         if (grid[row][col] == 0)
         {
            for (var idx = 0; idx < 4; idx++)
            {
               var newRow = row + dx[idx];
               var newCol = col + dy[idx];

               if (!isOutOfBounds(newRow,newCol) &&
                   grid[newRow][newCol] > 1 &&
                   !set.Contains(grid[newRow][newCol])) // gothca
               {
                  set.Add(grid[newRow][newCol]);
               }
            }
         }

         var islandMax = set.Sum(id => islandSize[id]);
         max = Math.Max(max, 1 + islandMax);
      }

      return max;
   }

   private int IslandCounter(int[][] grid, int row, int col, int islandId)
   {
      var size = 0;
      grid[row][col] = islandId;

      for (var i = 0; i < 4; i++)
      {
         var newRow = row + dx[i];
         var newCol = col + dy[i];

         if (isOutOfBounds(newRow, newCol)) continue;
         if (grid[newRow][newCol] == 1)
         {
            size += IslandCounter(grid, newRow, newCol, islandId);
         }
      }

      return 1 + size;
   }

   private bool isOutOfBounds(int row, int col)
   {
      if (row < 0 || row >= _maxRow
                  || col < 0 || col >= _maxCol)
      {
         return true;
      }

      return false;
   }
}