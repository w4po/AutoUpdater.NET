namespace AutoUpdaterDotNET.ChangelogViewers;

public class WebBrowserViewerProvider(int priority = 1) : IChangelogViewerProvider
{
    public bool IsAvailable => true;

    public int Priority { get; } = priority;

    public IChangelogViewer CreateViewer() => new WebBrowserViewer();
}
