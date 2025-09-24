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
    public partial class SuspendSub_frm : Form
    {
        private Suspended_Subscriptions Suspended_Subscriptions;
        private int SubscriptionID;
        public SuspendSub_frm(int SubscriptionID)
        {
            InitializeComponent();

            this.SubscriptionID = SubscriptionID;
        }

        private void _loadData()
        {
            Suspended_Subscriptions = Suspended_Subscriptions.FindBySubscriptionID(this.SubscriptionID);

            if(Suspended_Subscriptions != null)
            {
                label_RemainingDays.Text=Suspended_Subscriptions.RemainingDays.ToString();

            }



        }

      
        private void Btn_Resume_Click(object sender, EventArgs e)
        {
            Subscription subscription=Subscription.Find(SubscriptionID);
            if (subscription != null)
            {
                subscription.StartDate = StartDatePicker.Value;
                subscription.EndDate=EndDateTimePicker.Value;
                subscription.isSuspended = false;

                if(subscription.Save())
                {
                    if(Suspended_Subscriptions.Delete(Suspended_Subscriptions.SuspendedID))
                    {
                        MessageBox.Show("Subscription has been resumed.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }


            }
        }

        private void StartDatePicker_ValueChanged(object sender, EventArgs e)
        {
            EndDateTimePicker.Value=StartDatePicker.Value.AddDays(Convert.ToInt16(label_RemainingDays.Text));
        }

        private void SuspendSub_frm_Load(object sender, EventArgs e)
        {
            _loadData();
        }
    }
}
