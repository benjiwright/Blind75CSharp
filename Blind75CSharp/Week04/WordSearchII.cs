using System.Text;

namespace Blind75CSharp.Week04;

// Runtime: 1819 ms, faster than 25.44% of C# online submissions for Word Search II.
// Memory Usage: 51.5 MB, less than 13.15% of C# online submissions for Word Search II.
public class WordSearchII
{
   public IList<string> FindWords(char[][] board, string[] words)
   {
      if (board is null || words.Length == 0) return new List<string>();

      var trie = BuildPrefixTrie(words);
      bool[,] visited;
      var results = new HashSet<string>();

      for (var row = 0; row < board.Length; row++)
      {
         for (var col = 0; col < board[0].Length; col++)
         {
            visited = new bool[board.Length, board[0].Length];
            visited[row, col] = true;

            DfsBoard(row, col, trie.Head, new StringBuilder(board[row][col].ToString()));
         }
      }

      void DfsBoard(int row, int col, TrieNode node, StringBuilder word)
      {
         var letter = board[row][col];
         if (!node.Children.ContainsKey(letter)) return;

         if (node.Children[letter].IsWord) results.Add(word.ToString());

         // move each legal direction
         var dx = new int[] {0, 0, 1, -1};
         var dy = new int[] {1, -1, 0, 0};
         for (var i = 0; i < 4; i++)
         {
            var newRow = row + dx[i];
            var newCol = col + dy[i];

            // look before leap recursion
            if (newRow < 0 || newCol < 0
                           || newRow >= board.Length || newCol >= board[0].Length
                           || visited[newRow, newCol])
               continue;

            visited[newRow, newCol] = true;
            var newLetter = board[newRow][newCol];
            word.Append(newLetter);

            DfsBoard(newRow, newCol, node.Children[letter], word);

            // backtrack
            word.Remove(word.Length - 1, 1);
            visited[newRow, newCol] = false;
         }
      }

      return results.ToList();
   }

   private Trie BuildPrefixTrie(string[] words)
   {
      var trie = new Trie();

      foreach (var word in words)
      {
         trie.AddWord(word);
      }

      return trie;
   }

   internal class Trie
   {
      public TrieNode Head { get; init; }

      public Trie()
      {
         Head = new TrieNode('!');
      }

      public void AddWord(string word)
      {
         InsertChar(word, Head, 0);
      }

      private void InsertChar(string word, TrieNode node, int idx)
      {
         if (word.Length == idx)
         {
            node.IsWord = true;
            return;
         }

         var letter = word[idx];
         if (!node.Children.ContainsKey(letter))
         {
            node.Children.Add(letter, new TrieNode(letter));
         }

         InsertChar(word, node.Children[letter], idx + 1);
      }
   }

   internal class TrieNode
   {
      public char Value { get; init; }
      public Dictionary<char, TrieNode> Children { get; init; }

      public bool IsWord { get; set; } = false;

      public TrieNode(char value)
      {
         Value = value;
         Children = new Dictionary<char, TrieNode>();
      }
   }
}