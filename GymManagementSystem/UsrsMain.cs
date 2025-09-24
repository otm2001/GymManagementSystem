using BusinessLayerGymSystem;
using Microsoft.VisualBasic.ApplicationServices;
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
    public partial class UsrsMain : Form
    {

        private void _RefrshUsersDataGrid()
        {
            UsersList_DGrid.DataSource=BusinessLayerGymSystem.User.GetAllUsersDetails();
                
        }
        public UsrsMain()
        {
            InitializeComponent();
        }

        private void UsrsMain_Load(object sender, EventArgs e)
        {
            _RefrshUsersDataGrid();
        }

        private void AddNewUser_Save_Click(object sender, EventArgs e)
        {
            AddUpdateUser_Frm UserFrm = new AddUpdateUser_Frm(-1);
            UserFrm.ShowDialog();
        }

        private void Edit_User_Click(object sender, EventArgs e)
        {

            AddUpdateUser_Frm UserFrm = new AddUpdateUser_Frm(Convert.ToInt16(UsersList_DGrid.CurrentRow.Cells[0].Value));
            UserFrm.ShowDialog();
        }
    }
}
