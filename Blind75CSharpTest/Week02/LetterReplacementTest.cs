using Blind75CSharp.Week02;
using FluentAssertions;
using Xunit;

namespace Blind75CSharpTest.Week02;

public class LetterReplacementTest
{
   [Theory]
   [InlineData("ABAB", 2, 4)]
   [InlineData("AABABBA", 1, 4)]
   [InlineData("AAAA", 2, 4)]
   public void CharacterReplacement_Valid_When_ReplacementsLessThanSize(string input, int replacements, int expected)
   {
      var testObject = new LetterReplacement();
      var actual = testObject.CharacterReplacement(input, replacements);
      actual.Should().Be(expected); //                
   }
}