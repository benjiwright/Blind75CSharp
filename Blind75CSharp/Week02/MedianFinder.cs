namespace Blind75CSharp.Week02;

public class MedianFinder
{
   private readonly PriorityQueue<int, int> _minHeap;
   private readonly PriorityQueue<int, int> _maxHeap;

   public MedianFinder()
   {
      _minHeap = new PriorityQueue<int, int>();
      _maxHeap = new PriorityQueue<int, int>();
   }

   public void AddNum(int num)
   {
      // just throw everything in the max heap
      _maxHeap.Enqueue(num, -1 * num);

      // are things in the right place?
      if (_minHeap.Count > 0 && _maxHeap.Peek() > _minHeap.Peek())
      {
         var value = _maxHeap.Dequeue(); 
         _minHeap.Enqueue(value,value);
      }
      
      // balance heaps
      if (_maxHeap.Count - _minHeap.Count > 1)
      {
         var value = _maxHeap.Dequeue();
         _minHeap.Enqueue(value, value);
      }
      else if (_minHeap.Count - _maxHeap.Count > 1)
      {
         var value = _minHeap.Dequeue();
         _maxHeap.Enqueue(value, value * -1);
      }
   }

   public double FindMedian()
   {
//      var isOdd = Convert.ToBoolean((_minHeap.Count + _maxHeap.Count) % 2);

      if (_minHeap.Count > _maxHeap.Count) return Convert.ToDouble(_minHeap.Peek());
      if (_minHeap.Count < _maxHeap.Count) return Convert.ToDouble(_maxHeap.Peek());

      return Convert.ToDouble((_maxHeap.Peek() + _minHeap.Peek()) / 2.0);
   }
}

// Runtime: 995 ms, faster than 32.90% of C# online submissions for Find Median from Data Stream.
// Memory Usage: 106.2 MB, less than 5.64% of C# online submissions for Find Median from Data Stream.