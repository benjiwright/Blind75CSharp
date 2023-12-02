using System.Text;

namespace AdventOfCode.Year2023;

public class AoC2023Day02
{
   public int Part01(string[] lines, int red, int green, int blue)
   {
      var result = 0;
      foreach (var line in lines)
      {
         if (IsPossible(line, red, blue, green))
         {
            result += ParseGameLineForGameNumber(line);
         }
      }

      return result;
   }

   public int Part02(string[] lines)
   {
      var result = 0;
      foreach (var fullLine in lines)
      {
         var lineWithOutGameNumber = fullLine.Split(':')[1];
         result += FindLineMax(lineWithOutGameNumber);
      }

      return result;
   }

   private int FindLineMax(string lineWithOutGameNumber)
   {
      var dict = new Dictionary<string, int>();

      foreach (var grab in lineWithOutGameNumber.Split(';'))
      {
         var numWithColor = grab.Split(',');

         foreach (var s in numWithColor)
         {
            var count = GetCount(s);
            var color = GetColor(s);

            dict.TryAdd(color, count);
            var prevMax = dict[color];
            dict[color] = Math.Max(prevMax, count);
         }
      }

      return dict.Values.Aggregate(1, (acc, val) => acc * val);
   }

   private bool IsPossible(string fullLine, int red, int blue, int green)
   {
      var line = fullLine.Split(':')[1];

      var grabs = line.Split(';');

      var limits = new Dictionary<string, int>
      {
         {"red", red},
         {"blue", blue},
         {"green", green},
      };

      foreach (var grab in grabs)
      {
         var colors = grab.Split(',');

         foreach (var s in colors)
         {
            var count = GetCount(s);
            string color = GetColor(s);

            if (!limits.TryGetValue(color, out int maxColor))
               throw new ArgumentException($"color {color} not found");

            if (maxColor < count) return false;
         }
      }

      return true;
   }

   private string GetColor(string s)
   {
      var color = s.Trim().Split(' ')[1];
      return color.Trim();
   }

   private int GetCount(string s)
   {
      var num = s.Trim().Split(' ')[0];
      return int.Parse(num);
   }

   private int ParseGameLineForGameNumber(string line)
   {
      var words = line.Split(':');
      var word = words[0];

      var i = word.Length - 1;
      var reverseNumber = new StringBuilder();
      while (char.IsDigit(word[i]))
      {
         reverseNumber.Append(word[i]);
         i--;
      }

      var numberAsSb = new StringBuilder();
      foreach (var c in reverseNumber.ToString().Reverse())
      {
         numberAsSb.Append(c);
      }

      return int.Parse(numberAsSb.ToString());
   }
}