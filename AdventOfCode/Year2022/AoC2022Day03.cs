using System.Text;

namespace AdventOfCode.Year2022;

public class AoC2022Day03
{
   private readonly string[] _lines;

   public AoC2022Day03(string[] lines)
   {
      _lines = lines;
   }

   // Each rucksack has two large compartments
   // exactly one item type per rucksack

   // Lowercase item types a through z have priorities 1 through 26.
   // Uppercase item types A through Z have priorities 27 through 52.

   public int Part01()
   {
      var sack = new string[2];

      var duplicates = new StringBuilder();

      foreach (var line in _lines)
      {
         // split into two
         var mid = line.Length / 2;

         sack[0] = line.Substring(0, mid);
         sack[1] = line.Substring(mid, mid);

         duplicates.Append(FindDuplicatedInSacks(sack[0], sack[1]));
      }

      return ScoreMyDups(duplicates.ToString());
   }

   public int Part02()
   {
      var sacks = new List<string>();
      int score = 0;
      foreach (var line in _lines)
      {
         sacks.Add(line);

         if (sacks.Count == 3)
         {
            var dup = sacks[0].Intersect(sacks[1]).Intersect(sacks[2]).First();
            score += ScoreMyDups(dup.ToString());
            sacks = new List<string>();
         }
      }
      
      return score;
   }

   private int ScoreMyDups(string dups)
   {
      var score = 0;
      foreach (var c in dups)
      {
         if (IsLowerCase(c))
         {
            score += c - 96;
         }
         else
         {
            score += c - 38;
         }
         // (int) 'A' = 65 - x = 27
         // (int) 'Z' = 90
         // (int) 'a' = 97 - x = 1
      }

      return score;
   }

   private bool IsLowerCase(char c)
   {
      return c > 90;
   }

   private char FindDuplicatedInSacks(string s1, string s2)
   {
      var sack1 = new HashSet<char>();
      foreach (var c in s1)
      {
         sack1.Add(c);
      }

      foreach (var c in s2)
      {
         if (sack1.Contains(c)) return c;
      }

      throw new Exception("no matches between sacks?");
   }
}