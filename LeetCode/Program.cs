using LeetCode;

var res1 = MaxConsecutiveOnes.FindMaxConsecutiveOnes(new[] {1, 1, 0, 1, 1, 1});
Console.WriteLine(res1);

var res2 = FindNumbersWithEvenNumberOfDigits.FindNumbers(new[] {12, 345, 2, 6, 7896});
Console.WriteLine(res2);

var res3 = SquaresOfSortedArray.SortedSquares(new[] {-4, -1, 0, 3, 10});
for (var i = 0; i < res3.Length; i++)
{
    Console.Write($"{res3[i]} ");
}

Console.WriteLine();

var res4 = new[] {1, 0, 2, 3, 0, 4, 5, 0}; 
DuplicateZeros.DoubleZeros(res4);
for (var i = 0; i < res4.Length; i++)
{
    Console.Write($"{res4[i]} ");
}