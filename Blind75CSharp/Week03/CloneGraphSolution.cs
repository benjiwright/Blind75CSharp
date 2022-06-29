namespace Blind75CSharp.Week03;

public class CloneGraphSolution
{
   public Node CloneGraph(Node node)
   {
      if (node is null) return null;

      var queue = new Queue<Node>();
      queue.Enqueue(node);
      var visited = new Dictionary<Node, Node>
      {
         {node, new Node(node.val, new List<Node>())}
      };

      while (queue.Count > 0)
      {
         var currentNode = queue.Dequeue();

         foreach (var neighbor in currentNode.neighbors)
         {
            if (!visited.ContainsKey(neighbor))
            {
               visited.Add(neighbor, new Node(neighbor.val, new List<Node>()));
               queue.Enqueue(neighbor);
            }

            visited[currentNode].neighbors.Add(visited[neighbor]);
         }
      }

      return visited[node];
   }
   // Runtime: 174 ms, faster than 77.63% of C# online submissions for Clone Graph.
   // Memory Usage: 41.8 MB, less than 60.02% of C# online submissions for Clone Graph.
}

// Definition for a Node. (not my code)
public class Node
{
   public int val;
   public IList<Node> neighbors;

   public Node()
   {
      val = 0;
      neighbors = new List<Node>();
   }

   public Node(int _val)
   {
      val = _val;
      neighbors = new List<Node>();
   }

   public Node(int _val, IList<Node> _neighbors)
   {
      val = _val;
      neighbors = _neighbors;
   }
}