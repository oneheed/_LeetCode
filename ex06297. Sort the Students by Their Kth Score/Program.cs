// See https://aka.ms/new-console-template for more information
var solution = new Solution();

//var score1 = new int[][] { new int[] { 10, 6, 9, 1 }, new int[] { 7, 5, 11, 2 }, new int[] { 4, 8, 3, 15 } };
//var k1 = 2;
//var output1 = solution.SortTheStudents(score1, k1);
////Console.WriteLine(string.Join(",", output1)); // 50

var score2 = new int[][] {
    new int[] { 64766, 11978, 20502, 21365, 79611, 36797, 58431, 89540, 59373, 25955 },
    new int[] { 51305, 66104, 88468, 5333, 17233, 32521, 14087, 42738, 46669, 65662 },
    new int[] { 93306, 92793, 54009, 9715, 24354, 24895, 20069, 93332, 73836, 64359 },
    new int[] { 23358, 84599, 4675, 20979, 76889, 34630, 64098, 23468, 71448, 17848 } };
var k2 = 5;
var output21 = solution.SortTheStudents(score2, k2);
//Console.WriteLine(string.Join(",", output1)); // 50


public class Solution
{
    public int[][] SortTheStudents(int[][] score, int k)
    {
        if (score == null)
            return null;

        var row = score.Length;

        for (int i = 0; i < row; i++)
        {
            for (int j = i + 1; j < row; j++)
            {
                if (score[i][k] < score[j][k])
                {
                    var temp = score[i];
                    score[i] = score[j];
                    score[j] = temp;
                }
            }
        }

        return score;
    }
}