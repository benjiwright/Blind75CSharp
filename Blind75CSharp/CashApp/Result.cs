namespace Blind75CSharp.CashApp;

using System.Collections.Generic;
using System;

class Result
{
   /*
    * Complete the 'closestStraightCity' function below.
    *
    * The function is expected to return a STRING_ARRAY.
    * The function accepts following parameters:
    *  1. STRING_ARRAY c
    *  2. INTEGER_ARRAY x
    *  3. INTEGER_ARRAY y
    *  4. STRING_ARRAY q
    */

// n cities, m queries

   public static List<string> closestStraightCity(List<string> c, List<int> x, List<int> y, List<string> q)
   {
      var xDict = new Dictionary<int, List<int>>(); // x,y
      var yDict = new Dictionary<int, List<int>>(); // y,
      var result = new List<string>();

      // 23,1
      // 23,10
      // 23,20


      for (var i = 0; i < x.Count; i++)
      {
         if (!xDict.ContainsKey(x[i]))
         {
            xDict.Add(x[i], new List<int>());
         }

         xDict[x[i]].Add(y[i]);
      }

      for (var i = 0; i < x.Count; i++)
      {
         if (!yDict.ContainsKey(y[i]))
         {
            xDict.Add(y[i], new List<int>());
         }

         xDict[y[i]].Add(x[i]);
      }


      // Dict  City: x,
      var cities = new Dictionary<string, (int, int)>();
      for (var i = 0; i < c.Count; i++)
      {
         var myX = x[i];
         var myY = y[i];
         cities.Add(c[i], (myX, myY));
      }


      foreach (var query in q)
      {
         var (myX, myY) = cities[query];

         // {23: {1, 10, 20}}


         var closest = int.MaxValue;
         foreach (var aY in xDict[myX])
         {
            var dist = Math.Abs(aY - myY);
            if (dist == 0) continue;
            closest = Math.Min(closest, dist);
         }
      }


      return result;
   }
}