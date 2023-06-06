
// 4

var intArr = new[] { 2, 3, 4, 1, 5, 6, 3, 2 };
var strArr = new[] { "b", "z", "j", "a", "k" };

QuickSort(intArr, 0, intArr.Length - 1);
QuickSort(strArr, 0, strArr.Length - 1);

Console.WriteLine(string.Join(",", intArr));
Console.WriteLine(string.Join(",", strArr));


Console.ReadLine();







void QuickSort<T>(T[] array, int low, int high) where T : IComparable
{
    if (low < high)
    {
        int partitionIndex = Partition(array, low, high);

        // Recursively sort elements before and after partition
        QuickSort(array, low, partitionIndex - 1);
        QuickSort(array, partitionIndex + 1, high);
    }
}

int Partition<T>(T[] array, int low, int high) where T : IComparable
{
    // Select the pivot element
    T pivot = array[high];
    int i = (low - 1);

    // Put elements smaller than pivot on the left and greater than pivot on the right of pivot
    for (int j = low; j < high; j++)
    {
        if (array[j].CompareTo(pivot) <= 0)
        {
            i++;

            // Swap elements at i and j
            T temp = array[i];
            array[i] = array[j];
            array[j] = temp;
        }
    }

    // Swap pivot element with element at (i + 1)
    T temp1 = array[i + 1];
    array[i + 1] = array[high];
    array[high] = temp1;

    return i + 1;
}


/*
 
Time Complexity:

Best case: O(n log n), this scenario occurs when the pivot element is always the median of the array. This causes the array to be divided in half at each recursive step.
Average case: O(n log n), due to the divide and conquer nature of quick sort, it performs well on average.
Worst case: O(n^2), this scenario occurs when the pivot element is the smallest or largest element in the array. This causes an imbalance partition of the array.
Space Complexity:

Quick sort is an in-place sorting algorithm, but it needs space for recursion. In the worst case, its space complexity is O(n), and in the best case (balanced partition), it's O(log n).

Please note that the worst-case scenario of QuickSort (n^2 comparisons) can be avoided by using randomized QuickSort or choosing the median element as the pivot.

 */