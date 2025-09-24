using BusinessLayerGymSystem;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GymManagementSystem
{
    public partial class UclPersonCard : UserControl
    {
        public UclPersonCard()
        {
            InitializeComponent();
        }

        public  void LoadPersonInof(int PersonID)
        {
            Person person = Person.FindByID(PersonID);
            if (person != null)
            {
                PersonID_Lable.Text = person.PersonID.ToString();
                Name_Lable.Text = person.Name;
                Address_Lable.Text = person.Address;
                Phone_Lable.Text = person.Phone;
                Email_Lable.Text = person.Email;
                GenderLable.Text = person.Gender.ToString();
                DOBirth_Lable.Text = person.DateOfBirth.ToString();
                if (person.ImagePath != "")
                    Person_Image.Image = Image.FromFile(person.ImagePath);
            }
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }
    }
}
