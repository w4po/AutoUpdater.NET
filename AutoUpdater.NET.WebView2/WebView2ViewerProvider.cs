using AutoUpdaterDotNET.ChangelogViewers;

namespace AutoUpdaterDotNET.WebView2;

public class WebView2ViewerProvider(int priority = 2) : IChangelogViewerProvider
{
    public WebView2ViewerProvider() : this(2) { }

    public bool IsAvailable => WebView2Viewer.IsAvailable();

    public int Priority { get; } = priority;

    public IChangelogViewer CreateViewer() => new WebView2Viewer();
}
