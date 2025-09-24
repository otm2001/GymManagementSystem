using DataAccessGymSystem;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayerGymSystem
{
    public class Employee:Person
    {
        public enum eMode
        {
            AddNew,
            update
        }

        private enMode Mode=enMode.AddNew;
        public int EmployeeID {  get; set; } 

        public float Salary {  get; set; }

        public JobRole Job {  get; set; }

        private bool _AddNew()
        {
            this.EmployeeID = DataAccessEmployee.AddNewEmployee(PersonID, Salary, this.Job.JobRoleID);
            return (EmployeeID != -1);

        }

        private bool _Update()
        {
            return DataAccessEmployee.UpdateEmployeeInfo(this.EmployeeID, this.Salary, this.Job.JobRoleID);
        }
        public class JobRole
        {
            enMode Mode= enMode.AddNew;
            public int JobRoleID { get; set; }
            public string JobRoleName { get; set; }

            private bool _Addnew()
            {
                this.JobRoleID =JobRolesDatatAccesscs.AddNewJobRole(JobRoleName);
                return (JobRoleID != -1);
            }
            public JobRole ()
            {
                JobRoleID = -1;
                JobRoleName = string.Empty;
                Mode = enMode.AddNew;
            }
            public JobRole( int jobRoleID, string jobRoleName)
            {
                JobRoleID = jobRoleID;
                JobRoleName = jobRoleName;
                Mode = enMode.Update;
            }

            static public JobRole FindByID(int JobRoleID)
            {
                string JobRoleName = "";
                if(JobRolesDatatAccesscs.FindByJobRoleID(JobRoleID,ref JobRoleName))
                {
                    return new JobRole(JobRoleID, JobRoleName);
                }
                return null;
            }

            static public JobRole FindByJobName(string JobRoleName)
            {
                int JobRoleID = -1;
                if (JobRolesDatatAccesscs.FindByJobRoleName(JobRoleName, ref JobRoleID))
                {
                    return new JobRole(JobRoleID, JobRoleName);
                }
                return null;
            }

            static public bool Delete(int jobRoleId)
            {
                return JobRolesDatatAccesscs.DeleteJobRole(jobRoleId);
            }
            public bool Save()
            {
                if(Mode==enMode.AddNew)
                {
                    if(_Addnew())
                    {
                        this.Mode = enMode.Update;
                        return true;
                    }
                }
                return false;
            }

           static public DataTable GetAllJobRoles()
            {
                return JobRolesDatatAccesscs.GetAllJobRoles();
            }
        }

        public Employee()
            :base()
        {
            EmployeeID = -1;
            Salary = 0;
            Job = null;
            Mode=enMode.AddNew;
        }

         public Employee(int EmployeeID, float Salary, JobRole job, int PersonID, string Name, string Address, string Phone, DateTime DateOfBirth, char Gender, string ImagePath, string Email,bool isActive)
        : base(PersonID, Name, Address, Phone, DateOfBirth, Gender, ImagePath, Email, isActive)
        {
            this.EmployeeID = EmployeeID;
            this.Salary = Salary;
            this.Job = job;
            Mode=enMode.Update;

        }

        static public Employee FindByID(int EmployeeID)
        {
            int PersonID = -1, jobRoleID = -1;
            float Salary = 0;
            if(DataAccessEmployee.FindEmployeeByID(EmployeeID,ref PersonID,ref Salary,ref jobRoleID))
            {
                Person person=Person.FindByID(PersonID);
                JobRole job=JobRole.FindByID(jobRoleID);
                if(person!=null && job != null)
                 {    
                    return new Employee(EmployeeID, Salary, job, person.PersonID, person.Name, person.Address, person.Phone, person.DateOfBirth, person.Gender, person.ImagePath, person.Email,person.isActive);
                 }
            }
            return null;
        }

        static public bool Delete(int EmployeeID)
        {
            Employee employee= Employee.FindByID(EmployeeID);

            return DataAccessEmployee.DeleteEmployee(EmployeeID) && Person.Delete(employee.PersonID);
        }
       public bool Save()
        {
            if (Mode == enMode.AddNew)
            {
                if (base.Save())
                {
                    if (this._AddNew())
                    {
                        this.Mode = enMode.Update;
                        return true;
                    }
                }
            }

            else
            {
                if (base.Save())
                {
                    if(_Update())
                    {
                        return true;
                    }
                }
                
            }
            return false;
        }

        public static DataTable GetEmployeesDetails()
        {
            return DataAccessEmployee.GetAllEmployeesDetails();
        }
    }
}
