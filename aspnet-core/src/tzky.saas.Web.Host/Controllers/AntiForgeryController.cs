using Microsoft.AspNetCore.Antiforgery;
using tzky.saas.Controllers;

namespace tzky.saas.Web.Host.Controllers
{
    public class AntiForgeryController : saasControllerBase
    {
        private readonly IAntiforgery _antiforgery;

        public AntiForgeryController(IAntiforgery antiforgery)
        {
            _antiforgery = antiforgery;
        }

        public void GetToken()
        {
            _antiforgery.SetCookieTokenAndHeader(HttpContext);
        }
    }
}
