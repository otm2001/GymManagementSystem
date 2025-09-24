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
    public partial class AddUpdateGame_frm : Form
    {
        enum enMode
        {
            addNew,
            Update
        }

        private Game game;
        private int GameID;

        enMode Mode = enMode.addNew;
        public AddUpdateGame_frm(int GameID)
        {
            InitializeComponent();

            if (GameID != -1)
            {
                Mode = enMode.Update;
                this.GameID = GameID;
            }
        }

        private void SetImage_Btn_Click(object sender, EventArgs e)
        {

        }

        private void _FillTextBox_GameInfo()
        {
            game = Game.Find(GameID);

            if (game != null)
            {
                GameIDTxt.Text = game.GameID.ToString();
                GameName_Txt.Text = game.GameName;
                MonthlyFeeTxt.Text = game.MonthlyFee.ToString();
                DailyFeeTxt.Text = game.DailyFee.ToString();

            }
        }

        private void _Collect_GameInfo_FromBoxes()
        {
            game.GameName = GameName_Txt.Text;
            game.MonthlyFee = Convert.ToSingle(MonthlyFeeTxt.Text);
            game.DailyFee = Convert.ToSingle(DailyFeeTxt.Text);
        }
        private void AddUpdateGame_frm_Load(object sender, EventArgs e)
        {
            if (Mode == enMode.Update)
            {
                _FillTextBox_GameInfo();
                TitleLable.Text= "Edit Game";
            }
        }


        private void Btn_Close_Click(object sender, EventArgs e)
        {
            
        }

        private void saveBtn1_Click(object sender, EventArgs e)
        {
            if (Mode == enMode.Update)
            {
                if (MessageBox.Show("Are You Sure Want to Update this Game", "Update Game", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    _Collect_GameInfo_FromBoxes();
                    if (game.Save())
                    {
                        MessageBox.Show("Game Updated Successfully", "Updated Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }

            else
            {
                game = new Game();
                _Collect_GameInfo_FromBoxes();
                if (game.Save())
                {
                    MessageBox.Show("Game Added Successfully", "Added Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    GameIDTxt.Text = game.GameID.ToString();
                    Mode = enMode.Update;
                    TitleLable.Text = "Edit Game";

                }
            }
        }
    }
}
