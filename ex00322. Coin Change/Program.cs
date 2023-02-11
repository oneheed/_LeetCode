// See https://aka.ms/new-console-template for more information
var solution = new Solution();

var coins1 = new int[] { 2, 5 };
var amount1 = 7;
var output1 = solution.CoinChange(coins1, amount1);
Console.WriteLine(output1.ToString()); // 3


public class Solution
{


    public int CoinChange(int[] coins, int amount)
    {
        return Change(coins, amount, new Dictionary<int, int>());
    }


    public int Change(int[] coins, int amount, Dictionary<int, int> memo)
    {

        if (amount == 0)
            return 0;


        if (memo.ContainsKey(amount))
            return memo[amount];

        int minCoin = int.MaxValue;
        foreach (int coin in coins)
        {
            if (coin <= amount)
            {
                int min = Change(coins, amount - coin, memo);
                if (min < 0)
                    continue;
                else
                    minCoin = Math.Min(minCoin, min);
            }
        }

        memo[amount] = minCoin == int.MaxValue ? -1 : minCoin + 1;
        return memo[amount];
    }

}