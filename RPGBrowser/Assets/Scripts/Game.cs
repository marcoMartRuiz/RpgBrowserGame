using System;
using System.Collections.Generic;
using UnityEngine;
using Newtonsoft;

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
    List<Player> playerList
    {
        get;
        set;
    }


}

public class Player
{
    public string player_name
    {
        get;
        set;
    }
    public string player_num
    {
        get;
        set;
    }
}