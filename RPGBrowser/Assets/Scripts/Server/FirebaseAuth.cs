using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Runtime.InteropServices;
using TMPro;

public class FirebaseAuth : MonoBehaviour
{   
    public GameObject passwordInputFieldObj;
    
    public TextMeshProUGUI emailText;
    public TextMeshProUGUI passwordText;
    /// <summary>                                                                                                          
    /// Creates a user with email and password                                                                             
    /// </summary>                                                                                                         
    /// <param name="email"> User email </param>                                                                           
    /// <param name="password"> User password </param>                                                                     
    /// <param name="objectName"> Name of the gameobject to call the callback/fallback of </param>                         
    /// <param name="callback"> Name of the method to call when the operation was successful. Method must have signature: void Method(string output) </param>                                           /// <param name="fallback"> Name of the method to call when the operation was unsuccessful. Method must have signature: void Method(string output). Will return a serialized FirebaseError object </param>                                            
    [DllImport("__Internal")]
    public static extern void CreateUserWithEmailAndPassword(string email, string password, string objectName, string callback, string fallback);

    /// <summary>                                                                                                          
    /// Signs in a user with email and password                                                                            
    /// </summary>                                                                                                         
    /// <param name="email"> User email </param>                                                                           
    /// <param name="password"> User password </param>                                                                     
    /// <param name="objectName"> Name of the gameobject to call the callback/fallback of </param>                         
    /// <param name="callback"> Name of the method to call when the operation was successful. Method must have signature: void Method(string output) </param>                                           /// <param name="fallback"> Name of the method to call when the operation was unsuccessful. Method must have signature: void Method(string output). Will return a serialized FirebaseError object </param>                                            
    [DllImport("__Internal")]
    public static extern void SignInWithEmailAndPassword(string email, string password, string objectName, string callback, string fallback);

    private void Start()
    {

    }
    private void OnRequestSuccess(string data)
    {
        // text.color = Color.green;
        // text.text = data;
    }
    private void OnRequestFailed(string error)
    {
        // text.color = Color.red;
        // text.text = error;
    }

    private void GetUserAuth()
    {
        CreateUserWithEmailAndPassword(emailText.text,passwordText.text , gameObject.name, callback: "OnRequestSuccess", fallback: "OnRequestFailed");
    }

    public void OnClickSignUp()
    {
        
    }
    public void OnClickLogin()
    {

    }
}
