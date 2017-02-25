using SimpleSumatorMVC.Models;
using System;
using System.Web.Mvc;

namespace SimpleSumatorMVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index(SumViewModels model)
        {
            try
            {
                var firstNumber = decimal.Parse(model.FirstNum);
                var secondNumber = decimal.Parse(model.SecondNum);
                var sum = firstNumber + secondNumber;
                model.Sum = sum.ToString();
            }
            catch (Exception)
            {
                //model.Sum = "Don't do it!PLS!!!";
                
            }
            //model.Sum = (model.FirstNum + model.SecondNum);
            return View(model);
        }
        

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}