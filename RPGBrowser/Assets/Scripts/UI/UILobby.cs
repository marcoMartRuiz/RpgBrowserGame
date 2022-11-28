using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace MirrorNet
{
    public class UILobby : MonoBehaviour
    {
        [SerializeField] TMP_InputField joinInput;
        [SerializeField] Button joinButton;
        [SerializeField] Button hostButton;

        public void Host()
        {
            joinInput.interactable = false;
            joinButton.interactable = false;
            hostButton.interactable = false;
            
            RoomPlayer.localPlayer.HostGame();

        }
        public void Join()
        {
            joinInput.interactable = false;
            joinButton.interactable = false;
            hostButton.interactable = false;
        }
    }
}
