namespace Blind75CSharp.Week06;

public class Solution06
{
   public int MaximumUnits(int[][] boxTypes, int truckSize)
   {
      //  [[1,3],[2,2],[3,1]], truckSize = 4
      // 1 box that holds 3
      // 2 boxes that hold 2
      // 3 boxes that hold 1

      if (boxTypes.Length == 0) return 0;

      var result = 0;
      var boxesOnTruck = 0;

      boxTypes = boxTypes.OrderByDescending(x => x[1]).ToArray();

      foreach (var current in boxTypes)
      {
                  
         while (current[0] > 0)
         {
            result += current[1];
            current[0]--;
            boxesOnTruck++;

            if (truckSize == boxesOnTruck) return result;
         }
      }

      return result;
   }
   // Runtime: 199 ms, faster than 30.44% of C# online submissions for Maximum Units on a Truck.
   // Memory Usage: 41.4 MB, less than 25.47% of C# online submissions for Maximum Units on a Truck.
   
   private record Visit(string UserName, int TimeStamp, string Website);

   public IList<string> MostVisitedPattern(string[] username, int[] timestamp, string[] website)
   {
      var dict = new Dictionary<string, List<(int, int)>>();
      var seq = new Dictionary<string, List<string>>();
      var frequency = new Dictionary<string, int>();

      for (var i = 0; i < username.Length; i++)
      {
         if (!dict.ContainsKey(username[i]))
            dict.Add(username[i], new List<(int, int)>());

         dict[username[i]].Add((i, timestamp[i]));
      }

      foreach (var tuples in dict.Values)
      {
         if (tuples.Count < 3) continue;

         var orderedList = tuples.OrderBy(x => x.Item2).ToList();
         var set = new HashSet<string>();

         for (var i = 0; i < tuples.Count - 2; i++)
         for (var j = i + 1; j < tuples.Count - 1; j++)
         for (var k = j + 1; k < tuples.Count; k++)
         {
            var userJourney = new List<string>
            {
               website[orderedList[i].Item1],
               website[orderedList[j].Item1],
               website[orderedList[k].Item1]
            };

            var key = string.Join(" ", userJourney);
            if (!seq.ContainsKey(key))
            {
               seq.Add(key, userJourney);
               frequency.Add(key, 0);
            }

            if (!set.Contains(key))
            {
               frequency[key]++;
               set.Add(key);
            }
         }
      }

      return seq[frequency.OrderByDescending(x => x.Value)
         .ThenBy(x => x.Key).Select(x => x.Key)
         .Take(1)
         .ToArray()[0]];
   }
   // Runtime: 239 ms, faster than 64.15% of C# online submissions for Analyze User Website Visit Pattern.
   // Memory Usage: 48.1 MB, less than 34.59% of C# online submissions for Analyze User Website Visit Pattern.

   public IList<string> MostVisitedPatternConsecutive(string[] username, int[] timestamp, string[] website)
   {
      // convert to a record
      var allVisits = username
         .Select((name, i) => new Visit(name, timestamp[i], website[i]))
         .ToList();

      var userJourney = new Dictionary<string, List<string>>();
      foreach (var (userName, _, web) in allVisits.OrderBy(v => v.TimeStamp))
      {
         if (!userJourney.ContainsKey(userName)) userJourney.Add(userName, new List<string>());
         userJourney[userName].Add(web);
      }

      // brute force the shit out of this problem
      var routesFreq = new Dictionary<string, int>();
      var routes = new Dictionary<string, List<string>>();

      foreach (var (user, webs) in userJourney
                  .Where(kp => kp.Value.Count > 2))
      {
         for (var i = 0; i < webs.Count - 2; i++)
         {
            var key = string.Concat(webs.GetRange(i, 3).SelectMany(x => x + "|"));

            if (!routesFreq.ContainsKey(key)) routesFreq.Add(key, 0);
            routesFreq[key] += 1;

            if (!routes.ContainsKey(key)) routes.Add(key, new List<string>());
            routes[key] = webs.GetRange(i, 3);

            for (var j = i + 3; j < webs.Count; j++)
            {
               key += webs[j];

               if (!routesFreq.ContainsKey(key)) routesFreq.Add(key, 0);
               routesFreq[key] += 1;

               if (!routes.ContainsKey(key)) routes.Add(key, new List<string>());
               routes[key].Add(webs[j]);
            }
         }
      }

      var candidatesKeys = routesFreq
         .Where(kp => kp.Value == routesFreq.Values.Max())
         .Select(kp => kp.Key);

      return routes[candidatesKeys.OrderBy(x => x).First()];
   }


   public List<int> QuickSortLists(List<int> nums)
   {
      if (nums.Count < 2) // single or empty
      {
         return nums;
      }

      var pivot = nums[0];

      var less = new List<int>();
      var more = new List<int>();

      for (var i = 1; i < nums.Count; i++)
      {
         var num = nums[i];
         if (num <= pivot)
         {
            less.Add(num);
         }
         else
         {
            more.Add(num);
         }
      }

      return QuickSortLists(less)
         .Concat(new List<int> {pivot})
         .Concat(QuickSortLists(more))
         .ToList();
   }


   public bool WordBreak(string s, IList<string> wordDict)
   {
      return WordBreakMemo(s, wordDict, new Dictionary<string, bool>());
   }

   // According to LeetCode, this is too slow and we have to use DP
   private bool WordBreakMemo(string s, IList<string> wordDict, Dictionary<string, bool> memo)
   {
      if (s.Length == 0) return true;
      if (memo.ContainsKey(s)) return memo[s];

      foreach (var word in wordDict)
      {
         if (!s.StartsWith(word)) continue;
         var remaining = s.Substring(word.Length, s.Length - word.Length);
         if (!WordBreak(remaining, wordDict)) continue;
         memo.Add(s, true);
         return true;
      }

      return false;
   }
}