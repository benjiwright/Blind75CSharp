namespace Blind75CSharp.TreeHouseParty;

public static class LeetCodeTree
{
   public static TreeNode Build(int?[] arr)
   {
      var n = arr.Length;
      var queue = new Queue<TreeNode>();
      TreeNode root = null;

      if (arr.Length > 0)
      {
         root = new TreeNode(arr[0]);
         queue.Enqueue(root);
      }

      var idx = 1;
      TreeNode node = null;
      while (queue.Count > 0)
      {
         node = queue.Dequeue();
         
         TreeNode leftNode = null;
         if (idx < n && arr[idx] is not null)
         {
            leftNode = new TreeNode(arr[idx]);
         }
         
         TreeNode rightNode = null;
         if (idx + 1 < n  && arr[idx+1] is not null)
         {
            rightNode = new TreeNode(arr[idx + 1]);
         }

         node.left = leftNode;
         node.right = rightNode;
         
         if(leftNode is not null) queue.Enqueue(leftNode);
         if(rightNode is not null) queue.Enqueue(rightNode);

         idx += 2;
         if (idx >= n) break;
      }

      return root;
   }
}
