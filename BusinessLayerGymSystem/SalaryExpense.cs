using DataAccessGymSystem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayerGymSystem
{
    public class SalaryExpense : Expense
    {
        enMode Mode=enMode.AddNew;
        public int SalaryExpenseID {  get; set; }
        public int EmployeeID {  get; set; }
        public float Salary { get; set; }

        private bool _AddNew()
        {
            this.SalaryExpenseID=DataAccessSalaryExpense.AddNewSalaryExpense(EmployeeID,Salary,ExpenseID);
            return (SalaryExpenseID != -1);
        }

        private bool _Update()
        {
            return DataAccessSalaryExpense.UpdateSalaryExpense(SalaryExpenseID,EmployeeID,Salary);  
        }
        public SalaryExpense() 
        {
            this.SalaryExpenseID = -1;
            this.EmployeeID = -1;
            this.Salary = 0;
            Mode = enMode.AddNew;
        }

        private SalaryExpense(int salaryExpenseID,int EmployeeID,float Salary, int ExpenseID, float Amount, DateTime ExpenseDate, ExpenseType expenseType)
       :base(ExpenseID,Amount,ExpenseDate,expenseType)
        {
            this.SalaryExpenseID=salaryExpenseID;
            this.EmployeeID=EmployeeID;
            this.Salary = Salary;
            Mode = enMode.Update;
        }

        public static SalaryExpense FindByID(int salaryExpenseID)
        {
            int EmployeeID = -1, ExpenseID=-1;
            float Salary = 0;
            if (DataAccessSalaryExpense.FindSalaryExpenseByID(salaryExpenseID, ref EmployeeID, ref Salary, ref ExpenseID))
            {
                Expense expense = Expense.FindByID(ExpenseID);
                if (expense != null)

                    return new SalaryExpense(salaryExpenseID, EmployeeID, Salary,ExpenseID, expense.Amount, expense.ExpenseDate, expense.expenseType);
                }
            return null;
        }

        public static SalaryExpense FindByEmployeeID(int employeeID)
        {
            int salaryExpenseID = -1, ExpenseID = -1;
            float Salary = 0;

            if(DataAccessSalaryExpense.FindSalaryExpenseByEmployeeID(employeeID,ref salaryExpenseID,ref Salary,ref ExpenseID))
            {
                Expense expense = Expense.FindByID(ExpenseID);
                if(expense != null)
                {
                    return new SalaryExpense(salaryExpenseID, employeeID, Salary, ExpenseID, expense.Amount, expense.ExpenseDate, expense.expenseType);
                }
               
            }
            return null;
        }

        public static bool Delete(int salaryExpenseID)
        {
            SalaryExpense salaryExpense=SalaryExpense.FindByID(salaryExpenseID);

            return DataAccessSalaryExpense.DeleteSalaryExpense(salaryExpenseID) && Expense.Delete(salaryExpense.ExpenseID);
        }

        public bool Save()
        {
            if(Mode == enMode.AddNew)
            {
                if(base.Save())
                if(_AddNew())
                {
                    Mode = enMode.Update;
                    return true;
                }
            }

            else
            {
                if(base.Save() )
                if (_Update())
                    return true;

            }
            return false;
        }
        
    }
}
