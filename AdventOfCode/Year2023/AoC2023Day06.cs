using System.Text;

namespace AdventOfCode.Year2023;

public class AoC2023Day06
{
    private List<int> Times = new();
    private List<int> Distances = new();

    public int Part01(string[] lines)
    {
        ReadInputPopulateCollections(lines);
        
        List<int> results = [];
        
        for (var i = 0; i < Times.Count; i++)
        {
            results.Add(CountOfDistancesBeat(Times[i], Distances[i]));
        }

        return results.Aggregate(1, (a,b) => a * b);
    }

    private int CountOfDistancesBeat(long time, long recordDistance)
    {
        var result = 0;

        for (long i = 0; i < time; i++)
        {
            long duration = time - i;
            long travelDistance = i * duration;

            // have to beat dist, not tie
            if (travelDistance > recordDistance)
            {
                result++;
            }
        }

        return result;
    }

    private void ReadInputPopulateCollections(string[] lines)
    {
        // times
        Times = BuildList(lines[0].Split(' '));
        Distances = BuildList(lines[1].Split(' '));
    }

    private List<int> BuildList(string[] split)
    {
        List<int> result = new();

        for (var i = 1; i < split.Length; i++)
        {
            var section = split[i].Trim();
            if (string.IsNullOrEmpty(section)) continue;

            result.Add(int.Parse(section));
        }

        return result;
    }


    public long Part02(string[] lines)
    {
        
        (long time, long dist) = ReadInputPart2(lines);

        long min = FindMin(time,dist);
        long max = FindMax(time, dist);

        long lazy = CountOfDistancesBeat(time, dist);

        return lazy;

    }

    // this is not correct... yet
    private long FindMax(long time, long dist)
    {
        for (long i = dist; i >= 0; i--)
        {
            long duration = time - i;
            long travelDistance = i * duration;

            // have to beat dist, not tie
            if (travelDistance > dist)
            {
                return i;
            }
        }

        return -1;
    }

    private long FindMin(long time, long dist)
    {
        for (long i = 0; i < time; i++)
        {
            long duration = time - i;
            long travelDistance = i * duration;

            // have to beat dist, not tie
            if (travelDistance > dist)
            {
                return i;
            }
        }

        return -1;
    }

    private (long time, long dist) ReadInputPart2(string[] lines)
    {
        var splitTime = lines[0].Split(' ');
        StringBuilder timeSb = new ();
        for (int i = 1; i < splitTime.Length; i++)
        {
            var val = splitTime[i].ToString();
            if(string.IsNullOrEmpty(val)) continue;
            timeSb.Append(val);
        }
        
        var splitDist = lines[1].Split(' ');
        StringBuilder distSb = new ();
        for (int i = 1; i < splitDist.Length; i++)
        {
            var val = splitDist[i].ToString();
            if(string.IsNullOrEmpty(val)) continue;
            distSb.Append(val);
        }

        long time = long.Parse(timeSb.ToString());
        long dist = long.Parse(distSb.ToString());

        return (time,dist);
    }
}
