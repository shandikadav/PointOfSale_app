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
    public class BarangController
    {
        private BarangRepository _repository;

        public int Create(Barang barang)
        {
            int result = 0;
            if (string.IsNullOrEmpty(barang.BarangId))
            {
                MessageBox.Show("Id Barang harus diisi!!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }
            if (string.IsNullOrEmpty(barang.BarangName))
            {
                MessageBox.Show("Nama Barang harus diisi!!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }


            using (DBContext context = new DBContext())
            {
                _repository = new BarangRepository(context);
                result = _repository.Create(barang);
            }

            if (result > 0)
            {
                MessageBox.Show("Data Barang berhasil disimpan !", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Data Barang gagal disimpan !!!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            return result;
        }

        public int Update(Barang barang)
        {
            int result = 0;
            if (string.IsNullOrEmpty(barang.BarangId))
            {
                MessageBox.Show("Id Barang harus diisi!!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }
            if (string.IsNullOrEmpty(barang.BarangName))
            {
                MessageBox.Show("Nama Barang harus diisi!!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }



            using (DBContext context = new DBContext())
            {
                _repository = new BarangRepository(context);
                result = _repository.Update(barang);
            }

            if (result > 0)
            {
                MessageBox.Show("Data Barang berhasil diubah !", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Data Barang gagal diubah !!!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            return result;
        }

        public int Delete(Barang barang)
        {
            int result = 0;
            if (string.IsNullOrEmpty(barang.BarangId))
            {
                MessageBox.Show("Id Barang harus diisi!!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }
            if (string.IsNullOrEmpty(barang.BarangName))
            {
                MessageBox.Show("Nama Barang harus diisi!!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }



            using (DBContext context = new DBContext())
            {
                _repository = new BarangRepository(context);
                result = _repository.Delete(barang);
            }

            if (result > 0)
            {
                MessageBox.Show("Data Barang berhasil dihapus !", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Data Barang gagal dihapus !!!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            return result;
        }
    }
}
