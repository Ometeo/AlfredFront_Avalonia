using AlfredFront;

using Avalonia;
using Avalonia.ReactiveUI;
using Avalonia.Web;

using System.Diagnostics.CodeAnalysis;
using System.Runtime.Versioning;

[assembly: SupportedOSPlatform("browser")]

[ExcludeFromCodeCoverage]
internal partial class Program
{
    private static void Main(string[] args) => BuildAvaloniaApp()
        .UseReactiveUI()
        .SetupBrowserApp("out");

    public static AppBuilder BuildAvaloniaApp()
        => AppBuilder.Configure<App>();
}
