namespace Blind75CSharp.Xero;

public class XeroSolver
{
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

   private static double FindDistanceToOrigin(int x, int y)
   {
      return Math.Sqrt(x * x + y * y);
   }
}