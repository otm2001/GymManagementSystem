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
    public partial class MainMembers_frm : Form
    {
        enum enFilter
        {
            None,
            MemberID,
            Name
        }

        enFilter Filter=enFilter.None;
        public MainMembers_frm()
        {
            InitializeComponent();
        }

        private void _AddNewMember()
        {
            
                AddUpdateMembercs Form = new AddUpdateMembercs(-1);
                Form.ShowDialog();
                _RefreshMemberList();
            
          
        }
        public  void _UpdateMember()
        {
           // if (Settings.CurrentUser.CheckPermissions(User.enPermissions.UpdateMember))
          //  {
                AddUpdateMembercs Form = new AddUpdateMembercs(Convert.ToInt16(MemberList_DGrid.CurrentRow.Cells[0].Value));

                Form.ShowDialog();

                _RefreshMemberList();
           // }
          
        }

        public void _ViewDetails()
        {
                AddUpdateMembercs Form = new AddUpdateMembercs(Convert.ToInt16(MemberList_DGrid.CurrentRow.Cells[0].Value),true);

                Form.ShowDialog();

               
            
           
        }
        public void _DeleteMember()
        {
          //  if (Settings.CurrentUser.CheckPermissions(User.enPermissions.DeleteMember))
           // {
                if (MessageBox.Show("Are You Sure Want to Delete this Member", "Delete Member", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Member member = Member.FindByID(Convert.ToInt16(MemberList_DGrid.CurrentRow.Cells[0].Value));

                    if (member != null)
                        if (Member.Delete(member.MemberID, member.PersonID))
                        {
                            MessageBox.Show("Member Deleted Successfully", "Deleted Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            _RefreshMemberList();
                        }

                }
            //}
          
        }
        private void _MessageBox(string message)
        {
            MessageBox.Show("You don't have permissions to " + message,"",MessageBoxButtons.OK,MessageBoxIcon.Error);
        }
        private void _RefreshMemberList ()
        {
            MemberList_DGrid.DataSource = Member.GetAllMembersInfo();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            _RefreshMemberList ();
            
        }
        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void AddMemberBtn_Click(object sender, EventArgs e)
        {

        }

        private void UpdateMember_Btn_Click(object sender, EventArgs e)
        {
           _UpdateMember();
        }

        private void DeleteMember_Btn_Click(object sender, EventArgs e)
        {
            _DeleteMember();
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            //Search_TextBox.Focus();

            //if (Filter == enFilter.None)
            //    _RefreshMemberList();

            //else if (Filter == enFilter.MemberID)
            //{
            //    if (string.IsNullOrWhiteSpace(Search_TextBox.Text))
            //        MessageBox.Show("Search Lable should have avalue!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    else
            //        MemberList_DGrid.DataSource = Member.GetMembersWithID(Convert.ToInt32(Search_TextBox.Text));

            //}
            //else
            //{
            //    MemberList_DGrid.DataSource = Member.GetMembersWithName(Search_TextBox.Text);
            //}

        }

        private void FilterComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (FilterGameComboBox.SelectedIndex == 0)
            {
                Filter = enFilter.None;
                _RefreshMemberList();
            }

            else if (FilterGameComboBox.SelectedIndex == 1)
            {
                Filter = enFilter.MemberID;
                Search_TextBox.Focus();
            }

            else
            {
                Filter = enFilter.Name;
                Search_TextBox.Focus();
            }


            }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {

            _UpdateMember();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
           _DeleteMember();
        }

        private void Search_TextBox_TextChanged(object sender, EventArgs e)
        {
            

            if (Filter == enFilter.MemberID)
            {
                int result;

                if (string.IsNullOrWhiteSpace(Search_TextBox.Text))
                {

                    _RefreshMemberList();
                }

                else if (int.TryParse(Search_TextBox.Text, out result))

                    MemberList_DGrid.DataSource = Member.GetMembersWithID(result);

            }

          else if (Filter == enFilter.Name) 
            {
                
                MemberList_DGrid.DataSource = Member.GetMembersWithName(Search_TextBox.Text);
                if (MemberList_DGrid.RowCount == 0)
                    NotFoundPic.Visible = true;
            }

            if (MemberList_DGrid.RowCount == 0)
                NotFoundPic.Visible = true;
            else
                NotFoundPic.Visible = false;
        }

        private void AddMemberBtn_Click_1(object sender, EventArgs e)
        {
            _AddNewMember();    
        }

        private void viewDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _ViewDetails();
        }
    }
}
