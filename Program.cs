using System;

class Program
{
    static void Main(string[] args)
    {
        int[] valArr = [1,2,2,3];
        int totalPair = 4;
        Console.WriteLine(CountPair(valArr, totalPair));
    }

    private static int CountPair(int[] valArr, int totalPair)
    {
        Dictionary<int, int > pairs = [];
        int count = 0;
        foreach (int i in valArr)
        {
            int pair = totalPair - i;

            if (pairs.TryGetValue(pair, out int value))
            {
                count += value;
            }
            pairs[i] = pairs.GetValueOrDefault(i, 0) + 1;
        }

        return count;
    }
}