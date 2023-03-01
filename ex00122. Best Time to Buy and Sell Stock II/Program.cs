// See https://aka.ms/new-console-template for more information
var solution = new Solution1();

var input1 = new int[] { 7, 1, 5, 3, 6, 4 };
var output1 = solution.MaxProfit(input1);
Console.WriteLine(output1.ToString()); // 7

var input2 = new int[] { 1, 2, 3, 4, 5 };
var output2 = solution.MaxProfit(input2);
Console.WriteLine(output2.ToString()); // 4

var input3 = new int[] { 7, 6, 4, 3, 1 };
var output3 = solution.MaxProfit(input3);
Console.WriteLine(output3.ToString()); // 0

public class Solution
{
    public int MaxProfit(int[] prices)
    {
        var result = 0;
        var profit = int.MinValue;
        var buy = int.MaxValue;

        foreach (var price in prices)
        {
            buy = Math.Min(buy, price);

            if (profit > price - buy)
            {
                result += profit;
                profit = int.MinValue;
                buy = price;
            }
            else
            {
                profit = Math.Max(profit, price - buy);
            }
        }

        if (profit > 0)
            result += profit;

        return result;
    }
}

public class Solution1
{
    public int MaxProfit(int[] prices)
    {
        var profit = 0;

        for (int i = 1; i < prices.Length; i++)
        {
            var p = prices[i] - prices[i - 1];

            if (p > 0)
                profit += p;
        }

        return profit;
    }
}