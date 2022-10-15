using System.Text;

namespace Blind75CSharp.Week06;

public class Solution06
{
   public int FindDuplicate(int[] nums)
   {
      if (nums is null || nums.Length == 0) return -1;

      int slow = 0, fast = 0;
      
      // 0 1 2 3 4
      // 3,1,3,4,2
      while (true)
      {
         slow = nums[slow]; // move 1
         var tmp = nums[fast]; // move 2
         fast = nums[tmp];
         
         // detected a cycle
         if(slow == fast) break;
      }

      // slow walk
      var slow2 = 0;
      while (true)
      {
         if (slow == slow2) return slow;

         slow = nums[slow];
         slow2 = nums[slow2];

      }
      
      
      return -1;
   }

   public IList<IList<int>> Generate(int numRows)
   {
      var result = new List<IList<int>> {new List<int> {1}};

      for (var currRow = 2; currRow <= numRows; currRow++)
      {
         var nextRow = new int [currRow];
         nextRow[0] = 1;
         nextRow[currRow - 1] = 1;

         var previousRow = result.Last();

         for (var j = 1; j < currRow - 1; j++)
         {
            nextRow[j] = previousRow[j - 1] + previousRow[j];
         }

         result.Add(nextRow);
      }

      return result;
   }


   public int FindTargetSumWays(int[] nums, int target)
   {
      return Dp(nums, target, nums.Length - 1, 0, new Dictionary<(int, int), int>());
   }

   private int Dp(int[] nums, int target, int index, int sum, Dictionary<(int, int), int> memo)
   {
      if (memo.ContainsKey((index, sum))) return memo[(index, sum)];
      if (index < 0 && sum == target) return 1;
      if (index < 0) return 0;

      var positive = Dp(nums, target, index - 1, sum + nums[index], memo);
      var negative = Dp(nums, target, index - 1, sum + -1 * nums[index], memo);

      memo.Add((index, sum), positive + negative);
      return memo[(index, sum)];
   }

   public IList<IList<int>> Permute(int[] nums)
   {
      var result = new List<IList<int>>();
      PermuteRecurse(result, nums, 0);
      return result;
   }

   private void PermuteRecurse(List<IList<int>> res, int[] arr, int start)
   {
      if (start == arr.Length)
      {
         var list = arr.Select(t => (t)).ToList();
         res.Add(list);
         return;
      }

      for (var i = start; i < arr.Length; i++)
      {
         (arr[start], arr[i]) = (arr[i], arr[start]);
         PermuteRecurse(res, arr, start + 1);
         (arr[start], arr[i]) = (arr[i], arr[start]);
      }
   }


   public int CarFleet(int target, int[] position, int[] speed)
   {
      var pair = new (int, int) [position.Length];
      for (var i = 0; i < position.Length; i++)
      {
         pair[i] = (position[i], speed[i]);
      }

      var stack = new Stack<double>();
      foreach (var (p, s) in pair.OrderByDescending(i => i.Item1))
      {
         stack.Push((target - p) / (double) s);
         if (stack.Count >= 2 && stack.Peek() <= stack.Skip(1).First())
         {
            stack.Pop();
         }
      }

      return stack.Count;
   }
// Runtime: 389 ms, faster than 82.18% of C# online submissions for Car Fleet.
// Memory Usage: 59.8 MB, less than 9.77% of C# online submissions for Car Fleet.

   public int LargestRectangleArea(int[] heights)
   {
      var result = 0;
      var stack = new Stack<int>();
      stack.Push(-1);

      for (var i = 0; i < heights.Length; i++)
      {
         // keep monotonic increasing
         while (stack.Count > 1 && heights[stack.Peek()] >= heights[i])
         {
            var height = heights[stack.Pop()];
            var width = i - stack.Peek() - 1;
            result = Math.Max(result, height * width);
         }

         stack.Push(i);
      }

      // burn off remaining in stacks
      while (stack.Count > 1)
      {
         var height = heights[stack.Pop()];
         var width = heights.Length - stack.Peek() - 1;
         result = Math.Max(result, height * width);
      }

      return result;
   }
// Runtime: 436 ms, faster than 25.37% of C# online submissions for Largest Rectangle in Histogram.
// Memory Usage: 47.4 MB, less than 58.51% of C# online submissions for Largest Rectangle in Histogram.

   public int[] DailyTemperatures(int[] temperatures)
   {
      var result = new int[temperatures.Length];
      Array.Fill(result, 0);

      var stack = new Stack<int>();

      for (var i = 0; i < temperatures.Length; i++)
      {
         var t = temperatures[i];

         while (stack.Any() && temperatures[stack.Peek()] < t)
         {
            var prev = stack.Pop();
            result[prev] = i - prev;
         }

         stack.Push(i);
      }

      // 
      return result;
   }
// Runtime: 604 ms, faster than 27.07% of C# online submissions for Daily Temperatures.
// Memory Usage: 49.4 MB, less than 78.89% of C# online submissions for Daily Temperatures.

   public int Trap(int[] height)
   {
      var maxLeft = new int [height.Length];
      var maxRight = new int [height.Length];

      var max = 0;
      maxLeft[0] = max;
      for (var i = 0; i < height.Length - 1; i++)
      {
         var val = height[i];
         max = Math.Max(val, max);
         maxLeft[i + 1] = max;
      }

      max = 0;
      maxRight[height.Length - 1] = max;
      for (var i = height.Length - 1; i > 0; i--)
      {
         var val = height[i];
         max = Math.Max(val, max);
         maxRight[i - 1] = max;
      }

      var result = 0;
      for (var i = 0; i < height.Length; i++)
      {
         var heldWater = Math.Min(maxLeft[i], maxRight[i]) - height[i];
         if (heldWater > 0)
            result += heldWater;
      }

      return result;
   }
// Runtime: 106 ms, faster than 89.09% of C# online submissions for Trapping Rain Water.
// Memory Usage: 40.1 MB, less than 31.74% of C# online submissions for Trapping Rain Water.

   public int NumUniqueEmails(string[] emails)
   {
      var uniqueEmail = new HashSet<string>();

      foreach (var email in emails)
      {
         var local = new StringBuilder();
         for (var idx = 0; idx < email.Length; idx++)
         {
            switch (email[idx])
            {
               case '.':
                  continue;
               case '+':
               {
                  while (email[idx] != '@')
                  {
                     idx++;
                  }

                  break; // switch, not the 'for'
               }
            }

            if (email[idx] == '@')
            {
               var domain = email.Substring(idx);
               var parsedEmail = local + domain;
               uniqueEmail.Add(parsedEmail);
               break;
            }

            local.Append(email[idx]);
         }
      }

      return uniqueEmail.Count;
   }
// Runtime: 139 ms, faster than 53.54% of C# online submissions for Unique Email Addresses.
// Memory Usage: 39.4 MB, less than 88.33% of C# online submissions for Unique Email Addresses.

   public IList<string> LetterCombinations(string digits)
   {
      var results = new List<StringBuilder>();

      if (digits is null || digits.Length == 0) return new List<string>();

      var map = new Dictionary<char, List<char>>
      {
         {'2', new List<char> {'a', 'b', 'c'}},
         {'3', new List<char> {'d', 'e', 'f'}},
         {'4', new List<char> {'g', 'h', 'i'}},
         {'5', new List<char> {'j', 'k', 'l'}},
         {'6', new List<char> {'m', 'n', 'o'}},
         {'7', new List<char> {'p', 'q', 'r', 's'}},
         {'8', new List<char> {'t', 'u', 'v'}},
         {'9', new List<char> {'w', 'x', 'y', 'z'}},
      };

      for (var idx = 0; idx < digits.Length; idx++)
      {
         var digit = digits[idx];
         var chars = map[digit]; // trust data, instead of TryGetValue?

         for (var j = 0; j < chars.Count; j++)
         {
            var c = chars[j];
            for (var k = 0; k < chars.Count; k++)
            {
               results.Add(new StringBuilder());
               var index = j + k;
               results[index].Append(c);
            }
         }
      }

      return results.Select(result => result.ToString()).ToList();
   }

   public int RomanToInt(string s)
   {
      var map = new Dictionary<char, int>
      {
         {'I', 1},
         {'V', 5},
         {'X', 10},
         {'L', 50},
         {'C', 100},
         {'D', 500},
         {'M', 1000}
      };

      var result = 0;
      for (var i = 0; i < s.Length; i++)
      {
         var next = int.MinValue;
         if (i < s.Length - 1) next = map[s[i + 1]];

         var val = map[s[i]];
         if (next > val)
         {
            result += next - val;
            i++;
         }
         else
         {
            result += val;
         }
      }

      return result;
   }
// Runtime: 90 ms, faster than 78.29% of C# online submissions for Roman to Integer.
// Memory Usage: 36.8 MB, less than 64.78% of C# online submissions for Roman to Integer.

   public int ThreeSumClosest(int[] nums, int target)
   {
      var delta = int.MaxValue;
      Array.Sort(nums);

      for (var i = 0; i < nums.Length && delta != 0; i++)
      {
         var left = i + 1;
         var right = nums.Length - 1;

         while (left < right)
         {
            var sum = nums[i] + nums[left] + nums[right];

            if (Math.Abs(target - sum) < Math.Abs(delta))
            {
               delta = target - sum;
            }

            if (sum < target)
            {
               left++;
            }
            else
            {
               right--;
            }
         }
      }

      return target - delta;
   }
//Runtime: 256 ms, faster than 51.35% of C# online submissions for 3Sum Closest.
//Memory Usage: 39.4 MB, less than 74.82% of C# online submissions for 3Sum Closest.


   public bool ValidPalindrome(string s)
   {
      if (s is null) return false;
      if (s.Length < 3) return true;

      var left = 0;
      var right = s.Length - 1;

      while (left < right)
      {
         if (s[left] != s[right])
         {
            return CheckPalindrome(s, left + 1, right) || CheckPalindrome(s, left, right - 1);
         }

         left++;
         right--;
      }

      return true;
   }
// Runtime: 111 ms, faster than 76.78% of C# online submissions for Valid Palindrome II.
// Memory Usage: 41.9 MB, less than 37.16% of C# online submissions for Valid Palindrome II.

   private bool CheckPalindrome(string s, int left, int right)
   {
      while (left < right)
      {
         if (s[left] != s[right]) return false;
         left++;
         right--;
      }

      return true;
   }


   public bool ValidWordAbbreviation(string word, string abbr)
   {
      var abbrIdx = 0;
      var wordIdx = 0;
      while (wordIdx < word.Length && abbrIdx < abbr.Length)
      {
         if (word[wordIdx] == abbr[abbrIdx])
         {
            abbrIdx++;
            wordIdx++;
            continue;
         }

         var sb = new StringBuilder();
         while (abbrIdx < abbr.Length && char.IsDigit(abbr[abbrIdx]))
         {
            sb.Append(abbr[abbrIdx]);
            abbrIdx++;
         }

         if (sb.Length == 0 || sb[0] == '0') return false;

         var skipCharCount = int.Parse(sb.ToString());
         wordIdx += skipCharCount;
      }

      return wordIdx == word.Length && abbrIdx == abbr.Length;
   }
// Runtime: 98 ms, faster than 61.68% of C# online submissions for Valid Word Abbreviation.
// Memory Usage: 37.7 MB, less than 40.19% of C# online submissions for Valid Word Abbreviation.

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