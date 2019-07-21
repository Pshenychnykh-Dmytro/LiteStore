using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LiteStore.Application.Interfaces.AccountService;

namespace LiteStore.Web.Security.Services
{
    public class AuthenticationService : IAuthenticationService
    {
        private const int CookieVersion = 1;
        private const string CookieName = "__AUTH_COOKIE";
        private IAccountService _accountService;
        private HttpContext _context;

        public AuthenticationService(IAccountService accountService)
        {
            _accountService = accountService;
        }

        public void Init(HttpContext context)
        {
            _context = context;
        }
    }
}