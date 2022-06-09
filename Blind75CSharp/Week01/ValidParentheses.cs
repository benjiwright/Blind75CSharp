namespace Blind75CSharp.Week01;

public class ValidParentheses
{
   public bool IsValid(string s)
   {
      var stack = new Stack<char>();
      var pairs = new Dictionary<char, char>
      {
         {'(', ')'},
         {'{', '}'},
         {'[', ']'},
      };

      foreach (var c in s)
      {
         if (pairs.ContainsKey(c))
         {
            stack.Push(pairs[c]);
         }
         else
         {
            if (stack.Count == 0) return false;
            var popped = stack.Pop();
            if (popped != c) return false;
         }
      }

      return stack.Count <= 0;
   }
}

// Runtime: 103 ms, faster than 44.36% of C# online submissions for Valid Parentheses.
// Memory Usage: 36.6 MB, less than 68.52% of C# online submissions for Valid Parentheses.