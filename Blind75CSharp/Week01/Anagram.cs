namespace Blind75CSharp.Week01;

public class Anagram
{
   public bool IsAnagram(string s, string t)
   {
      if (s.Length != t.Length) return false;

      var dict = new Dictionary<char, int>();

      foreach (var c in s)
      {
         // embrace C# 7.0
         if (dict.TryGetValue(c, out var currentCount))
         {
            dict[c] = currentCount + 1;
         }
         else
         {
            dict.Add(c, 1);
         }
      }

      foreach (var c in t)
      {
         if (dict.TryGetValue(c, out var currentCount))
         {
            currentCount--;
            if (currentCount < 0) return false;
            dict[c] = currentCount;
         }
         else
         {
            return false;
         }
      }

      return true;
   }
}

// Runtime: 104 ms, faster than 54.64% of C# online submissions for Valid Anagram.
// Memory Usage: 38.8 MB, less than 62.51% of C# online submissions for Valid Anagram.