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
    public partial class dataCard : UserControl
    {

        public Image IconCard 
        {
            get { return Card_Icon.Image; }
            set { Card_Icon.Image = value; }

        }
        public string TitleCard { 
            get { return label1.Text; }
            set { label1.Text = value; } 
        }

        public string Number
        {
            get { return Number_Lable.Text; }
            set { Number_Lable.Text=value; }
        }

        public dataCard()
        {
            InitializeComponent();
        }
    }
}
