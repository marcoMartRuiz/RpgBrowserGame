using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Mathematics;

namespace ns_physics
{
    public static class ObjMovement
    {
        public static Rigidbody2D rigbody;
        public static RenderTexture renderTexture;
        public static Texture texture;
        public static float walkRadius;
        public static float dashRadius;
        public static float radiusDistance;
        public static float charSpeed;
        public static Vector2 initalPosition;
        public static Vector2 finalPosition;
        public static float horizontalMov;
        public static float verticalMov;
        public static Vector2 movementVelocity;
        // public TextMesh playerNameText;

        public static Vector2 getMovementVelocity(float moveRadius, float2 currentPosition, float2 newPosition, float movementSpeed)
        {
            movementVelocity = new Vector2(newPosition.x, newPosition.y);
            return movementVelocity;
        }

        public static void DashMovement()
        {
            if (radiusDistance <= walkRadius)
            {

            }
            if (radiusDistance > walkRadius)
            {

            }
        }
        public static void getPlayerRadius()
        {

        }
        public static void DrawOnRadius()
        {

        }


    }


}


//     addNameList = new AddNameList();
//     if (this.isLocalPlayer)
//     {
//         body = GetComponent<Rigidbody2D>();
//     }
//     CmndSetupPlayer(addNameList.NameText());
//     ConnectToServer();


// void Update()
// {
//     if (this.isLocalPlayer)
//     {
//         horizontalMov = Input.GetAxisRaw("Horizontal");
//         verticalMov = Input.GetAxisRaw("Vertical");
//     }
// }
// private void FixedUpdate()
// {
//     if (this.isLocalPlayer)
//     {
//         body.velocity = new Vector2(horizontal * Speed1, vertical * Speed1);
//     }
// }


// [SyncVar(hook = nameof(OnNameChange))] public string playerName;
// public AddNameList addNameList;
// public void ConnectToServer()
// {
//     Debug.Log(NetworkServer.spawned.Count);
//     Debug.Log(NetworkServer.spawned[1].ToString());
//     //    NetworkServer.Spawn()

// }
// public void OnNameChange(string _oldName, string _newName)
// {
//     playerNameText.text = playerName;
// }
// [Command]
// public void CmndSetupPlayer(string _name)
// {
//     playerName = _name;
// }