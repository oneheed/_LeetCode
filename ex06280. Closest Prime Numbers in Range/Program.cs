// See https://aka.ms/new-console-template for more information
var solution = new Solution();

var left1 = 10;
var right1 = 19;
var output1 = solution.ClosestPrimes(left1, right1);
Console.WriteLine(string.Join(",", output1)); // [11,13]

var left2 = 4;
var right2 = 6;
var output2 = solution.ClosestPrimes(left2, right2);
Console.WriteLine(string.Join(",", output2)); // [-1,-1]

var left3 = 17;
var right3 = 31;
var output3 = solution.ClosestPrimes(left3, right3);
Console.WriteLine(string.Join(",", output3)); // [17,19]

var left4 = 1087;
var right4 = 4441;
var output4 = solution.ClosestPrimes(left4, right4);
Console.WriteLine(string.Join(",", output4)); // [[1091,1093]]

var left5 = 19;
var right5 = 31;
var output5 = solution.ClosestPrimes(left5, right5);
Console.WriteLine(string.Join(",", output5)); // [19,31]

var left6 = 21;
var right6 = 25;
var output6 = solution.ClosestPrimes(left6, right6);
Console.WriteLine(string.Join(",", output6)); // [-1,-1]

var left7 = 1;
var right7 = 1;
var output7 = solution.ClosestPrimes(left7, right7);
Console.WriteLine(string.Join(",", output7)); // [-1,-1]

public class Solution
{
    public int[] ClosestPrimes(int left, int right)
    {
        var result = new int[2] { -1, -1 };
        var primeNumbers = new List<int>();

        for (int i = left; i <= right; i++)
        {
            if (IsPrime(i))
            {
                //Console.WriteLine($"{i}");
                primeNumbers.Add(i);
            }
        }

        var min = int.MaxValue;
        for (int i = 0; i < primeNumbers.Count - 1; i++)
        {
            if (min > primeNumbers[i + 1] - primeNumbers[i])
            {
                result[0] = primeNumbers[i];
                result[1] = primeNumbers[i + 1];
                min = primeNumbers[i + 1] - primeNumbers[i];
            }
        }

        return result;
    }

    public bool IsPrime(int n)
    {
        if (n <= 1)
            return false;

        if (n <= 3)
            return true;

        if (n % 2 == 0 || n % 3 == 0)
            return false;

        for (int i = 5; i * i <= n; i = i + 6)
        {
            if (n % i == 0 || n % (i + 2) == 0)
                return false;
        }

        return true;
    }
}