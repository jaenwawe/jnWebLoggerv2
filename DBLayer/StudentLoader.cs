/*

This project would be used to use the ENTITY project to connect to the DB and retrieve the data.

It would then fill the DTO (Data Transfer Object) classes, which can then be used in the rest of the application.

THIS SHOULD BE THE ONLY PLACE THAT TOUCHES THE ENTITY PROJECT.


For the time being, this is where you can "Mock" out your data, if you DB doesn't exist yet.... :)

*/

namespace DataLayer
{
    using System.Collections.Generic;
    using DTO;

    public class StudentLoader
    {
        public ICollection<StudentDTO> GetAllStudents()
        {
            // ToDo: Connect this when the DB exists, instead of fake data....

            List<StudentDTO> students = new List<StudentDTO>()
            {
                new StudentDTO() { Id = 1, FirstName = "Mom", LastName = "Doe", Age = 35 },
                new StudentDTO() { Id = 2, FirstName = "Dad", LastName = "Doe", Age = 40 },
                new StudentDTO() { Id = 3, FirstName = "Jane", LastName = "Doe", Age = 19 },
                new StudentDTO() { Id = 4, FirstName = "John", LastName = "Doe", Age = 17 },
                new StudentDTO() { Id = 5, FirstName = "Baby", LastName = "Doe", Age = 1 }
            };

            return students;
        }
    }
}
