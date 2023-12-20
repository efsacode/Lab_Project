using Microsoft.AspNetCore.Mvc;
using Application1.Models;
using System.Text.Encodings.Web;
using Microsoft.AspNetCore.Mvc.Filters;

namespace Application1.Controllers

{

    public class CustomFilter : Attribute, IActionFilter, IExceptionFilter
    {
        public void OnActionExecuted(ActionExecutedContext context)
        {
        }

        public void OnActionExecuting(ActionExecutingContext context)
        {
            if (context.ActionDescriptor.DisplayName.Contains("Create") || context.ActionDescriptor.DisplayName.Contains("Edit"))
            {
                var model = context.ActionArguments["employee"] as Employee;

                if (model != null)
                {
                    if (string.IsNullOrEmpty(model.Name) || string.IsNullOrEmpty(model.Surname))
                    {
                        context.ModelState.AddModelError("", "Name and Surname are required.");
                    }
                }
            }
        }

        public void OnException(ExceptionContext context)
        {
            context.Result = new ViewResult { ViewName = "Error" };
            context.ExceptionHandled = true;
        }
    }

    [CustomFilter]
    public class EmployeeController : Controller
    {

        List<Employee> _employees;
        public EmployeeController()
        {
            _employees = new List<Employee>
            {
               new Employee{

                Id = 1, Name = "Martin", Surname = "Simpson",
                BirthDate = new DateTime(1992, 12, 3),
                Position = "Marketing Expert", Image="/images/Martin.jpg"
                },
                      new Employee
                {
                Id = 2, Name = "Jacob", Surname = "Hawk",
                BirthDate = new DateTime(1995, 10, 2), Position = "Manager", Image="/images/Jacob.jpg"
                },
                      new Employee
                {
                Id = 3, Name = "Elizabeth", Surname = "Geil",
                BirthDate = new DateTime(2000, 1, 7),
                Position = "Software Engineer", Image="/images/Elizabeth.jpg"
                },
                      new Employee
                {
                Id = 4, Name = "Kate", Surname =  "Metain",
                BirthDate = new DateTime(1997, 2, 13),
                Position = "Admin", Image="/images/Kate.jpg"
                },
                      new Employee
                {
                Id = 5, Name = "Michael", Surname = "Cook",
                BirthDate = new DateTime(1990, 12, 25),
                Position = "Marketing expert", Image="/images/Michael.jpg"
                },
                            new Employee
                {
                Id = 6, Name = "John", Surname = "Snow",
                BirthDate = new DateTime(2001, 7, 15),
                Position = "Software Engineer", Image="/images/John.jpg"
                },
                             new Employee
                {
                Id = 7, Name = "Nina", Surname = "Soprano",
                BirthDate = new DateTime(1999, 9, 30),
                Position = "Software Engineer", Image="/images/Nina.jpg"
                },
                             new Employee
                {
                Id = 8, Name = "Tina", Surname = "Fins",
                BirthDate = new DateTime(2000, 5, 14),
                Position = "Team Leader", Image="/images/Tina.jpg"
                }
            };
        }

        public IActionResult Index()
        {
            ViewBag.Layout = "_Lab2Layout";
            return View(_employees);
            return View();
            
        }

        public IActionResult Details(int id)
        {
            var employee = _employees.FirstOrDefault(e => e.Id == id);
            if (employee == null)
            {
                return NotFound(); 
            }
           
            else
            {
                ViewBag.Layout = "_Lab2Layout";
                return View(employee);

            }

        }

        public IActionResult Edit(int id)
        {

            var employee = _employees.FirstOrDefault(e => e.Id == id);
            if (employee == null)
            {
                return NotFound();
            }

            else
            {
                ViewBag.Layout = "_Lab2Layout";
                return View(employee);

            }
        }

        public IActionResult Update(int id)
        {

            var employee = _employees.FirstOrDefault(e => e.Id == id);
            if (employee == null)
            {
                return NotFound();
            }

            else
            {
                ViewBag.Layout = "_Lab2Layout";
                return View(employee);

            }
        }

        
        [HttpPost]
        public IActionResult Update(int id, Employee employee)
        {
            
            return RedirectToAction("Index"); 
        }



    }
}
