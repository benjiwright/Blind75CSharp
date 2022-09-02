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
   // Runtime: 309 ms, faster than 27.97% of C# online submissions for Permutation in String.
   // Memory Usage: 38.8 MB, less than 48.23% of C# online submissions for Permutation in String.   

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


   public bool CheckInclusionCheeky(string s1, string s2)
   {
      if (s1.Length > s2.Length) return false;

      var s1Count = Enumerable.Repeat(0, 26).ToArray();
      var s2Count = Enumerable.Repeat(0, 26).ToArray();

      for (var i = 0; i < s1.Length; i++)
      {
         s1Count[s1[i] - 'a']++;
         s2Count[s2[i] - 'a']++;
      }

      var matches = 0;
      for (var i = 0; i < 26; i++)
      {
         if (s1Count[i] == s2Count[i]) matches++;
      }

      var left = 0;
      for (var right = s1.Length; right < s2.Length; right++)
      {
         if (matches == 26) return true;

         var index = s2[right] - 'a';
         s2Count[index]++;
         if (s1Count[index] == s2Count[index])
         {
            matches++;
         }
         else if (s1Count[index] + 1 == s2Count[index])
         {
            matches--;
         }

         index = s2[left] - 'a';
         s2Count[index]--;
         if (s1Count[index] == s2Count[index])
         {
            matches++;
         }
         else if (s1Count[index] - 1 == s2Count[index])
         {
            matches--;
         }

         left++;
      }

      return matches == 26;
   }
   // Runtime: 121 ms, faster than 64.94% of C# online submissions for Permutation in String.
   // Memory Usage: 38.3 MB, less than 57.34% of C# online submissions for Permutation in String.
}