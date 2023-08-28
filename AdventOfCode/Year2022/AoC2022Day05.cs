using System.Text;

namespace AdventOfCode.Year2022;

public class AoC2022Day05
{
   private List<LinkedList<char>> _world = new();
   private List<(int count, int source, int dest)> _instructions = new();

   private bool _AreWeDoneBuildingWorld = false;


   public string Part02(string[] lines)
   {
      _world.Add(new LinkedList<char>()); // not zero based instructions


      foreach (var line in lines)
      {
         ParseInput(line);
      }

      ExecuteInstructionsPart2();
      return GetSolutionFromWorld();
   }

   private void ExecuteInstructionsPart2()
   {
      // this could be done better with Skip, Take, and Reverse
      foreach (var instruction in _instructions)
      {
         var sourceCrates = _world[instruction.source];
         var itemsToMove = sourceCrates.TakeLast(instruction.count).ToList();

         foreach (var _ in itemsToMove)
         {
            sourceCrates.RemoveLast();
         }

         foreach (var item in itemsToMove)
         {
            _world[instruction.dest].AddLast(item);
         }
      }
   }


   public string Part01(string[] lines)
   {
      _world.Add(new LinkedList<char>()); // not zero based instructions

      foreach (var line in lines)
      {
         ParseInput(line);
      }

      ExecuteInstructions();

      return GetSolutionFromWorld();
   }

   private string GetSolutionFromWorld()
   {
      var sb = new StringBuilder();

      for (var i = 1; i < _world.Count; i++)
      {
         sb.Append(_world[i].Last.Value);
      }

      return sb.ToString();
   }

   private void ExecuteInstructions()
   {
      // this could be done better with Skip, Take, and Reverse
      foreach (var instruction in _instructions)
      {
         var itemsToMove = new List<char>();
         for (var i = 0; i < instruction.count; i++)
         {
            itemsToMove.Add(_world[instruction.source].Last());
            _world[instruction.source].RemoveLast();
         }

         foreach (var item in itemsToMove)
         {
            _world[instruction.dest].AddLast(item);
         }
      }
   }

   private void ParseInput(string line)
   {
      if (string.IsNullOrEmpty(line)) return;

      if (_AreWeDoneBuildingWorld)
      {
         BuildInstructions(line);
      }
      else
      {
         BuildWorld(line);
      }
   }

   private void BuildWorld(string line)
   {
      // 0         1         2 
      // 012345678901234567890
      //                 [B] [L]     [J]    
      // [S] [J] [S] [T] [T] [M] [D] [B] [H]

      for (var i = 1; i < line.Length; i += 4)
      {
         var c = line[i];

         var belongsToStackIdx = ((i - 1) / 4) + 1;
         if (_world.Count == belongsToStackIdx)
         {
            _world.Add(new LinkedList<char>());
         }

         switch (c)
         {
            case ' ': // skip whitespace
               continue;
            case '1': // flag to know when done building world
               _AreWeDoneBuildingWorld = true;
               return;
            default:
               _world[belongsToStackIdx].AddFirst(c);
               break;
         }
      }
   }

   private void BuildInstructions(string instruction)
   {
      var split = instruction.Split(" ");
      var count = Convert.ToInt32(split[1]);
      var source = Convert.ToInt32(split[3]);
      var dest = Convert.ToInt32(split[5]);

      _instructions.Add((count, source, dest));
   }
}