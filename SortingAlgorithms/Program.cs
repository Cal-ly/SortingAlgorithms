using SortingAlgorithms;
using SortingAlgorithmsLibrary;

while (true)
{
    // Step 1: List .txt files in the Numbers folder
    var numbersFolder = @"C:\Users\Cal-l\Documents\GitHub\SortingAlgorithms\SortingAlgorithms\Numbers\";
    var txtFiles = Directory.GetFiles(numbersFolder, "*.txt");

    if (txtFiles.Length == 0)
    {
        Console.WriteLine("No .txt files found in the Numbers folder.");
        return;
    }

    int fileIndex; // Initialize fileIndex
    fileIndex = UserInterface.GetFileIndex(txtFiles);
    var selectedFile = txtFiles[fileIndex];

    // Step 2: Provide sorting algorithm options
    int algorithmIndex = UserInterface.GetAlgorithmIndex();

    // Step 3: Ask if the user wants to measure time and metrics
    bool measureTime = UserInterface.GetYesNoInput("Would you like to measure time? (y/n)");
    bool measureMetrics = UserInterface.GetYesNoInput("Would you like to measure metrics? (y/n)");

    // Initialize stopwatch and metrics if needed
    MyStopwatch? stopwatch = measureTime ? new MyStopwatch() : null;
    MetricsHelper? metrics = measureMetrics ? new MetricsHelper() : null;

    // Read numbers from the selected file
    var numbers = File.ReadAllLines(selectedFile).Select(int.Parse).ToArray();

    // Start stopwatch if needed
    stopwatch?.Start();

    // Perform sorting based on the selected algorithm
    switch (algorithmIndex)
    {
        case 1:
            BubbleSort.BubbleSorting(numbers);
            break;
        case 2:
            InsertionSort.InsertionSorting(numbers);
            break;
        case 3:
            QuickSort.QuickSorting(numbers);
            break;
        case 4:
            SelectionSort.SelectionSorting(numbers);
            break;
        case 5:
            ShellSort.ShellSorting(numbers);
            break;
        case 6:
            MergeSort.MergeSorting(numbers);
            break;
        case 0:
            Environment.Exit(0);
            break;
        default:
            Console.WriteLine("Invalid algorithm index.");
            break;
    }

    // Stop stopwatch if needed
    stopwatch?.Stop();

    // Display results
    if (measureTime)
        Console.WriteLine($"Elapsed Time: {stopwatch?.ElapsedTime}");

    if (measureMetrics)
        Console.WriteLine($"Operation Count: {metrics?.OperationCount}");
}