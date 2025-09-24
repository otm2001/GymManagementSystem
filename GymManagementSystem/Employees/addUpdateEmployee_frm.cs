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
    public partial class addUpdateEmployee_frm : Form
    {
        private enum enPicture
        {
            DefaultPic,
            CustomPic
        }

        enPicture PicMode=enPicture.DefaultPic;

        private DialogResult _ShowAddImage()
        {
            openFileDialog1.Title = "Add Image";
            openFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.tif;...";

            DialogResult result= openFileDialog1.ShowDialog();

            if (result == DialogResult.OK)
            {
                Employee_PictureBox.Image = Image.FromFile(openFileDialog1.FileName);
                Employee_PictureBox.Tag = openFileDialog1.FileName;
                PicMode=enPicture.CustomPic;
                RemoveImage_Btn.Visible = true;
            }

            return result;
        }
        private void RemoveImage()
        {
            Employee_PictureBox.Image = Properties.Resources.employeeDefultPic;
            RemoveImage_Btn.Visible=false;
            PicMode = enPicture.DefaultPic;
        }

        Settings.enMode Mode=Settings.enMode.AddNew;
        private int EmployeeID;

        private Employee employee;
        public addUpdateEmployee_frm(int EmployeeID)
        {
            InitializeComponent();

            if(EmployeeID != -1)
            {
                Mode = Settings.enMode.Update;
                this.EmployeeID = EmployeeID;
            }
           
        }

        private void FillJobsComboBox()
        {
          DataTable dt=  Employee.JobRole.GetAllJobRoles();
            foreach (DataRow dr in dt.Rows)
            {
                if (dr["jobRoleName"].ToString() != "Coach")
                Jobs_ComboBox.Items.Add(dr["jobRoleName"].ToString());

            }
        }

        private void CollectDataToSave()
        {
            employee.Name=EmployeeName_TextBox.Text;
            employee.Job = Employee.JobRole.FindByJobName(Jobs_ComboBox.Text);
            employee.Phone=Phone_Txt.Text;
            employee.DateOfBirth = DateOFBirth_DataPicker.Value;
            employee.Salary=Convert.ToSingle(SalaryTextBox.Text);
            employee.isActive=Switch_IsActive.Checked;
            if (Male_RBtn.Checked)
                employee.Gender = 'M';
            else
                employee.Gender = 'F';

            employee.Email = Email_Txt.Text;
            employee.Address = Address_Txt.Text;

            if (PicMode == enPicture.CustomPic)
                employee.ImagePath =Convert.ToString(Employee_PictureBox.Tag);
            else
            {
                employee.ImagePath = "";
            }

        }

        private void LoadDataInTextBoxses()
        {
            employee=Employee.FindByID(this.EmployeeID);

            EmployeeID_Txt.Text=employee.EmployeeID.ToString();
            EmployeeName_TextBox.Text = employee.Name;

            Jobs_ComboBox.SelectedIndex=Jobs_ComboBox.FindString(employee.Job.JobRoleName);
            SalaryTextBox.Text = employee.Salary.ToString();

            if(Jobs_ComboBox.SelectedIndex==0)
                Jobs_ComboBox.Enabled=false;

            Phone_Txt.Text = employee.Phone;
            DateOFBirth_DataPicker.Value=employee.DateOfBirth;
            Switch_IsActive.Checked=employee.isActive;


            if (employee.Gender == 'M')
                Male_RBtn.Checked = true;
            else
                Female_RBtn.Checked = true;
            Email_Txt.Text = employee.Email;
            Address_Txt.Text = employee.Address;

            if (employee.ImagePath != "")
            {
                Employee_PictureBox.Image = Image.FromFile(employee.ImagePath);
                Employee_PictureBox.Tag=employee.ImagePath;
                RemoveImage_Btn.Visible = true;
            }

        }

        private void exit_Btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addUpdateEmployee_frm_Load(object sender, EventArgs e)
        {
            FillJobsComboBox();
            if (Mode == Settings.enMode.Update)
            {
                TitleLable.Text = "Edit Employee";
                LoadDataInTextBoxses();
            }
        }

        private void Btn_Save_Click(object sender, EventArgs e)
        {
            if (Mode == Settings.enMode.Update)
            {
                CollectDataToSave();
                if (employee.Save())
                    MessageBox.Show("Employee Update Successfully");

            }
            else
            {
                employee=new Employee();
                CollectDataToSave();
                if (employee.Save())
                {
                    MessageBox.Show("Employee Added Successfully");
                    EmployeeID_Txt.Text=employee.EmployeeID.ToString();
                }
            }
        }

        private void SetImage_Btn_Click(object sender, EventArgs e)
        {
            _ShowAddImage();
        }



        private void RemoveImage_Btn_Click(object sender, EventArgs e)
        {
            RemoveImage();
        }

        private void Switch_IsActive_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }
    }
}
