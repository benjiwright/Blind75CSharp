using System.Text;

namespace Blind75CSharp.Week02;

// Definition for singly-linked list.
public sealed class ListNode
{
   public int val;
   public ListNode next;

   public ListNode(int val = 0, ListNode next = null)
   {
      this.val = val;
      this.next = next;
   }
}

public class Solution
{
   public string MinWindow(string s, string t)
   {
      var result = string.Empty;
      if (t.Length > s.Length) return result;

      // build our matches
      var matchCounts = new Dictionary<char, int>();
      foreach (var c in t) // O(n)
      {
         if (!matchCounts.ContainsKey(c)) matchCounts.Add(c, 0);
         matchCounts[c]++;
      }

      var left = 0;
      var right = 0;
      var windowCounts = new Dictionary<char, int>();
      // slide our window
      while (right < s.Length) // O(n)
      {
         // manage the window counts
         var letter = s[right];
         if (matchCounts.ContainsKey(letter)) // nested O(n) so O(n^2)
         {
            if (!windowCounts.ContainsKey(letter))
            {
               windowCounts.Add(letter, 0);
            }

            windowCounts[letter]++;
         }

         // move the window
         while (IsWindowValid(windowCounts, matchCounts)) // also linear
         {
            var subString = s.Substring(left, right - left + 1);
            if (result == string.Empty || result.Length > subString.Length)
            {
               result = subString;
            }

            if (matchCounts.ContainsKey(s[left]))
            {
               windowCounts[s[left]]--;
            }

            left++;
         }

         right++;
      }

      return result;
   }
   // Runtime: 445 ms, faster than 5.03% of C# online submissions for Minimum Window Substring. 
   // Memory Usage: 50.4 MB, less than 5.15% of C# online submissions for Minimum Window Substring.
   // Runtime complexity is the approved solution on LC where it's a sliding window that is optimized to 
   // not include letter we do not care about.  I am confused my the runtime is slow.
   

   private bool IsWindowValid(IDictionary<char, int> windowDict, IDictionary<char, int> countsDict)
   {
      foreach (var kp in countsDict)
      {
         if (!windowDict.ContainsKey(kp.Key)) return false;
         if (windowDict[kp.Key] < kp.Value) return false;
      }

      return true;
   }


   public int LengthOfLongestSubstring(string s)
   {
      if (s.Length == 0) return 0;

      var result = 0;
      var right = 0;
      var left = 0;

      var occurs = new HashSet<char>();
      while (right < s.Length)
      {
         var letter = s[right];
         while (occurs.Contains(letter))
         {
            occurs.Remove(s[left]);
            left++;
         }

         occurs.Add(letter);
         right++;
         result = Math.Max(result, right - left);
      }

      return result;
   }
   // Runtime: 122 ms, faster than 39.81% of C# online submissions for Longest Substring Without Repeating Characters.
   // Memory Usage: 37.2 MB, less than 33.15% of C# online submissions for Longest Substring Without Repeating Characters.


   public int CountSubstrings(string s)
   {
      var results = 0;
      for (var middle = 0; middle < s.Length; middle++)
      {
         // odd
         results += CountPalindromes(s, middle, middle);
         // even
         results += CountPalindromes(s, middle, middle + 1);
      }

      return results;
   }

   private int CountPalindromes(string s, int left, int right)
   {
      var results = 0;
      while (left >= 0 && right < s.Length && s[left] == s[right])
      {
         results++;
         left--;
         right++;
      }

      return results;
   }
   // Before refactor:
   // Runtime: 101 ms, faster than 47.94% of C# online submissions for Palindromic Substrings.
   // Memory Usage: 34.9 MB, less than 54.45% of C# online submissions for Palindromic Substrings.

   // After readability refactor:
   // Runtime: 83 ms, faster than 69.36% of C# online submissions for Palindromic Substrings.
   // Memory Usage: 34.8 MB, less than 63.34% of C# online submissions for Palindromic Substrings.

   public IList<IList<int>> PacificAtlantic(int[][] heights)
   {
      var results = new List<IList<int>>();
      if (heights == null || heights.Length < 1) return results;


      var rowSize = heights.Length;
      var colSize = heights[0].Length;
      var visitedPacific = new HashSet<string>();
      var visitedAtlantic = new HashSet<string>();

      // North & South
      for (var row = 0; row < rowSize; row++)
      {
         VisitIsland(row, 0, visitedPacific, heights[row][0], rowSize, colSize, heights); // North
         VisitIsland(row, colSize - 1, visitedAtlantic, heights[row][colSize - 1], rowSize, colSize, heights); // South
      }

      // West & East
      for (var col = 0; col < colSize; col++)
      {
         VisitIsland(0, col, visitedPacific, heights[0][col], rowSize, colSize, heights); //West
         VisitIsland(rowSize - 1, col, visitedAtlantic, heights[rowSize - 1][col], rowSize, colSize, heights); // East
      }

      // Union
      for (var row = 0; row < rowSize; row++)
      {
         for (var col = 0; col < colSize; col++)
         {
            var location = $"{row},{col}";
            if (visitedAtlantic.Contains(location) && visitedPacific.Contains(location))
            {
               results.Add(new List<int> {row, col});
            }
         }
      }

      return results;
   }
   // Runtime: 400 ms, faster than 17.08% of C# online submissions for Pacific Atlantic Water Flow.
   // Memory Usage: 46.3 MB, less than 43.72% of C# online submissions for Pacific Atlantic Water Flow.

   private void VisitIsland(int row, int col, HashSet<string> visited, int previousHeight, int rowSize, int colSize,
      int[][] heights)
   {
      var location = $"{row},{col}";
      if (visited.Contains(location)) return;

      if (row < 0 || row >= rowSize) return;
      if (col < 0 || col >= colSize) return;

      var height = heights[row][col];
      if (height < previousHeight) return;

      visited.Add(location);

      VisitIsland(row + 1, col, visited, height, rowSize, colSize, heights);
      VisitIsland(row - 1, col, visited, height, rowSize, colSize, heights);
      VisitIsland(row, col + 1, visited, height, rowSize, colSize, heights);
      VisitIsland(row, col - 1, visited, height, rowSize, colSize, heights);
   }


   public int NumIslands(char[][] grid)
   {
      var visited = new HashSet<string>();
      var result = 0;

      for (var row = 0; row < grid.GetLength(0); row++)
      {
         for (var col = 0; col < grid[0].GetLength(0); col++)
         {
            if (VisitLocation(row, col, grid, visited)) result++;
         }
      }

      return result;
   }
   // Runtime: 277 ms, faster than 6.20% of C# online submissions for Number of Islands.
   // Memory Usage: 48.2 MB, less than 26.38% of C# online submissions for Number of Islands.

   private bool VisitLocation(int row, int col, char[][] grid, HashSet<string> visited)
   {
      // oob checks
      if (row < 0 || row >= grid.GetLength(0)) return false;
      if (col < 0 || col >= grid[0].GetLength(0)) return false;

      var location = $"{row}, {col}";
      if (visited.Contains(location)) return false;

      if (grid[row][col] == '0') return false;

      // mark visited and explore all neighbors
      visited.Add(location);
      VisitLocation(row - 1, col, grid, visited);
      VisitLocation(row + 1, col, grid, visited);
      VisitLocation(row, col - 1, grid, visited);
      VisitLocation(row, col + 1, grid, visited);

      return true;
   }

   public ListNode LinkedListRemoveNthNode(ListNode head, int n)
   {
      if (n == 0) return head.next;

      var current = head;
      var previous = head;
      var idx = 1;

      while (current != null)
      {
         current = current.next;
         if (idx == n)
         {
            previous.next = current.next;
            return head;
         }

         previous = current;
         idx++;
      }

      return head;
   }

   public ListNode RemoveNthFromEnd(ListNode head, int n)
   {
      var temp = new ListNode(0, head);
      var left = temp;
      var right = head;

      // walk the right to create a window
      while (right != null && n > 0)
      {
         right = right.next;
         n--;
      }

      while (right != null)
      {
         left = left.next;
         right = right.next;
      }

      // delete node
      left.next = left.next.next;

      return temp.next;
   }
   // Runtime: 125 ms, faster than 33.50% of C# online submissions for Remove Nth Node From End of List.
   // Memory Usage: 37.7 MB, less than 84.79% of C# online submissions for Remove Nth Node From End of List.

   public ListNode ReverseList(ListNode head)
   {
      if (head is null) return null; // this is dirty, but make that test case happy

      var current = head;
      ListNode previous = null;

      while (current is not null)
      {
         var temp = current.next;
         current.next = previous;
         previous = current;
         current = temp;
      }

      return previous;
   }
   // Runtime: 130 ms, faster than 28.43% of C# online submissions for Reverse Linked List.
   // Memory Usage: 37.8 MB, less than 66.70% of C# online submissions for Reverse Linked List.

   public bool HasCycle(ListNode head)
   {
      if (head is null) return false; // dirty to make leetcode happy

      var slow = head;
      var fast = head.next;
      while (slow != fast)
      {
         if (fast is null || fast.next is null) return false;

         slow = slow.next;
         fast = fast.next.next;
      }

      return true;
   }
   // Runtime: 135 ms, faster than 49.80% of C# online submissions for Linked List Cycle.
   // Memory Usage: 41.4 MB, less than 65.52% of C# online submissions for Linked List Cycle.


   public int MaxArea(int[] height)
   {
      if (height.Length < 2) return -1;

      var maxWater = 0;
      var left = 0;
      var right = height.Length - 1;

      while (left < right)
      {
         var currWater = (right - left) * Math.Min(height[left], height[right]);
         maxWater = Math.Max(currWater, maxWater);

         if (height[left] < height[right])
         {
            left++;
         }
         else if (height[left] > height[right])
         {
            right--;
         }
         else
         {
            left++;
            right--;
         }
      }

      return maxWater;
   }
   // Runtime: 187 ms, faster than 88.70% of C# online submissions for Container With Most Water.
   // Memory Usage: 50.5 MB, less than 19.07% of C# online submissions for Container With Most Water.   


   public Tuple<int, int> PriorityQueue(int[] nums)
   {
      var minHeap = new PriorityQueue<int, int>();
      var ghettoMaxHeap = new PriorityQueue<int, int>();
      var maxHeap = new PriorityQueue<int, IntMaxCompare>();

      // build heaps
      foreach (var num in nums)
      {
         minHeap.Enqueue(num, num);
         ghettoMaxHeap.Enqueue(num, -1 * num);
      }

      return new Tuple<int, int>(minHeap.Dequeue(), ghettoMaxHeap.Dequeue());
   }

   private class IntMaxCompare : IComparer<int>
   {
      public int Compare(int x, int y) => y.CompareTo(x); // invert the logic
   }
}