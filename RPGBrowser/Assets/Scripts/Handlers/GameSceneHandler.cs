
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Newtonsoft.Json;
public class GameSceneHandler : MonoBehaviour
{
    public GameObject playerPrefab;
    public GameObject DmPrefab;
    public string playerName = "Marco";
    public int playerId = 0;
    public bool isHost = false;

    void Start()
    {
        // List<string> nameList = new List<string>();
        // nameList.Add("Marco");

        // Game game = new Game();
        if (isHost == true) 
        {
            var newGm = Instantiate(DmPrefab, new Vector2(50, 50), Quaternion.identity, GameObject.FindGameObjectWithTag("Canvas").transform);
            // var playerHashTable = DataHandler.GetDmData(playerId, playerName);
            DataHandler.playerList.Add(playerId, newGm);
        }
        else
        {
            var newPlayer = Instantiate(playerPrefab, new Vector2(0, 0), Quaternion.identity, GameObject.FindGameObjectWithTag("Canvas").transform);

            var playerKey = DataHandler.playerList.ContainsKey(playerId);
            if(!playerKey)
            {
                DataHandler.playerList.Add(playerId, newPlayer);
            }
                playerId ++;

            // var playerdata = DataHandler.GetPlayerData(playerId, playerName);

            var newPlayerHandler = newPlayer.GetComponent<PlayerHandler>();
        }

        // MainManager.Instance.gameManager.currentGameInfo.playersIds;


        // DataHandler.SetDmData(GmName, newGm);

     

        // foreach (var playername in nameList)
        // {

        //     // var newEnviroment = Instantiate(EnviroPrefab, Vector2.zero, Quaternion.identity, GameObject.FindGameObjectWithTag("Canvas").transform);
        //     // var newA = Instantiate(Prefab, Vector2.zero, Quaternion.identity, GameObject.FindGameObjectWithTag("Canvas").transform);


        //     // newPlayerHandler.playerId = player.ToString();
        //     // newPlayerHandler.isLocalPlayer = player == playerList[0];
        //     // MainManager.Instance.currentLocalPlayerId;
        //     // newPlayerHandler.yourTurn = yourTurn;
        // }
    }
    void Update()
    {
        if (false)
        {
            // Destroy(playerList[playerid]);
        }
    }
}
