using EntityLayer;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace DataAccessLayer
{
    public class DALEmployee
    {
        public static List<Employee> EmployeeList()
        {
            List<Employee> employees = new List<Employee>();
            SqlCommand sqlCommand = new SqlCommand("SELECT * FROM Employees", Connection.sqlConnection);
            if (sqlCommand.Connection.State != System.Data.ConnectionState.Open)
            {
                sqlCommand.Connection.Open();
            }
            SqlDataReader sqlDR = sqlCommand.ExecuteReader();

            while (sqlDR.Read())
            {
                Employee employee = new Employee
                {
                    Id = short.Parse(sqlDR[0].ToString()),
                    Name = sqlDR[1].ToString(),
                    Surname = sqlDR[2].ToString(),
                    City = sqlDR[3].ToString(),
                    Salary = short.Parse(sqlDR[4].ToString()),
                    State = bool.Parse(sqlDR[5].ToString()),
                    Job = sqlDR[6].ToString()
                };
                employees.Add(employee);
            }
            sqlDR.Close();
            return employees;
        }

        public static int AddEmployee(Employee employee)
        {
            SqlCommand sqlCmd = new SqlCommand("INSERT INTO Employees(Name,Surname,City,Salary,State,Job) VALUES (@p1,@p2,@p3,@p4,@p5,@p6)", Connection.sqlConnection);
            if (sqlCmd.Connection.State != System.Data.ConnectionState.Open)
            {
                sqlCmd.Connection.Open();
            }
            sqlCmd.Parameters.AddWithValue("@p1",employee.Name);
            sqlCmd.Parameters.AddWithValue("@p2", employee.Surname);
            sqlCmd.Parameters.AddWithValue("@p3", employee.City);
            sqlCmd.Parameters.AddWithValue("@p4", employee.Salary);
            sqlCmd.Parameters.AddWithValue("@p5", employee.State);
            sqlCmd.Parameters.AddWithValue("@p6", employee.Job);
            return sqlCmd.ExecuteNonQuery();
        }

        public static bool DeleteEmployee(int id)
        {
            SqlCommand sqlCmdDelete = new SqlCommand("DELETE FROM Employees WHERE Id=@p1",Connection.sqlConnection);
            if (sqlCmdDelete.Connection.State != System.Data.ConnectionState.Open)
            {
                sqlCmdDelete.Connection.Open();
            }
            sqlCmdDelete.Parameters.AddWithValue("@p1",id);
            return sqlCmdDelete.ExecuteNonQuery() > 0;
        }

        public static bool UpdateEmployee(Employee employee)
        {
            SqlCommand sqlCmdUpdate = new SqlCommand("UPDATE Employees SET Name=@p1,Surname=@p2, City=@p3, Salary=@p4, State=@p5, Job=@p6 WHERE ID=@p7",Connection.sqlConnection);
            if (sqlCmdUpdate.Connection.State != System.Data.ConnectionState.Open)
            {
                sqlCmdUpdate.Connection.Open();
            }
            sqlCmdUpdate.Parameters.AddWithValue("@p1",employee.Name);
            sqlCmdUpdate.Parameters.AddWithValue("@p2", employee.Surname);
            sqlCmdUpdate.Parameters.AddWithValue("@p3", employee.City);
            sqlCmdUpdate.Parameters.AddWithValue("@p4", employee.Salary);
            sqlCmdUpdate.Parameters.AddWithValue("@p5", employee.State);
            sqlCmdUpdate.Parameters.AddWithValue("@p6", employee.Job);
            sqlCmdUpdate.Parameters.AddWithValue("@p7", employee.Id);
            return sqlCmdUpdate.ExecuteNonQuery() > 0;
        }
    }
}
