using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using POINT_OF_SALE.Model.Context;
using POINT_OF_SALE.Model.Entity;
using System.Data.SqlClient;

namespace POINT_OF_SALE.Model.Repository
{
    public class EmployeeRepository
    {
        private SqlConnection _conn;

        public EmployeeRepository(DBContext context)
        {
            _conn = context.Conn;
        }

        public int Create(Employee employee)
        {
            int result = 0;
            string sql = @"INSERT INTO employee (id_employee, firstName, lastName, contact, email, position) VALUES (@employeeid, @firstname, @lastname, @contact, @email, @position)";

            using (SqlCommand cmd = new SqlCommand(sql, _conn))
            {
                cmd.Parameters.AddWithValue("@employeeid", employee.IdEmployee);
                cmd.Parameters.AddWithValue("@firstname", employee.FirstName);
                cmd.Parameters.AddWithValue("@lastname", employee.LastName);
                cmd.Parameters.AddWithValue("@contact", employee.Contact);
                cmd.Parameters.AddWithValue("@email", employee.Email);
                cmd.Parameters.AddWithValue("@position", employee.Potition);

                try
                {
                    result = cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    System.Diagnostics.Debug.Print("Open Connection Error: {0}", ex.Message);
                }
            }
            return result;
        }

        public int Update(Employee employee)
        {
            int result = 0;
            string sql = @"UPDATE employee SET firstname = @firstname, lastname = @lastname, contact = @contact, email = @email, position = @position WHERE id_employee = @employeeid";

            using (SqlCommand cmd = new SqlCommand(sql, _conn))
            {
                cmd.Parameters.AddWithValue("@employeeid", employee.IdEmployee);
                cmd.Parameters.AddWithValue("@firstname", employee.FirstName);
                cmd.Parameters.AddWithValue("@lastname", employee.LastName);
                cmd.Parameters.AddWithValue("@contact", employee.Contact);
                cmd.Parameters.AddWithValue("@email", employee.Email);
                cmd.Parameters.AddWithValue("@position", employee.Potition);

                try
                {
                    result = cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    System.Diagnostics.Debug.Print("Open Connection Error: {0}", ex.Message);
                }
            }
            return result;
        }

        public int Delete(Employee employee)
        {
            int result = 0;
            string sql = @"DELETE FROM employee WHERE id_employee = @employeeid";

            using (SqlCommand cmd = new SqlCommand(sql, _conn))
            {
                cmd.Parameters.AddWithValue("@employeeid", employee.IdEmployee);
                cmd.Parameters.AddWithValue("@firstname", employee.FirstName);
                cmd.Parameters.AddWithValue("@lastname", employee.LastName);
                cmd.Parameters.AddWithValue("@contact", employee.Contact);
                cmd.Parameters.AddWithValue("@email", employee.Email);
                cmd.Parameters.AddWithValue("@position", employee.Potition);

                try
                {
                    result = cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    System.Diagnostics.Debug.Print("Open Connection Error: {0}", ex.Message);
                }
            }
            return result;
        }
    }
}
