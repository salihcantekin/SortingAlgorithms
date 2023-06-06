
// 5

var intArr = new[] { 2, 3, 4, 1, 5, 6, 3, 2 };
var strArr = new[] { "b", "z", "j", "a", "k" };

MergeSort(intArr, 0, intArr.Length - 1);
MergeSort(strArr, 0, strArr.Length - 1);

Console.WriteLine(string.Join(",", intArr));
Console.WriteLine(string.Join(",", strArr));


Console.ReadLine();



void MergeSort<T>(T[] array, int left, int right) where T : IComparable<T>
{
    if (left < right)
    {
        // Find the middle point
        int middle = left + (right - left) / 2;

        // Sort first and second halves
        MergeSort(array, left, middle);
        MergeSort(array, middle + 1, right);

        // Merge the sorted halves
        Merge(array, left, middle, right);
    }
}

void Merge<T>(T[] array, int left, int middle, int right) where T : IComparable<T>
{
    int n1 = middle - left + 1;
    int n2 = right - middle;

    // Create temp arrays
    T[] leftArray = new T[n1];
    T[] rightArray = new T[n2];

    // Copy data to temp arrays
    Array.Copy(array, left, leftArray, 0, n1);
    Array.Copy(array, middle + 1, rightArray, 0, n2);

    // Merge the temp arrays
    int leftIndex = 0, rightIndex = 0;

    // Initial index of merged subarray
    int k = left;
    while (leftIndex < n1 && rightIndex < n2)
    {
        if (leftArray[leftIndex].CompareTo(rightArray[rightIndex]) <= 0)
        {
            array[k] = leftArray[leftIndex];
            leftIndex++;
        }
        else
        {
            array[k] = rightArray[rightIndex];
            rightIndex++;
        }
        k++;
    }

    // Copy remaining elements of leftArray if any
    while (leftIndex < n1)
    {
        array[k] = leftArray[leftIndex];
        leftIndex++;
        k++;
    }

    // Copy remaining elements of rightArray if any
    while (rightIndex < n2)
    {
        array[k] = rightArray[rightIndex];
        rightIndex++;
        k++;
    }
}





/*
Time Complexity:

Best case: O(n log n), MergeSort is always guaranteed to be n log n, and this is also the best case.
Average case: O(n log n), even on average, MergeSort performs well due to the divide and conquer approach it follows.
Worst case: O(n log n), MergeSort always performs stably at O(n log n), regardless of the initial order of the input.

Space Complexity:

Merge sort is not an in-place sorting algorithm. Its space complexity is O(n) because an auxiliary array of size n is needed for the temporary storage of the sorted elements. So while MergeSort is an efficient algorithm with respect to time complexity, it may not be suitable for situations where memory space is a critical factor.
 */