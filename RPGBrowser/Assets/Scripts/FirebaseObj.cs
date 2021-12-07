using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Runtime.InteropServices;
using TMPro;

public class FirebaseObj : MonoBehaviour
{
    public TextMeshProUGUI text ;
    
   [DllImport("__Internal")]
   public static extern void GetJSON(string path, string objectName, string callback, string fallback);
    void Start()
    {
       GetJSON(path: "example", gameObject.name, callback: "OnRequestSuccess", fallback: "OnRequestFailed");
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
