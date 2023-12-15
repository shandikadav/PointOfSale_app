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
    public class EmployeeController
    {
        private EmployeeRepository _repository;

        public int Create(Employee employee)
        {
            int result = 0;
            if (string.IsNullOrEmpty(employee.IdEmployee))
            {
                MessageBox.Show("Id Karyawan harus diisi!!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }
            if (string.IsNullOrEmpty(employee.FirstName))
            {
                MessageBox.Show("Nama Depan harus diisi!!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }
            if (string.IsNullOrEmpty(employee.LastName))
            {
                MessageBox.Show("Nama Belakang harus diisi!!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }
            if (string.IsNullOrEmpty(employee.Contact))
            {
                MessageBox.Show("Nomor HP harus diisi!!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }
            if (string.IsNullOrEmpty(employee.Email))
            {
                MessageBox.Show("Email harus diisi!!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }
            if (string.IsNullOrEmpty(employee.Potition))
            {
                MessageBox.Show("Position harus diisi!!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }
            using (DBContext context = new DBContext())
            {
                _repository = new EmployeeRepository(context);
                result = _repository.Create(employee);
            }

            if (result > 0)
            {
                MessageBox.Show("Data Karyawan berhasil disimpan !", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Data Karyawan gagal disimpan !!!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            return result;
        }

        public int Update(Employee employee)
        {
            int result = 0;
            if (string.IsNullOrEmpty(employee.IdEmployee))
            {
                MessageBox.Show("Id Karyawan harus diisi!!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }
            if (string.IsNullOrEmpty(employee.FirstName))
            {
                MessageBox.Show("Nama Depan harus diisi!!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }
            if (string.IsNullOrEmpty(employee.LastName))
            {
                MessageBox.Show("Nama Belakang harus diisi!!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }
            if (string.IsNullOrEmpty(employee.Contact))
            {
                MessageBox.Show("Nomor HP harus diisi!!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }
            if (string.IsNullOrEmpty(employee.Email))
            {
                MessageBox.Show("Email harus diisi!!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }
            if (string.IsNullOrEmpty(employee.Potition))
            {
                MessageBox.Show("Position harus diisi!!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }
            using (DBContext context = new DBContext())
            {
                _repository = new EmployeeRepository(context);
                result = _repository.Update(employee);
            }

            if (result > 0)
            {
                MessageBox.Show("Data Karyawan berhasil diubah !", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Data Karyawan gagal diubah !!!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            return result;
        }

        public int Delete(Employee employee)
        {
            int result = 0;
            if (string.IsNullOrEmpty(employee.IdEmployee))
            {
                MessageBox.Show("Id Karyawan harus diisi!!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }
            if (string.IsNullOrEmpty(employee.FirstName))
            {
                MessageBox.Show("Nama Depan harus diisi!!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }
            if (string.IsNullOrEmpty(employee.LastName))
            {
                MessageBox.Show("Nama Belakang harus diisi!!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }
            if (string.IsNullOrEmpty(employee.Contact))
            {
                MessageBox.Show("Nomor HP harus diisi!!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }
            if (string.IsNullOrEmpty(employee.Email))
            {
                MessageBox.Show("Email harus diisi!!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }
            if (string.IsNullOrEmpty(employee.Potition))
            {
                MessageBox.Show("Position harus diisi!!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }
            using (DBContext context = new DBContext())
            {
                _repository = new EmployeeRepository(context);
                result = _repository.Delete(employee);
            }

            if (result > 0)
            {
                MessageBox.Show("Data Karyawan berhasil dihapus !", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Data Karyawan gagal dihapus !!!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            return result;
        }
    }
}
