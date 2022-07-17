using System.Collections.Generic;
using Blind75CSharp.Week04;
using FluentAssertions;
using Xunit;

namespace Blind75CSharpTest.Week04;

public class WordSearchIITest
{
   [Fact]
   public void FindWords_HandlesBoard_WhenValid()
   {
      var board = new[]
      {
         new[] {'o', 'a', 'a', 'n'},
         new[] {'e', 't', 'a', 'e'},
         new[] {'i', 'h', 'k', 'r'},
         new[] {'i', 'f', 'l', 'v'}
      };

      var words = new[]
      {
         "oath", "pea", "eat", "rain"
      };

      var testObj = new WordSearchII();

      var actualWords = testObj.FindWords(board, words);
      actualWords.Should().BeEquivalentTo(new List<string>() {"eat", "oath"});
   }
}