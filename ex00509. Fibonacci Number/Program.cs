// See https://aka.ms/new-console-template for more information
var solution = new Solution();

var n1 = 2;
var output1 = solution.Fib(n1);
Console.WriteLine(output1.ToString()); // 1

var n2 = 3;
var output2 = solution.Fib(n2);
Console.WriteLine(output2.ToString()); // 2

var n3 = 4;
var output3 = solution.Fib(n3);
Console.WriteLine(output3.ToString()); // 3

var n4 = 0;
var output4 = solution.Fib(n4);
Console.WriteLine(output4.ToString()); // 0

public class Solution
{
    public int Fib(int n)
    {
        if (n == 0)
            return 0;

        var res = new int[n + 1];
        res[0] = 0;
        res[1] = 1;

        for (int i = 2; i <= n; i++)
        {
            res[i] = res[i - 2] + res[i - 1];
            //Console.WriteLine($"{i} {res[i]}");
        }

        return res[n];
    }
}