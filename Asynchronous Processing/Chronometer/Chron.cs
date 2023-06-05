using System.Diagnostics;

namespace Chronometer;
public class Chron : IChronometer
{
    private Stopwatch _stopwatch;
    private List<string> _laps;

    public Chron()
    {
            this._stopwatch = new Stopwatch();
            this._laps = new List<string>();
    }

    public string GetTime => _stopwatch.Elapsed.ToString(@"mm\:ss\.ffff");
    public List<string> Laps => this._laps;

    public void Start()
    {
        _stopwatch.Start();
    }

    public void Stop()
    {
        _stopwatch.Stop();

    }

    public string Lap()
    {
        string resuslt = GetTime;
        _laps.Add(resuslt);
        return resuslt;
    }

    public void Reset()
    {
        _stopwatch.Reset();
        _laps.Clear();
    }
}
