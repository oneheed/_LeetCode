// See https://aka.ms/new-console-template for more information
var solution = new Solution1();

var input1 = new int[] { 7, 1, 5, 3, 6, 4 };
var output1 = solution.MaxProfit(input1);
Console.WriteLine(output1.ToString()); // 5

var input2 = new int[] { 7, 6, 4, 3, 1 };
var output2 = solution.MaxProfit(input2);
Console.WriteLine(output2.ToString()); // 0

var input3 = new int[] { 2, 4, 1 };
var output3 = solution.MaxProfit(input3);
Console.WriteLine(output3.ToString()); // 2


public class Solution
{
    public int MaxProfit(int[] prices)
    {
        var max = int.MinValue;
        var min = int.MaxValue;
        var result = 0;

        foreach (var price in prices)
        {
            if (price < min)
            {
                max = price;
                min = price;
            }

            if (price > max)
            {
                max = price;
                result = Math.Max(result, max - min);
            }
        }

        return result;
    }
}

public class Solution1
{
    public int MaxProfit(int[] prices)
    {
        var profit = int.MinValue;
        var buy = int.MaxValue;

        foreach (var price in prices)
        {
            buy = Math.Min(buy, price);
            profit = Math.Max(profit, price - buy);
        }

        return profit;
    }
}