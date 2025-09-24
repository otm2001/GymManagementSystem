using DataAccessGymSystem;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayerGymSystem
{
    public class User : Employee
    {
        public enum enPermissions : long
        {
            MainScreen = 2,
            MembersScreen = 4, AddNewMember = 8, UpdateMember = 16, DeleteMember = 32,
            CoachScreen = 64, AddNewCoach = 128, UpdateCoach = 256, DeleteCoach = 512,
            SubscriptionScreen = 1024, AddNewSubscription = 2048, UpdateSubscription = 4096, DeleteSubscription = 8192, SuspendSubscription = 16384,
            UsersScreen = 32768, AddNewUser = 65536, UpdateUser = 131072, DeleteUser = 262144,
            GamesScreen = 524288, AddNewGame = 1048576, UpdateGame = 2097152, DeleteGame = 4194304,
            EmployeesScreen = 8388608, AddNewEmployee = 16777216, UpdateEmployee = 33554432, DeleteEmployee = 67108864, payEmployeesSalaries = 134217728,
            ExpensesScreen = 268435456, AddNewExpense = 536870912, UpdateExpense = 1073741524, DeleteExpense = 2147483648


        }

        enMode Mode = enMode.AddNew;
        public int UserID { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }

        public long Permissions { get; set; }
        private bool Update()
        {
            return (DataAccessUser.UpdateUser(UserID, EmployeeID, UserName, Password, Permissions)) ? true : false;
        }
        static public User _Find(string UserName)
        {
            int UserID = -1, EmployeeID = -1;
            string password = "";
            long Permissions = -1;

            if (DataAccessUser.FindUserByUserName(UserName, ref UserID, ref EmployeeID, ref password, ref Permissions))
            {
                Employee employee = Employee.FindByID(EmployeeID);

                if (employee != null)
                {

                    return new User(UserID, EmployeeID, UserName, password, Permissions, employee.Salary, employee.Job, employee.PersonID, employee.Name, employee.Address, employee.Phone, employee.DateOfBirth, employee.Gender, employee.ImagePath, employee.Email, employee.isActive);
                }
                return null;


            }
            return null;
        }
        private bool _AddnewUser()
        {
            UserID = DataAccessUser.AddNewUser(EmployeeID, UserName, Password, Permissions);

            return (UserID != -1);
        }
        public User()
        {
            UserID = -1;
            UserName = string.Empty;
            Password = string.Empty;
            Permissions = -1;
            Mode = enMode.AddNew;

        }

        private User(int userID, int EmployeeID, string userName, string password, long Permissions, float Salary, Employee.JobRole job, int PersonID, string Name, string Address, string Phone, DateTime DateOfBirth, char Gender, string ImagePath, string Email,bool isActive)
            : base(EmployeeID, Salary, job, PersonID, Name, Address, Phone, DateOfBirth, Gender, ImagePath, Email, isActive)
        {
            UserID = userID;
            UserName = userName;
            Password = password;
            this.Permissions = Permissions;
            Mode = enMode.Update;
        }

        static public User FindByID(int UserID)
        {
            int EmployeeID = -1;
            string UserName = "", password = "";
            long Permissions = -1;

            if (DataAccessUser.FindUserByUserID(UserID, ref UserName, ref EmployeeID, ref password, ref Permissions))
            {
                Employee employee = Employee.FindByID(EmployeeID);

                if (employee != null)
                {

                    return new User(UserID, EmployeeID, UserName, password, Permissions, employee.Salary, employee.Job, employee.PersonID, employee.Name, employee.Address, employee.Phone, employee.DateOfBirth, employee.Gender, employee.ImagePath, employee.Email,employee.isActive);
                }
                return null;


            }
            return null;
        }

        static public bool Login(string UserName, string Password)
        {
            User user = User._Find(UserName);

            if (user != null)
            {
                if (user.Password == Password)
                    return true;
            }

            return false;
        }

        static public bool Delete(int UserID)
        {

            if (DataAccessUser.DeleteUser(UserID))
            {
                return true;
            }
            return false;
        }

        public bool Save()
        {
            if (Mode == enMode.AddNew)
            {

                if (_AddnewUser())
                {
                    Mode = enMode.Update;
                    return true;

                }


            }

            else
            {

                if (Update())
                    return true;

            }

            return false;

        }

        public bool CheckPermissions(enPermissions permissions)
        {
            if (this.Permissions == -1)
                return true;

            //Members
            else if (permissions == enPermissions.MembersScreen)
                return ((this.Permissions & (long)enPermissions.MembersScreen) == (long)enPermissions.MembersScreen);

            else if (permissions == enPermissions.AddNewMember)
                return ((this.Permissions & (long)enPermissions.AddNewMember) == (long)enPermissions.AddNewMember);

            else if (permissions == enPermissions.UpdateMember)
                return ((this.Permissions & (long)enPermissions.UpdateMember) == (long)enPermissions.UpdateMember);

            else if (permissions == enPermissions.DeleteMember)
                return ((this.Permissions & (long)enPermissions.DeleteMember) == (long)enPermissions.DeleteMember);


            //Coaches
            else if (permissions == enPermissions.CoachScreen)
                return ((this.Permissions & (long)enPermissions.CoachScreen) == (long)enPermissions.CoachScreen);

            else if (permissions == enPermissions.AddNewCoach)
                return ((this.Permissions & (long)enPermissions.AddNewCoach) == (long)enPermissions.AddNewCoach);

            else if (permissions == enPermissions.UpdateCoach)
                return ((this.Permissions & (long)enPermissions.UpdateCoach) == (long)enPermissions.UpdateCoach);

            else if (permissions == enPermissions.DeleteCoach)
                return ((this.Permissions & (long)enPermissions.DeleteCoach) == (long)enPermissions.DeleteCoach);

            //Subscriptions
            else if (permissions == enPermissions.SubscriptionScreen)
                return ((this.Permissions & (long)enPermissions.SubscriptionScreen) == (long)enPermissions.SubscriptionScreen);

            else if (permissions == enPermissions.AddNewSubscription)
                return ((this.Permissions & (long)enPermissions.AddNewSubscription) == (long)enPermissions.AddNewSubscription);

            else if (permissions == enPermissions.UpdateSubscription)
                return ((this.Permissions & (long)enPermissions.UpdateSubscription) == (long)enPermissions.UpdateSubscription);

            else if (permissions == enPermissions.DeleteSubscription)
                return ((this.Permissions & (long)enPermissions.DeleteSubscription) == (long)enPermissions.DeleteSubscription);

            else if (permissions == enPermissions.SuspendSubscription)
                return ((this.Permissions & (long)enPermissions.SuspendSubscription) == (long)enPermissions.SuspendSubscription);
            //Users

            else if (permissions == enPermissions.UsersScreen)
                return ((this.Permissions & (long)enPermissions.UsersScreen) == (long)enPermissions.UsersScreen);

            else if (permissions == enPermissions.AddNewUser)
                return ((this.Permissions & (long)enPermissions.AddNewUser) == (long)enPermissions.AddNewUser);

            else if (permissions == enPermissions.UpdateUser)
                return ((this.Permissions & (long)enPermissions.UpdateUser) == (long)enPermissions.UpdateUser);

            else if (permissions == enPermissions.DeleteUser)
                return ((this.Permissions & (long)enPermissions.DeleteUser) == (long)enPermissions.DeleteUser);

            //Games

            else if (permissions == enPermissions.GamesScreen)
                return ((this.Permissions & (long)enPermissions.GamesScreen) == (long)enPermissions.GamesScreen);

            else if (permissions == enPermissions.AddNewGame)
                return ((this.Permissions & (long)enPermissions.AddNewGame) == (long)enPermissions.AddNewGame);

            else if (permissions == enPermissions.UpdateGame)
                return ((this.Permissions & (long)enPermissions.UpdateGame) == (long)enPermissions.UpdateGame);

            else if (permissions == enPermissions.DeleteGame)
                return ((this.Permissions & (long)enPermissions.DeleteGame) == (long)enPermissions.DeleteGame);



            //Employees
            else if (permissions == enPermissions.EmployeesScreen)
                return ((this.Permissions & (long)enPermissions.EmployeesScreen) == (long)enPermissions.EmployeesScreen);

            else if (permissions == enPermissions.AddNewEmployee)
                return ((this.Permissions & (long)enPermissions.AddNewEmployee) == (long)enPermissions.AddNewEmployee);

            else if (permissions == enPermissions.UpdateEmployee)
                return ((this.Permissions & (long)enPermissions.UpdateEmployee) == (long)enPermissions.UpdateEmployee);

            else if (permissions == enPermissions.DeleteEmployee)
                return ((this.Permissions & (long)enPermissions.DeleteEmployee) == (long)enPermissions.DeleteEmployee);

            else if (permissions == enPermissions.payEmployeesSalaries)
                return ((this.Permissions & (long)enPermissions.payEmployeesSalaries) == (long)enPermissions.payEmployeesSalaries);

            //Expenses

            else if (permissions == enPermissions.ExpensesScreen)
                return ((this.Permissions & (long)enPermissions.ExpensesScreen) == (long)enPermissions.ExpensesScreen);

            else if (permissions == enPermissions.AddNewExpense)
                return ((this.Permissions & (long)enPermissions.AddNewExpense) == (long)enPermissions.AddNewExpense);

            else if (permissions == enPermissions.UpdateExpense)
                return ((this.Permissions & (long)enPermissions.UpdateExpense) == (long)enPermissions.UpdateExpense);

            else if (permissions == enPermissions.DeleteExpense)
                return ((this.Permissions & (long)enPermissions.DeleteExpense) == (long)enPermissions.DeleteExpense);

            //else

            else return false;





        }

        static public  DataTable GetAllUsersDetails()
        {
           return  DataAccessUser.GetAllUsersDetails();
        }

    }
}

