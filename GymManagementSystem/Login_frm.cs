using BusinessLayerGymSystem;
using Guna.UI2.WinForms;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GymManagementSystem
{
    public partial class Login_frm : Form
    {
        public Login_frm()
        {
            InitializeComponent();
        }

       
        private void Login_Btn_Click(object sender, EventArgs e)
        {
            
            if(BusinessLayerGymSystem.User.Login(UserName_Txt.Text,Password_Txt.Text))
            {
                Settings.CurrentUser = BusinessLayerGymSystem.User._Find(UserName_Txt.Text);
                
                MainForm Main=new MainForm();
                this.Hide();
                Main.ShowDialog();
                this.Close();
                
                
            }
            else
            {
                label_IncorrectMessage.Text = "Incorrect UserName or Password.";
                UserName_Txt.Text = string.Empty;
                Password_Txt.Text = string.Empty;
                UserName_Txt.BorderColor = Color.Red;
                Password_Txt.BorderColor = Color.Red;
            }
            
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            
        }

        private void Hide_btn_Click(object sender, EventArgs e)
        {
           
        }

        private void Password_Txt_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void Login_frm_Load(object sender, EventArgs e)
        {

        }

        private void HideShowPass_btn_Click(object sender, EventArgs e)
        {
            if(HideShowPass_btn.Checked)
            {  
                Password_Txt.UseSystemPasswordChar = false;
                HideShowPass_btn.Image = Properties.Resources.show__1_;
          
            }
            else
            {
                    Password_Txt.UseSystemPasswordChar = true;
                HideShowPass_btn.Image = Properties.Resources.hide__1_;
            }
        }

        private void UserName_Txt_MouseHover(object sender, EventArgs e)
        {

           
        }

        private void UserName_Txt_MouseEnter(object sender, EventArgs e)
        {
           
        }

        private void Login_Btn_MouseHover(object sender, EventArgs e)
        {
            ToolTip1.Show("Login", Login_Btn);
        }

        private void Close_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
