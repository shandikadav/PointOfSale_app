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
    public class DetailTransactionController
    {
        private DetailTransactionRepository _repository;

        public int Create(DetailTransaction detailTransact)
        {
            int result = 0;
            if (string.IsNullOrEmpty(detailTransact.IdDetailTransaction))
            {
                MessageBox.Show("Detail Transaksi harus diisi!!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }
            if (string.IsNullOrEmpty(detailTransact.ProductID))
            {
                MessageBox.Show("Product ID harus diisi!!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }


            using (DBContext context = new DBContext())
            {
                _repository = new DetailTransactionRepository(context);
                result = _repository.Create(detailTransact);
            }

            if (result > 0)
            {
                
            }
            else
            {
                MessageBox.Show("Data detail gagal disimpan !!!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            return result;
        }
    }


}
