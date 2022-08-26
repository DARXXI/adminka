using AdminPanel.Repository;
using Microsoft.AspNetCore.Mvc;

namespace AdminPanel.Web.Controllers
{
    public class BaseController : Controller
    {
        protected DataBaseContext Context = new();
        protected static CancellationTokenSource cancelTokenSource = new CancellationTokenSource();
        public CancellationToken Token = cancelTokenSource.Token;
    }

}
