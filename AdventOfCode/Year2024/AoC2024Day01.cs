namespace AdventOfCode.Year2024;

public class AoC2024Day01
{
    // this should be its own helper class (in a perfect world)
    public (List<int>, List<int> ) LinesToLists(string[] lines)
    {
        List<int> a = [];
        List<int> b = [];

        foreach (var line in lines)
        {
            var numbers = line.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            a.Add(int.Parse(numbers[0]));
            b.Add(int.Parse(numbers[1]));
        }

        return (a, b);
    }


    public int SumDistances(List<int> a, List<int> b)
    {
        a.Sort();
        b.Sort();
        int result = 0;

        for (var i = 0; i < a.Count; i++)
        {
            result += Math.Abs(a[i] - b[i]);
        }

        return result;
    }

    public int SimilarityScore(List<int> a, List<int> b)
    {
        var result = 0;
        var freq = FrequencyOfOccurs(b);

        foreach (var i in a)
        {
            if (freq.TryGetValue(i, out var value))
            {
                result += value * i;
            }
        }

        return result;
    }

    private Dictionary<int, int> FrequencyOfOccurs(List<int> ints) =>
        ints.GroupBy(x => x)
            .ToDictionary(g => g.Key, g => g.Count());
}