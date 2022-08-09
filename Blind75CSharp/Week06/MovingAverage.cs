namespace Blind75CSharp.Week06;

public class MovingAverage
{
   private int Size { get; }
   private double _total = 0;
   private readonly Queue<int> _queue = new();

   public MovingAverage(int size)
   {
      Size = size;
   }

   public double Next(int val)
   {
      if (_queue.Count == Size) _total -= _queue.Dequeue();

      _total += val;
      _queue.Enqueue(val);

      return Convert.ToDouble(_total / _queue.Count);
   }
}
// Runtime: 184 ms, faster than 60.21% of C# online submissions for Moving Average from Data Stream.
// Memory Usage: 49.3 MB, less than 54.58% of C# online submissions for Moving Average from Data Stream.