// See https://aka.ms/new-console-template for more information
var solution = new Solution();

var input1 = 521;
var output1 = solution.AlternateDigitSum(input1);
Console.WriteLine(string.Join(",", output1)); // 50


public class Solution
{
    public int AlternateDigitSum(int n)
    {
        var stack = new Stack<int>();

        while (n > 0)
        {
            var t = n % 10;
            stack.Push(t);

            n = n / 10;
        }

        var sum = 0;
        var diff = 1;
        while (stack.Any())
        {
            sum += diff * stack.Pop();

            diff *= -1;
        }

        return sum;
    }
}