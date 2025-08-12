using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using System;
using System.Threading.Tasks;

namespace Volo.Abp.AspNetCore.Components.Web.LeptonXLiteTheme.Themes.LeptonXLite
{
    public partial class PublicLayout : IDisposable
    {
        [Inject] IJSRuntime JSRuntime { get; set; }

        protected override async Task OnAfterRenderAsync(bool firstRender)
        {
            if (firstRender)
            {
                await JSRuntime.InvokeVoidAsync("initLeptonX");
            }
        }

        public void Dispose()
        {
            //NavigationManager.LocationChanged -= OnLocationChanged;
        }

    }
}
