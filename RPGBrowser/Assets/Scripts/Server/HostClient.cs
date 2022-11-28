using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mirror;
using kcp2k;

namespace MirrorNet
{
    public class HostClient : MonoBehaviour
    {
        // [SerializeField] GameObject roomObj;
        [SerializeField] NetworkManager networkManager;
        private void Start()
        {
            if (!Application.isBatchMode)
            {
                Debug.Log($"=== Client Build ===");
                networkManager.StartClient();
            }
            else
            {
                Debug.Log($"=== Server Build ===");
            }
        }
        public void OnClickJoinRoom()
        {
            networkManager.networkAddress = "localhost";
            networkManager.StartClient();
        }
        public void OnClickHostRoom()
        {
            //  networkManager.StartHost();
            //  InstantiateObj();
        }

        public void InstantiateObj()
        {
            // NetworkBehaviour.Instantiate(roomObj, roomObj.transform);
        }
    }
}
