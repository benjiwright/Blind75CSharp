namespace Blind75CSharp.Week01;

public class Intervals
{
   public int[][] Merge(int[][] intervals)
   {
      intervals = intervals.OrderBy(x => x[0]).ToArray();

      var results = new List<int[]>();

      var start = intervals[0][0];
      var end = intervals[0][1];

      for (var i = 1; i < intervals.Length; i++)
      {
         if (end >= intervals[i][0])
         {
            end = Math.Max(end, intervals[i][1]);
         }
         else
         {
            results.Add(new[] {start, end});
            start = intervals[i][0];
            end = intervals[i][1];
         }
      }

      results.Add(new[] {start, end});

      return results.ToArray();
   }
}

// Runtime: 226 ms, faster than 52.85% of C# online submissions for Merge Intervals.
// Memory Usage: 47.1 MB, less than 43.34% of C# online submissions for Merge Intervals.