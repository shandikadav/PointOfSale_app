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
    public class PaymentController
    {
        private PaymentRepository _repository;

        public int Create(Payment payment)
        {
            int result = 0;
            if (string.IsNullOrEmpty(payment.PaymentId))
            {
                MessageBox.Show("Id Payment harus diisi!!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }
            if (string.IsNullOrEmpty(payment.Method))
            {
                MessageBox.Show("Metode Pembayaran harus diisi!!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }
            
            using (DBContext context = new DBContext())
            {
                _repository = new PaymentRepository(context);
                result = _repository.Create(payment);
            }

            if (result > 0)
            {
                MessageBox.Show("Data Payment Method berhasil disimpan !", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Data Payment Method gagal disimpan !!!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            return result;
        }

        public int Update(Payment payment)
        {
            int result = 0;
            if (string.IsNullOrEmpty(payment.PaymentId))
            {
                MessageBox.Show("Id Payment harus diisi!!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }
            if (string.IsNullOrEmpty(payment.Method))
            {
                MessageBox.Show("Metode Pembayaran harus diisi!!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            using (DBContext context = new DBContext())
            {
                _repository = new PaymentRepository(context);
                result = _repository.Update(payment);
            }

            if (result > 0)
            {
                MessageBox.Show("Data Payment Method berhasil diubah !", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Data Payment Method gagal diubah !!!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            return result;
        }

        public int Delete(Payment payment)
        {
            int result = 0;
            if (string.IsNullOrEmpty(payment.PaymentId))
            {
                MessageBox.Show("Id Payment harus diisi!!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }
            if (string.IsNullOrEmpty(payment.Method))
            {
                MessageBox.Show("Metode Pembayaran harus diisi!!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            using (DBContext context = new DBContext())
            {
                _repository = new PaymentRepository(context);
                result = _repository.Delete(payment);
            }

            if (result > 0)
            {
                MessageBox.Show("Data Payment Method berhasil dihapus !", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Data Payment Method gagal dihapus !!!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            return result;
        }

        public List<Payment> GetPaymentName()
        {
            List<Payment> list = new List<Payment>();
            using (DBContext context = new DBContext())
            {
                _repository = new PaymentRepository(context);
                list = _repository.GetPaymentName();
            }
            return list;
        }
    }
}
