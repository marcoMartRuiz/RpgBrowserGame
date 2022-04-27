using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ns_UI;

public class PlayerHandler : MonoBehaviour
{

    public string playerId;
    public bool isLocalPlayer;
    public bool isPlayerTurn;
    public bool isGM;

    private void Start()
    {
        if (isLocalPlayer)
        {

        }
        else
        {

        }
    }

    private void Update()
    {
        // move and stuff
        Vector2 onScreenPoint = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        RaycastHit2D raycastHit = Physics2D.Raycast(onScreenPoint, Vector2.zero);

        if (Input.GetMouseButtonDown(0))
        {
            if (raycastHit.collider != null)
            {
                this.transform.Find("MenuPanelObj").gameObject.SetActive(true);
                this.transform.Find("PlayerSprite").gameObject.SetActive(false);

                // this.gameObject.GetComponent<Collider2D>().enabled = false;
            }
        }
        if (Input.GetKeyUp("escape"))
        {
            this.GetComponent<Collider2D>().enabled = true;
            this.transform.Find("RadiusObj").gameObject.SetActive(false);
        }
        // if (Input.GetMouseButton(0))
        // {

        // }
    }
}