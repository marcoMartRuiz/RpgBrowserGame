using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Collections;
using TMPro;
using System.Runtime.InteropServices;
public class CreateRoom : MonoBehaviour
{
    [SerializeField]
    GameObject ButtonTemplate;

    [SerializeField]
    TextMeshProUGUI roomName;
    TextMeshProUGUI inputText;
    
    List<GameObject> ButtonArray;
    public void OnClickCreateRoom()
    {
        var buttonObjNth = Instantiate(ButtonTemplate);
        ButtonArray.Add(buttonObjNth);
        roomName.text = inputText.text;
    }
    public void OnClickSignUp()
    {

    }
    public void OnclickLogin()
    {

    }
    
    
}
