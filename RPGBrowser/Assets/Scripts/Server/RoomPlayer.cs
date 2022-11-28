using System.Collections;
using System.Collections.Generic;
using Mirror;
using ns_Player;
using UnityEngine;


namespace MirrorNet
{
    public class RoomPlayer : NetworkBehaviour
    {
        public static RoomPlayer localPlayer;
        void Start()
        {
            if (isLocalPlayer)
            {
                localPlayer = this;
            }
        }     

        public void HostGame()
        {
            // List<string> roomListId = EnterRoom.GetRoomPlayerList().roomPlayerIdList;

        }  
    }
}
