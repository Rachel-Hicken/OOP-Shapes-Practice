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
            var blah = new ShapeFactory().Create(10).RandomShapes().ToIArea();
            return View(blah);
        }
    }
}