// See https://aka.ms/new-console-template for more information

var solution = new Solution();

var nums1 = new int[] { 1, 2, 3 };
var output1 = solution.Subsets(nums1);
Console.WriteLine(string.Join(',', output1.Select(x => $"[{string.Join(',', x)}]"))); // true

var nums2 = new int[] { 0 };
var output2 = solution.Subsets(nums2);
Console.WriteLine(string.Join(',', output2.Select(x => $"[{string.Join(',', x)}]"))); // true

public class Solution
{
    public IList<IList<int>> Subsets(int[] nums)
    {
        var result = new List<IList<int>>() { new List<int>() };

        foreach (var num in nums)
        {
            foreach (var r in result.ToList())
            {
                var temp = new List<int>(r)
                {
                    num
                };

                result.Add(temp);
            }
        }

        return result;
    }
}

// TODO : backtrack