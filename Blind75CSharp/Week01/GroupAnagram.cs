namespace Blind75CSharp.Week01;

public class GroupAnagram
{
   public IList<IList<string>> GroupAnagramsWithSort(string[] strs)
   {
      var results = new Dictionary<string, List<string>>();

      foreach (var str in strs)
      {
         var sortedWord = new string(str.OrderBy(x => x).ToArray());

         if (results.ContainsKey(sortedWord))
         {
            results[sortedWord].Add(str);
         }
         else
         {
            results.Add(sortedWord, new List<string> {str});
         }
      }

      return results.Values.Cast<IList<string>>().ToList();
      // Runtime: 329 ms, faster than 17.60% of C# online submissions for Group Anagrams.
      // Memory Usage: 50.3 MB, less than 73.74% of C# online submissions for Group Anagrams.
   }

   public IList<IList<string>> GroupAnagrams(string[] strs)
   {
      var result = new List<IList<string>>();
      if (strs.Length == 0) return result;
      var map = new Dictionary<string, List<string>>();

      foreach (var s in strs)
      {
         var hash = new char[26];
         foreach (var c in s)
         {
            hash[c - 'a']++;
         }

         var key = new string(hash);
         if (map.ContainsKey(key))
         {
            map[key].Add(s);
         }
         else
         {
            map.Add(key, new List<string> {s});
         }
      }

      return map.Values.Cast<IList<string>>().ToList();
      // without sorting (n log n), very small improvement
      // Runtime: 301 ms, faster than 26.88% of C# online submissions for Group Anagrams.
      // Memory Usage: 51.4 MB, less than 36.63% of C# online submissions for Group Anagrams.
   }
}