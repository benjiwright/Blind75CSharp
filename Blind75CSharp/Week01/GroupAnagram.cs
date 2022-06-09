namespace Blind75CSharp.Week01;

public class GroupAnagram
{
   public IList<IList<string>> GroupAnagrams(string[] strs)
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
   }
}

// Runtime: 329 ms, faster than 17.60% of C# online submissions for Group Anagrams.
// Memory Usage: 50.3 MB, less than 73.74% of C# online submissions for Group Anagrams.