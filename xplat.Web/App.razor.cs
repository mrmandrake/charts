using Avalonia.Web.Blazor;

namespace xplat.Web;

public partial class App
{
    protected override void OnParametersSet()
    {
        base.OnParametersSet();
        WebAppBuilder.Configure<xplat.App>()
            .SetupWithSingleViewLifetime();
    }
}