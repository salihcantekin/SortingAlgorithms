
// 3

var intArr = new[] { 2, 3, 4, 1, 5, 6, 3, 2 };
var strArr = new[] { "b", "z", "j", "a", "k" };

InsertionSort(intArr);
InsertionSort(strArr);

Console.WriteLine(string.Join(",", intArr));
Console.WriteLine(string.Join(",", strArr));


Console.ReadLine();

void InsertionSort<T>(T[] array)
{
    int length = array.Length;

    for (int i = 1; i < length; i++)
    {
        T key = array[i]; // The element to be compared
        int j = i - 1;

        /* Move elements of array[0..i-1], that are greater than key,
           to one position ahead of their current position */
        while (j >= 0 && Comparer<T>.Default.Compare(array[j], key) > 0)
        {
            array[j + 1] = array[j];
            j--;
        }

        array[j + 1] = key;
    }
}


/*
 Time Complexity:

Best case: O(n), this scenario occurs when the input array is already sorted. In this case, no swapping is needed.
Average case: O(n^2), as there are two nested loops.
Worst case: O(n^2), this scenario occurs when the input array is sorted in reverse order. In this case, every insertion is at the front of the array.
Space Complexity:

Insertion sort is an in-place sorting algorithm, which means it does not require any extra space and produces an output by making changes to the input array. Thus, the space complexity is O(1).

Note that while Insertion Sort is adaptive and stable, it is not suitable for large data sets due to its O(n^2) time complexity. However, it works well for smaller data sets and almost sorted arrays, and it's often used for teaching purposes due to its simplicity.
 */