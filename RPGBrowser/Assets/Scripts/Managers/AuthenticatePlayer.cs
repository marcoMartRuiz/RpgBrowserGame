using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Unity.Collections;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using FirebaseWebGL.Scripts.FirebaseBridge;
using FirebaseWebGL.Scripts.Objects;
using FirebaseWebGL.Examples.Utils;
using ns_UIfunctions;


public class AuthenticatePlayer : MonoBehaviour
{
    [SerializeField] Button forgotPassword;
    [SerializeField] TMP_InputField emailInput;
    [SerializeField] TMP_InputField passwordInput;
    [SerializeField] Button loginButton;
    [SerializeField] Button SignUpButton;
    [SerializeField] TextMeshProUGUI errorMessageEmptyField;
    [SerializeField] TextMeshProUGUI errorMessageNoMatch;
    [SerializeField] TextMeshProUGUI successText;
    [SerializeField] GameObject networkContainer;

    // bool isEmailMatch;
    // bool isPasswordMatch;

    public void OnClickSignUp()
    {
        //full email list not check JUST USING AS TEST
        // FirebaseDatabase.GetJSON(path: "players/player0/password", gameObject.name, callback: "OnSignUpPasswordCheck", fallback: "OnSignUpFailed"); //get
        // FirebaseDatabase.GetJSON(path: "players/player0", gameObject.name, callback: "OnRequestSuccessTest", fallback: "OnRequestFailed");

        if (string.IsNullOrEmpty(emailInput.text) || string.IsNullOrEmpty(passwordInput.text))
        {
            // FirebaseDatabase.PostJSON(path: "players", value: "playerTest: {email: emailInput.text, password: passwordInput.text}", gameObject.name, callback: "OnRequestSuccess", fallback: "OnRequestFailed");
            errorMessageEmptyField.gameObject.SetActive(true);
        }
        else
        {
            FirebaseAuth.CreateUserWithEmailAndPassword(email: emailInput.text, password: passwordInput.text, gameObject.name, callback: "OnRequestSuccess", fallback: "OnSignUpFailed");
        }
    }

    // private void OnRequestSuccessTest(string data) //All at once ..**FIX**..
    // {
    //     string inputData = "{email: " + emailInput.text + "," + "password: " + passwordInput.text + "}";
    //     if (data == inputData)
    //     {
    //         FirebaseDatabase.PostJSON(path: "players", value: "player: {email: emailInput.text, password: passwordInput.text}", gameObject.name, callback: "OnRequestSuccess", fallback: "OnRequestFailed");
    //     }
    // }
    //---------------------------------------------------------------------
    public void OnClickLogin()
    {
        // checked email and password
        // FirebaseDatabase.GetJSON(path: "players/player0/password", gameObject.name, callback: "OnSignUpPasswordCheck", fallback: "OnRequestFailed");
        if (string.IsNullOrEmpty(emailInput.text) || string.IsNullOrEmpty(passwordInput.text))
        {
            //load lobby scene
            errorMessageNoMatch.gameObject.SetActive(true);
        }
        else
        {
            // FirebaseAuth.SignInWithEmailAndPassword(email: emailInput.text, password: passwordInput.text, gameObject.name, callback: "OnRequestSuccess", fallback: "OnLoginFailed");
            OnRequestSuccess("Hello");

        }

    }
    //---------------------------------------------------------------------

    public void OnClickForgotPassword()
    {

    }

    private void OnSignUpFailed(string error)
    {
        errorMessageEmptyField.gameObject.SetActive(true);
    }
    //---------------------------------------------------------------------
    private void OnLoginFailed(string error)
    {
        errorMessageNoMatch.gameObject.SetActive(true);
    }
    private void OnRequestSuccess(string data)
    {
        successText.gameObject.SetActive(true);
        successText.text = data;
        gameObject.SetActive(false);
        networkContainer.SetActive(true);
    }
    // public void DisplayInfo(string info)
    // {
    //     successText.color = Color.green;
    //     testText.text = info;
    //     testText.gameObject.SetActive(true);
    // }
    // public void DisplayErrorObject(string error)
    // {
    //     var parsedError = StringSerializationAPI.Deserialize(typeof(FirebaseError), error) as FirebaseError;
    //     DisplayError(parsedError.message);
    // }
    // public void DisplayError(string error)
    // {
    //     testText.color = Color.red;
    //     testText.text = error;
    //     Debug.LogError(error);
    // }



    // private void OnSignUpEmailCheck(string data)
    // {
    //     successText.text = data;
    //     if (data == emailInput.text)
    //     {
    //         isEmailMatch = false;
    //     }
    //     else
    //     {
    //         isEmailMatch = true;
    //     }
    // }
    // private void OnSignUpPasswordCheck(string data)
    // {
    //     if (data == passwordInput.text)
    //     {
    //         isPasswordMatch = false;
    //     }
    //     else
    //     {
    //         isPasswordMatch = true;
    //     }
    // }
}
