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
        // public UserData UserData {get; set;}
    }
    public class CharacterID
    {
        public int id {get; set;}
    }
    public class UserData
    {
        public string username { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        // public string RegionNum { get; set; }
        // List<SavedGames> SavedGamesList { get; set; }

    }
    public class MyCharacters
    {
        public IList<CharacterID> characterList {get; set;}
    }

    public class MyCampaigns
    {

        // List<Player> PlayerList =  new List<Player>();
        public string name {get; set;}
        public string password {get; set;}
        public IList<UserID> playerlist {get; set;}
    }

    
}