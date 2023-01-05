// See https://aka.ms/new-console-template for more information
var solution = new Solution1();

var tasks1 = new int[] { 2, 2, 3, 3, 2, 4, 4, 4, 4, 4 };
var output1 = solution.MinimumRounds(tasks1);
Console.WriteLine(output1.ToString()); // 4

var tasks2 = new int[] { 2, 3, 3 };
var output2 = solution.MinimumRounds(tasks2);
Console.WriteLine(output2.ToString()); // -1

var tasks3 = new int[] { 5, 5, 5, 5 };
var output3 = solution.MinimumRounds(tasks3);
Console.WriteLine(output3.ToString()); // 2

var tasks4 = new int[] { 69, 65, 62, 64, 70, 68, 69, 67, 60, 65, 69, 62, 65, 65, 61, 66, 68, 61, 65, 63, 60, 66, 68, 66, 67, 65, 63, 65, 70, 69, 70, 62, 68, 70, 60, 68, 65, 61, 64, 65, 63, 62, 62, 62, 67, 62, 62, 61, 66, 69 };
var output4 = solution.MinimumRounds(tasks4);
Console.WriteLine(output4.ToString()); // 20

var tasks5 = new int[] { 66, 66, 63, 61, 63, 63, 64, 66, 66, 65, 66, 65, 61, 67, 68, 66, 62, 67, 61, 64, 66, 60, 69, 66, 65, 68, 63, 60, 67, 62, 68, 60, 66, 64, 60, 60, 60, 62, 66, 64, 63, 65, 60, 69, 63, 68, 68, 69, 68, 61 };
var output5 = solution.MinimumRounds(tasks5);
Console.WriteLine(output5.ToString()); // 20

var tasks6 = new int[] { 119, 115, 115, 119, 118, 113, 118, 120, 110, 113, 119, 115, 116, 118, 120, 117, 116, 111, 113, 119, 115, 113, 115, 111, 112, 119, 111, 111, 110, 112, 113, 120, 110, 111, 112, 111, 119, 112, 113, 112, 115, 116, 113, 114, 118, 119, 115, 114, 114, 112, 110, 117, 120, 110, 117, 116, 120, 118, 110, 120, 119, 113, 119, 120, 113, 110, 120, 114, 119, 115, 119, 117, 120, 116, 113, 113, 110, 118, 117, 116, 114, 114, 111, 116, 119, 112, 113, 116, 112, 116, 119, 112, 114, 114, 112, 118, 116, 113, 117, 116 };
var output6 = solution.MinimumRounds(tasks6);
Console.WriteLine(output6.ToString()); // 38

public class Solution
{
    public int MinimumRounds(int[] tasks)
    {
        var taskCounts = tasks.GroupBy(t => t).ToDictionary(x => x.Key, x => x.Count());
        var result = 0;

        foreach (var taskCount in taskCounts)
        {
            if (taskCount.Value < 2)
            {
                return -1;
            }
            else if (taskCount.Value % 3 == 0)
            {
                var round = taskCount.Value / 3;
                result += round;
            }
            else if (taskCount.Value % 3 == 1)
            {
                // 4 => 2 2
                // 7 => 3 2 2
                var round = (taskCount.Value - 4) / 3 + 2;
                result += round;
            }
            else if (taskCount.Value % 3 == 2)
            {
                // 5 => 3 2
                var round = (taskCount.Value - 2) / 3 + 1;
                result += round;
            }
            //else if (taskCount.Value % 2 == 0)
            //{
            //    var round = taskCount.Value / 2;
            //    result += round;
            //}
        }

        return result;
    }
}

public class Solution1
{
    public int MinimumRounds(int[] tasks)
    {
        var map = tasks.GroupBy(t => t).ToDictionary(x => x.Key, x => x.Count());
        var count = 0;

        foreach (var key in map.Keys)
        {
            var freq = map[key];
            if (freq == 1)
                return -1;

            count += freq / 3;
            if (freq % 3 != 0)
                count++;

        }

        return count;
    }
}