using DataAccessGymSystem;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static BusinessLayerGymSystem.Expense;

namespace BusinessLayerGymSystem
{
    public class Expense
    {
        protected enum enMode
        {
            AddNew,
            Update
        }

        enMode Mode = enMode.AddNew;
        public int ExpenseID { get; set; }
        public float Amount { get; set; }
        public DateTime ExpenseDate { get; set; }
        public ExpenseType expenseType { get; set; }

        public int UserID { get; set; }

        private bool _AddNew()
        {
            this.ExpenseID = DataAccessExpense.AddNewExpense(expenseType.ExpenseTypeId, Amount, ExpenseDate, UserID);

            return (ExpenseID != -1);
        }

        private bool _Update()
        {
            return DataAccessExpense.UpdateExpense(ExpenseID, Amount, expenseType.ExpenseTypeId, ExpenseDate, UserID);
        }
        public Expense()
        {
            this.ExpenseID = -1;
            this.Amount = 0;
            this.ExpenseDate = DateTime.Now;
            this.expenseType = null;
            Mode = enMode.AddNew;


        }
        protected Expense(int ExpenseID, float Amount, DateTime ExpenseDate, ExpenseType expenseType)
        {
            this.ExpenseID = ExpenseID;
            this.Amount = Amount;
            this.ExpenseDate = ExpenseDate;
            this.expenseType = expenseType;
            Mode = enMode.Update;
        }
        public class ExpenseType
        {
            enMode Mode = enMode.AddNew;
            public int ExpenseTypeId { get; set; }
            public string ExpenseName { get; set; }

            private bool _AddnewExpenseType()
            {
                this.ExpenseTypeId = DataAccessExpenseType.AddNewExpenseType(this.ExpenseName);
                return (ExpenseTypeId != -1);
            }
            public ExpenseType()
            {
                this.ExpenseTypeId = -1;
                this.ExpenseName = string.Empty;
                Mode = enMode.AddNew;
            }
            public ExpenseType(int expenseTypeId, string expenseName)
            {
                ExpenseTypeId = expenseTypeId;
                ExpenseName = expenseName;
                Mode = enMode.Update;
            }

            public static ExpenseType FindByID(int ExpenseTypeId)
            {
                string expenseName=string.Empty;
                if(DataAccessExpenseType.FindExpenseTypeByID(ExpenseTypeId,ref expenseName))
                {
                    return new ExpenseType(ExpenseTypeId,expenseName);
                }
                return null;


            }

            public static ExpenseType FindByName(string ExpenseTypeName)
            {
                int expenseId = -1;
                if (DataAccessExpenseType.FindExpenseTypeByName(ExpenseTypeName, ref expenseId))
                {
                    return new ExpenseType(expenseId, ExpenseTypeName);
                }
                return null;


            }
            public static bool DeleteExpenseType(int ExpenseTypeID)
            {
                return DataAccessExpenseType.DeleteExpenseType(ExpenseTypeID);
            }

            public bool Save()
            {
                if (Mode == enMode.AddNew)
                {
                    if (_AddnewExpenseType())
                    {
                        Mode = enMode.Update;
                        return true;
                    }

                }

                return false;
            }

            static public DataTable GetAllExpensesTypes()
            {
                return DataAccessExpenseType.GetAllExpensesTypes();
            }

        }

        static public Expense FindByID(int ExpenseID)
        {
            float Amount = 0;
            DateTime ExpenseDate = DateTime.Now;
            int ExpenseTypeID = -1, UserID = -1;

            if(DataAccessExpense.FindExpensebyID(ExpenseID,ref Amount,ref ExpenseTypeID,ref ExpenseDate,ref UserID))
            {
                ExpenseType expenseType=ExpenseType.FindByID(ExpenseTypeID);
                if(expenseType !=null)
                {
                    return new Expense(ExpenseID, Amount, ExpenseDate, expenseType);
                }
            }
            return null;
        }

      
        static public bool Delete(int ExpenseID)
        {
            return DataAccessExpense.DeleteExpense(ExpenseID);
        }
        public bool Save()
        {
            if (Mode == enMode.AddNew)
            {
                if (_AddNew())
                {
                    Mode = enMode.Update;
                    return true;
                }


            }

            else
            {
                if (_Update())
                    return true;
            }
            return false;
        }

        public static DataTable GetAllExpenses()
        {
            return DataAccessExpense.GetAllExpenses();
        }
    }

    }

