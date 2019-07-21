using LiteStore.Domain.SettingsProvider.Interfaces;
using LiteStore.Web.Models;
using System.Web.Mvc;

namespace LiteStore.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly IDbSettingsProvider _dbSettingsProvider;
        private readonly IPathSettingsProvider _pathSettingsProvider;
        public HomeController(IDbSettingsProvider dbSettingsProvider, IPathSettingsProvider pathSettingsProvider) {
            _dbSettingsProvider = dbSettingsProvider;
            _pathSettingsProvider = pathSettingsProvider;
        }
        // GET: Home
        public ActionResult Index()
        {
            var indexViewModel = new IndexVievMoel {
                Sql = _dbSettingsProvider.SqlConnectionString,
                Mongo = _dbSettingsProvider.MongoConnectionString,
                RootPath = _pathSettingsProvider.RootPath,
                Hibernate = _dbSettingsProvider.HibernateConnectionString
            };
            return View(indexViewModel);
        }
    }
}