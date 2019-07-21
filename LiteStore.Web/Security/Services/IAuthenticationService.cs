using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace LiteStore.Web.Security.Services
{
    public interface IAuthenticationService
    {
        void Init(HttpContext context);
    }
}
