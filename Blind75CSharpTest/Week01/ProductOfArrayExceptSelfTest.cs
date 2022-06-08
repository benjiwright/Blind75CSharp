using Blind75CSharp.Week01;
using Xunit;

namespace Blind75CSharpTest.Week01;

public class ProductOfArrayExceptSelfTest
{
   [Fact]
   public void ProductOfArrayExceptSelf_Valid()
   {
      var testObject = new ProductOfArrayExceptSelf();
      var input = new int[] {1, 2, 3, 4};
      var actual = testObject.ProductExceptSelf(input);
   }
}