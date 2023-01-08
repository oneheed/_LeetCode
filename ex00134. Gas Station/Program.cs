// See https://aka.ms/new-console-template for more information
var solution = new Solution();

var gas1 = new int[] { 1, 2, 3, 4, 5 };
var cost1 = new int[] { 3, 4, 5, 1, 2 };
var output1 = solution.CanCompleteCircuit(gas1, cost1);
Console.WriteLine(output1); // 3

var gas2 = new int[] { 2, 3, 4 };
var cost2 = new int[] { 3, 4, 3 };
var output2 = solution.CanCompleteCircuit(gas2, cost2);
Console.WriteLine(output2); // -1

var gas3 = new int[] { 5, 1, 2, 3, 4 };
var cost3 = new int[] { 4, 4, 1, 5, 1 };
var output3 = solution.CanCompleteCircuit(gas3, cost3);
Console.WriteLine(output3); // 4

var gas4 = new int[] { 5, 8, 2, 8 };
var cost4 = new int[] { 6, 5, 6, 6 };
var output4 = solution.CanCompleteCircuit(gas4, cost4);
Console.WriteLine(output4); // 3

var gas5 = new int[] { 3, 1, 1 };
var cost5 = new int[] { 1, 2, 2 };
var output5 = solution.CanCompleteCircuit(gas5, cost5);
Console.WriteLine(output5); // 0

var gas6 = new int[] { 7, 1, 0, 11, 4 };
var cost6 = new int[] { 5, 9, 1, 2, 5 };
var output6 = solution.CanCompleteCircuit(gas6, cost6);
Console.WriteLine(output6); // 3


public class Solution
{
    public int CanCompleteCircuit(int[] gas, int[] cost)
    {
        var result = 0;
        var sum = 0;
        var thank = 0;

        for (int i = 0; i < gas.Length; i++)
        {
            var diff = gas[i] - cost[i];
            sum += diff;
            thank += diff;
            Console.WriteLine($"{gas[i]} - {cost[i]} = {diff} {thank}");

            if (thank < 0)
            {
                result = (i + 1) % gas.Length;
                thank = 0;
            }
        }

        return sum >= 0 ? result : -1;
    }
}