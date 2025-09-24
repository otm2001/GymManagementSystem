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
    public partial class MainForm : Form
    {
        private Form CurrentForm = null;
        
        private void OpenChildForm(Form childForm)
        {

            if (CurrentForm != null)
            {
                CurrentForm.Close();
            }
            CurrentForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel.Controls.Add(childForm);
            panel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();


        }

        private void _showLockedScreen()
        {
            Locked_Frm locked_Frm = new Locked_Frm();
            
            OpenChildForm(locked_Frm);

        }

        public MainForm()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            
            Main_Btn.PerformClick();
          


        }
        private void Members_Btn_Click(object sender, EventArgs e)
        {
            
                MainMembers_frm Form = new MainMembers_frm();
                OpenChildForm(Form);
            
            

           
        }

        private void Games_Btn_Click(object sender, EventArgs e)
        {
           
        }

        private void Coaches_Btn_Click(object sender, EventArgs e)
        {
            
                MainCoaches_frm Form = new MainCoaches_frm();
                OpenChildForm(Form);
               
            
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            
                SubscriptionsMain Form = new SubscriptionsMain();
                OpenChildForm(Form);
             
          
        }

        private void User_Btn_Click(object sender, EventArgs e)
        {
            EditCurrentUser_Frm Form = new EditCurrentUser_Frm();
            OpenChildForm(Form);
           
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
          
        }

        private void ExpensesBtn_Click(object sender, EventArgs e)
        {
            

        }

        private void games_btn_Click_1(object sender, EventArgs e)
        {
            
                GameMain_frm Form = new GameMain_frm();
                OpenChildForm(Form);
              
           
        }

        private void Payments_Btn_Click(object sender, EventArgs e)
        {
            PaymentsMain form = new PaymentsMain();
            OpenChildForm(form);
           
        }

        private void EmployeesBtn_Click(object sender, EventArgs e)
        {
            MainEmployees Form = new MainEmployees();
            OpenChildForm(Form);
 
        }

        private void UsersBtn_Click(object sender, EventArgs e)
        {
            //UsrsMain form = new UsrsMain();
            //OpenChildForm(form);
        }

        private void Main_Btn_Click(object sender, EventArgs e)
        {
            Main main = new Main();
            OpenChildForm(main);
        }

        private void FinancialTransactionsBtn_click(object sender, EventArgs e)
        {
            FinancialTransactionsFrm frm = new FinancialTransactionsFrm();
            OpenChildForm(frm);
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

           // timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (guna2Button1.Checked)
            {
                panel_side.Width += 10;
                this.Width += 10;

                if (panel_side.Width >= 342)
                {

                    timer1.Stop();
                }
            }
            else
            {

                panel_side.Width -= 10;
                this.Width -= 10;
                if (panel_side.Width == 62)
                {

                    timer1.Stop();
                }
            }


        }

        private void panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel_Resize(object sender, EventArgs e)
        {

        }

        private void MainForm_Resize(object sender, EventArgs e)
        {
           

        }
        private void FrmInvoices_HandleCreated(object sender, EventArgs e)
        {
            
        }
    }
}
