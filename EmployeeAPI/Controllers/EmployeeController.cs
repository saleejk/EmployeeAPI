using EmployeeAPI.Model;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        public static List<Employee> employees = new List<Employee>();
        [HttpPost]
        public void addEmployee(Employee employee) {
            employees.Add(employee);
        }
        [HttpGet]
        public List<Employee> getAllEmployee()
        {
            return employees;
        }
        [HttpPut]
        public string editEmployee(int id, Employee updates)
        {
            var isEmployeeExists = employees.FirstOrDefault(user => user.id == id);
            if (isEmployeeExists == null) {
                return "employeeNotFound";
            }
            isEmployeeExists.name = updates.name;
            isEmployeeExists.age = updates.age;
            isEmployeeExists.designation = updates.designation;
            return "successfully updated employee details";
        }
        [HttpDelete]
        public void deleleEmployee(int id)
        {
            var isEmployeeExists = employees.FirstOrDefault(employee => employee.id == id);
            if (isEmployeeExists != null) {
                employees.Remove(isEmployeeExists);
            }
        }
        [HttpGet("{id}")]
        public Employee getById(int id)
        {
            var em = employees.FirstOrDefault(e => e.id == id);
            if(em!=null)
            {
                return em;
            }
            return null;
        }

    }

}
