using AlfredFront;

using Avalonia;
using Avalonia.ReactiveUI;
using Avalonia.Web;

using System.Diagnostics.CodeAnalysis;
using System.Runtime.Versioning;

[assembly: SupportedOSPlatform("browser")]

namespace AlfredFront.Web
{
    [ExcludeFromCodeCoverage]
    internal partial class Program
    {
        protected Program()
        {
            // Do nothing for now.
        }

        private static void Main(string[] args) => BuildAvaloniaApp()
            .UseReactiveUI()
            .SetupBrowserApp("out");

        public static AppBuilder BuildAvaloniaApp()
            => AppBuilder.Configure<App>();
    }
}
