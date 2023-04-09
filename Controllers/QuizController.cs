using CourseWork.Models;
using Microsoft.AspNetCore.Mvc;

namespace CourseWork.Controllers
{
    public class QuizController : Controller
    {
        private readonly DataContext _db;
        public QuizController(DataContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            List<Test> objTestList = _db.Tests.ToList();
            return View(objTestList);
        }
        [HttpPost]
        public IActionResult Index(QuizResult obj)
        {
            List<Test> objTestList = _db.Tests.ToList();
            int correct = 0;
            for(int i = 0; i < objTestList.Count(); i++)
            {
                if (objTestList[i].Answer == obj.Answers[i])
                {
                    correct++;
                }
            }
            return RedirectToAction("Results", "Quiz", new ResultVM { Score = correct, Total = objTestList.Count()});
        }

        public ActionResult Results(ResultVM result)
        {
            return View(result);
        }

    }
}
