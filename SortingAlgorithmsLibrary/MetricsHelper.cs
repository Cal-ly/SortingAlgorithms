namespace SortingAlgorithmsLibrary;
public class MetricsHelper
{
    private int _operationCount;
    public int OperationCount => _operationCount;

    public MetricsHelper()
    {
        _operationCount = 0;
    }

    public void IncrementOperationCount()
    {
        _operationCount++;
    }

    public void Reset()
    {
        _operationCount = 0;
    }

}