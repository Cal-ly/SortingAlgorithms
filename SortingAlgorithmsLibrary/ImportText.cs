namespace SortingAlgorithmsLibrary;
public class ImportText
{
    public int[] ImportAndPrune(string filePath)
    {
        // Read all lines from the file
        var lines = File.ReadAllLines(filePath);

        // Extract numbers and convert them to an array of integers
        var numbers = lines
            .SelectMany(line => line.Split(' ', ',', ';', '\t'))
            .Where(part => int.TryParse(part, out _))
            .Select(int.Parse)
            .ToArray();

        return numbers;
    }
}
