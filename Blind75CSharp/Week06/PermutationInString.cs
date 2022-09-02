namespace Blind75CSharp.Week06;

public class PermutationInString
{
   public bool CheckInclusion(string s1, string s2)
   {
      int left = 0, right = s1.Length - 1;


      while (right < s2.Length)
      {
         var subString = s2.Substring(left, s1.Length);

         if (IsAnagram(s1, subString)) return true;

         right++;
         left++;
      }


      return false;
   }

   private bool IsAnagram(string s1, string s2)
   {
      var frequencies = new int[26];
      Array.Fill(frequencies, 0);

      foreach (var c in s1)
      {
         frequencies[c - 'a']++;
      }

      foreach (var c in s2)
      {
         frequencies[c - 'a']--;
         if (frequencies[c - 'a'] < 0) return false;
      }

      return true;
   }
}
// Runtime: 309 ms, faster than 27.97% of C# online submissions for Permutation in String.
// Memory Usage: 38.8 MB, less than 48.23% of C# online submissions for Permutation in String.