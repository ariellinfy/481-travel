using Blazored.SessionStorage;
using Microsoft.AspNetCore.Components.Authorization;
using System.Security.Claims;

namespace travel.Model
{
    public class TravelAuthenticationStateProvider : AuthenticationStateProvider
    {
        private ISessionStorageService _sessionStorageService;

        public TravelAuthenticationStateProvider(ISessionStorageService sessionStorageService)
        {
            _sessionStorageService = sessionStorageService;
        }

        public override async Task<AuthenticationState> GetAuthenticationStateAsync()
        {
            var email = await _sessionStorageService.GetItemAsync<string>("email");
            ClaimsIdentity identity;

            if (email != null)
            {
                identity = new ClaimsIdentity(new[] {
                new Claim(ClaimTypes.Name, email),
                }, "apiauth_type");
            }
            else
            {
                identity = new ClaimsIdentity();
            }

            return await Task.FromResult(new AuthenticationState(new ClaimsPrincipal(identity)));
        }

        public void NotifyUserAuthentication(string email)
        {
            {
                var identity = new ClaimsIdentity(new[] {
                new Claim(ClaimTypes.Name, email),
                }, "apiauth_type");

                NotifyAuthenticationStateChanged(Task.FromResult(new AuthenticationState(new ClaimsPrincipal(identity))));
            }
        }

        public void NotifyUserLogout()
        {
            {
                _sessionStorageService.RemoveItemAsync("email");
                var identity = new ClaimsIdentity();

                NotifyAuthenticationStateChanged(Task.FromResult(new AuthenticationState(new ClaimsPrincipal(identity))));
            }
        }
    }
}
