
// 1

var intArr = new[] { 2, 3, 4, 1, 5, 6, 7, 2 };
var strArr = new[] { "b", "z", "j", "a", "k" };

BubbleSort(intArr);
BubbleSort(strArr);

Console.WriteLine(string.Join(",", intArr));
Console.WriteLine(string.Join(",", strArr));


Console.ReadLine();


// Time Complexity: O(n^2)
// Space Complexity: O(1)


void BubbleSort<T>(T[] array) where T : IComparable
{
    int length = array.Length; // Get the length of the array

    for (int i = 0; i < length; i++) // Loop for each element of the array
    {
        for (int j = 0; j < length - 1 - i; j++) // Another loop to compare each element with the rest of the array
        {
            if (array[j].CompareTo(array[j + 1]) > 0)
            {
                // Swap array[j] and array[j+1] if array[j] is greater than array[j+1]

                // (array[j + 1], array[j]) = (array[j], array[j + 1]);
                var temp = array[j];
                array[j] = array[j + 1];
                array[j + 1] = temp;
            }
            //if (Comparer<T>.Default.Compare(array[j], array[j + 1]) > 0)
            //{
                
            //}
        }
    }
}