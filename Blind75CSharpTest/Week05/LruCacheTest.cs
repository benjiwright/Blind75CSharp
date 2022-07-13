using Blind75CSharp.Week05;
using FluentAssertions;
using Xunit;

namespace Blind75CSharpTest.Week05;

public class LruCacheTest
{
   [Fact]
   public void LruCache_GetPut_Scenario()
   {
      const int capacity = 2;
      var testObj = new LRUCache(capacity);

      testObj.Put(1, 1);
      testObj.Put(2, 2);
      testObj.Get(1).Should().Be(1);

      testObj.Put(3, 3);
      testObj.Get(2).Should().Be(-1); // evicted

      testObj.Put(4, 4);
      testObj.Get(1).Should().Be(-1); // evicted
      testObj.Get(3).Should().Be(3);
      testObj.Get(4).Should().Be(4);
   }
}