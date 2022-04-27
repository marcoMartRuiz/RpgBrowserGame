using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using ns_physics;
using ns_UI;
namespace ns_Player{

    public class Player : MonoBehaviour{
    
        [SerializeField] GameObject brush;
        [SerializeField] string playerName;
        GameObject brushInstance;
       
    
        private void Start(){
            // newplayer = Instantiate(this.gameObject, transform.position, Quaternion.identity, GameObject.FindGameObjectWithTag("Canvas").transform);
            // newplayerName = newplayer.transform.Find("PlayerNameTextObj").GetComponent<TextMeshProUGUI>();
            // r1 = newplayer.transform.Find("innerRadiusObj").gameObject;
            // drawArea = new DrawArea();
            //may want to add drawarea class instance to save rout info?
        }
        // private void Update(){
        //     Vector2 worldPoint = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        //     RaycastHit2D hit = Physics2D.Raycast(worldPoint, Vector2.zero);
        //     //get obj that mouse is hovering over
            
        //     if (Input.GetMouseButtonDown(0) & hit.collider != null){
        //         //get obj mouse hovers over and
        //         newplayer.transform.Find("MenuPanelObj").gameObject.SetActive(true);
               
        //        if (r1.activeInHierarchy == false)
        //        {
                   
        //         brushInstance = Instantiate(brush, transform.position, Quaternion.identity, GameObject.FindGameObjectWithTag("Canvas").transform);
        //         drawArea.CreateBrush(brushInstance,worldPoint,PlayerPrefab);
        //        }
                   
              
        //     }
        //     else if (Input.GetMouseButton(0) & r1.activeInHierarchy)
        //     {
        //         drawArea.PointToMousePos(worldPoint);

               
        //     }
        //      if (Input.GetMouseButtonUp(0) & r1.activeInHierarchy)
        //     {
        //         // drawArea.getPathDrawn();
                
     
        //     }
        //     // if (Input.GetMouseButtonDown(1)){
        //     //     Debug.Log("Right Click");
        //     // }

        //     ObjMovement.getMovementVelocity(10f, new Unity.Mathematics.float2(newplayer.transform.position.x, newplayer.transform.position.y), new Unity.Mathematics.float2(10, 10), 10f);


        // }
    }


}
