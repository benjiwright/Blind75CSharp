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
}