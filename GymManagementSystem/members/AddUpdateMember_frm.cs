using BusinessLayerGymSystem;
using Guna.UI2.WinForms;
using Microsoft.VisualBasic;
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
    public partial class AddUpdateMember_frm : Form
    {
        private enum enMode {
            AddNewMember,
            UpdateMember

        }
        enMode Mode = enMode.AddNewMember;

        private enum enPicture
        {
            DefaultPic,
            CustomPic
        }

        enPicture PicMode = enPicture.DefaultPic;

        private int MemberID = -1;

        private Member member;
        private DialogResult _ShowAddImage()
        {

            openFileDialog1.Title = "Add Image";
            openFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.tif;...";

            DialogResult result = openFileDialog1.ShowDialog();

            if (result == DialogResult.OK)
            {
                Member_PictureBox.Tag = openFileDialog1.FileName;
                Member_PictureBox.Image = Image.FromFile(openFileDialog1.FileName);
                PicMode = enPicture.CustomPic;
            }

            return result;
        }

        private void _Fill_MemberInfo_inBoxes()
        {
             

            MemberID_TextBox.Text = member.MemberID.ToString();

            Name_TextBox.Text = member.Name;

            Address_TextBox.Text = member.Address;

            Phone_TextBox.Text = member.Phone;

            Email_TextBox.Text = member.Email;

            DateOFBirth_DataPicker.Text = member.DateOfBirth.ToString();

            if (member.Gender == 'M')
                Male_RBtn.Checked = true;
            else
            Female_RBtn.Checked=true;

            ENumber_textBox.Text = member.EmergencyNumber;
            Switch_IsActive.Checked = member.isActive;

            if (member.ImagePath != "")
            {
                Member_PictureBox.Image = Image.FromFile(member.ImagePath);
                Member_PictureBox.Tag = member.ImagePath;
                RemoveImge_Btn.Visible = true;
                PicMode=enPicture.CustomPic;

            }

        }

        private void Collect_MemberInfo_FromBoxes()
        {
            member.Name = Name_TextBox.Text;
            member.Address = Address_TextBox.Text;
            member.Phone = Phone_TextBox.Text;
            member.Email = Email_TextBox.Text;
            member.DateOfBirth=Convert.ToDateTime(DateOFBirth_DataPicker.Text);

            if (Male_RBtn.Checked)
                member.Gender = 'M';
            else
                member.Gender = 'F';

            member.isActive=Switch_IsActive.Checked;
            member.EmergencyNumber = ENumber_textBox.Text;

            if (PicMode==enPicture.DefaultPic)
                member.ImagePath = "";
            else
                member.ImagePath =Member_PictureBox.Tag.ToString();
            
            

        }
        public AddUpdateMember_frm(int MemberID)
        {
            InitializeComponent();


            if (MemberID != -1)
            {
                Mode = enMode.UpdateMember;
                this.MemberID = MemberID;
            }
                
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            

            

        }

        private void Member_PictureBox_Click(object sender, EventArgs e)
        {

        }

        private void SetImage_Btn_Click(object sender, EventArgs e)
        {
            if(_ShowAddImage()==DialogResult.OK)
              
                RemoveImge_Btn.Visible = true;
            
        }

        private void RemoveImge_Btn_Click(object sender, EventArgs e)
        {
       
            PicMode = enPicture.DefaultPic;
            RemoveImge_Btn.Visible=false;

        }

        private void AddUpdate_frm_Load(object sender, EventArgs e)
        {
            if(Mode == enMode.UpdateMember)
            {
                 member = Member.FindByID(MemberID);
                _Fill_MemberInfo_inBoxes();
                TitleLable.Text = "Edit Member";
            }
            

        }

        

        

        //validating
        private void Name_TextBox_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Name_TextBox.Text))
            {
                e.Cancel = true;
                Name_TextBox.Focus();
                errorProvider1.SetError(Name_TextBox, "Name should have avalue!");
                Name_TextBox.PlaceholderText = "Required";
                
                
            }
            else
            {
                e.Cancel= false;
                errorProvider1.SetError(Name_TextBox, "");
                Name_TextBox.PlaceholderText = "";
            }
        }

        private void Phone_TextBox_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Phone_TextBox.Text))
            {
                e.Cancel = true;
                Name_TextBox.Focus();
                errorProvider1.SetError(Phone_TextBox, "Phone should have avalue!");

            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(Phone_TextBox, "");
            }
        }

        private void Btn_Saves_Click(object sender, EventArgs e)
        {
            if (Mode == enMode.UpdateMember)
            {
                if (MessageBox.Show("Are You Sure Want to Update this Member", "Update Member", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Collect_MemberInfo_FromBoxes();
                    if (member.Save())
                    {
                        MessageBox.Show("Member Updated Successfully", "Updated Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }

            else
            {
                member = new Member();
                Collect_MemberInfo_FromBoxes();
                if (member.Save())
                {
                    MessageBox.Show("Member Added Added", "Updated Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Mode = enMode.UpdateMember;
                    TitleLable.Text = "Edit Member";
                }
                MemberID_TextBox.Text = member.MemberID.ToString();
            }
        }
    }
}
