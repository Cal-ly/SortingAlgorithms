namespace SortingAlgorithmsLibrary;
public static class QuickSort
{
    public static void QuickSorting(int[] array)
    {
        QuickSorting(array, 0, array.Length - 1);
    }

    private static void QuickSorting(int[] array, int low, int high)
    {
        if (low < high)
        {
            int pivotIndex = Partition(array, low, high);
            QuickSorting(array, low, pivotIndex - 1);
            QuickSorting(array, pivotIndex + 1, high);
        }
    }

    private static int Partition(int[] array, int low, int high)
    {
        int pivot = array[high];
        int i = low - 1;
        for (int j = low; j < high; j++)
        {
            if (array[j] < pivot)
            {
                i++;
                (array[i], array[j]) = (array[j], array[i]); // Tuple swap in C# 12
            }
        }
        (array[i + 1], array[high]) = (array[high], array[i + 1]);
        return i + 1;
    }
}