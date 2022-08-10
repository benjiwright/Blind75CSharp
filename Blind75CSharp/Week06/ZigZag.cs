using System.Text;

namespace Blind75CSharp.Week06;

public class ZigZag
{
   // PAYPALISHIRING
   // 3 rows
   // 0] P   A   H   N
   // 1] A P L S I I G
   // 2] Y   I   R

   // PAYPALISHIRING
   // 4 rows
   // 0) P     I    N
   // 1) A   L S  I G
   // 2) Y A   H R
   // 3) P     I


   public string Convert(string s, int numRows)
   {
      var results = new StringBuilder[numRows];
      for (var idx = 0; idx < numRows; idx++) results[idx] = new StringBuilder();

      var sIdx = 0;
      while (sIdx < s.Length)
      {
         for (var idx = 0; idx < numRows && sIdx < s.Length; idx++) // down
            results[idx].Append(s[sIdx++]);
         for (var idx = numRows-2; idx >= 1 && sIdx < s.Length; idx--) // diag
            results[idx].Append(s[sIdx++]);
      }

      // stitch results
      var result = new StringBuilder();
      foreach (var sb in results)
         result.Append(sb);

      return result.ToString();
   }
   // readable
   // Runtime: 131 ms, faster than 56.99% of C# online submissions for Zigzag Conversion.
   // Memory Usage: 37.9 MB, less than 73.16% of C# online submissions for Zigzag Conversion.

   public string ConvertBeforeRefactor(string s, int numRows)
   {

      if (numRows >= s.Length || numRows == 1) return s;
      
      var results = new List<char>[numRows];
      for (var i = 0; i < numRows; i++) // is there a way to init on declare?
      {
         results[i] = new List<char>();
      }

      var idx = 0;
      var counter = 0;
      while (idx < s.Length)
      {
         results[counter].Add(s[idx]);
         counter++;
         idx++;

         if (counter == numRows)
         {
            counter--;
            while (counter > 0)
            {
               counter--;
               if (idx >= s.Length) return MergeArrays(results);
               results[counter].Add(s[idx]);
               idx++;
            }

            counter++;
         }
      }

      return MergeArrays(results);
   }
   // Holy edge cases nightmare
   // Runtime: 145 ms, faster than 41.35% of C# online submissions for Zigzag Conversion.
   // Memory Usage: 37.9 MB, less than 73.16% of C# online submissions for Zigzag Conversion.

   private string MergeArrays(List<char>[] arrays) // probably better way to do this
   {
      var sb = new StringBuilder();
      foreach (var array in arrays)
      {
         sb.Append(new string(array.ToArray()));
      }

      return sb.ToString();
   }
}