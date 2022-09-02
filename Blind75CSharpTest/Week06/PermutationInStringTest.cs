using Blind75CSharp.Week06;
using FluentAssertions;
using Xunit;

namespace Blind75CSharpTest.Week06;

public class PermutationInStringTest
{
   [Fact]
   public void PermutationInString_Cheeky()
   {
      var testObj = new PermutationInString();
      testObj.CheckInclusionCheeky("ab", "eidbaooo").Should().BeTrue();
      testObj.CheckInclusionCheeky("ab", "eidboaoo").Should().BeFalse();
   }
}