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