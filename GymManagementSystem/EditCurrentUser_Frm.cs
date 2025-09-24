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
    public partial class EditCurrentUser_Frm : Form
    {
        public EditCurrentUser_Frm()
        {
            InitializeComponent();
        }

        private void EditCurrentUser_Frm_Load(object sender, EventArgs e)
        {
            UserName_Txt.Text=Settings.CurrentUser.UserName;
            Password_Txt.Text=Settings.CurrentUser.Password;

        }

        private void Edit_Btn_Click(object sender, EventArgs e)
        {
            
            Settings.CurrentUser.UserName = UserName_Txt.Text;
            Settings.CurrentUser.Password = Password_Txt.Text;
            if(Settings.CurrentUser.Save())
            {
                MessageBox.Show("Edited Sucessfully");
                
            }
        }
    }
}
