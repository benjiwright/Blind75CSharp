using System;
using System.Collections.Generic;
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

   [Fact]
   public void PacificAtlantic_When_Valid()
   {
      var input = new int[][]
      {
         new int[] {1, 2, 2, 3, 5},
         new int[] {3, 2, 3, 4, 4},
         new int[] {2, 4, 5, 3, 1},
         new int[] {6, 7, 1, 4, 5},
         new int[] {5, 1, 1, 2, 4}
      };

      var testObject = new Solution();
      var actual = testObject.PacificAtlantic(input);

      var expected = new List<IList<int>>
      {
         new List<int> {0, 4},
         new List<int> {1, 3},
         new List<int> {1, 4},
         new List<int> {2, 2},
         new List<int> {3, 0},
         new List<int> {3, 1},
         new List<int> {4, 0}
      };

      actual.Count.Should().Be(expected.Count);
      actual.Should().BeEquivalentTo(expected);
   }

   [Fact]
   public void PacificAtlantic_When_AllSameHeight()
   {
      var input = new int[][]
      {
         new int[] {1, 1},
         new int[] {1, 1},
         new int[] {1, 1}
      };

      var testObject = new Solution();
      var actual = testObject.PacificAtlantic(input);

      var expected = new List<IList<int>>
      {
         new List<int> {0, 0},
         new List<int> {0, 1},
         new List<int> {1, 0},
         new List<int> {1, 1},
         new List<int> {2, 0},
         new List<int> {2, 1},
      };

      actual.Count.Should().Be(expected.Count);
      actual.Should().BeEquivalentTo(expected);
   }

   [Theory]
   [InlineData("abc", 3)] // "a", "b", "c"
   [InlineData("aaa", 6)] // "a", "a", "a", "aa", "aa", "aaa"
   [InlineData("abcdcba", 10)]
   public void CountSubstrings_When_Valid(string input, int expected)
   {
      var testObj = new Solution();
      var actual = testObj.CountSubstrings(input);
      actual.Should().Be(expected);
      // TODO: have not started this problem. Got too excited for Trie
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