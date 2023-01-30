// See https://aka.ms/new-console-template for more information
var solution = new Solution();

var nums1 = new int[] { 2, 3, 6, 7 };
var target1 = 7;
var output1 = solution.CombinationSum(nums1, target1);
Console.WriteLine(string.Join(',', output1.Select(x => $"[{string.Join(',', x)}]"))); // [[2,2,3],[7]]

var nums2 = new int[] { 2, 3, 5 };
var target2 = 8;
var output2 = solution.CombinationSum(nums2, target2);
Console.WriteLine(string.Join(',', output2.Select(x => $"[{string.Join(',', x)}]"))); // [[2,2,2,2],[2,3,3],[3,5]]


public class Solution
{
    public IList<IList<int>> CombinationSum(int[] candidates, int target)
    {
        var result = new List<IList<int>>();
        Array.Sort(candidates);

        CombinationSum(result, candidates, target, new List<int>());

        return result;
    }

    public void CombinationSum(List<IList<int>> result, int[] candidates, int target, List<int> nums)
    {
        if (nums.Sum() == target)
        {
            result.Add(nums.ToList());
            return;
        }
        else if (nums.Sum() > target)
        {
            return;
        }

        for (int i = 0; i < candidates.Length; i++)
        {
            var c = candidates[i];
            nums.Add(c);
            CombinationSum(result, candidates.Skip(i).ToArray(), target, nums);
            nums.Remove(c);
        }
    }
}