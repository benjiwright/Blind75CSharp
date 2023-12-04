using System.Text;

namespace AdventOfCode.Year2023;

public class AoC2023Day03
{
   private char[,] _matrix;
   private int ROW;
   private int COL;

   public int Part01(string[] lines)
   {
      var result = 0;

      _matrix = Matrixify(lines);
      ROW = _matrix.GetLength(0);
      COL = _matrix.GetLength(1);

      for (var r = 0; r < ROW; r++)
      for (var c = 0; c < COL; c++)
      {
         var curr = _matrix[r, c];

         if (char.IsDigit(curr))
         {
            int fullNumber = FindFullNumber(r, c, new Dictionary<(int, int), int>());
            int numberLength = NumberLength(fullNumber);

            if (HasSymbolNearby(fullNumber, numberLength, r, c))
            {
               result += fullNumber;
            }

            c += numberLength - 1;
         }
      }

      return result;
   }

   public int Part02(string[] lines)
   {
      var result = 0;
      var found = false;

      _matrix = Matrixify(lines);
      ROW = _matrix.GetLength(0);
      COL = _matrix.GetLength(1);

      var containsDigit = new Dictionary<(int, int), int>();

      for (var r = 0; r < ROW; r++)
      for (var c = 0; c < COL; c++)
      {
         var curr = _matrix[r, c];
         if (char.IsDigit(curr))
         {
            var number = FindFullNumber(r, c, containsDigit);
            c += NumberLength(number) - 1;
         }
      }

      for (var r = 0; r < ROW; r++)
      for (var c = 0; c < COL; c++)
      {
         var curr = _matrix[r, c];

         if (curr == '*')
         {
            HashSet<int> adjNums = FindAllAdjacentNumbers(r, c, containsDigit);
            if (adjNums.Count == 2)
            {
               result += adjNums.First() * adjNums.Last();
               found = true;
            }
         }
      }

      return found ? result : 0;
   }

   private HashSet<int> FindAllAdjacentNumbers(int r, int c, Dictionary<(int, int), int> containsDigit)
   {
      var result = new HashSet<int>();

      var adjMatrix = new List<int[]>
      {
         new[] {1, 1},
         new[] {1, 0},
         new[] {1, -1},
         new[] {0, 1},
         new[] {0, -1},
         new[] {-1, 1},
         new[] {-1, 0},
         new[] {-1, -1},
      };

      foreach (var a in adjMatrix)
      {
         var rx = r + a[0];
         var cx = c + a[1];

         if (rx < 0 || rx >= ROW || cx < 0 || cx >= COL) continue;

         var curr = _matrix[rx, cx];
         if (char.IsDigit(curr))
         {
            result.Add(containsDigit[(rx, cx)]);
         }
      }

      return result;
   }

   private bool HasSymbolNearby(int fullNumber, int length, int r, int c)
   {
      // check four corners
      if (SafeIsSymbolCheck(r - 1, c - 1)) return true; // top left
      if (SafeIsSymbolCheck(r + 1, c - 1)) return true; // bot left
      if (SafeIsSymbolCheck(r - 1, c + length)) return true; // top right
      if (SafeIsSymbolCheck(r + 1, c + length)) return true; // bot right


      // DFS
      Queue<(int, int)> queue = new();
      var visited = new HashSet<(int, int)>();
      queue.Enqueue((r, c));

      while (queue.Count > 0)
      {
         var (row, col) = queue.Dequeue();
         // boundary check
         if (row < 0 || row >= ROW || col < 0 || col >= COL) continue;
         if (visited.Contains((row, col))) continue;

         visited.Add((row, col));
         var curr = _matrix[row, col];

         if (!char.IsLetter(curr) && !char.IsNumber(curr) && curr != '.') return true; // this good enough?

         // if (curr == '.') continue;
         // if (char.IsLetter(curr)) continue;
         if (char.IsDigit(curr))
         {
            queue.Enqueue((row + 1, col));
            queue.Enqueue((row - 1, col));
            queue.Enqueue((row, col + 1));
            queue.Enqueue((row, col - 1));
         }
      }

      return false;
   }

   private bool SafeIsSymbolCheck(int r, int c)
   {
      // boundary check
      if (r < 0 || r >= ROW || c < 0 || c >= COL) return false;

      var curr = _matrix[r, c];
      if (curr == '.') return false;
      if (char.IsDigit(curr)) return false;

      return true;
   }


   private int NumberLength(int num)
   {
      var result = 0;
      // skip ahead col counter based on int size
      while (num > 0)
      {
         num /= 10;
         result++;
      }

      return result;
   }

   private int FindFullNumber(int r, int c, Dictionary<(int, int), int> containsDigit)
   {
      var sb = new StringBuilder();

      List<(int, int)> digits = new();

      for (; c < COL; c++)
      {
         var curr = _matrix[r, c];
         if (char.IsDigit(curr))
         {
            digits.Add((r, c));
            sb.Append(curr);
         }
         else
         {
            break;
         }
      }

      var result = int.Parse(sb.ToString());
      foreach (var (row, col) in digits)
      {
         containsDigit[(row, col)] = result;
      }

      return result;
   }

   private char[,] Matrixify(string[] lines)
   {
      var row = lines.Length;
      var col = lines[0].Length;
      var result = new char[row, col];

      for (var r = 0; r < row; r++)
      {
         var line = lines[r];
         for (var c = 0; c < col; c++)
         {
            var letter = line[c];
            result[r, c] = letter;
         }
      }

      return result;
   }
}