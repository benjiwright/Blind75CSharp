using Blind75CSharp.Week06;
using FluentAssertions;
using Xunit;

namespace Blind75CSharpTest.Week06;

public class DataLogTest
{
   private readonly DataLog _testObj = new();


   [Fact]
   public void ReorderLogFiles_When_LcExampleOne()
   {
      var logs = new[] {"dig1 8 1 5 1", "let1 art can", "dig2 3 6", "let2 own kit dig", "let3 art zero"};
      var expected = new[] {"let1 art can", "let3 art zero", "let2 own kit dig", "dig1 8 1 5 1", "dig2 3 6"};

      var actual = _testObj.ReorderLogFiles(logs);

      actual.Should().BeEquivalentTo(expected, cfg => cfg.WithStrictOrdering());
   }
}