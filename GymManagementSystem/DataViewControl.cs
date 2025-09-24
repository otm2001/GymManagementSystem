using Guna.UI2.WinForms;
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
    public partial class DataViewControl : UserControl
    {

        public Image Icon
        {

            get { return _Icon.Image; }
            set
            {
                _Icon.Image = value;
                            }


        }
        
        public Panel squarePanal
        {
            get { return panel1; }
            set { panel1 = value; }
        }
        public Guna2Chip Chip
        {
            get { return squareChip; }
            set {  squareChip = value; }
        }

        public string Title
        {
            get { return label_Title.Text; }
            set { label_Title.Text = value; }
        }

        public Point Titleloction
        {
            get { return label_Title.Location; }
            set { label_Title.Location = value; }

        }
     

        public string Number
        {
            get { return label_Number.Text; }
            set { label_Number.Text = value; }
        }


        public DataViewControl()
        {
            InitializeComponent();
        }


    }

    }

