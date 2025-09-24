using DataAccessGymSystem;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayerGymSystem
{
    public class Coach : Employee
    {
        enMode Mode = enMode.AddNew;

        public int CoachID { get; set; }
        public string Qualification { get; set; }

        public  int GameID {  get; set; }

        private bool _AddNewCoach()
        {
            CoachID = DataAccessCoach.addNewCoachGetID(EmployeeID, Qualification, GameID);
            return (CoachID != -1);


        }

        private bool Update()
        {
            if(DataAccessCoach.UpdateCoach(CoachID, Qualification,GameID))
                return true;
            else
            return false;
        }

        public Coach()
        {
            CoachID = -1;
            Qualification = string.Empty;
            GameID = -1;
            Mode = enMode.AddNew;
        }

        private Coach(int CoachID,int EmployeeID, string Qualification,int GameID,float Salary,Employee.JobRole job, int PersonID, string Name, string Address, string Phone, DateTime DateOfBirth, char Gender, string ImagePath,string Email,bool isActive)
            : base(EmployeeID,Salary,job,PersonID, Name, Address, Phone, DateOfBirth, Gender, ImagePath, Email, isActive)
        {
            
                this.CoachID = CoachID;
                this.Qualification = Qualification;
                this.GameID = GameID;
                Mode = enMode.Update;

            
        }

        static public  Coach FindByID(int CoachID)
        {
            int EmployeeID = -1;
            int GameID = -1;
            string Qualification = "";

            if(DataAccessCoach.FindCoachByID(CoachID,ref EmployeeID, ref Qualification,ref GameID))
            {
                Employee employee = Employee.FindByID(EmployeeID);

                if(employee != null)
                {
                    return new Coach(CoachID,EmployeeID, Qualification,GameID,employee.Salary,employee.Job,employee.PersonID, employee.Name, employee.Address, employee.Phone, employee.DateOfBirth, employee.Gender, employee.ImagePath,employee.Email,employee.isActive);
                }

            }

            return null;

        }

        static public Coach FindByName(string Name)
        {
            int CoachID= -1;
            if(DataAccessCoach.FindCoachName(Name,ref CoachID))
            {
                Coach coach=Coach.FindByID(CoachID);
                if (coach != null)
                    return new Coach(coach.CoachID, coach.EmployeeID, coach.Qualification, coach.GameID, coach.Salary, coach.Job, coach.PersonID, coach.Name, coach.Address, coach.Phone, coach.DateOfBirth, coach.Gender, coach.ImagePath, coach.Email,coach.isActive);
            }

            return null;
        }
        static public Coach FindByEmployeeID(int EmployeeID)
        {
            int CoachID = -1;
            if(DataAccessCoach.FindCoachEmployeeID(EmployeeID, ref CoachID))
            {
                Coach coach = Coach.FindByID(CoachID);
                if(coach != null)
                    return coach;
            }
            return null;

        }
        static public bool Delete(int CoachID)
        {
            Employee employee=FindByID(CoachID);

            return (DataAccessCoach.DeleteCoach(CoachID) && Employee.Delete(employee.EmployeeID)) ;

           
               
        }
        

        public  bool Save()
        {
            if (Mode == enMode.AddNew)
            {
                if (base.Save())
                {
                    if (_AddNewCoach())
                    {
                        Mode = enMode.Update;
                        return true;


                    }
                    

                }
                    return false;


            }

            else
            {
                if (base.Save())
                {
                    if (Update())
                        return true;
                }
               
                return false;

                
            }

          
        
        }

        public static DataTable GetAllCoachesInfo()
        {
            return DataAccessCoach.GetAllCoachesInfo();
        }

        public static DataTable GetAllCoachesWithFilterGameName(string GameName)
        {
            return DataAccessCoach.GetAllCoachesWithFilter(GameName);
        }
    }
}
