namespace AdventOfCode.Year2022;

public class AoC2022Day04
{
   public int Part01(string[] lines)
   {
      var score = 0;
      foreach (var line in lines)
      {
         var assignments = MakePairs(line);

         if (IsTheFirstAssigmentBigger(assignments[0], assignments[1]))
         {
            if (IsASubSet(assignments[0].min, assignments[0].max, assignments[1].min, assignments[1].max))
            {
               score++;
            }
         }
         else
         {
            if (IsASubSet(assignments[1].min, assignments[1].max, assignments[0].min, assignments[0].max))
            {
               score++;
            }
         }
      }

      return score;
   }

   public int Part02(string[] lines)
   {
      int result = 0;
      foreach (var line in lines)
      {
         var sections = line.Split(',');

         var range1 = sections[0].Split("-");
         var range2 = sections[1].Split("-");

         var range1Start = Convert.ToInt32(range1[0]);
         var range1End = Convert.ToInt32(range1[1]);
         var range2Start = Convert.ToInt32(range2[0]);
         var range2End = Convert.ToInt32(range2[1]);

         if ((range2Start <= range1Start && range2End >= range1Start) || 
             (range2Start <= range1End && range2End >= range1End) || 
             (range1Start <= range2Start && range1End >= range2Start) || 
             (range1Start <= range2End && range1End >= range2End))
         {
            ++result;
         }
      }

      return result;
   }

   private bool IsASubSet(int biggerMin, int biggerMax, int smallerMin, int smallerMax)
   {
      return smallerMax <= biggerMax && smallerMin >= biggerMin;
   }

   private bool IsTheFirstAssigmentBigger((int min, int max) ass1, (int min, int max) ass2)
   {
      var size1 = ass1.max - ass1.min;
      var size2 = ass2.max - ass2.min;

      return size1 > size2;
   }

   private List<(int min, int max)> MakePairs(string line)
   {
      var result = new List<(int min, int max)>();

      var pairs = line.Split(',');
      var list = new List<string[]>();
      foreach (var pair in pairs)
      {
         list.Add(pair.Split('-'));
      }
      
      foreach (var foo in list)
      {
         var min = int.Parse(foo[0]);
         var max = int.Parse(foo[1]);

         result.Add((min, max));
      }

      return result;
   }
}