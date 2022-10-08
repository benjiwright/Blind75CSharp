namespace Blind75CSharp.CashApp;

using System;
using System.Text;

/*
PAGINATION INTERFACE
We have a list of items and we want to add pagination. You will create a text-based UI to show and navigate between the pages.

Your pagination component is based on three integer values: (1) total number of pages, (2) number of pages to show, and (3) the current page.

It uses an * to mark the current page. That page should be centered as much as feasible. A “<” on the left side indicates that the user can move down from the current page. A “>” on the right side indicates that the user can move up from the current page. Here is an example:

┍━━━━━━━━━━━━━━━━━━━━━━━━━┑
│         Inputs          │     
┝━━━━━━━┯━━━━━━━┯━━━━━━━━━┿━━━━━━━━━━━━━━━━━━━━━━━━━━━┑
│ Total │ Show  │ Current │ Output                    │
┝━━━━━━━┿━━━━━━━┿━━━━━━━━━┿━━━━━━━━━━━━━━━━━━━━━━━━━━━┥
│   10  │   7   │    5    │ < 2 3 4 5* 6 7 8 >        │
┕━━━━━━━┷━━━━━━━┷━━━━━━━━━┷━━━━━━━━━━━━━━━━━━━━━━━━━━━┙
┍━━━━━━━━━━━━━━━━━━━━━━━━━┑
│         Inputs          │     
┝━━━━━━━┯━━━━━━━┯━━━━━━━━━┿━━━━━━━━━━━━━━━━━━━━━━━━━━━┑
│ Total │ Show  │ Current │ Output                    │
┝━━━━━━━┿━━━━━━━┿━━━━━━━━━┿━━━━━━━━━━━━━━━━━━━━━━━━━━━┥
│   10  │   7   │    1    │ 1* 2 3 4 5 6 7 >          │
│   10  │   7   │    10   │ < 4 5 6 7 8 9 10*   
│   10  │   7   │    9    │ < 4 5 6 7 8 9* 10   
|   10  │   1   │    3    │ < 3* >   
|    1  |   3   |    1    | 1*    
│    5  │   7   │    3    │ < 1 2 3* 4 5 >            │
┕━━━━━━━┷━━━━━━━┷━━━━━━━━━┷━━━━━━━━━━━━━━━━━━━━━━━━━━━┙

1*

*/
public class MainFail
{
   public static void Main()
   {
      Console.WriteLine(Pagination(10, 7, 10)); // right
      // Console.WriteLine(Pagination(10,7,9)); // right
      Console.WriteLine(Pagination(10, 7, 5)); //  < 2 3 4 5* 6 7 8 >  center
   }

   private static string Pagination(int total, int show, int current)
   {
      int n = show > total ? total : show; // 7 > 10  = 7

      // handle center case
      var center = show / 2; // 7 / 2 = 3
      if (current + center > total) // 5 + 3
      {
         return Center(total - show + 1, total, current);
      }
      else if (current - center <= 0) // TODO: check boundary
      {
         // handle left case
      }
      else
      {
         return Center(current - center, current + center, current);
      }

      return "fail";
   }

   private static string Center(int start, int end, int current)
   {
      var sb = new StringBuilder();
      for (var i = start; i <= end; i++) // 
      {
         sb.Append(i);
         if (i == current) sb.Append('*');
         sb.Append(' ');
      }

      return sb.ToString();
   }
}

// │ Total │ Show  │ Current │ Output                    │
// ┝━━━━━━━┿━━━━━━━┿━━━━━━━━━┿━━━━━━━━━━━━━━━━━━━━━━━━━━━┥
// │   10  │   7   │    10   │ < 4 5 6 7 8 9 10*   
// │   10  │   7   │    9    │ < 4 5 6 7 8 9* 10   