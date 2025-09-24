using BusinessLayerGymSystem;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GymManagementSystem
{
    public partial class PaySalary_frm : Form
    {
        private Settings.enMode Mode = Settings.enMode.AddNew;

        private SalaryExpense SalaryExpense;

        private int EmployeeID;
        private int SalaryExpenseID;
        public PaySalary_frm(int EmployeeID,int SalaryExpenseID=-1)
          
        {
            InitializeComponent();
            if (SalaryExpenseID == -1)
            {
                Mode = Settings.enMode.AddNew;
                this.EmployeeID = EmployeeID;
            }
            else
            {
                Mode = Settings.enMode.Update;
                this.SalaryExpenseID = SalaryExpenseID;

            }
        }

        private void _loadData()
        {
           
            Employee employee = Employee.FindByID(EmployeeID);

            EmployeeID_Label.Text = employee.EmployeeID.ToString();
            Name_label.Text = employee.Name;

            if (Mode == Settings.enMode.AddNew)
            {
                Salary_label.Text = employee.Salary.ToString();
                SalaryExpense= new SalaryExpense();
                return;
            }

            else
            {
                Salary_label.Text=SalaryExpense.Salary.ToString();
                ExpenseDataPicker.Value=SalaryExpense.ExpenseDate;
                Amount_Txt.Text=SalaryExpense.Amount.ToString();

            }
               
            
        }

        private void CollectDataToSave()
        {
            SalaryExpense.EmployeeID= this.EmployeeID;
            SalaryExpense.Salary=Convert.ToSingle(Salary_label.Text);
            SalaryExpense.expenseType = Expense.ExpenseType.FindByID(1);
            SalaryExpense.Amount =Convert.ToSingle(Amount_Txt.Text);
            SalaryExpense.ExpenseDate = ExpenseDataPicker.Value;
            SalaryExpense.UserID=Settings.CurrentUser.UserID;


        }
        private void PaySalary_frm_Load(object sender, EventArgs e)
         {
            if(Mode == Settings.enMode.Update)
            {
               SalaryExpense = SalaryExpense.FindByID(SalaryExpenseID);
                this.EmployeeID = SalaryExpense.EmployeeID;

            }

            _loadData();
            
        }

        private void Btn_Save_Click(object sender, EventArgs e)
        {
            CollectDataToSave();

            if (Mode == Settings.enMode.AddNew)
            {
                if (MessageBox.Show("Are you sure wnat to pay this amount to this employee", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (SalaryExpense.Save())
                    {
                        Mode = Settings.enMode.Update;
                        MessageBox.Show("Payed Sucssefully");
                    }
                }

            }
            else
            {
                if (SalaryExpense.Save())
                {
                    Mode = Settings.enMode.Update;
                    MessageBox.Show("Updated Sucssefully");
                }
            }

        }
    }
}
