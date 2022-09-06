namespace Blind75CSharp.Week06;

public class MinStack
{
   private readonly Stack<(int, int)> _stack;

   public MinStack()
   {
      _stack = new();
   }

   public void Push(int val)
   {
      if (!_stack.Any())
      {
         _stack.Push((val, val));
         return;
      }

      var (_, prevMin) = _stack.Peek();
      var min = Math.Min(val, prevMin);
      _stack.Push((val, min));
   }

   public void Pop()
   {
      _stack.Pop();
   }

   public int Top()
   {
      var (val, _) = _stack.Peek();
      return val;
   }

   public int GetMin()
   {
      var (_, min) = _stack.Peek();
      return min;
   }
}
// Runtime: 221 ms, faster than 28.22% of C# online submissions for Min Stack.
// Memory Usage: 46.7 MB, less
