using EmployeeManagmentSystem.Common.Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeManagmentSystem.Services.Interfaces
{
    public interface IEmployeeService
    {
        Employee GetEmployeeById(int id);
        List<EmployeeListDto> GetEmployees();
        Employee GetEmployeeByName(string name);
        bool CreateEmployee(Employee employee);
        bool UpdateEmployee(int id, Employee employee);
        bool DeleteEmployee(int id);
    }
}

