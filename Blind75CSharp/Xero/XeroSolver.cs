using Blind75CSharp.Week03;

namespace Blind75CSharp.Xero;

public class XeroSolver
{
   // Runtime 237 ms  Beats 45.93%
   // Memory  45.7 MB Beats 50.84%
   public int[] GetConcatenation(int[] nums)
   {
      var result = new int [nums.Length * 2];
      for (var i = 0; i < nums.Length; i++)
      {
         //  0 1 2 3  4 5 6 7
         // [1,3,2,1][1,3,2,1]
         result[i] = nums[i];
         result[nums.Length + i] = nums[i];
      }

      return result;
   }


   // 934. Shortest Bridge
   // TODO: https://leetcode.com/problems/shortest-bridge/description/
   public int ShortestBridge(int[][] grid)
   {
      // find first land on first island
      var startOfIsland = FindFirstCordinateThatIsLand(grid);

      // up,down,left,right
      var directions = new List<int[]>
      {
         new int[] {1, 0},
         new int[] {-1, 0},
         new int[] {0, 1},
         new int[] {0, -1},
      };

      var queue = new Queue<(int row, int col)>();
      var visited = new HashSet<(int row, int col)>();

      void ExploreIsland(int row, int col)
      {
         if (row < 0 || row >= grid.Length) return;
         if (col < 0 || col >= grid[0].Length) return;
         if (visited.Contains((row, col))) return;

         if (grid[row][col] == 1)
         {
            queue.Enqueue((row, col));
            visited.Add((row, col));
            foreach (var dir in directions)
            {
               ExploreIsland(row + dir[0], col + dir[1]);
               // TODO: stopped here. I am hating using nested functions. I tried it. It's messy
            }
         }
      }


      ExploreIsland(startOfIsland.row, startOfIsland.col);
      // bfs away from island until we hit the next island


      return -1;
   }


   private (int row, int col) FindFirstCordinateThatIsLand(int[][] grid)
   {
      for (var row = 0; row < grid.Length; row++)
      for (var col = 0; col < grid[0].Length; col++)
      {
         if (grid[row][col] == 1)
            return (row, col);
      }

      throw new Exception("No land exists on this map");
   }

   // Runtime 295 ms  Beats 5.26%
   // Memory  46.8 MB Beats 32.98%
   public int MinSubArrayLen(int target, int[] nums)
   {
      var left = 0;
      var right = 0;
      var sum = 0;
      var result = int.MaxValue;

      while (right < nums.Length)
      {
         sum += nums[right];

         while (sum >= target)
         {
            result = Math.Min(result, right + 1 - left);
            sum -= nums[left++];
         }

         right++;
      }

      return result == int.MaxValue ? 0 : result;
   }


   // Runtime 233 ms Beats 60.31%
   // Memory 44.9 MB Beats 61.60%
   public int RemoveDuplicates(int[] nums)
   {
      if (nums.Length == 1) return 1;

      var ptr = 0;
      for (var idx = 1; idx < nums.Length; idx++)
      {
         var current = nums[idx];
         var previous = nums[ptr];

         if (current != previous)
         {
            ptr++;
            nums[ptr] = nums[idx];
         }
      }

      // i:                   |
      //    0,1,2,3,4,2,2,3,3,4
      // p:         |
      //    0,1,2,3,4

      return ptr + 1;
   }


   // Runtime: 137 ms. Beats 93.53%
   // Memory:  42.5 MB Beats 29.91%
   public int RemoveElement(int[] nums, int val)
   {
      var ptr = 0;
      for (var idx = 0; idx < nums.Length; idx++)
      {
         var current = nums[idx];

         if (current != val)
         {
            nums[ptr] = nums[idx];
            ptr++;
         }
      }

      return ptr;
   }


   public bool IsAlienSorted(string[] words, string order)
   {
      if (words.Length < 2) return true;
      if (order.Length != 26) return false;

      Dictionary<char, int> orders = new();
      var counter = 0;
      foreach (var c in order)
      {
         orders.TryAdd(c, counter);
         counter++;
      }

      for (var i = 0; i < words.Length - 1; i++)
      {
         if (!CompareTwoWordsInOrder(words[i], words[i + 1], orders))
            return false;
      }


      return true;
   }

   private bool CompareTwoWordsInOrder(string first, string second, IDictionary<char, int> order)
   {
      for (var i = 0; i < first.Length; i++)
      {
         if (i == second.Length) return false;

         if (order[first[i]] < order[second[i]])
         {
            return true;
         }

         if (order[first[i]] > order[second[i]])
         {
            return false;
         }
      }

      return true;
   }


   // Runtime 348 ms Beats 93.89%
   // Memory 58.1 MB Beats 15.2%
   // https://leetcode.com/problems/k-closest-points-to-origin/submissions/859405986/
   public int[][] KClosest(int[][] points, int k)
   {
      var pq = new PriorityQueue<int[], double>();
      foreach (var a in points)
      {
         // i hate jagged arrays
         var distance = FindDistanceToOrigin(a[0], a[1]);

         pq.Enqueue(a, distance);
      }

      var result = new List<int[]>();

      while (k > 0)
      {
         result.Add(pq.Dequeue());
         k--;
      }

      return result.ToArray();
   }

   public int[] PlusOne(int[] digits)
   {
      var num = ExtractNumber(digits);

      return ConvertNumToArray(num + 1);
   }

   private int ExtractNumber(int[] digits)
   {
      // 0 1 2 3
      // 4 5 6 7

      // pow = 4-3-1=2    10^2 = 10
      var num = 0;
      for (var idx = 0; idx < digits.Length; idx++)
      {
         var powerTen = (int) Math.Pow(10, digits.Length - idx - 1);
         num += digits[idx] * powerTen;
      }

      return num;
   }

   private int[] ConvertNumToArray(int number)
   {
      var result = new List<int>();
      while (number > 0)
      {
         result.Add(number % 10);
         number /= 10;
      }

      result.Reverse();

      return result.ToArray();
   }

   private static double FindDistanceToOrigin(int x, int y)
   {
      return Math.Sqrt(x * x + y * y);
   }


   public IList<bool> KidsWithCandies(int[] candies, int extraCandies)
   {
      var max = candies.Max();


      return candies.Select(num => num + extraCandies >= max).ToList();
   }

   private Dictionary<TreeNode, int> dict = new();

   public int DeepestLeavesSum(TreeNode root)
   {
      // 1) find the depth of the tree
      // 2) calc only those nodes

      BfsDepth(root, 0);
      var maxDepth = dict.Values.Max();

      return dict.Where(kp => kp.Value == maxDepth)
         .Sum(kp => kp.Key.val);
   }

   private void BfsDepth(TreeNode node, int depth)
   {
      if (node is null) return;

      dict.Add(node, depth);

      BfsDepth(node.left, depth + 1);
      BfsDepth(node.right, depth + 1);
   }

   public int MaxIncreaseKeepingSkyline(int[][] grid)
   {
      var n = grid.Length;

      var rowMax = new int[n];
      var colMax = new int[n];

      for (var r = 0; r < n; r++)
      for (var c = 0; c < n; c++)
      {
         rowMax[r] = Math.Max(rowMax[r], grid[r][c]);
         colMax[c] = Math.Max(colMax[c], grid[r][c]);
      }

      var result = 0;
      for (var r = 0; r < n; r++)
      for (var c = 0; c < n; c++)
      {
         result += Math.Min(rowMax[r], colMax[c] - grid[r][c]);
      }

      return result;
   }

   // https://leetcode.com/problems/parallel-courses-iii/
   // hard!
   public int MinimumTime(int n, int[][] relations, int[] time)
   {
      // build adjacency list
      var adjList = new Dictionary<int, List<int>>();
      foreach (var array in relations)
      {
         var src = array[0];
         var dest = array[1];
         if (!adjList.ContainsKey(src))
         {
            adjList.Add(src, new List<int>());
         }

         adjList[src].Add(dest);
      }


      var maxTime = new Dictionary<int, int>();
      int Dfs(int node)
      {
         // base case
         if (maxTime.TryGetValue(node, out var value))
            return value;

         var result = time[node - 1];

         foreach (var neighbor in adjList[node])
         {
            result = Math.Max(result, time[node - 1] + Dfs(neighbor));
         }

         // cache
         maxTime[node] = result;
         return maxTime[node];
      }

      // perform dfs with 1 based offset
      for (var i = 1; i < n + 1; i++)
      {
         Dfs(i);
      }

      return maxTime.Values.Max();
   }
}