using EmployeeAPI.Model;
using EmployeeAPI.Services;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployee _employ;
        public EmployeeController(IEmployee employy)
        {
            _employ = employy;
        }
        [HttpGet]
        public IEnumerable<EmployeeModel> GetAll()
        {
            return _employ.getEmployee();
        }
        [HttpPost]
        public IEnumerable<EmployeeModel> addEmployee(EmployeeModel em)
        {
            return _employ.addEmployee(em);
        }
        [HttpPut]
        public IEnumerable<EmployeeModel>editEmployee(int id,EmployeeModel em) { 
           
            return _employ.editEmployee(id,em);
        }
        [HttpDelete]
        public void deleteEmployee(int id)
        {
            _employ.deleteEmployee(id);
        }
        [HttpGet("getbyid{id:int}")]
        public EmployeeModel getElementById(int id)
        {
            return _employ.getElementById(id);
        }


    }

}


