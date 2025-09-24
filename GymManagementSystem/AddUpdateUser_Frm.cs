using BusinessLayerGymSystem;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace GymManagementSystem
{
    public partial class AddUpdateUser_Frm : Form
    {
        enum enMode
        {
            AddNewUser,
            UpdateUser
        }

        private enMode Mode= enMode.AddNewUser;
        private User user;
        private int UserID;
        public AddUpdateUser_Frm(int UserID)
        {
            InitializeComponent();
            if(UserID!=-1)
            {
                Mode = enMode.UpdateUser;
                this.UserID = UserID;
            }
        }

        private void _loadPermissionstoCheckBoxes()
        {
            if(user.Permissions==-1)
            {
                AllPermission_checkBox.Checked = true;
            }

            else
            {
                if(user.CheckPermissions(User.enPermissions.MembersScreen))
                    MemberMain_checkBox.Checked = true;

                 if(user.CheckPermissions(User.enPermissions.AddNewMember))
                    AddNewMember_checkBox.Checked = true;

                if(user.CheckPermissions(User.enPermissions.UpdateMember))
                    UpdateMember_checkBox.Checked = true;

                 if(user.CheckPermissions(User.enPermissions.DeleteMember))
                    DeleteMember_checkBox.Checked = true;
                

                 if(user.CheckPermissions(User.enPermissions.CoachScreen))
                    CoachesMain_CheckBox.Checked = true;

                 if(user.CheckPermissions(User.enPermissions.AddNewCoach))
                    AddNewCoach_checkBox.Checked= true;

               if(user.CheckPermissions(User.enPermissions.UpdateCoach))
                    UpdateCoach_checkBox.Checked=true;

                if(user.CheckPermissions(User.enPermissions.DeleteCoach))
                    DeleteCoach_checkBox.Checked = true;


                if (user.CheckPermissions(User.enPermissions.SubscriptionScreen))
                    SubscriptionsMain_checkBox.Checked = true;

                if(user.CheckPermissions(User.enPermissions.AddNewSubscription))
                    AddnewSubscriptions_checkBox.Checked = true;

                 if(user.CheckPermissions(User.enPermissions.UpdateSubscription))
                    UpdateSubscriptions_checkBox.Checked = true;

                 if(user.CheckPermissions(User.enPermissions.DeleteSubscription))
                    DeleteSubscriptions_checkBox.Checked = true;

                 if(user.CheckPermissions(User.enPermissions.SuspendSubscription))
                    SuspendSubscription_checkBox.Checked = true;


                 if(user.CheckPermissions(User.enPermissions.GamesScreen))
                    MainGmaescheckBox.Checked = true;

                 if(user.CheckPermissions(User.enPermissions.AddNewGame))
                    AddNewGame_checkBox.Checked = true;

                 if (user.CheckPermissions(User.enPermissions.UpdateGame))
                    UpdateGame_checkBox.Checked = true;

                 if(user.CheckPermissions(User.enPermissions.DeleteGame))
                    DeleteGame_checkBox.Checked = true;


                 if(user.CheckPermissions(User.enPermissions.UsersScreen))
                    UsersMaincheckBox.Checked = true;

                 if(user.CheckPermissions(User.enPermissions.AddNewUser))
                    AddNewUser_checkBox.Checked = true;

                 if(user.CheckPermissions(User.enPermissions.UpdateUser))
                    UpdateUser_checkBox.Checked = true;

                 if (user.CheckPermissions(User.enPermissions.DeleteUser))
                    DeleteUser_checkBox.Checked = true;

                if (user.CheckPermissions(User.enPermissions.EmployeesScreen))
                    MainEmployees_checkBox.Checked = true;

                if (user.CheckPermissions(User.enPermissions.AddNewEmployee))
                    AddNewEmployee_Checkbox.Checked = true;

                if (user.CheckPermissions(User.enPermissions.UpdateEmployee))
                    UpdateEmpensecheckBox.Checked = true;

                if (user.CheckPermissions(User.enPermissions.DeleteEmployee))
                    DeleteEmpensecheckBox.Checked = true;

                if (user.CheckPermissions(User.enPermissions.payEmployeesSalaries))
                    PaySalarycheckBox.Checked = true;

                if (user.CheckPermissions(User.enPermissions.ExpensesScreen))
                    MainExpenses_checkBox.Checked = true;

                if (user.CheckPermissions(User.enPermissions.AddNewExpense))
                    AddnewExpense_checkBox.Checked = true;

                if (user.CheckPermissions(User.enPermissions.DeleteExpense))
                    DeleteEmpensecheckBox .Checked = true;

                if (user.CheckPermissions(User.enPermissions.UpdateExpense))
                    DeleteEmpensecheckBox.Checked = true;



            }

        }
        private void _CollectPermissionsToSave()
        {
            if (AllPermission_checkBox.Checked)
                user.Permissions = -1;

            else
            {
                user.Permissions = 0;

                if (MemberMain_checkBox.Checked)
                    user.Permissions = user.Permissions + (long)User.enPermissions.MembersScreen;

                if(AddNewMember_checkBox.Checked)
                    user.Permissions= user.Permissions + (long)User.enPermissions.AddNewMember;

                if (UpdateMember_checkBox.Checked)
                    user.Permissions = user.Permissions + (long)User.enPermissions.UpdateMember;

                if (DeleteMember_checkBox.Checked)
                    user.Permissions = user.Permissions + (long)User.enPermissions.DeleteMember;

                if(CoachesMain_CheckBox.Checked)
                    user.Permissions = user.Permissions + (long)User.enPermissions.CoachScreen;

                if (AddNewCoach_checkBox.Checked)
                    user.Permissions = user.Permissions + (long)User.enPermissions.AddNewCoach;

                if (UpdateCoach_checkBox.Checked)
                    user.Permissions = user.Permissions + (long)User.enPermissions.UpdateCoach;

                if (DeleteCoach_checkBox.Checked)
                    user.Permissions = user.Permissions + (long)User.enPermissions.DeleteCoach;

                if(SubscriptionsMain_checkBox.Checked)
                    user.Permissions = user.Permissions + (long)User.enPermissions.SubscriptionScreen;

                if (AddnewSubscriptions_checkBox.Checked)
                    user.Permissions = user.Permissions + (long)User.enPermissions.AddNewSubscription;

                if (UpdateSubscriptions_checkBox.Checked)
                    user.Permissions = user.Permissions + (long)User.enPermissions.UpdateSubscription;

                if (DeleteSubscriptions_checkBox.Checked)
                    user.Permissions = user.Permissions + (long)User.enPermissions.DeleteSubscription;

                if (SuspendSubscription_checkBox.Checked)
                    user.Permissions = user.Permissions + (long)User.enPermissions.SuspendSubscription;

                if(MainGmaescheckBox.Checked)
                    user.Permissions = user.Permissions + (long)User.enPermissions.GamesScreen;

                if (AddNewGame_checkBox.Checked)
                    user.Permissions = user.Permissions + (long)User.enPermissions.AddNewGame;

                if (UpdateGame_checkBox.Checked)
                    user.Permissions = user.Permissions + (long)User.enPermissions.UpdateGame;

                if (DeleteGame_checkBox.Checked)
                    user.Permissions = user.Permissions + (long)User.enPermissions.DeleteGame;

                if (UsersMaincheckBox.Checked)
                    user.Permissions = user.Permissions + (long)User.enPermissions.UsersScreen;

                if (AddNewUser_checkBox.Checked)
                    user.Permissions = user.Permissions + (long)User.enPermissions.AddNewUser;

                if (UpdateUser_checkBox.Checked)
                    user.Permissions = user.Permissions + (long)User.enPermissions.UpdateUser;

                if (DeleteUser_checkBox.Checked)
                    user.Permissions = user.Permissions + (long)User.enPermissions.DeleteUser;

                if (MainEmployees_checkBox.Checked)
                    user.Permissions = user.Permissions + (long)User.enPermissions.EmployeesScreen;

                if (AddNewEmployee_Checkbox.Checked)
                    user.Permissions = user.Permissions + (long)User.enPermissions.AddNewEmployee;

                if (UpdateEmpensecheckBox.Checked)
                    user.Permissions = user.Permissions + (long)User.enPermissions.UpdateEmployee;

                if (DeleteEmpensecheckBox.Checked)
                    user.Permissions = user.Permissions + (long)User.enPermissions.DeleteEmployee;

                if (MainExpenses_checkBox.Checked)
                    user.Permissions = user.Permissions + (long)User.enPermissions.ExpensesScreen;

                if (AddnewExpense_checkBox.Checked)
                    user.Permissions = user.Permissions + (long)User.enPermissions.AddNewExpense;

                if (UpdateEmpensecheckBox.Checked)
                    user.Permissions = user.Permissions + (long)User.enPermissions.UpdateExpense;

                if (DeleteEmpensecheckBox.Checked)
                    user.Permissions = user.Permissions + (long)User.enPermissions.DeleteExpense;

                if (PaySalarycheckBox.Checked)
                    user.Permissions = user.Permissions + (long)User.enPermissions.payEmployeesSalaries;



            }
        }
        private void LoadData()
        {
            user = User.FindByID(UserID);

            UserID_TextBox.Text = user.UserID.ToString();
            EmployeeID_Txt.Text=user.EmployeeID.ToString();
            UserName_TextBox.Text = user.UserName;
            Password_TextBox.Text=user.Password;

            _loadPermissionstoCheckBoxes();

        }

        private void _CollectDataToSave()
        {
           
            user.EmployeeID =Convert.ToInt16(EmployeeID_Txt.Text);
            user.UserName= UserName_TextBox.Text;
            user.Password= Password_TextBox.Text;
            _CollectPermissionsToSave();
        }
        private void AddUpdateUser_Frm_Load(object sender, EventArgs e)
        {
            if(Mode==enMode.UpdateUser)
            {
                LoadData();
            }

            
        }

        private void guna2CheckBox5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void AllMemberPermissions_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void AllMembers_Permission_CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (AllMembers_Permission_CheckBox.Checked)
            {
                MemberMain_checkBox.Checked = true;
                MemberMain_checkBox.Enabled = false;

                AddNewMember_checkBox.Checked = true;
                AddNewMember_checkBox.Enabled = false;

                UpdateMember_checkBox.Checked = true;
                UpdateMember_checkBox.Enabled = false;

                DeleteMember_checkBox.Checked = true;
                DeleteMember_checkBox.Enabled=false;
            }
            else
            {
                MemberMain_checkBox.Checked = false;
                MemberMain_checkBox.Enabled = true;

                AddNewMember_checkBox.Checked = false;
                AddNewMember_checkBox.Enabled = true;

                UpdateMember_checkBox.Checked = false; 
                DeleteMember_checkBox.Checked = true;

                DeleteMember_checkBox.Checked = false;
                 DeleteMember_checkBox.Enabled = false;
            }
        }

        private void AllCoachesPermissions_CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if(AllCoachesPermissions_CheckBox.Checked)
            {
                CoachesMain_CheckBox.Checked = true;
                CoachesMain_CheckBox.Enabled = false;
                AddNewCoach_checkBox.Checked = true;
                AddNewCoach_checkBox.Enabled = false;
                UpdateCoach_checkBox.Checked = true;
                UpdateCoach_checkBox.Enabled = false;
                DeleteCoach_checkBox.Checked = true;
                DeleteCoach_checkBox.Enabled = false;
            }
            else
            {
                CoachesMain_CheckBox.Checked= false;
                CoachesMain_CheckBox.Enabled = true;
                AddNewCoach_checkBox.Checked= false;
                AddNewCoach_checkBox.Enabled = true;
                UpdateCoach_checkBox.Checked= false;
                UpdateCoach_checkBox.Enabled = true;
                DeleteCoach_checkBox.Checked = false;
                DeleteCoach_checkBox.Enabled = true;
            }
        }

        private void AllSubscriptionsPermissions_CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (AllSubscriptionsPermissions_CheckBox.Checked)
            {
                SubscriptionsMain_checkBox.Checked = true;
                SubscriptionsMain_checkBox.Enabled = false;

                AddnewSubscriptions_checkBox.Checked = true;
                AddnewSubscriptions_checkBox.Enabled= false;

                DeleteSubscriptions_checkBox.Checked = true;
                DeleteSubscriptions_checkBox.Enabled = false;

                UpdateSubscriptions_checkBox.Checked= true;
                UpdateSubscriptions_checkBox.Enabled = false;

                SuspendSubscription_checkBox.Checked = true;
                SuspendSubscription_checkBox.Enabled=false;
            }

            else
            {
                SubscriptionsMain_checkBox.Checked= false;
                SubscriptionsMain_checkBox.Enabled = true;

                AddnewSubscriptions_checkBox.Checked= false;
                AddnewSubscriptions_checkBox.Enabled= true;

                DeleteSubscriptions_checkBox.Checked= false;
                DeleteSubscriptions_checkBox.Enabled= true;

                UpdateSubscriptions_checkBox.Checked= false;
                UpdateSubscriptions_checkBox.Enabled = true;   

                SuspendSubscription_checkBox.Checked= false;
                SuspendSubscription_checkBox.Enabled = true;

            }
        }

        private void AllGamesPermission_CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if(AllGamesPermission_CheckBox.Checked)
            {
                MainGmaescheckBox.Checked = true;
                MainGmaescheckBox.Enabled = false;

                AddNewGame_checkBox.Checked= true;
                AddNewGame_checkBox.Enabled= false;

                DeleteGame_checkBox.Checked= true;
                DeleteGame_checkBox.Enabled= false;

                UpdateGame_checkBox.Checked= true;
                UpdateGame_checkBox.Enabled = false;
            }

            else
            {
                MainGmaescheckBox.Checked = false;
                MainGmaescheckBox.Enabled = true;

                AddNewGame_checkBox.Checked = false;
                AddNewGame_checkBox.Enabled = true;

                DeleteGame_checkBox.Checked = false;
                DeleteGame_checkBox.Enabled = true;

                UpdateGame_checkBox.Checked = false;
                UpdateGame_checkBox.Enabled = true;
            }
        }

        private void AllUsersPermissions_CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (AllUsersPermissions_CheckBox.Checked)
            {
                UsersMaincheckBox.Checked = true;
                UsersMaincheckBox.Enabled = false;

                AddNewUser_checkBox.Checked = true;
                AddNewUser_checkBox.Enabled = false;

                DeleteUser_checkBox.Checked = true;
                DeleteUser_checkBox.Enabled = false;

                UpdateUser_checkBox.Checked = true;
                UpdateUser_checkBox.Enabled = false;






            }
            else
            {
                UsersMaincheckBox.Checked= false;
                UsersMaincheckBox.Enabled = true;

                AddNewUser_checkBox.Checked= false;
                AddNewUser_checkBox.Enabled = true;

                DeleteUser_checkBox.Checked = false;
                DeleteUser_checkBox.Enabled = true;

                UpdateUser_checkBox.Checked = false;
                UpdateUser_checkBox.Enabled = true;



            }
        }

        private void AllPermission_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (AllPermission_checkBox.Checked)
            {
                AllMembers_Permission_CheckBox.Checked = true;
                AllCoachesPermissions_CheckBox.Checked = true;
                AllSubscriptionsPermissions_CheckBox.Checked = true;
                AllGamesPermission_CheckBox.Checked = true;
                AllUsersPermissions_CheckBox.Checked = true;
                AllEmployeesPermissions_CheckBox.Checked = true;
                AllExpensesPermissions_checkBox.Checked = true;



            }
            else
            {
                AllMembers_Permission_CheckBox.Checked= false;
                AllCoachesPermissions_CheckBox.Checked = false;
                AllSubscriptionsPermissions_CheckBox.Checked= false;
                AllGamesPermission_CheckBox.Checked = false;
                AllUsersPermissions_CheckBox.Checked= false;
                AllEmployeesPermissions_CheckBox.Checked = false;
                AllExpensesPermissions_checkBox.Checked = false;

            }
        }

        private void Next_btn_Click(object sender, EventArgs e)
        {
           
        }

        private void Btn_Save_Click(object sender, EventArgs e)
        {
            if(Mode==enMode.AddNewUser)
            {
                user=new User();
                _CollectDataToSave();
                if(user.Save())
                {
                    MessageBox.Show("Added Sucsessfully");
                    Mode = enMode.UpdateUser;
                }
            }
            else
            {
                _CollectDataToSave();
                if(user.Save())
                    MessageBox.Show("Updated Sucsessfully");
            }

        }

        private void Personal_InfoTab_Click(object sender, EventArgs e)
        {

        }

        private void AddNewEmployeeBtn_Click(object sender, EventArgs e)
        {
           MainEmployees mainEmployees = new MainEmployees();
            mainEmployees.ShowDialog();
        }

        private void AllExpensesPermissions_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (AllExpensesPermissions_checkBox.Checked)
            {
                MainExpenses_checkBox.Checked = true;
                MainExpenses_checkBox.Enabled=false;

                AddnewExpense_checkBox.Checked = true;
                AddnewExpense_checkBox.Enabled = false;

                UpdateEmpensecheckBox.Checked = true;
                UpdateEmpensecheckBox.Enabled = false;

                DeleteEmpensecheckBox.Checked=true;
                DeleteEmpensecheckBox.Enabled=false;

            }

            else
            {
                MainExpenses_checkBox.Checked = false;
                MainExpenses_checkBox.Enabled = true;

                AddnewExpense_checkBox.Checked = false;
                AddnewExpense_checkBox.Enabled = true;

                UpdateEmpensecheckBox.Checked = false;
                UpdateEmpensecheckBox.Enabled = true;

                DeleteEmpensecheckBox.Checked = false;
                DeleteEmpensecheckBox.Enabled = true;
            }
        }

        private void AllEmployeesPermissions_CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (AllEmployeesPermissions_CheckBox.Checked)
            {
                MainEmployees_checkBox.Checked = true;
                MainEmployees_checkBox.Enabled = false;

                AddNewEmployee_Checkbox.Checked = true;
                AddNewEmployee_Checkbox.Enabled = false;

                UpdateEmployee_checkBox.Checked = true;
                UpdateEmployee_checkBox.Enabled = false;

                DeleteEmployeecheckBox.Checked = true;
                DeleteEmployeecheckBox.Enabled = false;

                PaySalarycheckBox.Checked = true;
                PaySalarycheckBox.Enabled = false;



            }

            else
            {
                MainEmployees_checkBox.Checked = false;
                MainEmployees_checkBox.Enabled = true;

                AddNewEmployee_Checkbox.Checked = false;
                AddNewEmployee_Checkbox.Enabled = true;

                UpdateEmployee_checkBox.Checked = false;
                UpdateEmployee_checkBox.Enabled = true;

                DeleteEmployeecheckBox.Checked = false;
                DeleteEmployeecheckBox.Enabled = true;

                PaySalarycheckBox.Checked = false;
                PaySalarycheckBox.Enabled = true;



            }
        }

        private void PersonalInfoTabPage_Click(object sender, EventArgs e)
        {

        }

        private void Next_btn_Click_1(object sender, EventArgs e)
        {
            UsrsTabControl.SelectedTab=PermissionsTabPage;
        }
    }
}
