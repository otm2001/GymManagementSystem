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
    public partial class MainCoaches_frm : Form
    {
        public MainCoaches_frm()
        {
            InitializeComponent();
        }

        private void FilterByGameName(string GameName)
        {
            if (FilterGamesComboBox.SelectedIndex == 0)
                _RefreshData();
            else
            CoachesList_DGrid.DataSource = Coach.GetAllCoachesWithFilterGameName(GameName);

        }
        private void _FillGamesComboBox()
        {
            DataTable Games = Game.GetAllGames();

            foreach (DataRow Game in Games.Rows)
            {
                FilterGamesComboBox.Items.Add(Game["GameName"].ToString());

            }
        }
        private void _RefreshData()
        {
            CoachesList_DGrid.DataSource=Coach.GetAllCoachesInfo();
        }
        private void form2_Load(object sender, EventArgs e)
        {
            _FillGamesComboBox();
            _RefreshData();
        }

        private void FilterGamesComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
        FilterByGameName(FilterGamesComboBox.Text);
        }

        private void AddCoachBtn_Click_1(object sender, EventArgs e)
        {
            
                AddUpdateCoach_frm form = new AddUpdateCoach_frm(-1);
                if(form.ShowDialog()==DialogResult.OK)
                {
                   
                }
               
                _RefreshData();
           
            
                
            
            }

            private void UpdateCoach_Btn_Click_1(object sender, EventArgs e)
        {
          
                AddUpdateCoach_frm form = new AddUpdateCoach_frm(Convert.ToInt16(CoachesList_DGrid.CurrentRow.Cells[0].Value));
                form.ShowDialog();
                _RefreshData();
            
          

        }

        private void DeleteCoach_Btn_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure want to delete this Coach?", "Delete Coach", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Coach coach = Coach.FindByID(Convert.ToInt16(CoachesList_DGrid.CurrentRow.Cells[0].Value));
                if (coach != null)
                {
                    if (Coach.Delete(coach.CoachID))
                    {
                        MessageBox.Show("Coach deleted Successfully", "Deleted Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        _RefreshData();
                    }


                }
            }
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddUpdateCoach_frm form = new AddUpdateCoach_frm(Convert.ToInt16(CoachesList_DGrid.CurrentRow.Cells[0].Value));
            form.ShowDialog();
            _RefreshData();
        }
    }
}
