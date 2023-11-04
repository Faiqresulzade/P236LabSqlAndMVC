using Microsoft.AspNetCore.Mvc;
using WebApplication1.Services.Abstract;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        private readonly IAppDataContext _appDataContext;

        public HomeController(IAppDataContext appDataContext)
        {
            _appDataContext = appDataContext;
        }

        public IActionResult Index()
        {
            var students=_appDataContext.GetStudentData();

            return View(students);
        }

        #region DataBase olanda ishleyecek
        //public IActionResult Delete(int? id)
        //{
        //    var student = _appDataContext.GetStudentData().Find(s=>s.Id==id);

        //    if (student == null) return BadRequest();

        //    _appDataContext.GetStudentData().Remove(student);

        //    return RedirectToAction("Index");
        //}
        #endregion
    }
}
