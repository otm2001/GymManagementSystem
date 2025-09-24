using DataAccessGymSystem;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayerGymSystem
{
    public class DietPlan
    {
        private enum enMode
        {
            AddNew,
            Update
        }

        private enMode Mode = enMode.AddNew;
        public int DietPlanID { get; set; }

        public string Name { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public string WeeklyMealPlan { get; set; }

        private bool _Update()
        {
            return DataAccessDietPlan.UpdateDietPlan(DietPlanID, Name, Description, Category, WeeklyMealPlan);
        }

        private bool _AddNewDietPlan()
        {
            DietPlanID = DataAccessDietPlan.AddNewDietPlan(Name, Description, Category, WeeklyMealPlan);
            return DietPlanID != -1;
        }

        public DietPlan()
        {
            DietPlanID = -1;
            Name = string.Empty;
            Description = string.Empty;
            Category = string.Empty;
            WeeklyMealPlan = string.Empty;
            Mode = enMode.AddNew;
        }

        public DietPlan(int dietPlanID, string name, string description, string category, string weeklyMealPlan)
        {
            DietPlanID = dietPlanID;
            Name = name;
            Description = description;
            Category = category;
            WeeklyMealPlan = weeklyMealPlan;
            Mode = enMode.Update;
        }

        static public DietPlan Find(int DietPlanID)
        {
            string Name = "", Description = "", Category = "", WeeklyMealPlan = "";

            if (DataAccessDietPlan.FindDietPlanByID(DietPlanID, ref Name, ref Description, ref Category, ref WeeklyMealPlan))
            {
                return new DietPlan(DietPlanID, Name, Description, Category, WeeklyMealPlan);
            }

            return null;
        }

        static public DietPlan FindByName(string Name)
        {
            int DietPlanID = -1;
            string Description = "", Category = "", WeeklyMealPlan = "";

            if (DataAccessDietPlan.FindDietPlanByName(Name, ref DietPlanID, ref Description, ref Category, ref WeeklyMealPlan))
            {
                return new DietPlan(DietPlanID, Name, Description, Category, WeeklyMealPlan);
            }

            return null;
        }

        public bool Save()
        {
            if (Mode == enMode.AddNew)
            {
                if (_AddNewDietPlan())
                {
                    Mode = enMode.Update;
                    return true;
                }
            }
            else
            {
                if (_Update())
                    return true;
            }

            return false;
        }

        static public bool Delete(int DietPlanID)
        {
            return DataAccessDietPlan.DeleteDietPlan(DietPlanID);
        }

        static public DataTable GetAllDietPlans()
        {
            return DataAccessDietPlan.GetAllDietPlans();
        }
    }
}
