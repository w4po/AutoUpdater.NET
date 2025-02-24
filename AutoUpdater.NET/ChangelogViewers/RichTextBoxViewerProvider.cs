namespace AutoUpdaterDotNET.ChangelogViewers;

public class RichTextBoxViewerProvider(int priority = 0) : IChangelogViewerProvider
{
    public bool IsAvailable => true;

    public int Priority { get; } = priority;

    public IChangelogViewer CreateViewer() => new RichTextBoxViewer();
}
