using System.Web.Mvc;
using ShapeLibrary.Factory;
using ShapeLibrary.Model.Extensions;

namespace ProcessShapesWebApp.Controllers
{
    public class ProcessShapeController : Controller
    {
        // GET: ProcessShape
        public ActionResult Index()
        {
            var shapes = new RandomShapeFactory().Create(10).Random().ToIArea();
            return View(shapes);
        }
    }
}