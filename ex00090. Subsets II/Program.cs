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
        var res = new List<IList<int>>();

        Array.Sort(nums);

        DFS(res, nums, 0, new List<int>());

        return res;
    }

    private void DFS(List<IList<int>> res, int[] nums, int index, List<int> cur)
    {
        res.Add(cur);

        for (int i = index; i < nums.Length; i++)
        {
            if (index != i && nums[i - 1] == nums[i])
            {
                continue;
            }

            cur.Add(nums[i]);

            DFS(res, nums, i + 1, new List<int>(cur));

            cur.RemoveAt(cur.Count - 1);
        }
    }
}