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
    public class TransactionController
    {
        private TransactionRepository _repository;

        public int Create(Transaction transaction)
        {
            int result = 0;
            if (string.IsNullOrEmpty(transaction.IdTransaction))
            {
                MessageBox.Show("Nomor Transaksi harus diisi!!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }
            if (string.IsNullOrEmpty(transaction.IdPayment))
            {
                MessageBox.Show("Product ID harus diisi!!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }


            using (DBContext context = new DBContext())
            {
                _repository = new TransactionRepository(context);
                result = _repository.Create(transaction);
            }

            if (result > 0)
            {
                MessageBox.Show("Data transaksi berhasil disimpan !", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Data transaksi gagal disimpan !!!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            return result;
        }
    }
}
