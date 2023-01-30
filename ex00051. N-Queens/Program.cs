// See https://aka.ms/new-console-template for more information

var solution = new Solution();

var n1 = 4;
var output1 = solution.SolveNQueens(n1);
Console.WriteLine(string.Join(',', output1.Select(x => $"[{string.Join(',', x)}]"))); // [[".Q..","...Q","Q...","..Q."],["..Q.","Q...","...Q",".Q.."]]

var n2 = 1;
var output2 = solution.SolveNQueens(n2);
Console.WriteLine(string.Join(',', output2.Select(x => $"[{string.Join(',', x)}]"))); // [["Q"]]


public class Solution
{
    public IList<IList<string>> SolveNQueens(int n)
    {
        var result = new List<IList<string>>();
        var temp = Enumerable.Repeat(-1, n).ToArray();
        var row = 0;
        for (int i = 0; i < n; i++)
        {
            temp[row] = i;

            Temp(temp, row + 1, n, result);
        }

        return result;
    }

    public void Temp(int[] temp, int row, int n, IList<IList<string>> result)
    {
        if (row == n)
        {

            var sub = new List<string>();
            foreach (var item in temp)
            {
                var text = Enumerable.Repeat('.', n).ToArray();
                text[item] = 'Q';
                sub.Add(new string(text));
            }

            result.Add(sub);

            return;
        }

        var not = Enumerable.Range(0, n).ToList();
        for (int i = 0; i < row; i++)
        {
            var low = temp[i];
            var r = temp[i] + row - i;
            var l = temp[i] - row + i;

            //Console.WriteLine($"{low} {r} {l}");

            not.Remove(low);

            if (r < n)
                not.Remove(r);

            if (l >= 0)
                not.Remove(l);
        }

        if (!not.Any())
        {
            return;
        }


        foreach (var n1 in not)
        {
            temp[row] = n1;
            Temp(temp, row + 1, n, result);
        }
    }
}