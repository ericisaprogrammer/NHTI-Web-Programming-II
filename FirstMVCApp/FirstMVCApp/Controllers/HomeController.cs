using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FirstMVCApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult CalcApp()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CalcApp(string operation = "empty", string first = "", string second = "")
        {
            string ans = "";

            if (first == "" || second == "")
            {
                ans = "Please enter a number into both boxes.";
            }
            else
            {
                double firstNumber = Convert.ToDouble(first);
                double secondNumber = Convert.ToDouble(second);
                switch (operation)
                {
                    case "add":
                        ans = (firstNumber + secondNumber) + "";
                        break;
                    case "sub":
                        ans = (firstNumber - secondNumber) + "";
                        break;
                    case "multiply":
                        ans = (firstNumber * secondNumber) + "";
                        break;
                    case "divide":
                        if (secondNumber == 0)
                        {
                            ans = "ERR: DIVIDE BY ZERO";
                        }
                        else
                        {
                            ans = (firstNumber / secondNumber) + "";
                        }
                        break;
                    default:
                        ans = "Please select an operation.";
                        break;
                }
            }
            
            return View("CalcApp", (object)ans);
        }
        public ActionResult Index()
        {
            return View();
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