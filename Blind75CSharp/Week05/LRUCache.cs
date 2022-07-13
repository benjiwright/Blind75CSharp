namespace Blind75CSharp.Week05;

public class LRUCache
{
   private readonly int _capacity;
   private readonly LinkedList<int[]> _linkList;
   private readonly Dictionary<int, LinkedListNode<int[]>> _cache;

   public LRUCache(int capacity)
   {
      _capacity = capacity;
      _linkList = new LinkedList<int[]>();
      _cache = new Dictionary<int, LinkedListNode<int[]>>();
   }

   public int Get(int key)
   {
      if (!_cache.ContainsKey(key)) return -1;

      // move to MRU
      MoveToMru(_cache[key]);

      return _cache[key].Value[1];
   }

   public void Put(int key, int value)
   {
      if (_cache.ContainsKey(key)) _cache[key].Value[1] = value;
      else
      {
         if (_cache.Count == _capacity)
         {
            _cache.Remove(_linkList.Last.Value[0]);
            _linkList.RemoveLast();
         }

         _cache.Add(key, new LinkedListNode<int[]>(new[] {key, value}));
      }

      MoveToMru(_cache[key]);
   }

   private void MoveToMru(LinkedListNode<int[]> node)
   {
      if (node.Previous != null) _linkList.Remove(node);
      if (_linkList.First != node) _linkList.AddFirst(node);
   }
}
// Runtime: 1165 ms, faster than 46.80% of C# online submissions for LRU Cache.
// Memory Usage: 141.6 MB, less than 39.27% of C# online submissions for LRU Cache.