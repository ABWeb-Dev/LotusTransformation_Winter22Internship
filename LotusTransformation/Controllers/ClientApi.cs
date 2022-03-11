using LotusTransformation.Data;
using Microsoft.AspNetCore.Mvc;

namespace LotusTransformation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientApi : ControllerBase
    {
        // GET: Api
        private LotusTransformationDBContext _dbContext;

        public ClientApi(LotusTransformationDBContext db)
        {
            _dbContext = db;
        }
        public IActionResult Get()
        {
            return Ok(_dbContext.ClientAccountInformation);
        }

        //// GET: Api/Details/5
        //public ActionResult Details(int id)
        //{
        //    return View();
        //}

        //// GET: Api/Create
        //public ActionResult Create()
        //{
        //    return View();
        //}

        //// POST: Api/Create
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Create(IFormCollection collection)
        //{
        //    try
        //    {
        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}

        //// GET: Api/Edit/5
        //public ActionResult Edit(int id)
        //{
        //    return View();
        //}

        //// POST: Api/Edit/5
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Edit(int id, IFormCollection collection)
        //{
        //    try
        //    {
        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}

        //// GET: Api/Delete/5
        //public ActionResult Delete(int id)
        //{
        //    return View();
        //}

        //// POST: Api/Delete/5
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Delete(int id, IFormCollection collection)
        //{
        //    try
        //    {
        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}
    }
}
