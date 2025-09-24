using DataAccessGymSystem;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayerGymSystem
{
      public class Payment
    {
        private  enum enMode
        {
            AddNew,
            Update
        }

        private enMode Mode=enMode.AddNew;


        private bool _AddnewPayment()
        {
            PaymentID = DataAccessPayment.AddNewPayment(Amount, Date, MemberID);

            return (PaymentID != -1);
        }

        private bool _Update()
        {
            return (DataAccessPayment.UpdatePayment(PaymentID, Amount, Date, MemberID));

        }
        public int PaymentID {  get; set; }
        public float Amount {  get; set; }

        public DateTime Date { get; set; }

        public int MemberID {  get; set; }

        public Payment()
        {
            PaymentID = -1;
            Amount = 0;
            Date = DateTime.Now;
            MemberID = -1;
            Mode= enMode.AddNew;
        }

        private Payment(int paymentID, float amount, DateTime date, int memberID)
        {
            PaymentID = paymentID;
            Amount = amount;
            Date = date;
            MemberID = memberID;
            Mode = enMode.Update;
        }

        static public Payment Find(int PaymentID)
        {
            float Amount = 0;
            DateTime date = DateTime.Now;
            int MemberID = -1;

            if(DataAccessPayment.FindPaymentByID(PaymentID,ref Amount,ref date,ref MemberID))
            {
                return new Payment(PaymentID,Amount,date,MemberID);
            }
            return null;
        }

        static public bool Delete(int PaymentID)
        {
            return DataAccessPayment.DeletePayment(PaymentID);
        }
        public bool Save()
        {
            if (Mode == enMode.AddNew)
            {
                if (_AddnewPayment())
                {
                    Mode = enMode.Update;
                    return true;

                }



            }
            else
            {
                if(_Update())
                    return true;
            }


                return false;
        }

        static public DataTable GetAllPayments()
        {
            return DataAccessPayment.GetAllPayments();
        }

        static public DataTable GetAllPaymentsByName(string Name)
        {
            return DataAccessPayment.GetAllPaymentsByName(Name);
        }

    }
}
