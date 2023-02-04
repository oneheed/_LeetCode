// See https://aka.ms/new-console-template for more information
var solution = new Solution();

var nums1 = new int[] { 10, 1, 2, 7, 6, 1, 5 };
var target1 = 8;
var output1 = solution.CombinationSum2(nums1, target1);
Console.WriteLine(string.Join(',', output1.Select(x => $"[{string.Join(',', x)}]"))); // [[1,1,6],[1,2,5],[1,7],[2,6]]

var nums2 = new int[] { 2, 5, 2, 1, 2 };
var target2 = 5;
var output2 = solution.CombinationSum2(nums2, target2);
Console.WriteLine(string.Join(',', output2.Select(x => $"[{string.Join(',', x)}]"))); // [[1,2,2],[5]]


public class Solution
{
    public IList<IList<int>> CombinationSum2(int[] candidates, int target)
    {
        var res = new List<IList<int>>();
        Array.Sort(candidates);
        //Console.WriteLine(string.Join(",", candidates));
        CombinationSum2(res, candidates, target, new List<int>(), 0);

        return res;
    }

    private void CombinationSum2(IList<IList<int>> res, int[] candidates, int target, List<int> cur, int index)
    {
        //Console.WriteLine(string.Join(",", cur));
        if (target == cur.Sum())
            res.Add(new List<int>(cur));

        for (int i = index; i < candidates.Length && cur.Sum() + candidates[i] <= target; i++)
        {
            if (i != index && candidates[i - 1] == candidates[i])
                continue;

            var c = candidates[i];
            cur.Add(c);
            CombinationSum2(res, candidates, target, cur, i + 1);
            cur.Remove(c);
        }
    }
}

public class Solution1
{
    public IList<IList<int>> CombinationSum2(int[] candidates, int target)
    {
        var res = new List<IList<int>>();
        Array.Sort(candidates);
        //Console.WriteLine(string.Join(",", candidates));
        CombinationSum2(res, candidates, target, new List<int>(), 0);

        return res;
    }

    private void CombinationSum2(IList<IList<int>> res, int[] candidates, int target, List<int> cur, int index)
    {
        //Console.WriteLine(string.Join(",", cur));
        if (target == 0)
            res.Add(new List<int>(cur));

        for (int i = index; i < candidates.Length && target - candidates[i] >= 0; i++)
        {
            if (i != index && candidates[i - 1] == candidates[i])
                continue;

            var c = candidates[i];
            cur.Add(c);
            CombinationSum2(res, candidates, target - c, cur, i + 1);
            cur.Remove(c);
        }
    }
}