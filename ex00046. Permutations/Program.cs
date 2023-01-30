// See https://aka.ms/new-console-template for more information
var solution = new Solution();

var nums1 = new int[] { 1, 2, 3 };
var output1 = solution.Permute(nums1);
Console.WriteLine(string.Join(',', output1.Select(x => $"[{string.Join(',', x)}]"))); // [[1,2,3],[1,3,2],[2,1,3],[2,3,1],[3,1,2],[3,2,1]]


public class Solution
{
    IList<IList<int>> result = new List<IList<int>>();

    public IList<IList<int>> Permute(int[] nums)
    {
        foreach (var num in nums)
        {
            var remove = nums.ToList();
            remove.Remove(num);
            var t = new List<int>() { num };
            Temp(t, remove.ToArray());
        }


        return result;
    }


    private void Temp(List<int> result, int[] nums)
    {
        if (nums.Any())
        {
            foreach (var num in nums)
            {
                var remove = nums.ToList();
                remove.Remove(num);

                result.Add(num);

                Temp(result, remove.ToArray());

                result.Remove(num);
            }
        }
        else
        {
            this.result.Add(result.ToList());
        }
    }
}

//　TODO 優化