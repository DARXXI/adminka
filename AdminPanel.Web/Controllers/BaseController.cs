using AdminPanel.Repository;
using Microsoft.AspNetCore.Mvc;



namespace AdminPanel.Web.Controllers
{
    public class BaseController : Controller
    {
        protected DataBaseContext Context = new();
        public string currentData = DateTime.Now.ToString("dd/MM/yyyy HH:mm");
    }

}
