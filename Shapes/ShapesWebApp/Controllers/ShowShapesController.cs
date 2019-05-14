using ShapeLibrary.Factory;
using System.Web.Mvc;
using ShapeLibrary.Model.Extension;

namespace ShapesWebApp.Controllers
{
    public class ShowShapesController : Controller
    {
        // GET: ShowShapes
        public ActionResult Index()
        {
            var shapes = new ShapeFactory().Create(10).RandomShapes().ToIArea();

            return View(shapes);
        }
    }
}