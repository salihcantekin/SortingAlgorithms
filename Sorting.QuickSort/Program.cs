
// 4 -> Quick Sort

int[] intArray = new[] { 9, 2, 6, 2, 7, 0 };
string[] strArray = new[] {"a", "z", "b", "x", "y" };

QuickSortLomuto(intArray, 0, intArray.Length - 1);
QuickSortLomuto(strArray, 0, strArray.Length - 1);

Console.WriteLine(string.Join(',', intArray));
Console.WriteLine(string.Join(',', strArray));

Console.ReadLine();

void QuickSortLomuto<T>(T[] array, int low, int high)
    where T : IComparable
{
    if (low < high)
    {
        var partitionIndex = PartitionLomuto(array, low, high);

        QuickSortLomuto(array, low, partitionIndex - 1);
        QuickSortLomuto(array, partitionIndex + 1, high);
    }
}

int PartitionLomuto<T>(T[] array, int low, int high)
    where T : IComparable
{
    var pivot = array[high];
    int i = low - 1;

    for(int j = low; j < high; j++) 
    {
        if (array[j].CompareTo(pivot) < 0)
        {
            i++;
            Swap(array, i, j);
        }
    }

    Swap(array, i + 1, high);

    return i + 1;
}




void QuickSortHoare<T>(T[] array, int low, int high)
    where T : IComparable
{
    if (low < high)
    {
        var partitionIndex = PartitionHoare(array, low, high);

        QuickSortHoare(array, low, partitionIndex);
        QuickSortHoare(array, partitionIndex + 1, high);
    }
}

int PartitionHoare<T>(T[] array, int low, int high)
    where T: IComparable
{
    var pivot = array[low];
    int i = low - 1, j = high + 1;

    while(true)
    {
        do
        {
            i++;
        } while (array[i].CompareTo(pivot) < 0);

        do
        {
            j--;
        } while (array[j].CompareTo(pivot) > 0);

        if (i >= j)
            return j;

        Swap(array, i, j);
    }
}
void Swap<T>(T[] array, int i, int j)
{
    (array[i], array[j]) = (array[j], array[i]);
}