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

Console.WriteLine();

// var res5 = new[] {2, 0};
// MergeSortedArray.Merge(res5, 1, new[] {1}, 1);
// var res5 = new[] {1, 2, 3, 0, 0, 0};
// MergeSortedArray.Merge(res5, 3, new[] {2, 5, 6}, 3);
// var res5 = new[] {0};
// MergeSortedArray.Merge(res5, 0, new[] {1}, 1);
var res5 = new[] {4, 0, 0, 0, 0, 0};
MergeSortedArray.Merge(res5, 1, new[] {1, 2, 3, 5, 6}, 5);
// var res5 = new[] {0, 0, 0, 0, 0};
// MergeSortedArray.Merge(res5, 0, new[] {1, 2, 3, 4, 5}, 5);

for (var i = 0; i < res5.Length; i++)
{
    Console.Write($"{res5[i]} ");
}