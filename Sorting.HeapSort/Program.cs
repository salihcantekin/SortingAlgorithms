
// 6

var intArr = new[] { 4, 1, 7, 64, 02, 62, 144 };
var strArr = new[] { "b", "z", "j", "a", "k" };

HeapSort(intArr);
HeapSort(strArr);


Console.WriteLine(string.Join(",", intArr));
Console.WriteLine(string.Join(",", strArr));


Console.ReadLine();


void HeapSort<T>(T[] array) where T : IComparable<T>
{
    int length = array.Length;

    // Build heap
    for (int i = length / 2 - 1; i >= 0; i--)
        Heapify(array, length, i);

    // One by one extract an element from heap
    for (int i = length - 1; i >= 0; i--)
    {
        // Swap
        (array[i], array[0]) = (array[0], array[i]);

        // Heapify root element
        Heapify(array, i, 0);
    }
}
 
void Heapify<T>(T[] array, int length, int i) where T : IComparable<T>
{
    int largest = i; // Initialize largest as root
    int left = 2 * i + 1;
    int right = 2 * i + 2;

    // If left child is larger than root
    if (left < length && array[left].CompareTo(array[largest]) > 0)
        largest = left;

    // If right child is larger than largest so far
    if (right < length && array[right].CompareTo(array[largest]) > 0)
        largest = right;

    // If largest is not root
    if (largest != i)
    {
        // Swap
        (array[largest], array[i]) = (array[i], array[largest]);

        // Recursively heapify the affected sub-tree
        Heapify(array, length, largest);
    }
}

/*
Time Complexity:

Best case: O(n log n), it takes logarithmic time for heapify operation.
Average case: O(n log n), same as the best case.
Worst case: O(n log n), again the same as the best case.

Space Complexity:

Heap sort is an in-place sorting algorithm. It requires a constant amount of space for sorting a list. So, the space complexity of Heap sort is O(1).

Heap Sort is not a stable sort, and requires a bit more comparison and swap operations than QuickSort, that's why it is not used often in practice. However, it's guaranteed to run in O(n log n), which is an advantage over QuickSort which can degrade to O(n^2).
 */