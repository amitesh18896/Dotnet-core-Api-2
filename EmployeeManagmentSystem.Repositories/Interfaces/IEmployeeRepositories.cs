using EmployeeManagmentSystem.Common.Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeManagmentSystem.Repositories.Interfaces
{
    public interface IEmployeeRepository
    {
        Employee GetEmployeeById(int id);
        List<EmployeeListDto> GetEmployees();
        Employee GetEmployeeByName(string name);
        bool CreateEmployee(Employee employee);
        bool UpdateEmployee(int id, Employee employee);
        bool DeleteEmployee(int id);
    }
}


