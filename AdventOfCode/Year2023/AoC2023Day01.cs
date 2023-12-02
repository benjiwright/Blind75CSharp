namespace AdventOfCode.Year2023;

// https://adventofcode.com/2023/day/1/
public class AoC2023Day01
{
   public int Part01(string[] lines)
   {
      var sum = 0;

      foreach (var line in lines)
      {
         sum += FindLineScorePart01(line);
      }

      return sum;
   }

   public int Part02(string[] lines)
   {
      var numbers = new Dictionary<string, int>
      {
         {"one", 1}, {"two", 2}, {"three", 3}, {"four", 4}, {"five", 5}, {"six", 6}, {"seven", 7}, {"eight", 8},
         {"nine", 9},
      };

      int sum = 0;

      foreach (var line in lines)
      {
         int first = FindFirst(line, numbers);
         int second = FindSecond(line, numbers);

         sum += first * 10 + second;
      }

      return sum;
   }

   private int FindSecond(string line, Dictionary<string, int> numbers)
   {
      for (int i = line.Length - 1; i >= 0; i--)
      {
         var c = line[i];
         if (char.IsDigit(c)) return int.Parse(c.ToString());

         if (char.IsLetter(c))
         {
            for (int numSize = 3; numSize <= 5; numSize++)
            {
               var startIndex = i - numSize + 1;
               if (startIndex > 0)
               {
                  var comparing = line.Substring(startIndex, numSize);
                  if (numbers.TryGetValue(comparing, out var value)) return value;
               }
            }
         }
      }

      throw new ArgumentException("did not find the second number");
   }

   private int FindFirst(string line, Dictionary<string, int> numbers)
   {
      for (var i = 0; i < line.Length; i++)
      {
         var c = line[i];
         if (char.IsDigit(c)) return int.Parse(c.ToString());

         if (char.IsLetter(c))
         {
            for (int numSize = 3; numSize <= 5; numSize++)
            {
               if (i + numSize < line.Length)
               {
                  var comparing = line.Substring(i, numSize);
                  if (numbers.TryGetValue(comparing, out var value)) return value;
               }
            }
         }
      }

      throw new ArgumentException("did not find the first number");
   }


   private int FindLineScorePart01(string s)
   {
      char firstDigit = '\n', secondDigit = '\n';

      foreach (var c in s)
      {
         if (char.IsDigit(c))
         {
            firstDigit = c;
            break;
         }
      }

      for (int i = s.Length - 1; i >= 0; i--)
      {
         if (char.IsDigit(s[i]))
         {
            secondDigit = s[i];
            break;
         }
      }

      return int.Parse(firstDigit + secondDigit.ToString());
   }
}