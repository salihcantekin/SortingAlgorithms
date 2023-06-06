
// 7

using System.Numerics;

var intArr = new[] { 2, 3, 4, 1, 5, 6, 3, 2 };

BucketSort(intArr);

Console.WriteLine(string.Join(",", intArr));


Console.ReadLine();


static void BucketSort(int[] array)
{
    int numberOfBuckets = array.Length;

    // 1. Create empty buckets
    List<List<int>> buckets = new List<List<int>>(numberOfBuckets);
    for (int i = 0; i < numberOfBuckets; i++)
    {
        buckets.Add(new List<int>());
    }

    // 2. Find maximum value to determine the divider
    int maxValue = array.Max();

    // 3. Insert elements into buckets
    for (int i = 0; i < array.Length; i++)
    {
        int bucketKey = (array[i] * numberOfBuckets) / (maxValue + 1);
        buckets[bucketKey].Add(array[i]);
    }

    // 4. Sort each bucket and place back into input array
    int current = 0;
    for (int i = 0; i < buckets.Count; i++)
    {
        List<int> bucket = buckets[i];
        bucket.Sort(); // Use built-in sort or another sorting algorithm here
        for (int j = 0; j < bucket.Count; j++)
        {
            array[current++] = bucket[j];
        }
    }
}


/*
 
Time Complexity:

Best case: O(n+k), when the input is uniformly distributed over the range.
Average case: O(n+k), again with the assumption of uniform distribution.
Worst case: O(n^2), this happens when all elements are put in a single bucket.
Space Complexity:

The space complexity of bucket sort is O(n+k) as we need to create n buckets each containing at most k elements.

The Bucket Sort is useful when input is uniformly distributed over a range and not advisable for smaller lists as its average and worst case complexity is high.

*/