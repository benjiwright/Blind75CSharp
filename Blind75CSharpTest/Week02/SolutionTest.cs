using System;
using System.Linq;
using Blind75CSharp.Week02;
using FluentAssertions;
using Xunit;

namespace Blind75CSharpTest.Week02;

public class SolutionTest
{
   [Fact]
   public void ReverseList_When_Valid()
   {
      var input = new int[] {1, 2, 3, 4, 5};
      var head = BuildLinkedList(input);

      var testObject = new Solution();
      var newHead = testObject.ReverseList(head);

      var expected = new int[] {5, 4, 3, 2, 1};

      var idx = 0;
      var current = newHead;
      while (current is not null)
      {
         current.val.Should().Be(expected[idx]);
         current = current.next;
         idx++;
      }
   }

   private ListNode BuildLinkedList(int[] nums)
   {
      ListNode head = null;

      for (var i = 0; i < nums.Length; i++)
      {
         var newNode = new ListNode(nums[i]);
         if (head is null)
         {
            head = newNode;
            continue;
         }

         var temp = head;
         while (temp.next != null)
         {
            temp = temp.next;
         }

         temp.next = newNode;
      }

      return head;
   }


   [Fact]
   private void PriorityQueue()
   {
      var input = new int[] {3, 6, 1, 8, 2, 0, -11, 23, 3, 5, 3, 2,};
      var testObject = new Solution();

      var actual = testObject.PriorityQueue(input);
      var (min, max) = actual;

      min.Should().Be(input.Min());
      max.Should().Be(input.Max());
   }
}