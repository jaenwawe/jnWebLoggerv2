/*

Dusan Palider
CSE 686
Spring 2016

Purpose of this project is to show a recommended skeleton for the code organization that would allow good testability, reuse and mocking, 
which would allow you to start working on your project before your DB layer is ready

The following projects are included:

Entity Layer
  - this project will contain the entity model. It is THE ONLY place that will connect to the database
  - other project references: N/A

Data Layer
  - this project will contain the logic used to retrieve data and to place the data into DTOs/MVs. It is THE ONLY place where the Entity Project can be referenced
  - other project references: Entity Project (for DB connection) and DTO Project (for the data classes that will be passed into the rest of the application)

Controller Logic
  - this project will contain all application logic, to allow for controllers to be skinny.
  - other project references: Data Layer (for data retrieval) and DTO Project (for the data classes used)

ProjectExampleWeb
  - this is the web project containing all of the web files - scripts, styles and such. The controllers are very skinny, and should only make calls into the Controller
    Logic project, NEVER into any of the lower projects
  - other project references: Controller Logic (for both data retrieval but also all application logic) and DTO Project (for the data classes used)

*/

namespace ProjectSkeletonExample.Controllers
{
    using System.Collections.Generic;
    using System.Web.Mvc;
    using ControllerLogic;
    using DTO;

    public class HomeController : Controller
    {
        HomeControllerLogic controllerLogic;

        public HomeController()
        {
            this.controllerLogic = new HomeControllerLogic();
        }

        public ActionResult Index()
        {
            ICollection<StudentDTO> students = this.controllerLogic.GetAllStudents();

            return View(students);
        }

        public ActionResult UnderAge()
        {
            ICollection<StudentDTO> students = this.controllerLogic.GetAllUnderageStudents();

            return View(students);
        }
    }
}