namespace AdventOfCode.Year2022;

public class AoC2022Day06
{
   public int Part01And02(string line, int size = 4)
   {
      int windowSize = size;
      var right = windowSize - 1;
      var dict = new Dictionary<char,int>();
      
      for (var i = 0; i < windowSize; i++)
      {
         var c = line[i];
         dict.TryAdd(c, 0);
         dict[c]++;
      }
      
      if (dict.Count == windowSize) return right + 1;

      // iterate
      for(var left=0; right<line.Length; left++)
      {
         if (dict.Count == windowSize) return right + 1;

         var c = line[left];
         dict[c]--;
         if (dict[c] == 0) dict.Remove(c);
         

         if (right + 1 == line.Length) return -1;
         right++;
         
         if(!dict.ContainsKey(line[right]))
            dict.Add(line[right],0);

         dict[line[right]]++;

      }
      
      return -1;
   }
}