using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using POINT_OF_SALE.Model.Context;
using POINT_OF_SALE.Model.Entity;
using POINT_OF_SALE.Model.Repository;

namespace POINT_OF_SALE.Controller
{
    public class UserController
    {
        private UserRepository _repository;

        public int Create(User users)
        {
            int result = 0;
            if(string.IsNullOrEmpty(users.IdUser))
            {
                MessageBox.Show("Id User harus diisi!!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }
            if (string.IsNullOrEmpty(users.Username))
            {
                MessageBox.Show("Username harus diisi!!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }
            if (string.IsNullOrEmpty(users.Password))
            {
                MessageBox.Show("Password harus diisi!!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }
            if (string.IsNullOrEmpty(users.IdEmployee))
            {
                MessageBox.Show("Id Karyawan harus diisi!!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }
            using(DBContext context = new DBContext())
            {
                _repository = new UserRepository(context);
                result = _repository.Create(users);
            }

            if (result > 0)
            {
                MessageBox.Show("Data User berhasil disimpan !", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } else
            {
                MessageBox.Show("Data User gagal disimpan !!!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            return result;
        }

        public int Update(User users)
        {
            int result = 0;
            if (string.IsNullOrEmpty(users.IdUser))
            {
                MessageBox.Show("Id User harus diisi!!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }
            if (string.IsNullOrEmpty(users.Username))
            {
                MessageBox.Show("Username harus diisi!!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }
            if (string.IsNullOrEmpty(users.Password))
            {
                MessageBox.Show("Password harus diisi!!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }
            if (string.IsNullOrEmpty(users.IdEmployee))
            {
                MessageBox.Show("Id Karyawan harus diisi!!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }
            using (DBContext context = new DBContext())
            {
                _repository = new UserRepository(context);
                result = _repository.Update(users);
            }

            if (result > 0)
            {
                MessageBox.Show("Data User berhasil diupdate !", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Data User gagal diupdate !!!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            return result;
        }

        public int Delete(User users)
        {
            int result = 0;
            if (string.IsNullOrEmpty(users.IdUser))
            {
                MessageBox.Show("Id User harus diisi!!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }
            if (string.IsNullOrEmpty(users.Username))
            {
                MessageBox.Show("Username harus diisi!!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }
            if (string.IsNullOrEmpty(users.Password))
            {
                MessageBox.Show("Password harus diisi!!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }
            if (string.IsNullOrEmpty(users.IdEmployee))
            {
                MessageBox.Show("Id Karyawan harus diisi!!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }
            using (DBContext context = new DBContext())
            {
                _repository = new UserRepository(context);
                result = _repository.Delete(users);
            }

            if (result > 0)
            {
                MessageBox.Show("Data User berhasil dihapus !", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Data User gagal dihapus !!!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            return result;
        }

        public List<Employee> GetEmployeeName()
        {
            List<Employee> list = new List<Employee>();
            using(DBContext context = new DBContext())
            {
                _repository = new UserRepository(context);
                list = _repository.GetEmployeeName();
            }
            return list;
        }
    }
}
