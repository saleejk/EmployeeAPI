using EmployeeAPI.Model;

namespace EmployeeAPI.Services
{
    public class EmployeeServices : IEmployee
    {
        List<EmployeeModel> employees = new List<EmployeeModel>()
        { new EmployeeModel() { id = 1, name = "rayees", age = 21, designation = "manager" },new EmployeeModel()
        {
            id=1,name="babi",age=22,designation="hr"
        }
        };
        public IEnumerable<EmployeeModel> addEmployee(EmployeeModel employ)
        {
            int Id = employees.LastOrDefault().id + 1;
            EmployeeModel employeee = new EmployeeModel() { id = Id, name = employ.name, age = employ.age, designation = employ.designation };
           employees.Add(employeee);
            return employees;
        }
        public IEnumerable<EmployeeModel> getEmployee()
        {
            return employees;
        }
        public IEnumerable<EmployeeModel>editEmployee(int ID, EmployeeModel employ)
        {
            var em = employees.FirstOrDefault(val => val.id == ID);
            if(ID == null) {
                return null;
            } else
            {
            
            em.name=employ.name;
            em.age=employ.age;
            em.designation=employ.designation;
            return employees;

            }
        }
        public void deleteEmployee(int id)
        {
            var deletee =employees.FirstOrDefault(val=>val.id==id);
            employees.Remove(deletee);
        }
        public EmployeeModel getElementById(int Id)
        {
            var getById = employees.FirstOrDefault(val => val.id == Id);
            return getById;
        }

       
    }
}
