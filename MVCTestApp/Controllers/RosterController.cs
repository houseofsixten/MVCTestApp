using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCTestApp.Controllers
{
    public class RosterController : Controller
    {
        private List<Models.Employee> emp;

        public RosterController()
        {
            emp = new List<Models.Employee>();

            emp.Add(new Models.Employee(Models.OperatorLevel.Elite,
                                        Models.OperatorClass.Supporter,
                                        "Angelina",
                                        "Airborne messenger with the power to control gravity",
                                        "angelina.jpg"));

            emp.Add(new Models.Employee(Models.OperatorLevel.Senior,
                                        Models.OperatorClass.Medic,
                                        "Perfumer",
                                        "Gardener whose aromatherapy heals wounds",
                                        "perfumer.jpg"));

            emp.Add(new Models.Employee(Models.OperatorLevel.Veteran,
                                        Models.OperatorClass.Medic,
                                        "Myrrh",
                                        "Potato fox alchemist",
                                        "myrrh.jpg"));
        }

        public IActionResult Index()
        {
            return View(emp);
        }
    }
}
