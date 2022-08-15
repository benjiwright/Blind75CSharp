namespace Blind75CSharp.GoogleTop100;

public class ShortestBridgeSolver
{
   private int MAX_ROW;
   private int MAX_COL;
   private int[] DX = {0, 1, -1, 0};
   private int[] DY = {1, 0, 0, -1};

   public int ShortestBridge(int[][] grid)
   {
      MAX_ROW = grid.Length;
      MAX_COL = grid[0].Length;

      for (var row = 0; row < MAX_ROW; row++)
      {
         for (var col = 0; col < MAX_COL; col++)
         {
            // 1) find first island
            if (grid[row][col] == 0) continue;

            // 2) explore entire island
            var island = new HashSet<(int, int)>();
            ExploreIsland(row, col, island, grid);

            // 3) bfs flood from each node in island until we hit the other island
            return FloodIsland(island, grid);
         }
      }

      // unreachable
      return -1;
   }

   private int FloodIsland(HashSet<(int, int)> island, int[][] grid)
   {
      var queue = new Queue<(int, int)>();
      var visited = new HashSet<(int, int)>();
      // first level
      foreach (var t in island)
      {
         queue.Enqueue(t);
         visited.Add(t);
      }

      var bridgeLength = 0;
      while (queue.Count > 0)
      {
         // queue this layer's neighbors
         var layerNeighborCount = queue.Count;
         for (var i = 0; i < layerNeighborCount; i++)
         {
            var tuple = queue.Dequeue();
            visited.Add(tuple);
            var (row, col) = tuple;


            for (var dir = 0; dir < 4; dir++)
            {
               var r = row + DX[dir];
               var c = col + DY[dir];

               // safe add to queue
               if (r < 0 || c < 0
                         || r >= MAX_ROW || c >= MAX_COL
                         || visited.Contains((r, c)))
               {
                  continue;
               }

               if (grid[r][c] == 1)
                  return bridgeLength;

               queue.Enqueue((r, c));
            }
         }

         bridgeLength++;
      }

      return -1;
   }

   private void ExploreIsland(int row, int col, ISet<(int, int)> island, int[][] grid)
   {
      if (row < 0 || col < 0
                  || row >= MAX_ROW || col >= MAX_COL
                  || grid[row][col] == 0)
      {
         return;
      }


      if (island.Contains((row, col))) return;

      island.Add((row, col));

      for (var i = 0; i < 4; i++)
      {
         var r = row + DX[i];
         var c = col + DY[i];

         ExploreIsland(r, c, island, grid);
      }
   }
}