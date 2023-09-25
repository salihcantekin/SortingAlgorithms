
// Sıralama Algoritmaları - Bubble Sort (Baloncuk Sıralaması)

int[] numbers = { 5, 2, 7, 9, 1, 0, 6, 3, 4, 10 };
string[] names = { "Ali", "Veli", "Ayşe", "Fatma" };

BubbleSort(numbers);
BubbleSort(names);

Console.WriteLine(string.Join(',', numbers));
Console.WriteLine(string.Join(',', names));

Console.ReadLine();

// Space Complexity : O (1)
// Time Complexity :  O (n^2)


void BubbleSort<T>(T[] array) where T: IComparable
{
    for (int i = 0; i < array.Length; i++)
    {
        for (int j = 0; j < array.Length - i - 1; j++)
        {
            if (array[j].CompareTo(array[j + 1]) > 0)
            {
                var temp = array[j];
                array[j] = array[j + 1];
                array[j + 1] = temp;

                //(array[j], array[j + 1]) = (array[j + 1], array[j]);
            }
        }
    }
}