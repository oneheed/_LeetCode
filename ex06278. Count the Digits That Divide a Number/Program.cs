// See https://aka.ms/new-console-template for more information

var solution = new Solution();

var input1 = 7;
var output1 = solution.CountDigits(input1);
Console.WriteLine(output1.ToString()); // 1

var input2 = 121;
var output2 = solution.CountDigits(input2);
Console.WriteLine(output2.ToString()); // 2

var input3 = 1248;
var output3 = solution.CountDigits(input3);
Console.WriteLine(output3.ToString()); // 4

public class Solution
{
    public int CountDigits(int num)
    {
        var reuslt = 0;
        var temp = num;
        while (temp > 0)
        {
            var c = temp % 10;

            if (num % c == 0)
                reuslt++;

            temp /= 10;

            //Console.WriteLine($"{temp} {c}");
        }

        return reuslt;
    }
}