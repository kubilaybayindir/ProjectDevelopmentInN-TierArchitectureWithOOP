using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer;
using DataAccessLayer;
namespace LogicLayer
{
    public class LogicEmployee
    {
        public static List<Employee> LLEmployeeList()
        {
            return DALEmployee.EmployeeList();
        }

        public static int LLAddEmployee(Employee employee)
        {
            if (employee.Name !="" && employee.Surname != "" && employee.Salary != 2000)
            {
                return DALEmployee.AddEmployee(employee);
            }
            else
            {
                return -1;
            }
        }

        public static bool LLDeleteEmployee(int id)
        {
            if (id >= 1)
            {
                return DALEmployee.DeleteEmployee(id);
            }
            else
            {
                return false;
            }
        }

        public static bool LLUpdateEmployee(Employee employee)
        {
            if (employee.Name != "" && employee.Surname != "" && employee.Salary != 1000)
            {
                return DALEmployee.UpdateEmployee(employee);
            }
            else
            {
                return false;
            }
        }

    }
}
