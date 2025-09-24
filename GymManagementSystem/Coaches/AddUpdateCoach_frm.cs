using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLayerGymSystem;

namespace GymManagementSystem
{
    public partial class AddUpdateCoach_frm : Form
    {
        private enum enPicture
        {
            DefaultPic,
            CustomPic
        }

        enPicture PicMode = enPicture.DefaultPic;
        private enum enMode
        {
            AddNew,
            Update
        }

        public int CoachID;
        private Coach coach;

        private enMode Mode=enMode.AddNew;

        private void _FillGames_ComboBox()
        {
            DataTable dt =Game.GetAllGames();

            foreach(DataRow dataRow in dt.Rows)
            {
                Game_ComboBox.Items.Add(dataRow["GameName"]); 

            }
        }

        private DialogResult _ShowAddImage()
        {

            openFileDialog1.Title = "Add Image";
            openFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.tif;...";

            DialogResult result = openFileDialog1.ShowDialog();

            if(result==DialogResult.OK)
            {
                Coach_PictureBox.Image=Image.FromFile(openFileDialog1.FileName);
                Coach_PictureBox.Tag = openFileDialog1.FileName;
                PicMode = enPicture.CustomPic;
            }
            return result;
        }
         private void _Fill_CoachInfo_inBoxes()
        {
           coach = Coach.FindByID(CoachID);

            CoachID_TextBox.Text = coach.CoachID.ToString();
            Name_Txt.Text = coach.Name;
            Address_TextBox.Text = coach.Address;
            Phone_TextBox.Text = coach.Phone;
            Email_TextBox.Text = coach.Email;
            DateOFBirth_DataPicker.Text=coach.DateOfBirth.ToString();
            if (coach.Gender == 'M')
                Male_RBtn.Checked = true;
            else
                Female_RBtn.Checked = true;
            

           Game_ComboBox.SelectedIndex= Game_ComboBox.FindString(Game.Find(coach.GameID).GameName);
            Qualification_TextBox.Text = coach.Qualification;

            if(coach.ImagePath != "")
            {
            Coach_PictureBox.Image=Image.FromFile(coach.ImagePath);
            Coach_PictureBox.Tag = coach.ImagePath;
            PicMode=enPicture.CustomPic;
            RemoveImage_Btn.Visible = true;
            }

            Salary_TextBox.Text = coach.Salary.ToString();
            

        }

        private void _Collect_CoachInfo_FromBoxes()
        {
            coach.Name = Name_Txt.Text;
            coach.Phone=Phone_TextBox.Text;
            coach.Address=Address_TextBox.Text;
            coach.Email=Email_TextBox.Text;
            coach.DateOfBirth=Convert.ToDateTime(DateOFBirth_DataPicker.Text);
            coach.Salary=Convert.ToSingle(Salary_TextBox.Text);
            if (Male_RBtn.Checked)
             coach.Gender = 'M';
            else
                coach.Gender = 'F';

            coach.GameID = Game.FindByName(Game_ComboBox.Text).GameID;
            coach.Qualification = Qualification_TextBox.Text;

            if (PicMode == enPicture.CustomPic)
                coach.ImagePath = Coach_PictureBox.Tag.ToString();
            else
                coach.ImagePath = "";

            coach.Job = Employee.JobRole.FindByID(1);


        }
        public AddUpdateCoach_frm(int CoachID)
        {
            InitializeComponent();
            if(CoachID!=-1)
            {
                Mode = enMode.Update;
              this.CoachID = CoachID;
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            _FillGames_ComboBox();

            if (Mode == enMode.Update)
            {
                _Fill_CoachInfo_inBoxes();
                TitleLable.Text = "Edit Coach";
            }



        }

        private void Btn_Save_Click(object sender, EventArgs e)
        {
            if (Mode == enMode.Update)
            {
                
                    if (MessageBox.Show("Are You Sure Want to Update this Member", "Update Member", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                  
                  
                    if(coach.Save())
                        MessageBox.Show("Member Updated Successfully", "Updated Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                
            }
            else
            {
                coach = new Coach();
                _Collect_CoachInfo_FromBoxes();
                if(coach.Save())
                {
                    MessageBox.Show("Member Added Successfully", "Added Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CoachID_TextBox.Text = coach.CoachID.ToString();
                    Mode = enMode.Update;
                    TitleLable.Text = "Edit Coach";
                }
            }
        }

        private void SetImage_Btn_Click(object sender, EventArgs e)
        {
            if(_ShowAddImage()==DialogResult.OK)
                RemoveImage_Btn.Visible=true;

        }

      

        private void Btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Name_Txt_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Name_Txt.Text))
            {
                e.Cancel = true;
                Name_Txt.Focus();
                errorProvider1.SetError(Name_Txt, "Name should have avalue");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(Name_Txt, "");
            }



        }

        private void Phone_TextBox_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Phone_TextBox.Text))
            {
                e.Cancel = true;
                Name_Txt.Focus();
                errorProvider1.SetError(Phone_TextBox, "Phone should have avalue");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(Phone_TextBox, "");
            }
        }

        private void Game_ComboBox_Validating(object sender, CancelEventArgs e)
        {
            if(string.IsNullOrWhiteSpace(Game_ComboBox.Text))
            { e.Cancel = true;
            
            Game_ComboBox.Focus();
                errorProvider1.SetError(Game_ComboBox, "Game should have avalue");
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void RemoveImage_Btn_Click(object sender, EventArgs e)
        {
            PicMode = enPicture.DefaultPic;
            RemoveImage_Btn.Visible = false;
            Coach_PictureBox.Image = Properties.Resources.coachDefultPic;
        }
    }
}
