// See https://aka.ms/new-console-template for more information

var solution = new Solution();

var grid1 = new int[][] { new[] { 1, 0, 1 }, new[] { 0, 0, 0 }, new[] { 1, 0, 1 } };
var output1 = solution.MaxDistance(grid1);
Console.WriteLine(output1.ToString()); // 2

public class Solution
{
    public int MaxDistance(int[][] grid)
    {
        var queue = new Queue<(int x, int y)>();
        var n = grid.Length;

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (grid[i][j] == 1)
                {
                    queue.Enqueue((i, j));
                }
            }
        }

        if (!queue.Any() || queue.Count == n * n)
            return -1;

        var dir = new int[][] { new[] { 0, -1 }, new[] { 0, 1 }, new[] { -1, 0 }, new[] { 1, 0 } };
        var dis = -1;
        while (queue.Count > 0)
        {
            var count = queue.Count;
            for (int i = 0; i < count; i++)
            {
                var loc = queue.Dequeue();

                for (int j = 0; j < dir.Length; j++)
                {
                    var x = loc.x + dir[j][0];
                    var y = loc.y + dir[j][1];
                    if (x >= 0 && x < n &&
                        y >= 0 && y < n &&
                        grid[x][y] == 0)
                    {
                        grid[x][y] = 1;
                        queue.Enqueue((x, y));
                    }
                }
            }

            dis++;
        }

        return dis;
    }
}