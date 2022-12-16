using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagmentSystem.Common.Entities.Dtos
{
    public class Employee
    {
        public DateTime UpdatedOn;

        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Email { get; set; }
        public DateTime DateOfJoining { get; set; }
        public string Department { get; set; }
        public string Competency { get; set; }
        public int CompetencyId { get; set; }
        public int DepartmentId { get; set; }
        public DateTime CreatedOn { get; set; }
    }
}
