using CourseWork.Models;
using Microsoft.AspNetCore.Mvc;

namespace CourseWork.Controllers
{
	public class TestController : Controller
	{
		private readonly DataContext _db;
        public TestController(DataContext db)
        {
            _db = db;
        }
        public IActionResult Index()
		{
			List<Test> objTestList = _db.Tests.ToList();
			return View(objTestList);
		}
		public IActionResult Create()
		{
			return View();
		}
		[HttpPost]
		public IActionResult Create(Test obj)
		{
			if (ModelState.IsValid)
			{
                _db.Tests.Add(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
			return View();
		}
		public IActionResult Edit(int? id)
		{
			if(id == null || id == 0)
			{
				return NotFound();
			}
			Test? qst = _db.Tests.FirstOrDefault(t => t.Id == id);
			if(qst == null)
			{
				return NotFound();
			}
            return View(qst); 
		}
        [HttpPost]
        public IActionResult Edit(Test obj)
        {
            if (ModelState.IsValid)
			{
                _db.Tests.Update(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
			return View();
        }
        public IActionResult Delete(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            Test? qst = _db.Tests.FirstOrDefault(t => t.Id == id);
            if (qst == null)
            {
                return NotFound();
            }
            return View(qst);
        }
        [HttpPost]
        [ActionName("Delete")]
        public IActionResult DeletePOST(int? id)
        {
            Test? obj = _db.Tests.FirstOrDefault(t => t.Id == id);
            if(obj == null)
            {
                return NotFound();
            }
            _db.Tests.Remove(obj);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
