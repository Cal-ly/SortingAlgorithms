namespace SortingAlgorithmsLibrary;
public class MyStopwatch
{
    private readonly System.Diagnostics.Stopwatch _stopwatch;

    public MyStopwatch()
    {
        _stopwatch = new System.Diagnostics.Stopwatch();
    }

    public void Start()
    {
        _stopwatch.Start();
    }

    public void Stop()
    {
        _stopwatch.Stop();
    }

    public void Reset()
    {
        _stopwatch.Reset();
    }

    public TimeSpan ElapsedTime => _stopwatch.Elapsed;
}