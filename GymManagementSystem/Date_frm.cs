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
    public partial class Date_frm : Form
    {
        private int SubscriptionID=-1;
        private Subscription _subscription;
        public Date_frm(int SubscriptionID)
        {
            this.SubscriptionID = SubscriptionID;
            InitializeComponent();
        }

        private void Date_frm_Load(object sender, EventArgs e)
        {
            _subscription =Subscription.Find(this.SubscriptionID);
        }

        private void Start_DatePicker_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Btn_Resume_Click(object sender, EventArgs e)
        {
            _subscription.StartDate=Start_DatePicker.Value;
            _subscription.EndDate=EndDateTimePicker.Value;

            if(_subscription.resumeSubscription())
            {
                MessageBox.Show("Subscription Resumed Sucssefully");
            }
        }

        private void Start_DatePicker_ValueChanged(object sender, EventArgs e)
        {
            Suspended_Subscriptions suspended_ = Suspended_Subscriptions.FindBySubscriptionID(SubscriptionID);
            EndDateTimePicker.Value = Start_DatePicker.Value.AddDays(suspended_.RemainingDays);
        }
    }
}
