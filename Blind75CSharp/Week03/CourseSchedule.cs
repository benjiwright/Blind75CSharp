namespace Blind75CSharp.Week03;

public class CourseSchedule
{
   public bool CanFinish(int numCourses, int[][] prerequisites)
   {
      if (prerequisites.Length == 0) return true;

      // Kahn from memory?
      var depCount = new Dictionary<int, int>();
      var routes = new Dictionary<int, List<int>>();

      // build our managing collections
      foreach (var pair in prerequisites)
      {
         if (!depCount.ContainsKey(pair[0]))
         {
            depCount.Add(pair[0], 0);
         }

         depCount[pair[0]]++;

         if (!routes.ContainsKey(pair[1]))
         {
            routes.Add(pair[1], new List<int> {pair[0]});
         }
         else
         {
            routes[pair[1]].Add(pair[0]);
         }
      }

      // build initial queue of no pre-reqs
      var queue = new Queue<int>();
      for (var i = 0; i < numCourses; i++)
      {
         if (!depCount.ContainsKey(i))
         {
            queue.Enqueue(i);
         }
      }

      // not required, but pseudo optimization
      if (queue.Count <= 0) return false;

      var completedCourseCount = 0;
      while (queue.Count > 0)
      {
         completedCourseCount++;
         var courseId = queue.Dequeue();

         routes.TryGetValue(courseId, out var courseRoutes);
         if (courseRoutes == null) continue;
         foreach (var courseRoute in courseRoutes)
         {
            depCount[courseRoute]--;
            if (depCount[courseRoute] == 0)
               queue.Enqueue(courseRoute);
         }
      }

      return completedCourseCount == numCourses;
   }
   // Runtime: 134 ms, faster than 77.88% of C# online submissions for Course Schedule.
   // Memory Usage: 43.2 MB, less than 44.75% of C# online submissions for Course Schedule.
}