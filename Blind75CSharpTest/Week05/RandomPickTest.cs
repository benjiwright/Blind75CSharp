using System.Linq;
using Blind75CSharp.Week05;
using Xunit;

namespace Blind75CSharpTest.Week05;

public class RandomPickTest
{
   [Fact]
   public void PickIndex_HowToVerifyRandom()
   {
      // 0 has 25% chance
      // 1 has 75% chance
      var array = new int[] {1, 3};
      var testObj = new RandomPick(array);
      var actual = testObj.PickIndex();
   }

   [Fact]
   public void PickIndex_MoreNumnbersToPickFrom()
   {
      // 0 has 25% chance
      // 1 has 25% chance
      // 2 has 50% chance
      var array = new int[] {1, 1, 2};
      var testObj = new RandomPick(array);

      foreach (var _ in array)
      {
         var actual = testObj.PickIndex();
      }
   }
}