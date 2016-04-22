/*

This project contains all of the logic for the controllers. It will help us follow the skinny controller design principle

*/

namespace ControllerLogic
{
    using System.Collections.Generic;
    using System.Linq;
    using DataLayer;
    using DTO;

    public class HomeControllerLogic
    {
        public ICollection<StudentDTO> GetAllStudents()
        {
            ICollection<StudentDTO> students;

            StudentLoader loader = new StudentLoader();

            students = loader.GetAllStudents();

            return students;
        }

        public ICollection<StudentDTO> GetAllUnderageStudents()
        {
            List<StudentDTO> students;

            StudentLoader loader = new StudentLoader();

            students = loader.GetAllStudents().Where(x => x.Age < 18).ToList();

            return students;
        }
    }
}
