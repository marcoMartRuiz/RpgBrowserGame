using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameSceneHandler : MonoBehaviour
{
    public GameObject playerPrefab;

    void Start()
    {
        // MainManager.Instance.gameManager.currentGameInfo.playersIds;
        var playerList = new List<string>();
        playerList.Add("Marco");
        // playerList.Add("Ocram");
        // playerList.Add("Alisa");
        foreach (var player in playerList)
        {
            var newPlayer = Instantiate(playerPrefab, Vector2.zero, Quaternion.identity, GameObject.FindGameObjectWithTag("Canvas").transform);
            var newPlayerHandler = newPlayer.GetComponent<PlayerHandler>();

            newPlayerHandler.playerId = player;
            newPlayerHandler.isLocalPlayer = player == playerList[0].ToString();
            // MainManager.Instance.currentLocalPlayerId;
            // newPlayerHandler.yourTurn = yourTurn;
        }
    }
    void Update()
    {

    }
}
