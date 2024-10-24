namespace SortingAlgorithms;
public static class UserInterface
{
    public static int GetFileIndex(string[] txtFiles)
    {
        int fileIndex = -1;
        Console.WriteLine("Select a .txt file:");
        for (int i = 0; i < txtFiles.Length; i++)
        {
            Console.WriteLine($"{i + 1}. {Path.GetFileName(txtFiles[i])}");
        }

        string? input = Console.ReadLine();
        if (string.IsNullOrEmpty(input) || !int.TryParse(input, out fileIndex) || fileIndex < 1 || fileIndex > txtFiles.Length)
        {
            Console.WriteLine("Invalid input. Please enter a valid number corresponding to a file.");
            Environment.Exit(0);
        }
        return fileIndex - 1;
    }

    public static int GetAlgorithmIndex()
    {
        int algorithmIndex = -1;
        Console.WriteLine("Select a sorting algorithm:");
        Console.WriteLine("1. Bubble Sort");
        Console.WriteLine("2. Insertion Sort");
        Console.WriteLine("3. Quick Sort");
        Console.WriteLine("4. Selection Sort");
        Console.WriteLine("5. Shell Sort");
        Console.WriteLine("6. Merge Sort");
        Console.WriteLine("0. Exit");

        string? input = Console.ReadLine();
        if (string.IsNullOrEmpty(input) || !int.TryParse(input, out algorithmIndex) || algorithmIndex < 1 || algorithmIndex > 5)
        {
            Console.WriteLine("Invalid input. Please enter a valid number corresponding to an algorithm.");
            Environment.Exit(0);
        }
        return algorithmIndex;
    }

    public static bool GetYesNoInput(string message)
    {
        Console.WriteLine(message);
        string? input = Console.ReadLine();
        return input?.ToLower() == "y";
    }
}
