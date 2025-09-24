using DataAccessGymSystem;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayerGymSystem
{
    public class Suspended_Subscriptions
    {
       private enum enMode
        {
            addNew,
            Update
        }

        enMode Mode = enMode.addNew;    
        public int SuspendedID {  get; set; }
        public int SubscriptionID { get; set; }

        public DateTime SuspendedDate { get; set; }

        public int RemainingDays { get; set; }

        private bool _Addnew()
        {
            SuspendedID = DataAccessSuspendedSubscriptions.AddnewSuspededSubscription(SubscriptionID, SuspendedDate, RemainingDays);
            return (SuspendedID != -1);
            
        }

        private bool _Update()
        {
            return DataAccessSuspendedSubscriptions.UpdateSuspendedSubscription(SuspendedID, SuspendedDate, RemainingDays);
        }
        public Suspended_Subscriptions()
        {
            SuspendedID = -1;
            SubscriptionID = -1;
            SuspendedDate = DateTime.Now;
            RemainingDays = 0;
            Mode = enMode.addNew;
        }

        public Suspended_Subscriptions(int SupendedID,int SubscriptionID,DateTime SuspendedDate,int RemainingDays)
        {
            this.SuspendedID= SupendedID;
            this.SubscriptionID = SubscriptionID;
            this.SuspendedDate = SuspendedDate;
            this.RemainingDays =RemainingDays;
            Mode = enMode.Update;
        }

        static public Suspended_Subscriptions FindBySubscriptionID(int SubscriptionID)
        {
            int SuspendedID = -1;
            DateTime SuspendedDate= DateTime.Now;
            int RemainingDays = 0;

            if(DataAccessSuspendedSubscriptions.FindBySubscriptionID(SubscriptionID,ref SuspendedID,ref SuspendedDate,ref RemainingDays))
            {
                return new Suspended_Subscriptions(SuspendedID,SubscriptionID, SuspendedDate, RemainingDays);
            }
            return null;

        }

        static public bool Delete(int SuspendedID)
        {
            return DataAccessSuspendedSubscriptions.DeleteSuspendedSubscription(SuspendedID);
        }
        public bool Save()
        {
            if (Mode == enMode.addNew)
            {
                if (_Addnew())
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

        static public DataTable GetAllSuspendedSubscriptions()
        {
            return DataAccessSuspendedSubscriptions.GetAllSuspendedSubscriptions();
        }
    }
}
