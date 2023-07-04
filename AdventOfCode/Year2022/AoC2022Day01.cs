using AdventOfCode.Utils;

namespace AdventOfCode.Year2022;

//https://adventofcode.com/2022/day/1
public class AoC2022Day01
{
   public int Day01(string fileName)
   {
      var lines = FileReader.ReadAllLines(fileName);
      var elves = new Dictionary<int, int>();
      var elf = 1;
      var calories = 0;
      foreach (var line in lines)
      {
         if (string.IsNullOrEmpty(line))
         {
            elves.TryAdd(elf, calories);
            elf++;
            calories = 0;
         }
         else
         {
            var num = int.Parse(line);
            calories += num;
         }
      }
      
      return  elves.Values.OrderDescending().Take(3).Sum();
   }
}