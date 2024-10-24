namespace SortingAlgorithmsLibrary;

public static class BubbleSort
{
    public static void BubbleSorting(int[] array)
    {
        int n = array.Length;
        bool swapped;
        for (int i = 0; i < n - 1; i++)
        {
            swapped = false;
            for (int j = 0; j < n - i - 1; j++)
            {
                if (array[j] > array[j + 1])
                {
                    (array[j], array[j + 1]) = (array[j + 1], array[j]); // Tuple swap i C# 12
                    swapped = true;
                }
            }
            if (!swapped) break;
        }
    }
}
