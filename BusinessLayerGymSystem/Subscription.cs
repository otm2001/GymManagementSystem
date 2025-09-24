using DataAccessGymSystem;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayerGymSystem
{
    public class Subscription
    {
        enum enMode
        {
            AddNew, Update
        }

        private enMode Mode = enMode.AddNew;
        public int SubscriptionID { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public int MemberID { get; set; }

        public int CoachID { get; set; }

        public int GameID { get; set; }

        public char SubscriptionsType { get; set; }

        public int Numberofdays {  get; set; }
        public float Fee { get; set; }

        //public int PaymentId { get; set; }

        public bool isSuspended {  get; set; }

        public Payment Payment { get; set; }
        private bool _AddNew()
        {
            SubscriptionID = DataAccessSubscription.AddNewSubscription(StartDate, EndDate, MemberID, CoachID, GameID, SubscriptionsType,Numberofdays, Fee, Payment.PaymentID);

            return (SubscriptionID != -1);
        }

        private bool _Update()
        {
            return (DataAccessSubscription.UpdateSubscription(SubscriptionID, StartDate, EndDate, MemberID, CoachID, GameID, SubscriptionsType,Numberofdays, Fee,isSuspended));
        }
        public Subscription()
        {
            SubscriptionID = -1;
            StartDate = DateTime.Now;
            EndDate = DateTime.Now;
            MemberID = -1;
            CoachID = -1;
            GameID = -1;

            Payment = new Payment();
            Payment.PaymentID = -1;
            Payment.Amount = 0;

            Payment.Date=DateTime.Now;
            SubscriptionsType = char.MinValue;
            Numberofdays = 0;
            Mode = enMode.AddNew;
            isSuspended = false;


        }
        public Subscription(int subscriptionID, DateTime startDate, DateTime endDate, int memberID, int instructorID, int gameID, char subscriptions_Type,int NumberOfDays, float fee, Payment payment)
        {
            SubscriptionID = subscriptionID;
            StartDate = startDate;
            EndDate = endDate;
            MemberID = memberID;
            CoachID = instructorID;
            GameID = gameID;
            SubscriptionsType = subscriptions_Type;
            this.Numberofdays = NumberOfDays;
            Fee = fee;
            Payment = payment;
            Mode = enMode.Update;

        }
        static public Subscription Find(int SubscriptionID)
        {
            DateTime StartDate= DateTime.Now,EndDate = DateTime.Now;
            int MemberID = -1, instructorID = -1, GameID = -1, PaymentID = -1, NumberOfDays = 0;
            char subscriptions_Type=char.MinValue;
            float Fee = 0;

            if(DataAccessSubscription.FindSubscription(SubscriptionID,ref StartDate,ref EndDate,ref MemberID,ref instructorID,ref GameID,ref subscriptions_Type,ref NumberOfDays, ref Fee,ref PaymentID))
            {
                Payment payment =Payment.Find(PaymentID);

                if(payment != null)
                return new Subscription(SubscriptionID,StartDate,EndDate,MemberID,instructorID,GameID,subscriptions_Type, NumberOfDays, Fee,payment);
            }
            return null;
            
        }
        static public bool Delete(int SubscriptionID)
        {
            return DataAccessSubscription.DeleteSubscription(SubscriptionID);
        }
        public bool Save()
        {

            if (Mode == enMode.AddNew)
            {
                if(Payment.Save())
                if (_AddNew())
                {
                    Mode = enMode.Update;
                    return true;
                }
            }
            else
            {
                if(Payment.Save())
                if (_Update())
                    return true;
            }
            return false;
        }
        static public DataTable GetAllSubscriptions()
        {
            return DataAccessSubscription.GetAllSuvsriptions();
        }
        public bool suspendSubscription(int RemainingDays)
        {
            Suspended_Subscriptions Sus_Subscriptions=new Suspended_Subscriptions();

            Sus_Subscriptions.SubscriptionID = this.SubscriptionID;
            Sus_Subscriptions.RemainingDays =RemainingDays;
            Sus_Subscriptions.SuspendedDate=DateTime.Now;

            if(Sus_Subscriptions.Save())
            {
                this.isSuspended = true;
                if (this.Save())
                return true;
            }

            return false;

        }
        public bool resumeSubscription()
        {
            Suspended_Subscriptions suspended_Subscriptions = Suspended_Subscriptions.FindBySubscriptionID(this.SubscriptionID);

            if(Suspended_Subscriptions.Delete(suspended_Subscriptions.SuspendedID))
            {
                this.isSuspended= false;
                if(this.Save())
                    return true;

            }

            return false;
        }

        static public DataTable GetSubscriptionsCountPerGame()
        {
            return DataAccessSubscription.GetSubsriptionsperGame();
        }
    }
}