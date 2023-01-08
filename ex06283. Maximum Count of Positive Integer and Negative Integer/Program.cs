// See https://aka.ms/new-console-template for more information
var solution = new Solution();

var input4 = new int[] { -2, -1, -1, 1, 2, 3 };
var output4 = solution.MaximumCount(input4);
Console.WriteLine(string.Join(",", output4)); // 3


var input5 = new int[] { -3, -2, -1, 0, 0, 1, 2 };
var output5 = solution.MaximumCount(input5);
Console.WriteLine(string.Join(",", output5)); // 3

var input6 = new int[] { -1924, -1910, -1840, -1797, -1714, -1640, -1638, -1567, -1564, -1409, -1141, -1115, -1068, -658, -465, -447, -434, -386, -321, -191, -186, -127, -63, 69, 186, 253, 334, 401, 482, 805, 809, 812, 833, 913, 955, 991, 1113, 1128, 1133, 1178, 1204, 1570, 1616, 1725, 1729, 1787, 1853, 1943, 1980, 1980 };
var output6 = solution.MaximumCount(input6);
Console.WriteLine(string.Join(",", output6)); // 27


public class Solution
{
    public int MaximumCount(int[] nums)
    {
        var minCount = 0;
        var maxCount = 0;

        foreach (var num in nums)
        {
            if (num > 0)
                maxCount++;

            if (num < 0)
                minCount++;
        }

        return Math.Max(minCount, maxCount);
    }
}