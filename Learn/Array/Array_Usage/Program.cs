// See https://aka.ms/new-console-template for more information

// 1. Initialize
var a0 = new int[5];
var a1 = new int[] { 1, 2, 3 };

// 2. Get Length
Console.WriteLine($"The size of a1 is: {a1.Length}");

// 3. Access Element
Console.WriteLine($"The first element is: {a1[0]}");

// 4. Iterate all Elements
Console.Write("[Version 1] The contents of a1 are: ");
for (int i = 0; i < a1.Length; ++i)
{
    Console.Write(" " + a1[i]);
}
Console.WriteLine();

Console.Write("[Version 2] The contents of a1 are:");
foreach (int item in a1)
{
    Console.Write(" " + item);
}
Console.WriteLine();

// 5. Modify Element
a1[0] = 4;

// 6. Sort
Array.Sort(a1);

Console.WriteLine($"[Version 3] The contents of a1 are: {string.Join(" ", a1)}");