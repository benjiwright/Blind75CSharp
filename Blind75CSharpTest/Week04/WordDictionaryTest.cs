using Blind75CSharp.Week04;
using FluentAssertions;
using Xunit;

namespace Blind75CSharpTest.Week04;

public class WordDictionaryTest
{
   private readonly WordDictionary _testObj;

   public WordDictionaryTest()
   {
      _testObj = new WordDictionary();
   }


   [Fact]
   public void WordDictionary_Works()
   {
      _testObj.AddWord("bad");
      _testObj.AddWord("dad");
      _testObj.AddWord("mad");

      _testObj.Search("pad").Should().BeFalse();
      _testObj.Search("bad").Should().BeTrue();
      _testObj.Search(".ad").Should().BeTrue();
      _testObj.Search("b..").Should().BeTrue();
   }

   [Fact]
   public void WordDictionary_Handles_Duplicates()
   {
      _testObj.AddWord("a");
      _testObj.AddWord("a");

      _testObj.Search(".").Should().BeTrue();
      _testObj.Search("a").Should().BeTrue();

      _testObj.Search("aa").Should().BeFalse();
      _testObj.Search("a").Should().BeTrue();

      _testObj.Search(".a").Should().BeFalse();
      _testObj.Search("a.").Should().BeFalse(); // gotcha!!
   }

   [Fact]
   public void WordDictionary_Handles_EndingWildcards()
   {
      _testObj.AddWord("bad");
      _testObj.AddWord("bad");

      _testObj.Search("b..").Should().BeTrue();
   }
}