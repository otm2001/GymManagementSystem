using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using DataAccessGymSystem;

namespace BusinessLayerGymSystem
{
    public class Member : Person
    {
        enMode Mode=enMode.AddNew;
        public int MemberID { get; set; }
        public string EmergencyNumber { get; set; }
       

        private bool AddnewMember()
        {
            MemberID=DataAccessMember.AddNewMemberGetID(PersonID,EmergencyNumber);
            return (MemberID !=-1);
        }

        private bool _Update()
        {
            if (DataAccessMember.UpdateMember(MemberID, EmergencyNumber))
                return true;
            else
                return false;
        }
        public Member()
        {
            MemberID = -1;
            EmergencyNumber = string.Empty;
            
            Mode = enMode.AddNew;

        }

        protected Member(int MemberID, string EmergencyNumber,bool isActive, int personID, string name, string address, string phone, DateTime dateOfBirth, char gender, string imagePath,string Email)
           : base(personID,name,address,phone,dateOfBirth,gender,imagePath, Email,isActive)
            {
               this.MemberID = MemberID;
               this.EmergencyNumber = EmergencyNumber;
            
               Mode = enMode.Update;

            }

        public static Member FindByID(int MemberID)
        {
            int PersonID = -1;
            string EmergencyNumber = "";



            if (DataAccessMember.FindMemberByID(MemberID, ref PersonID, ref EmergencyNumber))
            {
                Person person = Person.FindByID(PersonID);
                if (person != null)
                {
                    return new Member(MemberID, EmergencyNumber, person.isActive, PersonID, person.Name, person.Address, person.Phone, person.DateOfBirth, person.Gender, person.ImagePath,person.Email);
                }

            }

            return null;
        }
        public static Member FindByID2(int MemberID)
        {
            int PersonID = -1;
            string EmergencyNumber = "";



            if (DataAccessMember.FindMemberByID2(MemberID, ref PersonID, ref EmergencyNumber))
            {
                Person person = Person.FindByID2(PersonID);
                if (person != null)
                {
                    return new Member(MemberID, EmergencyNumber, person.isActive, PersonID, person.Name, person.Address, person.Phone, person.DateOfBirth, person.Gender, person.ImagePath, person.Email);
                }

            }

            return null;
        }

        public static bool Delete(int MemberID,int personID)
        {
            if(DataAccessMember.DeleteMember(MemberID))
            {
                if(Person.Delete(personID))
                    return true;
            }
            return false;
        }
        public override bool Save()
        {
            if(Mode==enMode.AddNew)
            {
                if(base.Save())
                {
                    if(AddnewMember())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                }

                return false;
            }
            else
            {
                if(base.Save())
                {
                    _Update();
                    return true;
                }

               return false;

            }
        }

        static public DataTable GetAllMembersInfo()
        {
            return DataAccessMember.GetMemberInfo();
        }

        static public DataTable GetAlllMemberInfoWay2()
        {
            return DataAccessMember.GetMemberInfoWay2();
        }

        static public DataTable GetMembersWithID(int MemberID)
        {
           return DataAccessMember.GetMembersFilterByID(MemberID);
        }

        static public DataTable GetMembersWithName(string Name)
        {
            return DataAccessMember.GetMembersFilterByName(Name);
        }

        static public int CountOfMembers()
        {
            return GetAllMembersInfo().Rows.Count;
        }

        static public int CountOfActiveMembers()
        {
            return DataAccessMember.getCountOFActiveMembers();
        }

        static public int CountOFInAciveMembers()
        {
            return CountOfMembers()-CountOfActiveMembers();
        }
    }
}
