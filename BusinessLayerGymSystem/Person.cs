using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using DataAccessGymSystem;

namespace BusinessLayerGymSystem
{
    public class Person
    {

       public enum enMode
        {
            AddNew=1,
            Update=2
        }

        enMode Mode = enMode.AddNew;

        public int PersonID {  get; set; }
        public string Name { get; set; }

        public string Address {  get; set; }

        public string Phone {  get; set; }


        public string Email {  get; set; }
        

        public DateTime DateOfBirth { get; set; }

        public char Gender {  get; set; }

        public string ImagePath {  get; set; }

        public bool isActive { get; set; }
        private  bool AddNewPerson()
        {

            this.PersonID =DataAccessPereson.AddNewPersonGetID(Name, Address, Phone, DateOfBirth, Gender, ImagePath,Email, isActive );
            return (this.PersonID != -1);
        }

        private bool Update()
        {

            if(DataAccessPereson.UpdatePerson(PersonID,Name,Address,Phone,DateOfBirth,Gender,ImagePath, Email, isActive ))
                return true;
            return false;

        }
        public  Person()
        {
            PersonID = -1;
            Name= string.Empty;
            Address= string.Empty;
            Phone= string.Empty;
            Email= string.Empty;
            DateOfBirth = DateTime.Now;
            Gender = 'M';
            ImagePath = string.Empty;
            isActive = false;
            Mode = enMode.AddNew;

           
        }

        public Person( int personID,string name,  string  address,  string phone, DateTime dateOfBirth,  char gender,  string imagePath,string email,bool isActive)
        {
           PersonID=personID;
            Name = name;
            Address = address;
            Phone = phone;
            Email = email;
            DateOfBirth = dateOfBirth;
            Gender = gender;
            ImagePath = imagePath;
            this.isActive = isActive;
            Mode = enMode.Update;
        }

        public static  Person FindByID(int Id)
        {
            string Name = "", Address = "", Phone = "", ImagePath = "", Email = "";
            DateTime DateOfBirth = DateTime.Now;
            char Gender =char.MinValue;
            bool isActive = false;

            if(DataAccessPereson.FindPersonByID(Id,ref Name, ref Address, ref Phone, ref DateOfBirth, ref Gender, ref ImagePath,ref Email,ref isActive))
            {
             return new Person(Id,Name,Address,Phone,DateOfBirth,Gender,ImagePath,Email, isActive   );   
            }
            else
            {
                return null;
            }





        }

        static public Person FindByID2(int Id)
        {
            string Name = "", Address = "", Phone = "", ImagePath = "", Email = "";
            DateTime DateOfBirth = DateTime.Now;
            char Gender = char.MinValue;
            bool isActive = false;

            if (DataAccessPereson.FindPersonByID2(Id, ref Name, ref Address, ref Phone, ref DateOfBirth, ref Gender, ref ImagePath, ref Email, ref isActive))
            {
                return new Person(Id, Name, Address, Phone, DateOfBirth, Gender, ImagePath, Email, isActive);
            }
            else
            {
                return null;
            }





        }

        //static protected Person FindByName(string Name)
        //{
        //    int PersonID = -1;
        //    string Address = "", Phone = "", ImagePath = "", Email = "";
        //    DateTime DateOfBirth = DateTime.Now;
        //    char Gender = char.MinValue;

        //    if (DataAccessPereson.FindPersonByName(Name,ref PersonID, ref Address, ref Phone, ref DateOfBirth, ref Gender, ref ImagePath, ref Email))
        //    {
        //        return new Person(PersonID, Name, Address, Phone, DateOfBirth, Gender, ImagePath, Email);
        //    }
        //    else
        //    {
        //        return null;
        //    }


        //}
        static public  bool Delete(int PersonID)
        {
            if(DataAccessPereson.DeletePerson(PersonID))
                return true;
            else
            return false;
        }
        public virtual bool Save()
        {
            if (Mode == enMode.AddNew)
            {
                if (AddNewPerson())
                {

                    Mode = enMode.Update;
                    return true;
                }
                else
                    return false;
                


            }
            else
            {
                if (this.Update())
                    return true;
             
                else
                return false;

               
            }

        }
    }
}
