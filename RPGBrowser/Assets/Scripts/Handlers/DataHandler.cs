using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class DataHandler
{
    public static Hashtable playerList = new Hashtable(); //PlayerDictionary
    static DataHandler()
    {
        
    }
    public static List<string> GetPlayerList(int playerid, string name)
    {
        //    Player player = new Player();
        List<string> playerList = new List<string>();
        playerList.Add(name);
        return playerList;
    }
    public static void SetPlayerData()
    {
    }
    public static void GetNpcData()
    {

    }
    public static void SetNpcData()
    {

    }
    // public static Dictionary<string, GameObject> GetDmData(int gameid, string dmname)
    // {
    //     return playerList;
    // }
    public static void SetDmData(string name, GameObject PrefabObj)
    {
        playerList.Add(name, PrefabObj);
    }
    public static void GetWorldData()
    {

    }
    public static void SetWorldData()
    {

    }
    public static void GetSceneData()
    {

    }
    public static void SetSceneData()
    {

    }
}
