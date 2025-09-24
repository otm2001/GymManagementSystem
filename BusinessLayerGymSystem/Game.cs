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
    public class Game
    {
        private enum enMode
        {
            AddNew,
            Update
        }

        private enMode Mode = enMode.AddNew;
        public int GameID { get; set; }

        public string GameName { get; set; }
        public float MonthlyFee { get; set; }
        public float DailyFee { get; set; }

        private bool _Update()
        {
            return (DataAccessGame.UpdateGame(GameID, GameName, MonthlyFee, DailyFee));
        }
        private bool _AddNewGame()
        {
            GameID = DataAccessGame.AddNewGame(GameName, MonthlyFee, DailyFee);

            return (GameID != -1);
        }

        public Game()
        {
            GameID = -1;
            GameName = string.Empty;
            MonthlyFee = 0;
            DailyFee = 0;
            Mode = enMode.AddNew;
        }

        public Game(int gameID, string gameName, float monthlyFee, float dailyFee)
        {
            GameID = gameID;
            GameName = gameName;
            MonthlyFee = monthlyFee;
            DailyFee = dailyFee;
            Mode = enMode.Update;
        }

        static public Game Find(int GameID)
        {
            string GameName = "";
            float MonthlyFee= 0, DailyFee= 0;

            if(DataAccessGame.FindGameByID(GameID,ref GameName,ref MonthlyFee,ref DailyFee))
            {
                return new Game(GameID,GameName,MonthlyFee,DailyFee);
            }

            return null;
        }

        static public bool Delete(int GameID)
        {
            return (DataAccessGame.DeleteGame(GameID));
        }
        static public Game FindByName(string GameName)
        {
            int GameID = -1;
            float MonthlyFee = 0, DailyFee = 0;

            if(DataAccessGame.FindGameByName(GameName,ref GameID,ref  MonthlyFee,ref DailyFee))
            {
                return new Game(GameID, GameName,MonthlyFee,DailyFee);
            }
            return null;


        }
        public bool Save()
        {
            if (Mode == enMode.AddNew)
            {
                if (_AddNewGame())
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

        static public DataTable GetAllGames()
        {

        return DataAccessGame.GetAllGames(); 
        }
    }
}
