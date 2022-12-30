// See https://aka.ms/new-console-template for more information

// why left+(right-left)/2 will not overflow?
var left = int.MaxValue - 1;
var right = int.MaxValue;

Console.WriteLine((left + right) >> 1);

Console.WriteLine(2 >> 1);
Console.WriteLine((left - right) / 2);
Console.WriteLine((left - right) >> 1);
var test1 = -2 >> 1; // 01 >> 1
var test2 = -2 / 2;
var test3 = 0 >> 1;
var test4 = -3 >> 1;
var test5 = -3 / 2;

Console.WriteLine(left - ((left - right) >> 1));
Console.WriteLine((left + right) / 2);
Console.WriteLine(left - (left - right) / 2);


