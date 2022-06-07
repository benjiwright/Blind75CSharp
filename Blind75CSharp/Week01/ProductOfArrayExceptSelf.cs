namespace Blind75CSharp.Week01;

public class ProductOfArrayExceptSelf
{
   public int[] ProductExceptSelf(int[] nums)
   {
      var results = new int[nums.Length];

      var prefixes = new int[nums.Length];

      var prefix = 1;
      for (var i=0; i < nums.Length; i++)
      {
         prefixes[i] *= prefix;
         
      }
      
      
      var postfixes = new int[nums.Length];
      
      


      return results;
   }
}