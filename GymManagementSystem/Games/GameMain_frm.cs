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
    public partial class GameMain_frm : Form
    {
        public GameMain_frm()
        {
            InitializeComponent();
        }

        private void _RefreshDatainDGrid()
        {
            GamesList_DGrid.DataSource = Game.GetAllGames();
        }
        private void GameMain_frm_Load(object sender, EventArgs e)
        {
           _RefreshDatainDGrid();
        }

        private void AddGameBtn_Click(object sender, EventArgs e)
        {
            AddUpdateGame_frm Form = new AddUpdateGame_frm(-1);
            Form.ShowDialog();
            _RefreshDatainDGrid();
        }

        private void UpdateGameBtn_Click(object sender, EventArgs e)
        {
            AddUpdateGame_frm Form = new AddUpdateGame_frm(Convert.ToInt16(GamesList_DGrid.CurrentRow.Cells[0].Value));
            Form.ShowDialog();
            _RefreshDatainDGrid();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Game game=Game.Find(Convert.ToInt16(GamesList_DGrid.CurrentRow.Cells[0].Value));
            if (game != null)
            {
               if( MessageBox.Show("Are You sure wnat to delete this game?","Delete game",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
                {
                    Game.Delete(game.GameID);
                    _RefreshDatainDGrid();
                }

            }
        }
    }
}
