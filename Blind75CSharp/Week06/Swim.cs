namespace Blind75CSharp.Week06;

public class Swim
{
   public int SwimInWater(int[][] grid)
   {
      var n = grid.Length;
      var directions = new List<(int, int)>
      {
         (0, 1),
         (0, -1),
         (1, 0),
         (-1, 0),
      };

      var frontier = new PriorityQueue<(int, int), int>(); // (r,c)
      frontier.Enqueue((0, 0), grid[0][0]);
      var visited = new HashSet<(int, int)> {(0, 0)};

      while (frontier.Count > 0)
      {
         frontier.TryDequeue(out var tup, out var weight);
         var (r, c) = tup;

         if (r == n - 1 && c == n - 1) return weight;

         // add the frontier for my location
         foreach (var (x, y) in directions)
         {
            var newRow = r + x;
            var newCol = c + y;

            if (newRow < 0 || newRow == n ||
                newCol < 0 || newCol == n ||
                visited.Contains((newRow, newCol)))
               continue;

            visited.Add((newRow, newCol));

            var maxToGetHere = Math.Max(grid[newRow][newCol], weight);
            frontier.Enqueue((newRow, newCol), maxToGetHere);
         }
      }

      return -1;
   }
   // Runtime: 189 ms, faster than 22.35% of C# online submissions for Swim in Rising Water.
   // Memory Usage: 40.2 MB, less than 32.94% of C# online submissions for Swim in Rising Water.
}