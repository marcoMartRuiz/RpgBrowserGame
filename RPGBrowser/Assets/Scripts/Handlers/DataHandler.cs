using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class DataHandler
{
    public static Dictionary<string, GameObject> playerList = new Dictionary<string, GameObject>();

    public static void GetPlayerListData()
    {

    }
    public static void SetPlayerListData()
    {

    }
    public static void GetNpcData()
    {

    }
    public static void SetNpcData()
    {

    }
    public static Dictionary<string, GameObject> GetDmData()
    {
        return playerList;
    }
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
