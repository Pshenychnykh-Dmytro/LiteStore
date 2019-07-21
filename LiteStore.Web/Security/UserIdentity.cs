using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Web;

namespace LiteStore.Web.Security
{
    public class UserIdentity : IIdentity
    {
        public string Name => throw new NotImplementedException();

        public string AuthenticationType => throw new NotImplementedException();

        public bool IsAuthenticated => throw new NotImplementedException();
    }
}