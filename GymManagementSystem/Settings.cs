using BusinessLayerGymSystem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GymManagementSystem
{
    public class Settings
    {
        static public User CurrentUser { get; set; }
        static public Form CurrentForm {  get; set; }

        public enum enMode
        {
            AddNew,
            Update
        }


       
        
    }
}
