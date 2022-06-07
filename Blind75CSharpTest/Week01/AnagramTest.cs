using Blind75CSharp.Week01;
using FluentAssertions;
using Xunit;

namespace Blind75CSharpTest.Week01;

public class AnagramTest
{
   [Theory]
   [InlineData("anagram", "nagaram", true)]
   [InlineData("car", "rat", false)]
   public void IsAnagram_WhenValid(string s, string t, bool expected)
   {
      var testObject = new Anagram();
      var actual = testObject.IsAnagram(s, t);
      actual.Should().Be(expected);
   }
}