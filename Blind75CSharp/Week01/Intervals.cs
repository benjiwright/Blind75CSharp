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

   // Runtime: 226 ms, faster than 52.85% of C# online submissions for Merge Intervals.
   // Memory Usage: 47.1 MB, less than 43.34% of C# online submissions for Merge Intervals.


   public int[][] Insert(int[][] intervals, int[] newInterval)
   {
      if (intervals.Length == 0) return new List<int[]> {newInterval}.ToArray();

      var results = new List<int[]>();
      var idx = 0;

      // insert all intervals before the newInterval
      while (intervals[idx][1] < newInterval[0])
      {
         results.Add(intervals[idx++]);
      }

      // do all the merging required for newInterval
      var start = newInterval[0];
      var end = newInterval[1];
      while (idx < intervals.Length && intervals[idx][0] <= end)
      {
         start = Math.Min(start, intervals[idx][0]);
         end = Math.Max(end, intervals[idx][1]);
         idx++;
      }

      results.Add(new int[] {start, end});

      // add remaining intervals that do not require merging
      while (idx < intervals.Length)
      {
         results.Add(intervals[idx++]);
      }

      return results.ToArray();
   }
}