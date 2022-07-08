namespace Blind75CSharp.Week04;

public class WordDictionary
{
   private readonly WordNode _root;

   public WordDictionary()
   {
      _root = new WordNode();
   }

   public void AddWord(string word)
   {
      var current = _root;
      foreach (var letter in word)
      {
         current.Children[letter - 'a'] ??= new WordNode();

         current = current.Children[letter - 'a'];
      }

      current.IsTerminationg = true;
   }

   public bool Search(string word) => Dfs(_root, word, 0);

   private bool Dfs(WordNode? node, string word, int index)
   {
      if (node is null) return false;

      if (index == word.Length) return node.IsTerminationg;

      if (word[index] == '.')
      {
         foreach (var child in node.Children)
         {
            if (Dfs(child, word, index + 1)) return true;
         }
      }
      else
      {
         var newNode = node.Children[word[index] - 'a'];
         if (Dfs(newNode, word, index + 1))
         {
            return true;
         }
      }

      return false;
   }
}

internal class WordNode
{
   public WordNode[] Children;
   public bool IsTerminationg { get; set; } = false;

   public WordNode()
   {
      Children = new WordNode[26];
   }
}

// Runtime: 2938 ms, faster than 19.34% of C# online submissions for Design Add and Search Words Data Structure.
// Memory Usage: 171.8 MB, less than 12.60% of C# online submissions for Design Add and Search Words Data Structure.
// I spent an hour debugging and this is still ultra slow =(