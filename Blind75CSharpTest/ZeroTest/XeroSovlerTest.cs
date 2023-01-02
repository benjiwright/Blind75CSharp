﻿using Blind75CSharp.Xero;
using FluentAssertions;
using Xunit;

namespace Blind75CSharpTest.ZeroTest;

public class XeroSovlerTest
{
   [Theory]
   [InlineData(new int[] {2, 1, 2}, 5)]
   public void FindDistanceToOrigin(int[] input, int expected)
   {
      var testObj = new XeroSolver();
   }


   [Theory]
   [InlineData(new string[] {"apple", "app"}, "abcdefghijklmnopqrstuvwxyz", false)]
   public void IsAlienSortedTester(string[] words, string order, bool expected)
   {
      var testObj = new XeroSolver();
      testObj.IsAlienSorted(words, order).Should().Be(expected);
   }


   [Theory]
   [InlineData(new int[] {0,1,2,2,3,0,4,2}, 2, 5)]
   public void RemoveElementTester(int[] input, int val, int expected)
   {
      var testObj = new XeroSolver();
      testObj.RemoveElement(input, val).Should().Be(expected);

   }
}