// See https://aka.ms/new-console-template for more information

var solution = new Solution();

//var n1 = 5;
//var input1 = new List<IList<int>> { new List<int> { 1, 2 }, new List<int> { 2, 3 }, new List<int> { 3, 4 }, new List<int> { 4, 2 }, new List<int> { 1, 4 }, new List<int> { 2, 5 } };
//var output1 = solution.IsPossible(n1, input1);
//Console.WriteLine(output1.ToString()); // true

//var n2 = 4;
//var input2 = new List<IList<int>> { new List<int> { 1, 2 }, new List<int> { 3, 4 } };
//var output2 = solution.IsPossible(n2, input2);
//Console.WriteLine(output2.ToString()); // true

//var n3 = 4;
//var input3 = new List<IList<int>> { new List<int> { 1, 2 }, new List<int> { 1, 3 }, new List<int> { 1, 4 } };
//var output3 = solution.IsPossible(n3, input3);
//Console.WriteLine(output3.ToString()); // false

//var n4 = 4;
//var input4 = new List<IList<int>> { new List<int> { 4, 1 }, new List<int> { 3, 2 }, new List<int> { 2, 4 }, new List<int> { 1, 3 } };
//var output4 = solution.IsPossible(n4, input4);
//Console.WriteLine(output4.ToString()); // true

//var n5 = 4;
//var input5 = new List<IList<int>> { new List<int> { 1, 2 }, new List<int> { 2, 3 }, new List<int> { 3, 4 }, new List<int> { 4, 1 }, new List<int> { 1, 3 } };
//var output5 = solution.IsPossible(n5, input5);
//Console.WriteLine(output5.ToString()); // false

var n6 = 11;
var input6 = new List<IList<int>> { new List<int> { 5, 9 }, new List<int> { 8, 1 }, new List<int> { 2, 3 }, new List<int> { 7, 10 }, new List<int> { 3, 6 }, new List<int> { 6, 7 }, new List<int> { 7, 8 }, new List<int> { 5, 1 }, new List<int> { 5, 7 }, new List<int> { 10, 11 }, new List<int> { 3, 7 }, new List<int> { 6, 11 }, new List<int> { 8, 11 }, new List<int> { 3, 4 }, new List<int> { 8, 9 }, new List<int> { 9, 1 }, new List<int> { 2, 10 }, new List<int> { 9, 11 }, new List<int> { 5, 11 }, new List<int> { 2, 5 }, new List<int> { 8, 10 }, new List<int> { 2, 7 }, new List<int> { 4, 1 }, new List<int> { 3, 10 }, new List<int> { 6, 1 }, new List<int> { 4, 9 }, new List<int> { 4, 6 }, new List<int> { 4, 5 }, new List<int> { 2, 4 }, new List<int> { 2, 11 }, new List<int> { 5, 8 }, new List<int> { 6, 9 }, new List<int> { 4, 10 }, new List<int> { 3, 11 }, new List<int> { 4, 7 }, new List<int> { 3, 5 }, new List<int> { 7, 1 }, new List<int> { 2, 9 }, new List<int> { 6, 10 }, new List<int> { 10, 1 }, new List<int> { 5, 6 }, new List<int> { 3, 9 }, new List<int> { 2, 6 }, new List<int> { 7, 9 }, new List<int> { 4, 11 }, new List<int> { 4, 8 }, new List<int> { 6, 8 }, new List<int> { 3, 8 }, new List<int> { 9, 10 }, new List<int> { 5, 10 }, new List<int> { 2, 8 }, new List<int> { 7, 11 } };
var output6 = solution.IsPossible(n6, input6);
Console.WriteLine(output6.ToString()); // false


public class Solution
{
    public bool IsPossible(int n, IList<IList<int>> edges)
    {
        var result = Enumerable.Range(1, n).ToDictionary(x => x, x =>
        {
            var result = Enumerable.Range(1, n).ToList();
            result.Remove(x);

            return result;
        });

        foreach (var edge in edges)
        {
            result[edge[0]].Remove(edge[1]);
            result[edge[1]].Remove(edge[0]);
        }

        //if (n % 2 == 0 && result.Any(x => x.Value == n - 1))
        //return false;

        //if (!result.Any(x => x.Value % 2 == 1))
        //{
        //    return true;
        //}

        //for (int i = 0; i < 2; i++)
        //{
        //    var temp = result.Where(x => x.Value < n - 1 && x.Value % 2 == 1).OrderBy(x => x.Value).ToList();

        //    result[temp[0].Key]++;
        //    result[temp[1].Key]++;

        //    if (!result.Any(x => x.Value % 2 == 1))
        //    {
        //        return true;
        //    }
        //}

        return false;
    }
}



public class TestClass1
{
    private readonly int _test1;

    public int Test1 { get { return _test1; } }

    public TestClass1()
    {
        _test1 = 1;
    }
}

public class TestClass2
{
    public int Test1 { get; }

    public TestClass2()
    {
        Test1 = 1;
    }
}