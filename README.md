This is a Unity package for reading Moonscraper charts. None of this code is new - it was simply just carved out of the [Moonscraper codebase](https://github.com/FireFox2000000/Moonscraper-Chart-Editor/) and put together here as a Unity package.

## Example usage

```csharp
var fname = "C:\\notes.chart";
var song = ChartReader.ReadChart(fname);
            
var chart = song.GetChart(
    Song.Instrument.Guitar,
    Song.Difficulty.Expert);

Debug.Log("note_count=" + chart.note_count);
foreach (var note in chart.notes)
{
    Debug.Log(
        "tick=" + note.tick
        + " time=" + note.time
        + " fret=" + note.guitarFret);
}
```