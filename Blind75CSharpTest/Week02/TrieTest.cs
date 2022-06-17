using Blind75CSharp.Week02;
using FluentAssertions;
using Xunit;

namespace Blind75CSharpTest.Week02;

public class TrieTest
{
   [Fact]
   public void Full_LC_UseCase()
   {
      var testObj = new Trie();
      testObj.Insert("apple");
      testObj.Search("apple").Should().BeTrue();
      testObj.Search("app").Should().BeFalse();
      testObj.StartsWith("app").Should().BeTrue();
      testObj.Insert("app");
      testObj.Search("app").Should().BeTrue();
   }
}