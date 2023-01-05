// See https://aka.ms/new-console-template for more information
var solution = new Solution();

var input1 = new int[] { 2, 4, 3, 7, 10, 6 };
var output1 = solution.DistinctPrimeFactors(input1);
Console.WriteLine(output1.ToString()); // 4

solution = new Solution();
var input2 = new int[] { 2, 4, 8, 16 };
var output2 = solution.DistinctPrimeFactors(input2);
Console.WriteLine(output2.ToString()); // 1


public class Solution
{
    private HashSet<int> _solution = new HashSet<int>();

    public int DistinctPrimeFactors(int[] nums)
    {
        foreach (var num in nums)
        {
            var temp = num;
            for (int i = 2; i <= num; i++)
            {
                if (temp % i == 0)
                {
                    temp = temp / i;
                    i--;

                    if (!_solution.Contains(i))
                        _solution.Add(i);
                }
            }
        }

        return _solution.Count;
    }
}