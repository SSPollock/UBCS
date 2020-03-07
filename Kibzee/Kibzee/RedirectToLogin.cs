using Microsoft.AspNetCore.Components;

namespace Kibzee
{
    public class RedirectToLogin : ComponentBase
    {
        [Inject]
        protected NavigationManager NavigationManager { get; set; }

        protected override void OnInitialized()
        {
            NavigationManager.NavigateTo("Identity/Account/Login", true);
        }
    }
}
