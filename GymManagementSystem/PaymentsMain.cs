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
    public partial class PaymentsMain : Form
    {
        private void _RefreshPaymentsDGridView()
        {
            PaymentsList_DGrid.DataSource=Payment.GetAllPayments();
        }
        public PaymentsMain()
        {
            InitializeComponent();
        }

        private void PaymentsMain_Load(object sender, EventArgs e)
        {
            _RefreshPaymentsDGridView();
        }

        private void Search_TextBox_TextChanged(object sender, EventArgs e)
        {
            PaymentsList_DGrid.DataSource = Payment.GetAllPaymentsByName(Search_TextBox.Text);
        }
    }
}
