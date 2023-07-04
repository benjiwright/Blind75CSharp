namespace AdventOfCode.Year2022;

public class AoC2022Day02
{
   public int PlayGame(string[] lines)
   {
      var score = 0;

      foreach (var line in lines)
      {
         var elf2 = GetElf(line[0]);
         var outcome = PickOutcome(line[2]);
         var elf1 = WhatShouldPlayer1Pick(outcome, elf2);

         if (outcome == Outcome.Win)
            score += 6;
         else if (outcome == Outcome.Draw) 
            score += 3;

         // 0 if you lost, 3 if the round was a draw, and 6 if you won
         score += (int) elf1;
      }

      return score;
   }

   // X means you need to lose, Y means you need to end the round in a draw, and Z means you need to win.
   private Outcome PickOutcome(char c) => c switch
   {
      'X' => Outcome.Lose,
      'Y' => Outcome.Draw,
      'Z' => Outcome.Win,
      _ => throw new ArgumentOutOfRangeException(nameof(c), c, null)
   };

   private Rochambeau WhatShouldPlayer1Pick(Outcome outcome, Rochambeau elf) => outcome switch
   {
      Outcome.Lose => PickLoser(elf),
      Outcome.Draw => elf,
      Outcome.Win => PickWinner(elf),
      _ => throw new ArgumentOutOfRangeException(nameof(outcome), outcome, null)
   };

   private Rochambeau PickWinner(Rochambeau elf) => elf switch
   {
      Rochambeau.Rock => Rochambeau.Paper,
      Rochambeau.Paper => Rochambeau.Scissors,
      Rochambeau.Scissors => Rochambeau.Rock,
      _ => throw new ArgumentOutOfRangeException(nameof(elf), elf, null)
   };

   private Rochambeau PickLoser(Rochambeau elf) => elf switch
   {
      Rochambeau.Paper => Rochambeau.Rock,
      Rochambeau.Rock => Rochambeau.Scissors,
      Rochambeau.Scissors => Rochambeau.Paper,
      _ => throw new ArgumentOutOfRangeException(nameof(elf), elf, null)
   };

  
   // A for Rock, B for Paper, and C for Scissors
   private Rochambeau GetElf(char c) => c switch
   {
      'A' => Rochambeau.Rock,
      'X' => Rochambeau.Rock,

      'B' => Rochambeau.Paper,
      'Y' => Rochambeau.Paper,

      'C' => Rochambeau.Scissors,
      'Z' => Rochambeau.Scissors,
      _ => throw new ArgumentOutOfRangeException(nameof(c), c, null)
   };
}

// 1 for Rock, 2 for Paper, and 3 for Scissors
public enum Rochambeau
{
   Rock = 1,
   Paper = 2,
   Scissors = 3
};

public enum Outcome
{
   Win = 6,
   Lose = 0,
   Draw = 3
};