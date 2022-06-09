using Blind75CSharp.Week01;
using Xunit;

namespace Blind75CSharpTest.Week01;

public class GroupAnagramTest
{
   [Fact]
   public void GroupAnagram_Valid()
   {
      var input = new string[] {"eat", "tea", "tan", "ate", "nat", "bat"};
      var testObject = new GroupAnagram();
      var actual = testObject.GroupAnagrams(input);
   }
}