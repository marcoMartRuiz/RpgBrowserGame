using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.IO;
using Unity.Collections;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using FirebaseWebGL.Scripts.FirebaseBridge;
using FirebaseWebGL.Scripts.Objects;
using FirebaseWebGL.Examples.Utils;
using ns_UIfunctions;
using Newtonsoft.Json;
using ns_RealtimeDBObj;




public class AuthenticatePlayer : MonoBehaviour
{
    [SerializeField] Button forgotPassword;
    [SerializeField] TMP_InputField usernameInput;
    [SerializeField] TMP_InputField emailInput;
    [SerializeField] TMP_InputField passwordInput;
    [SerializeField] Button loginButton;
    [SerializeField] Button SignUpButton;
    [SerializeField] TextMeshProUGUI errorMessageText;
    [SerializeField] GameObject networkContainer;

    // bool isEmailMatch;
    // bool isPasswordMatch;
    public string SignInErrorMessages(int i)
    {
        string[] signInErrorMessages = { "Empty field not valid", "Password or Email does not match" };
        return signInErrorMessages[i];
    }

    public void OnClickSignUp()
    {

        if (string.IsNullOrEmpty(emailInput.text) || string.IsNullOrEmpty(passwordInput.text))
        {
            // FirebaseDatabase.PostJSON(path: "players", value: "playerTest: {email: emailInput.text, password: passwordInput.text}", gameObject.name, callback: "OnRequestSuccess", fallback: "OnRequestFailed");
            errorMessageText.text = SignInErrorMessages(0);
        }
        else
        {
            FirebaseAuth.CreateUserWithEmailAndPassword(email: emailInput.text, password: passwordInput.text, gameObject.name, callback: "OnSignUpSuccess", fallback: "DisplayErrorObject");
        }
    }
    //---------------------------------------------------------------------
    public void OnClickLogin()
    {
        // checked email and password
        if (string.IsNullOrEmpty(emailInput.text) || string.IsNullOrEmpty(passwordInput.text))
        {
            //load lobby scene
            errorMessageText.text = SignInErrorMessages(0);
        }
        //check if account is in use (low)
        else
        {
            FirebaseAuth.SignInWithEmailAndPassword(email: emailInput.text, password: passwordInput.text, gameObject.name, callback: "OnLoginSuccess", fallback: "DisplayErrorObject");
        }
    }
    //---------------------------------------------------------------------
    // private void OnSignUpSuccess(string data)
    // {
    //     UserData emailPasswordData = new UserData
    //     {
    //         username = usernameInput.text,
    //         email = emailInput.text,
    //         password = passwordInput.text,
    //     };
    //     string jsonValue = JsonConvert.SerializeObject(emailPasswordData, Formatting.Indented);// string inputData = "{email: " + emailInput.text + "," + "password: " + passwordInput.text + "}";
    //     errorMessageText.text = " ";
    //     FirebaseDatabase.PostJSON(path: "browsergame/players", value: jsonValue, gameObject.name, callback: "OnRequestSuccess", fallback: "DisplayErrorObject");
    // }
    private void OnLoginSuccess(string data)
    {
        // gameObject.SetActive(false);
        // networkContainer.SetActive(true);

        errorMessageText.text = " ";
    }
    //-----------------------------------------------S----------------------
    public void OnRequestSuccess()
    {
        errorMessageText.color = Color.green;
        errorMessageText.text = "sucess";
    }
    private void OnRequestFailed(string error)
    {
        errorMessageText.text = error;
    }
    //---------------------------------------------------------------------
    public void OnClickForgotPassword()
    {

    }
    public void DisplayErrorObject(string error)
    {
        var parsedError = StringSerializationAPI.Deserialize(typeof(FirebaseError), error) as FirebaseError;
        OnRequestFailed(parsedError.message);
    }





}
