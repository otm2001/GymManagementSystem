using BusinessLayerGymSystem;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GymManagementSystem
{
    public partial class AddUpdateExpense : Form
    {

        private ArrayList gymExpenses = new ArrayList();

        private Settings.enMode Mode=Settings.enMode.AddNew;

        private Expense expense;
        private int ExpenseID;
        public AddUpdateExpense(int ExpenseID)
        {
            InitializeComponent();
            if (ExpenseID != -1)
            {
                Mode = Settings.enMode.Update;
                this.ExpenseID = ExpenseID;
            }
        }

        private void _loadExpensesTypestoCombobox()
        {
            DataTable dt = Expense.ExpenseType.GetAllExpensesTypes();
            foreach (DataRow dr in dt.Rows)
            {
                ExpensesTypes_ComboBox.Items.Add(dr["ExpenseTypeName"].ToString());

            }
        }
        private void CollectDataToSave()
        {
            expense.expenseType = Expense.ExpenseType.FindByName(ExpensesTypes_ComboBox.Text);
            expense.ExpenseDate = ExpenseDataPicker.Value;
            expense.Amount=Convert.ToSingle(Amount_Txt.Text);
            expense.UserID = 2;
        }
        private void _loadExpensesDataToBoxes()
        {
            expense =Expense.FindByID(ExpenseID);

            ExpensesTypes_ComboBox.SelectedIndex = ExpensesTypes_ComboBox.FindString(expense.expenseType.ExpenseName);
            ExpensesTypes_ComboBox.Enabled = false;

            ExpenseDataPicker.Value = expense.ExpenseDate;
            Amount_Txt.Text = expense.Amount.ToString();



        }
        private void AddUpdateExpense_Load(object sender, EventArgs e)
        {
            _loadExpensesTypestoCombobox();

            if (Mode == Settings.enMode.Update)
            {
                _loadExpensesDataToBoxes();
                TitleLable.Text = "Edit Expense";
            }


        }

        private void Btn_Save_Click(object sender, EventArgs e)
        {
            

            if (Mode == Settings.enMode.AddNew)
            {
                expense=new Expense();
                CollectDataToSave();

                if(expense.Save())
                {
                    MessageBox.Show("Expense Added Sueccessflly");
                    Mode = Settings.enMode.Update;
                    TitleLable.Text = "Edit Expense";

                }
            }

            else
            {
                CollectDataToSave();
                if (expense.Save())
                {
                    MessageBox.Show("Expense Updated Sueccessflly");
                    
                }


            }
            
        }
    }
}
