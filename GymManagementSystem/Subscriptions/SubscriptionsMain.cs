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
    public partial class SubscriptionsMain : Form
    {
        public SubscriptionsMain()
        {
            InitializeComponent();
        }

        private void _RefreshDatainDGrid()
        {
            AllSubList_DGrid.DataSource = Subscription.GetAllSubscriptions();
        }
        private void _RefreshSuspendedDGrid()
        {
            SuspendSubList_DGrid.DataSource = Suspended_Subscriptions.GetAllSuspendedSubscriptions();
        }

        private void _DeleteSub()
        {
            if (MessageBox.Show("Are You Sure Want to Delete the Subscription", "Delete Subscription", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Subscription subscription = Subscription.Find(Convert.ToInt16(AllSubList_DGrid.CurrentRow.Cells[0].Value));
                if(subscription != null)
                if (Subscription.Delete(subscription.SubscriptionID) && Payment.Delete(subscription.Payment.PaymentID))
                {
                    MessageBox.Show("Subscription Deleted Successfully", "Deleted Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _RefreshDatainDGrid();
                }
            }
        }
        private void SubscriptionsMain_Load(object sender, EventArgs e)
        {
            _RefreshDatainDGrid();
            _RefreshSuspendedDGrid();
           
        }

        private void SubList_DGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Add_Btn_Click(object sender, EventArgs e)
        {
            AddUpdateSubscription_frm Form = new AddUpdateSubscription_frm(-1);
            Form.ShowDialog();
            _RefreshDatainDGrid();
        }

        private void Update_Btn_Click(object sender, EventArgs e)
        {
            AddUpdateSubscription_frm Form = new AddUpdateSubscription_frm(Convert.ToInt16(AllSubList_DGrid.CurrentRow.Cells[0].Value));
            Form.ShowDialog();
            _RefreshDatainDGrid();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddUpdateSubscription_frm Form = new AddUpdateSubscription_frm(Convert.ToInt16(AllSubList_DGrid.CurrentRow.Cells[0].Value));
            Form.ShowDialog();
            _RefreshDatainDGrid();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _DeleteSub();
        }

        private void Delete_btn_Click(object sender, EventArgs e)
        {
            _DeleteSub();
        }

        
        private void SuspendedSub_Tab_Click(object sender, EventArgs e)
        {
           
        }

        private void Subscriptions_Tab_Click(object sender, EventArgs e)
        {
        }
        
        private void suspendToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
                if (MessageBox.Show("Are You sure want to suspend this Subscription", "suspend", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Subscription subscription = Subscription.Find(Convert.ToInt16(Convert.ToInt16(AllSubList_DGrid.CurrentRow.Cells[0].Value)));
                    if (subscription != null)
                    {
                        TimeSpan Days = subscription.EndDate.Date - DateTime.Now.Date;

                        double days = Days.Days;

                        if (subscription.suspendSubscription(Convert.ToInt16(days)))
                        {
                            MessageBox.Show("Suspended Sucessfully");
                            _RefreshDatainDGrid();
                            _RefreshSuspendedDGrid();
                            
                        }



                    }

                }
            

            
        }

        private void resumeToolStripMenuItem_Click(object sender, EventArgs e)
        {
           if(MessageBox.Show("Are you sure want to resume this Subscription?","",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
            {
                SuspendSub_frm form = new SuspendSub_frm(Convert.ToInt16(SuspendSubList_DGrid.CurrentRow.Cells[0].Value));
                form.ShowDialog();
                _RefreshSuspendedDGrid();
                _RefreshDatainDGrid();

            }
         }
    }
}