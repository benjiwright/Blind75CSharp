namespace Blind75CSharp.Week06;

public class FreqStack
{
   private int _max = 0;
   private readonly Dictionary<int, int> _counts;
   private readonly Dictionary<int, Stack<int>> _stacks;

   public FreqStack()
   {
      _stacks = new();
      _counts = new();
   }

   public void Push(int val)
   {
      if (!_counts.ContainsKey(val))
         _counts.Add(val, 0);

      _counts[val]++;
      var cnt = _counts[val];

      if (cnt > _max)
      {
         _max = cnt;
         _stacks[cnt] = new Stack<int>();
      }

      _stacks[cnt].Push(val);
   }

   public int Pop()
   {
      var result = _stacks[_max].Pop();
      _counts[result]--;

      if (_stacks[_max].Count == 0) _max--;

      return result;
   }
}
// Runtime 822ms Beats 13.72%
// Memory 62.6MB Beats 21.57%