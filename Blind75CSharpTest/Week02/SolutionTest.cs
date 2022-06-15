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

   [Fact]
   public void PriorityQueue()
   {
      var input = new int[] {3, 6, 1, 8, 2, 0, -11, 23, 3, 5, 3, 2,};
      var testObject = new Solution();

      var actual = testObject.PriorityQueue(input);
      var (min, max) = actual;

      min.Should().Be(input.Min());
      max.Should().Be(input.Max());
   }

   [Fact]
   public void LinkedListRemoveNthNode_When_Middle()
   {
      var input = new int[] {1, 2, 3, 4, 5};
      var head = BuildLinkedList(input);

      var testObject = new Solution();
      var actual = testObject.LinkedListRemoveNthNode(head, 2);


      var idx = 0;
      var expected = new int[] {1, 2, 4, 5};
      var current = actual;
      while (current is not null)
      {
         current.val.Should().Be(expected[idx]);
         current = current.next;
         idx++;
      }
   }

   [Fact]
   public void LinkedListRemoveNthNode_When_Head()
   {
      var input = new int[] {1, 2, 3, 4, 5};
      var head = BuildLinkedList(input);

      var testObject = new Solution();
      var actual = testObject.LinkedListRemoveNthNode(head, 0);


      var idx = 0;
      var expected = new int[] {2, 3, 4, 5};
      var current = actual;
      while (current is not null)
      {
         current.val.Should().Be(expected[idx]);
         current = current.next;
         idx++;
      }
   }

   [Fact]
   public void LinkedListRemoveNthNode_When_Tail()
   {
      var input = new int[] {1, 2, 3, 4, 5};
      var head = BuildLinkedList(input);

      var testObject = new Solution();
      var actual = testObject.LinkedListRemoveNthNode(head, 4);

      var idx = 0;
      var expected = new int[] {1, 2, 3, 4};
      var current = actual;
      while (current is not null)
      {
         current.val.Should().Be(expected[idx]);
         current = current.next;
         idx++;
      }
   }

   [Fact]
   public void RemoveNthFromEnd_When_Middle()
   {
      var input = new int[] {1, 2, 3, 4, 5};
      var head = BuildLinkedList(input);

      var testObject = new Solution();
      var actual = testObject.RemoveNthFromEnd(head, 2);

      var idx = 0;
      var expected = new int[] {1, 2, 3, 5};
      var current = actual;
      while (current is not null)
      {
         current.val.Should().Be(expected[idx]);
         current = current.next;
         idx++;
      }
   }

   [Fact]
   public void RemoveNthFromEnd_When_Last()
   {
      var input = new int[] {1, 2, 3, 4, 5};
      var head = BuildLinkedList(input);

      var testObject = new Solution();
      var actual = testObject.RemoveNthFromEnd(head, 1);

      var idx = 0;
      var expected = new int[] {1, 2, 3, 4};
      var current = actual;
      while (current is not null)
      {
         current.val.Should().Be(expected[idx]);
         current = current.next;
         idx++;
      }
   }

   [Fact]
   public void RemoveNthFromEnd_When_First()
   {
      var input = new int[] {1, 2, 3, 4, 5};
      var head = BuildLinkedList(input);

      var testObject = new Solution();
      var actual = testObject.RemoveNthFromEnd(head, 5);

      var idx = 0;
      var expected = new int[] {2, 3, 4, 5};
      var current = actual;
      while (current is not null)
      {
         current.val.Should().Be(expected[idx]);
         current = current.next;
         idx++;
      }
   }

   [Fact]
   public void NumIslands_When_OneBigIsland()
   {
      var grid = new char[][]
      {
         new char[] {'1', '1', '1', '1', '0'},
         new char[] {'1', '1', '0', '1', '0'},
         new char[] {'1', '1', '0', '0', '0'},
         new char[] {'0', '0', '0', '0', '0'}
      };

      var testObject = new Solution();
      var actual = testObject.NumIslands(grid);
      actual.Should().Be(1);
   }

   [Fact]
   public void NumIslands_When_ManyIslands()
   {
      var grid = new char[][]
      {
         new char[] {'1', '1', '0', '0', '0'},
         new char[] {'1', '1', '0', '0', '0'},
         new char[] {'0', '0', '1', '0', '0'},
         new char[] {'0', '0', '0', '1', '1'}
      };

      var testObject = new Solution();
      var actual = testObject.NumIslands(grid);
      actual.Should().Be(3);
   }


   #region Helper Methods

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

   #endregion
}