using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ClientList : MonoBehaviour
{
   
    [SerializeField] TextMeshProUGUI text;
    [SerializeField] TMP_InputField newInputEmail;
    [SerializeField] TMP_InputField newInputPassword;



    // public void SubmitText()
    // {
    //     var newInputName2 = GameObject.Instantiate(newInputName);
    //     newInputName2.transform.position = new Vector3(newInputName.transform.parent.position.x, newInputName.transform.parent.position.y - 40f, newInputName.transform.parent.position.z);
    //     newInputName2.text = currentInputField.text;
    //     newInputName2.fontSize = 14f;
    //     // newInputName.text = currentInputField.text;
    //     newNameText = currentInputField.textComponent.text; 

    // }
  
   

    public void OnLoginButton()
    {
        // getclentList compare 
        FirbaseDB.GetJSON(path: newInputEmail.text, gameObject.name, callback: "OnRequestSuccess", fallback: "OnRequestFailed");
        // search algorith on client list
        //if both email and password and RandomRoomkey match allow auth token to be given and access 
        if (newInputEmail.text == "ocram414@gmail.com")
        {
            // FirebaseAuthservices and ?Onchangescene
            Debug.Log("access granted");
            // onChangescene
        }
        else
        {
           Debug.Log("Denied");
           //error message for client and remove/reset client inputs
        }

        //open commadnds for dbserver <-> clients
    }

    //OnSignUpButton aka JoinButton
    public void OnSignUpButton()
    {

        //create client template info
        //fill in email, password, etc. 
        //etc
    }
    private void OnRequestSuccess(string data)
    {
        text.color = Color.green;
        text.text = data;
    }
    private void OnRequestFailed(string error)
    {
        text.color = Color.red;
        text.text = error;
    }


}
