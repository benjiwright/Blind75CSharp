namespace Blind75CSharp.Week02;

public class LetterReplacement
{
   public int CharacterReplacement(string s, int k)
   {
      if (s == null || s.Length == 0)
         return 0;

      var charCounts = new Dictionary<char, int>();

      int left = 0, right = 0, maxCnt = 0, maxLen = 0;

      while (right < s.Length)
      {
         var rightChar = s[right];
         if (charCounts.ContainsKey(rightChar))
            charCounts[rightChar]++;
         else
            charCounts.Add(rightChar, 1);
         right++;

         maxCnt = Math.Max(maxCnt, charCounts[rightChar]);

         if (right - left - maxCnt > k)
         {
            var leftChar = s[left];
            charCounts[leftChar]--;
            left++;
         }

         maxLen = Math.Max(maxLen, right - left);
      }
      return maxLen;
   }
   // Runtime: 96 ms, faster than 62.24% of C# online submissions for Longest Repeating Character Replacement.
   // Memory Usage: 35.8 MB, less than 94.13% of C# online submissions for Longest Repeating Character Replacement.
}