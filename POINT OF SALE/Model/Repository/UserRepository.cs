using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using POINT_OF_SALE.Model.Context;
using POINT_OF_SALE.Model.Entity;

namespace POINT_OF_SALE.Model.Repository
{
    public class UserRepository
    {
        private SqlConnection _conn;

        public UserRepository(DBContext context)
        {
            _conn = context.Conn;
        }

        public int Create(User users)
        {
            int result = 0;
            string sql = @"INSERT INTO users (id_user, username, password, id_employee) VALUES (@userid, @username, @password, @employeeid)";

            using (SqlCommand cmd = new SqlCommand(sql, _conn))
            {
                cmd.Parameters.AddWithValue("@userid", users.IdUser);
                cmd.Parameters.AddWithValue("@username", users.Username);
                cmd.Parameters.AddWithValue("@password", users.Password);
                cmd.Parameters.AddWithValue("@employeeid", users.IdEmployee);

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

        public int Update(User users)
        {
            int result = 0;
            string sql = @"UPDATE users SET username = @username, password = @password, id_employee = @employeeid WHERE id_user = @userid";

            using (SqlCommand cmd = new SqlCommand(sql, _conn))
            {
                cmd.Parameters.AddWithValue("@userid", users.IdUser);
                cmd.Parameters.AddWithValue("@username", users.Username);
                cmd.Parameters.AddWithValue("@password", users.Password);
                cmd.Parameters.AddWithValue("@employeeid", users.IdEmployee);

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

        public int Delete(User users)
        {
            int result = 0;
            string sql = @"DELETE FROM users WHERE id_user = @userid";

            using (SqlCommand cmd = new SqlCommand(sql, _conn))
            {
                cmd.Parameters.AddWithValue("@userid", users.IdUser);
                cmd.Parameters.AddWithValue("@username", users.Username);
                cmd.Parameters.AddWithValue("@password", users.Password);
                cmd.Parameters.AddWithValue("@employeeid", users.IdEmployee);

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

        public List<Employee> GetEmployeeName()
        {
            string sql = @"SELECT id_employee, firstName FROM employee";
            List<Employee> userList = new List<Employee>();
            using (SqlCommand cmd = new SqlCommand(sql, _conn))
            {
                using(SqlDataReader rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        Employee employees = new Employee();
                        employees.FirstName = rd["firstName"].ToString();
                        employees.IdEmployee = rd["id_employee"].ToString();
                        userList.Add(employees);
                    }
                }
            }
            return userList;
        }

        public List<Employee> GetEmployeeNameByPosition()
        {
            string sql = @"SELECT id_employee, firstName, position FROM employee WHERE position = 'Cashier'";
            List<Employee> userList = new List<Employee>();
            using (SqlCommand cmd = new SqlCommand(sql, _conn))
            {
                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        Employee employees = new Employee();
                        employees.FirstName = rd["firstName"].ToString();
                        employees.IdEmployee = rd["id_employee"].ToString();
                        employees.Potition = rd["position"].ToString();
                        userList.Add(employees);
                    }
                }
            }
            return userList;
        }
    }
}
