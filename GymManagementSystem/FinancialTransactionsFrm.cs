using Guna.UI2.WinForms.Suite;
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
    public partial class FinancialTransactionsFrm : Form
    {
        private Form CurrentForm = null;
        private void OpenChildForm(Form childForm)
        {

            if (CurrentForm != null)
            {
                CurrentForm.Close();
            }
            CurrentForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel.Controls.Add(childForm);
            panel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();


        }

        public FinancialTransactionsFrm()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Expences_btn_Click(object sender, EventArgs e)
        {
            ExpensesMain_frm form = new ExpensesMain_frm();

          OpenChildForm(form);
        }

        private void Payments_btn_Click(object sender, EventArgs e)
        {
            PaymentsMain paymentsMain = new PaymentsMain();
            OpenChildForm(paymentsMain);
        }

        private void FinancialTransactionsFrm_Load(object sender, EventArgs e)
        {
            Expences_btn.PerformClick();
        }
    }
}
