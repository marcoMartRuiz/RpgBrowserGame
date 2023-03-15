using System;
using System.Collections.Generic;
using UnityEngine;
using Newtonsoft;
namespace ns_RealtimeDBObj
{

    public class Game
    {

        public int game_id
        {
            get;
            set;
        }
        public string dm
        {
            get;
            set;
        }



    }
   public class UserID
    {
        public string uid { get; set; }
        public UserData UserData {get; set;}
    }

    public class UserData
    {
        public string username { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        // public string RegionNum { get; set; }
        // List<SavedGames> SavedGamesList { get; set; }

    }

    public class SavedGames
    {

        public string gameName;
        public DateTime savedDate;
    }
}