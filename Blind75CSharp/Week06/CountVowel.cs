namespace Blind75CSharp.Week06;

public class CountVowel
{
   public int CountVowelPermutation(int n)
   {
      var dp = new[] {1L, 1L, 1L, 1L, 1L};
      int a = 0, e = 1, i = 2, o = 3, u = 4;
      long mod = 1_000_000_007;;
      
      for (var idx = 2; idx < n + 1; idx++)
      {
         var temp = new long[5];
         Array.Copy(dp, temp, 5);
      
         dp[a] = (temp[e] + temp[i] + temp[u]) % mod;
         dp[e] = (temp[a] + temp[i]) % mod;
         dp[i] = (temp[e] + temp[o]) % mod;
         dp[o] = temp[i] % mod;
         dp[u] = (temp[i] + temp[o]) % mod;
      }

      // Rules:
      // a => e
      // e => a, i
      // i => a, e, o, u
      // o => i, u
      // u => a

      // Reversed:
      // a: e,i,u
      // e: a,i
      // i: e,o
      // o: i
      // u: i,o

      return (int) (dp.Sum() % mod);
   }
   // Runtime: 30 ms, faster than 86.09% of C# online submissions for Count Vowels Permutation.
   // Memory Usage: 27.3 MB, less than 57.74% of C# online submissions for Count Vowels Permutation.
}