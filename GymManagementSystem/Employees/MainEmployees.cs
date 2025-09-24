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
    public partial class MainEmployees : Form
    {
        public MainEmployees()
        {
            InitializeComponent();
        }

        private void _RefrshEmployeeData()
        {
            EmployeesList_DGrid.DataSource = Employee.GetEmployeesDetails();
            
            
        }

        private bool _DeleteEmployee(int EmployeeID)
        {
            Employee employee = Employee.FindByID(EmployeeID);

            if (employee != null)
            {
                if (MessageBox.Show("Are you sure want to delete this Employee?", "Delete Employee", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (employee.Job.JobRoleID != 1)
                    {
                        if (Employee.Delete(EmployeeID))
                        {
                            MessageBox.Show("Employee deleted Sucessfully");
                            return true;
                        }
                    }

                    else
                    {
                        Coach coach = Coach.FindByEmployeeID(EmployeeID);
                        if (coach != null)
                        {
                            if (Coach.Delete(coach.CoachID))
                            {
                                MessageBox.Show("Employee deleted Sucessfully");
                                return true;
                            }
                        }
                    }

                }
             

            }
                return false;
        }

        private void EditEmployee()
        {
            addUpdateEmployee_frm from = new addUpdateEmployee_frm(Convert.ToInt16(EmployeesList_DGrid.CurrentRow.Cells[0].Value));
            from.ShowDialog();
            _RefrshEmployeeData();
        }

        private void MainEmployees_Load(object sender, EventArgs e)
        {
          _RefrshEmployeeData();
        }

        private void Btn_Add_Click(object sender, EventArgs e)
        {
            addUpdateEmployee_frm from = new addUpdateEmployee_frm(-1);
            from.ShowDialog();
            _RefrshEmployeeData();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
         
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            EditEmployee();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditEmployee();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_DeleteEmployee(Convert.ToInt16(EmployeesList_DGrid.CurrentRow.Cells[0].Value)))
            {
                _RefrshEmployeeData();
            }
        }

        private void paySalaryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
                PaySalary_frm form = new PaySalary_frm(Convert.ToInt16(EmployeesList_DGrid.CurrentRow.Cells[0].Value));
                form.ShowDialog();
            
        }
    }
}
