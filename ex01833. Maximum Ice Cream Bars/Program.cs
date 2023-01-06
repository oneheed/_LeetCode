// See https://aka.ms/new-console-template for more information
var solution = new Solution1();

var s1 = new int[] { 1, 3, 2, 4, 1 };
var t1 = 7;
var output1 = solution.MaxIceCream(s1, t1);
Console.WriteLine(output1); //4

var s2 = new int[] { 10, 6, 8, 7, 7, 8 };
var t2 = 5;
var output2 = solution.MaxIceCream(s2, t2);
Console.WriteLine(output2); //0

var s3 = new int[] { 1, 6, 3, 1, 2, 5 };
var t3 = 20;
var output3 = solution.MaxIceCream(s3, t3);
Console.WriteLine(output3); //6

var s4 = new int[] { 5 };
var t4 = 5;
var output4 = solution.MaxIceCream(s4, t4);
Console.WriteLine(output4); //1

public class Solution
{
    public int MaxIceCream(int[] costs, int coins)
    {
        Array.Sort(costs);
        var result = 0;
        for (int i = 0; i < costs.Length; i++)
        {
            if (costs[i] <= coins)
            {
                coins -= costs[i];
                result++;
            }

            if (coins <= 0)
            {
                return result;
            }
        }

        return result;
    }
}

public class Solution1
{
    public int MaxIceCream(int[] costs, int coins)
    {
        var index = 0;
        Array.Sort(costs);
        while (coins > 0 && index < costs.Length)
        {
            coins -= costs[index];
            if (coins < 0)
                return index;
            index++;
        }

        return index;
    }
}