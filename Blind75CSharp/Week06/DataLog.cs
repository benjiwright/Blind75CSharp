using System.Text;

namespace Blind75CSharp.Week06;

public class DataLog
{
   private List<DigitLog> _digitLogs = new();
   private PriorityQueue<LetterLog, LetterLog> _letterLogs = new();

   public string[] ReorderLogFiles(string[] logs)
   {
      foreach (var log in logs)
      {
         var delimited = log.Split(" ");
         var id = delimited[0];
         var isLetterLog = delimited[1].All(char.IsLetter);

         var theLog = new StringBuilder();
         foreach (var l in delimited.Skip(1).Take(delimited.Length - 1).ToList())
         {
            theLog.Append(l + " ");
         }

         if (theLog.Length > 0)
         {
            theLog.Remove(theLog.Length - 1, 1);
         }

         if (isLetterLog)
         {
            var letterLog = new LetterLog(id, theLog.ToString());
            _letterLogs.Enqueue(letterLog, letterLog);
         }
         else
            _digitLogs.Add(new DigitLog(id, theLog.ToString()));
      }

      var result = new string[_letterLogs.Count + _digitLogs.Count];
      var idx = 0;

      while (_letterLogs.Count > 0)
      {
         var letterLog = _letterLogs.Dequeue();
         result[idx] = letterLog.Identifier + " " + letterLog.Logs;
         idx++;
      }

      foreach (var digitLog in _digitLogs)
      {
         result[idx] = digitLog.Identifier + " " + digitLog.Logs;
         idx++;
      }

      return result;
   }
   // Runtime: 297 ms, faster than 12.94% of C# online submissions for Reorder Data in Log Files.
   // Memory Usage: 47.4 MB, less than 56.06% of C# online submissions for Reorder Data in Log Files.
}

public interface IAmazonLog
{
   string Identifier { get; init; }
   string Logs { get; init; }
}

public class LetterLog : IAmazonLog, IComparable
{
   public LetterLog(string id, string logs)
   {
      Identifier = id;
      Logs = logs;
   }

   public string Identifier { get; init; }
   public string Logs { get; init; }

   public int CompareTo(object? obj)
   {
      if (obj == null) return 1;

      if (obj is not LetterLog other) throw new ArgumentException("Bad cast");

      return CompareTo(other);
   }

   private int CompareTo(LetterLog other)
   {
      return Logs == other.Logs
         ? string.Compare(Identifier, other.Identifier, StringComparison.Ordinal)
         : string.Compare(Logs, other.Logs, StringComparison.Ordinal);
   }
}

public class DigitLog : IAmazonLog
{
   public string Identifier { get; init; }
   public string Logs { get; init; }

   public DigitLog(string id, string logs)
   {
      Identifier = id;
      Logs = logs;
   }
}