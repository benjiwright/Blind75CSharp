namespace Blind75CSharp.Week06;

public class MinSpanTree
{
   public int MinCostConnectPoints(int[][] points)
   {
      var edges = FindAllEdges(points);
      return Prims(edges);
   }

   private int Prims(Dictionary<int, List<(int, int)>> edges)
   {
      // Min Spanning Tree
      // n nodes will have n-1 edges, with least cost to connect

      // 1) pick any node and BFS
      // 2) add to min heap (aka Frontier, every node connected to my node with weight)
      //    a) this will make us pick greedy pick the next best node
      // 3) check once all nodes are visited
      // 4) profit


      var nodeId = edges.First().Key;
      var visited = new HashSet<int>();
      var minHeap = new PriorityQueue<int, int>();
      minHeap.Enqueue(nodeId, 0);
      var result = 0;

      while (visited.Count < edges.Count)
      {
         minHeap.TryDequeue(out nodeId, out var cost);

         if (visited.Contains(nodeId)) continue;

         result += cost;
         visited.Add(nodeId);

         // add neighbors to frontier
         foreach (var (neighbor, weight) in edges[nodeId])
         {
            minHeap.Enqueue(weight, neighbor);
         }
      }

      return result;
   }
   // Runtime: 435 ms, faster than 63.67% of C# online submissions for Min Cost to Connect All Points.
   // Memory Usage: 69 MB, less than 43.53% of C# online submissions for Min Cost to Connect All Points.

   private Dictionary<int, List<(int, int)>> FindAllEdges(int[][] points)
   {
      //  [[0,0],[2,2],[3,10],[5,2],[7,0]]

      var edges = new Dictionary<int, List<(int, int)>>();
      var n = points.Length;

      for (var i = 0; i < n; i++)
      {
         var x1 = points[i][0];
         var y1 = points[i][1];
         edges.Add(i, new List<(int, int)>());

         for (var j = 0; j < n; j++)
         {
            if (i == j) continue;

            var x2 = points[j][0];
            var y2 = points[j][1];

            var weight = ManhattanDistance(x1, y1, x2, y2);
            edges[i].Add((weight, j));
         }
      }

      return edges;
   }

   private int ManhattanDistance(int x1, int y1, int x2, int y2) => Math.Abs(x1 - x2) + Math.Abs(y1 - y2);
}