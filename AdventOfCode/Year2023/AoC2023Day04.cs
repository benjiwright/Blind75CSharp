using System.Text;

namespace AdventOfCode.Year2023;

public class AoC2023Day04
{
   public int Part01(string[] lines)
   {
      var result = 0;
      foreach (var line in lines)
      {
         result += ParseScoreCardLine(line);
      }

      return result;
   }

   private int ParseScoreCardLine(string line)
   {
      // Card 1: 41 48 83 86 17 | 83 86  6 31 17  9 48 53
      var fullSplit = line.Split(":");
      var split = fullSplit[1].Split('|');
      var winning = split[0].Split(' ');
      var picked = split[1].Split(' ');

      var intersect = winning.Intersect(picked).ToList();
      var count = intersect.Count();
      if (intersect.Contains(string.Empty)) // probably a way to trim during split
      {
         count--;
      }

      if (count <= 2)
         return count;

      return (int) Math.Pow(2, count - 1);

      // 1 => 1
      // 2 => 2
      // 3 => 4
      // 4 => 8
      // 5 => 16
   }

   private int[] array;

   public int Part02(string[] lines)
   {
      array = new int [lines.Length];
      Array.Fill(array, 1);

      foreach (var line in lines)
      {
         var scores = ParseScoreCardLinePart2(line);
         SimulatePlay(scores.gameId, scores.matches);
      }

      return array.Sum();
   }

   private void SimulatePlay(int gameId, int matches)
   {
      var multiplier = array[gameId];
      gameId++;
      for (; gameId < array.Length && matches > 0; gameId++)
      {
         array[gameId]+= multiplier;
         matches--;
      }
   }

   private (int gameId, int matches) ParseScoreCardLinePart2(string line)
   {
      // Card 1: 41 48 83 86 17 | 83 86  6 31 17  9 48 53
      var fullSplit = line.Split(":");
      var game = int.Parse(fullSplit[0].Split("Card ")[1].Trim()) - 1;
      var split = fullSplit[1].Split('|');
      var winning = split[0].Split(' ');
      var picked = split[1].Split(' ');

      var intersect = winning.Intersect(picked).ToList();
      var count = intersect.Count();
      if (intersect.Contains(string.Empty)) // could trim with calling select on both collections
      {
         count--;
      }

      return (game, count);
   }
}