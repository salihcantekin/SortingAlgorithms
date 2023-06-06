
// 2

var intArr = new[] { 2, 3, 4, 1, 5, 6, 3, 2 };
var strArr = new[] { "b", "z", "j", "a", "k" };

SelectionSort(intArr);
SelectionSort(strArr);

Console.WriteLine(string.Join(",", intArr));
Console.WriteLine(string.Join(",", strArr));


Console.ReadLine();


void SelectionSort<T>(T[] array)
{
    int length = array.Length;

    for (int i = 0; i < length - 1; i++)
    {
        // Assume the first element is the smallest
        int minIndex = i;

        // Loop through the array starting from 'i + 1'
        for (int j = i + 1; j < length; j++)
        {
            // If we find a smaller number, update 'minIndex'
            if (Comparer<T>.Default.Compare(array[j], array[minIndex]) < 0)
            {
                minIndex = j;
            }
        }

        // After we find the smallest number of the rest array, swap it with the first number
        T temp = array[minIndex];
        array[minIndex] = array[i];
        array[i] = temp;
    }
}




/*
Zaman Karmaşıklığı:

En iyi durum: O(n^2), bu durumda bile her elemanın diğer tüm elemanlarla karşılaştırılması gerekiyor.
Ortalama durum: O(n^2), çünkü her durumda n(n-1)/2 karşılaştırma yapılıyor.
En kötü durum: O(n^2), burada da her elemanın diğer tüm elemanlarla karşılaştırılması gerekiyor.

Boşluk Karmaşıklığı: O(1)

 */