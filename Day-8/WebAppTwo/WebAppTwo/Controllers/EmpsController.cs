using Microsoft.AspNetCore.Mvc;
using WebAppTwo.Models;

namespace WebAppTwo.Controllers
{
    public class EmpsController : Controller
    {
        private static List<Emp> listEmps = new List<Emp>()
        {
            new Emp{Id=1,Name="Sam",Designation="Manager",Salary=98000.50 },
            new Emp{Id=2,Name="Deep",Designation="HR",Salary=78000.50 },
            new Emp{Id=3,Name="Rohan",Designation="Developer",Salary=85000.50 },
            new Emp{Id=4,Name="Gagan",Designation="Developer",Salary=87000.50 },
            new Emp{Id=5,Name="Naina",Designation="Tester",Salary=60000.50 },


        };
        public IActionResult Index()
        {
            return View(listEmps);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View(new Emp());
        }
        [HttpPost]
        public IActionResult Create(Emp model)
        {
            if(ModelState.IsValid) 
            { 
                listEmps.Add(model); 
                return RedirectToAction("Index");
            }
            return View();
        }

        public IActionResult Delete(int id)
        {
            Emp emp=listEmps.SingleOrDefault(x => x.Id == id);  
            if(emp!=null)
            {
                return View(emp);
            }
            else
            {
                return NotFound();
            }
           
        }
        [HttpPost]
        public IActionResult Delete(Emp model)
        {
            Emp emp = listEmps.SingleOrDefault(x => x.Id == model.Id);
            if (emp != null)
            {
                listEmps.Remove(emp);
                return RedirectToAction("Index");
            }
            else
            {
                return View();
            }

        }
    }
}
