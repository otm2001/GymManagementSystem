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
using System.Windows.Forms.DataVisualization.Charting;

namespace GymManagementSystem
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void _loadDataToChart()
        {
            DataTable dt = Subscription.GetSubscriptionsCountPerGame();

            foreach (DataRow dr in dt.Rows)
            {
                chart1.Series["SubscriptionGames"].Points.AddXY(Convert.ToString(dr[0]),Convert.ToInt16(dr[1]));
            }
        }
        private void Main_Load(object sender, EventArgs e)
        {
            dataCard_Members.Number = (Member.CountOfMembers()).ToString();
            dataCard_ActiveMembers.Number= (Member.CountOfActiveMembers()).ToString();
           dataCard_InActiveMembers.Number=(Member.CountOFInAciveMembers()).ToString();

         
            _loadDataToChart();
            
           // Welcome_Lable.Text = "Welcome back," + Settings.CurrentUser.Name;
            Time_Lable.Text = DateTime.Now.ToShortTimeString().Substring(0,5);
            if (DateTime.Now.ToString("tt") == "AM")
                label_Morning_Evening.Text = "Good Morning";
            else
                label_Morning_Evening.Text = "Good Evening";
            
        }

        private void guna2Chip2_Click(object sender, EventArgs e)
        {

        }
    }
}
