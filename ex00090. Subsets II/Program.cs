// See https://aka.ms/new-console-template for more information
var solution = new Solution();

var nums1 = new int[] { 1, 2, 2 };
var output1 = solution.SubsetsWithDup(nums1);
Console.WriteLine(string.Join(',', output1.Select(x => $"[{string.Join(',', x)}]"))); // [[],[1],[1,2],[1,2,2],[2],[2,2]]

var nums2 = new int[] { 1, 2, 3 };
var output2 = solution.SubsetsWithDup(nums2);
Console.WriteLine(string.Join(',', output2.Select(x => $"[{string.Join(',', x)}]"))); // [[],[1],[1,2],[1,2,3],[1,3],[2],[2,3],[3]]

public class Solution
{
    public IList<IList<int>> SubsetsWithDup(int[] nums)
    {
        var returnList = new List<IList<int>>() { new List<int>() };
        var list = new List<int>();
        for (int i = 0; i < nums.Length; i++)
        {
            var j = i + 1;
            while (j < nums.Length)
            {
                if (list.Contains(nums[i]))
                {
                    j++;
                    continue;
                }

                list.Add(nums[i]);

                var tempList = new List<int> { nums[i] };
                returnList.Add(new List<int>(tempList));

                for (int k = j; k < nums.Length; k++)
                {
                    tempList.Add(nums[k]);
                    returnList.Add(new List<int>(tempList));
                }
                j++;
            }
        }

        return returnList;
    }
}