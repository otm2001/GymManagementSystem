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
    public partial class AddUpdateSubscription_frm : Form
    {
        private enum enMode
        {
            addNew,
            Update
        }

        private enMode Mode = enMode.addNew;
        private enum enSubTypeMode
        {
            Monthly,
            Daily
        }
        private enSubTypeMode SubTypeMode = enSubTypeMode.Monthly;

        private Subscription subscription;
        

        private int SubID;
        public AddUpdateSubscription_frm(int SubID)
        {
            InitializeComponent();

            if (SubID != -1)
            {
                Mode = enMode.Update;
                this.SubID = SubID;
            }

        }

        private void _FillGamesComboBoxData()
        {
            DataTable dt = Game.GetAllGames();
            foreach (DataRow dr in dt.Rows)
            {

                Game_ComboBox.Items.Add(dr["GameName"]);

            }
        }

        private void _FillSubDataInBoxes()
        {
            this.subscription = Subscription.Find(SubID);
          

            SubIDTxt.Text = subscription.SubscriptionID.ToString();
            MemberID_Txt.Text = subscription.MemberID.ToString();
            Game_ComboBox.SelectedIndex = Game_ComboBox.FindString(Game.Find(subscription.GameID).GameName);
            CoachesComboBox.SelectedIndex = CoachesComboBox.FindString(Coach.FindByID(subscription.CoachID).Name);

            if (subscription.SubscriptionsType == 'M')
            {
                SubTypeMode = enSubTypeMode.Monthly;
                SubscriptionsTypeComboBox.SelectedIndex = 1;
            }
            else
            {
                SubTypeMode = enSubTypeMode.Daily;
                SubscriptionsTypeComboBox.SelectedIndex = 0;
            }

            NumericUpDown_Days.Value = subscription.Numberofdays;

            Start_DatePicker.Value = subscription.StartDate;
            EndDatePicker.Value = subscription.EndDate;

            Calcolate_Btn.PerformClick();

            AmountTxt.Text = subscription.Payment.Amount.ToString();



        }
        private void _FillCoachesCombBoxData(string GameName)
        {
            CoachesComboBox.Items.Clear();
            DataTable dt = Coach.GetAllCoachesWithFilterGameName(GameName);

            foreach (DataRow dr in dt.Rows)
            {

                CoachesComboBox.Items.Add(dr["Name"]);

            }
        }
        private void _Collect_SubInfo_FromBoxes()
        {
            subscription.MemberID = Convert.ToInt16(MemberID_Txt.Text);
            subscription.GameID = Game.FindByName(Game_ComboBox.Text).GameID;
            subscription.CoachID = Convert.ToInt16(Coach.FindByName(CoachesComboBox.Text).CoachID);
            if (SubTypeMode == enSubTypeMode.Daily)
                subscription.SubscriptionsType = 'D';
            else subscription.SubscriptionsType = 'M';
            subscription.Numberofdays = Convert.ToInt16(NumericUpDown_Days.Value);
            subscription.StartDate = Start_DatePicker.Value;
            subscription.EndDate = EndDatePicker.Value;
            subscription.Fee = Convert.ToSingle(Fee_TextBox.Text);
            subscription.Payment.Amount = Convert.ToSingle(AmountTxt.Text);
            subscription.Payment.MemberID = subscription.MemberID;
             subscription.Payment.Date = DateTime.Now;


        }
        private void AddUpdateSubscription_frm_Load(object sender, EventArgs e)
        {
            _FillGamesComboBoxData();

            if (Mode == enMode.Update)
            {
                _FillSubDataInBoxes();
                TitleLable.Text = "Edit Subscription";
            }

        }

        private void SubscriptionsTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (SubscriptionsTypeComboBox.SelectedIndex == 0)//Daily
            {
                SubTypeMode = enSubTypeMode.Daily;
                NumericUpDown_Days.Enabled = true;
            }
            else
            {
                SubTypeMode = enSubTypeMode.Monthly;
                NumericUpDown_Days.Value = 30;
                NumericUpDown_Days.Enabled = false;
            }
        }

        private void Game_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            _FillCoachesCombBoxData(Game_ComboBox.Text);
        }

        private void AddMemberBtn_Click(object sender, EventArgs e)
        {
            AddUpdateMember_frm Form = new AddUpdateMember_frm(-1);
            Form.ShowDialog();
        }



        private void Start_DatePicker_ValueChanged(object sender, EventArgs e)
        {

            DateTime dateTime = Convert.ToDateTime(Start_DatePicker.Value);
            dateTime = dateTime.AddDays(Convert.ToInt16(NumericUpDown_Days.Value));
            EndDatePicker.Value = dateTime;


        }

        private void Calcolate_Btn_Click(object sender, EventArgs e)
        {
            Game game = Game.FindByName(Game_ComboBox.Text);

            if (SubTypeMode == enSubTypeMode.Monthly)
            {
                Fee_TextBox.Text = game.MonthlyFee.ToString();
            }
            else
            {
                Fee_TextBox.Text = (Convert.ToInt16(NumericUpDown_Days.Value) * game.DailyFee).ToString();
            }
        }

        private void Btn_Save_Click(object sender, EventArgs e)
        {
            if (Mode == enMode.Update)
            {
                if (MessageBox.Show("Are You Sure Want to Update this Subscription", "Update Subscription", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                   _Collect_SubInfo_FromBoxes();

                    if(subscription.Save())
                    {
                        MessageBox.Show("Subscription Updated Successfully", "Updated Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }



                }
            }

            else
            {
                subscription=new Subscription();
                

                _Collect_SubInfo_FromBoxes();

                
                    if (subscription.Save())
                    {
                        MessageBox.Show("Subscription Added Successfully", "Added Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        SubIDTxt.Text = subscription.SubscriptionID.ToString();
                     TitleLable.Text = "Edit Subscription";
                }
                
            }
        }

        private void Btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
