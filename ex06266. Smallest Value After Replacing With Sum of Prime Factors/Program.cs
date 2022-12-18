// See https://aka.ms/new-console-template for more information
var solution = new Solution();

//var input1 = 15;
//var output1 = solution.SmallestValue(input1);
//Console.WriteLine(output1.ToString()); // [4,7,2,9,6,3,1]

//var input2 = 2;
//var output2 = solution.SmallestValue(input2);
//Console.WriteLine(string.Join(",", output2)); // [1,2,3,4,5]

//var input3 = 4;
//var output3 = solution.SmallestValue(input3);
//Console.WriteLine(string.Join(",", output3)); // [3,4,6,16,17]

//var input4 = 99953;
var input4 = 19;
var output4 = solution.SmallestValue(input4);
Console.WriteLine(string.Join(",", output4)); // [3,4,6,16,17]


public class Solution
{
    public int SmallestValue(int n)
    {
        int ans = Test(n);
        if (ans == n)
            return ans;
        else
            return SmallestValue(ans);
    }

    private int Test(int n)
    {
        int sm = 0;
        while (n % 2 == 0)
        {
            sm += 2;
            n = n / 2;
        }

        for (int i = 3; i <= Math.Sqrt(n); i = i + 2)
        {

            while (n % i == 0)
            {
                sm += i;
                n = n / i;
            }
        }


        if (n > 2)
            sm += n;


        return sm;
    }
}
