// See https://aka.ms/new-console-template for more information
var solution = new Solution1();

var n1 = 4;
var output1 = solution.Tribonacci(n1);
Console.WriteLine(output1.ToString()); // true

var n2 = 25;
var output2 = solution.Tribonacci(n2);
Console.WriteLine(output2.ToString()); // true

public class Solution
{
    public int Tribonacci(int n)
    {
        var result = new Dictionary<int, int>() { { 0, 0 }, { 1, 1 }, { 2, 1 } };

        for (int i = 3; i <= n; i++)
        {
            result[i] = result[i - 3] + result[i - 2] + result[i - 1];
        }

        return result[n];
    }
}

public class Solution1
{
    public int Tribonacci(int n)
    {
        var (a, b, c) = (0, 1, 1);

        if (n == 0)
        {
            return 0;
        }

        for (int i = 3; i <= n; i++)
        {
            (a, b, c) = (b, c, a + b + c);
        }

        return c;
    }
}