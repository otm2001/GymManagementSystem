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
    public partial class ExpensesMain_frm : Form
    {

        private void _RefrshExpenseData()
        {
            ExpensesList_DGrid.DataSource = Expense.GetAllExpenses();
        }
        public ExpensesMain_frm()
        {
            InitializeComponent();
        }

        private void ExpensesMain_frm_Load(object sender, EventArgs e)
        {
            _RefrshExpenseData();

        }

        private void Btn_Add_Click(object sender, EventArgs e)
        {
            AddUpdateExpense Form = new AddUpdateExpense(-1);
            
            Form.ShowDialog(this);

            _RefrshExpenseData();
        }

        private void Edit_Btn_Click(object sender, EventArgs e)
        {
            AddUpdateExpense Form = new AddUpdateExpense(Convert.ToInt16(ExpensesList_DGrid.CurrentRow.Cells[0].Value));
            Form.ShowDialog();
            _RefrshExpenseData();
        }
    }
}
