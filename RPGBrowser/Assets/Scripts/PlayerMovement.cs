using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mirror;
using TMPro;
public class PlayerMovement : NetworkBehaviour
{
    Rigidbody2D body;
    float horizontal;
    float vertical;
    public float runSpeed = 10.0f;
    public TextMesh playerNameText;
    [SyncVar(hook = nameof(OnNameChange))] public string playerName;
    public AddNameList addNameList;
    void Start()
    {
        addNameList = new AddNameList();
        if (this.isLocalPlayer)
        {
            body = GetComponent<Rigidbody2D>();
        }
        CmndSetupPlayer(addNameList.NameText());
        ConnectToServer();

    }
    void Update()
    {
        if (this.isLocalPlayer)
        {
            horizontal = Input.GetAxisRaw("Horizontal");
            vertical = Input.GetAxisRaw("Vertical");
        }
    }
    private void FixedUpdate()
    {
        if (this.isLocalPlayer)
        {
            body.velocity = new Vector2(horizontal * runSpeed, vertical * runSpeed);
        }
    }
     public void ConnectToServer()
   {
       Debug.Log(NetworkServer.spawned.Count);
       Debug.Log(NetworkServer.spawned[1].ToString());
    //    NetworkServer.Spawn()

   }
    public void OnNameChange(string _oldName, string _newName)
    {
        playerNameText.text = playerName;
    }
   [Command]
   public void CmndSetupPlayer(string _name)
   {
       playerName = _name;
   }

}
