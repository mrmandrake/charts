using Avalonia.Web.Blazor;

namespace xplat.Web;

public partial class App
{
    protected override void OnParametersSet()
    {
        base.OnParametersSet();
        
        BlazorSingleViewLifetimeExtensions.SetupWithBlazorSingleViewLifetime<xplat.App>();
    }
}