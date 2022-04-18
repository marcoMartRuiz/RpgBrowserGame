using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mirror;

public class AutoHostClient : NetworkBehaviour
{   
    [SerializeField] GameObject roomObj;
    [SerializeField] NetworkManager networkManager;
    private void Start() {
        if (!Application.isBatchMode)
        {
            
        }
    }
    public void OnClickJoinRoom()
    {
        networkManager.networkAddress = "localhost";
        networkManager.StartClient();
    }
     public void OnClickHostRoom()
     {
         networkManager.StartHost();
         InstantiateObj();
     }
   
    public void InstantiateObj()
    {
        NetworkBehaviour.Instantiate(roomObj, roomObj.transform);
    }
}
