namespace Blind75CSharp.Week02;

public class Trie
{
   private readonly TrieNode _root;

   public Trie()
   {
      _root = new TrieNode('!');
   }

   public void Insert(string word)
   {
      var current = _root;

      foreach (var letter in word)
      {
         var match = current.Children.FirstOrDefault(x => x.Value == letter);

         if (match is not null)
         {
            // traverse
            current = match;
         }
         else
         {
            // create new node
            var newNode = new TrieNode(letter);
            current.Children.Add(newNode);
            current = newNode;
         }
      }

      current.IsTerminating = true;
   }

   public bool Search(string word)
   {
      var current = _root;
      for (var i = 0; i < word.Length; i++)
      {
         var letter = word[i];
         var match = current.Children.FirstOrDefault(x => x.Value == letter);

         if (match is null) return false;

         if (i == word.Length - 1 && match.IsTerminating)
         {
            return true;
         }

         // traverse
         current = match;
      }

      return false;
   }

   public bool StartsWith(string prefix)
   {
      var current = _root;
      foreach (var letter in prefix)
      {
         var match = current.Children.FirstOrDefault(x => x.Value == letter);

         if (match is null) return false;

         // traverse
         current = match;
      }

      return true;
   }
}

internal record TrieNode(char Value)
{
   public bool IsTerminating { get; set; }
   public HashSet<TrieNode>? Children { get; } = new();
}

// Runtime: 518 ms, faster than 11.24% of C# online submissions for Implement Trie (Prefix Tree).
// Memory Usage: 63.5 MB, less than 92.06% of C# online submissions for Implement Trie (Prefix Tree).