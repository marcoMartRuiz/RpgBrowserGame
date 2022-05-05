using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameSceneHandler : MonoBehaviour
{
    public GameObject playerPrefab;
    public GameObject DmPrefab;
    public string DmName = "DM";
    public int playerId = 0;

    void Start()
    {
        List<string> nameList = new List<string>();
        nameList.Add("soldier");
        // nameList.Add("Meep");

        // MainManager.Instance.gameManager.currentGameInfo.playersIds;


                var newDm = Instantiate(DmPrefab, new Vector2(100, 100), Quaternion.identity, GameObject.FindGameObjectWithTag("Canvas").transform);
                // DataHandler.SetDmData(DmName, newDm);

        var playerHashTable = DataHandler.GetDmData();
            Debug.Log(playerHashTable.Keys);

        foreach (var playername in nameList)
        {

            // var newEnviroment = Instantiate(EnviroPrefab, Vector2.zero, Quaternion.identity, GameObject.FindGameObjectWithTag("Canvas").transform);
            // var newA = Instantiate(Prefab, Vector2.zero, Quaternion.identity, GameObject.FindGameObjectWithTag("Canvas").transform);
                var newPlayer = Instantiate(playerPrefab, new Vector2(0, 0), Quaternion.identity, GameObject.FindGameObjectWithTag("Canvas").transform);
                var newPlayerHandler = newPlayer.GetComponent<PlayerHandler>();
           

            // newPlayerHandler.playerId = player.ToString();
            // newPlayerHandler.isLocalPlayer = player == playerList[0];
            // MainManager.Instance.currentLocalPlayerId;
            // newPlayerHandler.yourTurn = yourTurn;
        }
    }
    void Update()
    {
        if (false)
        {
            // Destroy(playerList[playerid]);
        }
    }
}
