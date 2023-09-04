using RazorPagesTutorial.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RazorPagesTutorial.Services
{

    public class MockEmployeeRepository : IEmployeeRepository
    {
        private List<Employee> _employeeList;

        public MockEmployeeRepository() 
        {
            _employeeList = new List<Employee>()
            {
                new Employee() { Id = 1, Name = "Mary", Department = Dept.HR, Email = "mary@pragimtech.com",PhotoPath="HR.jpg" },
                new Employee() { Id = 2, Name = "John", Department = Dept.IT, Email = "john@pragimtech.com",PhotoPath="IT.jpg" },
                new Employee() { Id = 3, Name = "Sam", Department = Dept.Payroll, Email = "sam@pragimtech.com",PhotoPath="payroll.jpg" },
                new Employee() { Id = 3, Name = "David", Department = Dept.IT, Email = "david@pragimtech.com"}
            };

        }
        public IEnumerable<Employee> GetAllEmployees()
        {
            return _employeeList;
        }

        public Employee GetEmployee(int id)
        {
            return _employeeList.FirstOrDefault(e => e.Id == id);
        }
    }
}
