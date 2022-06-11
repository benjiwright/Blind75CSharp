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
}