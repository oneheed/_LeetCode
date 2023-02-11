// See https://aka.ms/new-console-template for more information
var solution = new Solution();

//var fruits1 = new int[] { 1, 2, 1 };
//var output1 = solution.TotalFruit(fruits1);
//Console.WriteLine(output1.ToString()); // 3

//var fruits2 = new int[] { 0, 1, 2, 2 };
//var output2 = solution.TotalFruit(fruits2);
//Console.WriteLine(output2.ToString()); // 3

//var fruits3 = new int[] { 1, 2, 3, 2, 2 };
//var output3 = solution.TotalFruit(fruits3);
//Console.WriteLine(output3.ToString()); // 4

var fruits4 = new int[] { 3, 3, 3, 1, 2, 1, 1, 2, 3, 3, 4 };
var output4 = solution.TotalFruit(fruits4);
Console.WriteLine(output4.ToString()); // 5


public class Solution
{
    public int TotalFruit(int[] fruits)
    {
        var max = 0;
        var typeCount = 0;

        var counts = new int[fruits.Length];
        var curMax = 0;
        var start = 0;
        foreach (var f in fruits)
        {
            if (counts[f] == 0)
                typeCount++;

            curMax++;
            counts[f]++;

            while (typeCount > 2 && start < fruits.Length)
            {
                counts[fruits[start]]--;
                if (counts[fruits[start]] == 0)
                    typeCount--;

                start++;
                curMax--;
            }

            max = Math.Max(max, curMax);
        }

        return max;
    }
}