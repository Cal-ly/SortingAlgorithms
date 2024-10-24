namespace SortingAlgorithmsLibrary;
public static class SelectionSort
{
    public static void SelectionSorting(int[] array)
    {
        int n = array.Length;
        for (int i = 0; i < n - 1; i++)
        {
            int minIndex = i;
            for (int j = i + 1; j < n; j++)
            {
                if (array[j] < array[minIndex])
                    minIndex = j;
            }
            (array[i], array[minIndex]) = (array[minIndex], array[i]); // Tuple swap i C# 12
        }
    }
}