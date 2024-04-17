using EmployeeAPI.Model;

namespace EmployeeAPI.Services
{
    public interface IEmployee
    {
        IEnumerable<EmployeeModel> addEmployee(EmployeeModel em);
        IEnumerable<EmployeeModel> getEmployee();
        IEnumerable<EmployeeModel> editEmployee(int id,EmployeeModel em);
        void  deleteEmployee(int id);
        EmployeeModel getElementById(int id);
    }


}