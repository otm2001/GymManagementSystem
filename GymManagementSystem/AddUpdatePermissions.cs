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
    public partial class AddUpdatePermissions : Form
    {
        static public long _Permissions=0;

        enum enMode
        {
            Addnew,
            Update
        }
        private enMode Mode = enMode.Addnew;
        public AddUpdatePermissions(long Permissions)
        {
            InitializeComponent();
            if (Permissions != 0)
            {

                Mode = enMode.Update;
               _Permissions=Permissions;

            }
        }

        private void guna2GroupBox5_Click(object sender, EventArgs e)
        {

        }


        //










        private void AllPermission_checkBox_CheckedChanged_1(object sender, EventArgs e)
        {
        }

        private void AllMembers_Permission_CheckBox_CheckedChanged_1(object sender, EventArgs e)
        {
           
        }

        private void AllCoachesPermissions_CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void AllGamesPermission_CheckBox_CheckedChanged_1(object sender, EventArgs e)
        {

        }

        private void AllUsersPermissions_CheckBox_CheckedChanged_1(object sender, EventArgs e)
        {
        
        }

        private void AllSubscriptionsPermissions_CheckBox_CheckedChanged_1(object sender, EventArgs e)
        {
        }

        private void Ok_Btn_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
        private void _loadDataToCheckBoxes()
        {
           
        }
        private void AddUpdatePermissions_Load(object sender, EventArgs e)
        {
           
        }
    }
}
