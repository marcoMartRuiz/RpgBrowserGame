using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Collections;
using TMPro;
using System.Runtime.InteropServices;
using UnityEngine.UI;
using System;


public class OfflineManager : MonoBehaviour
{
    [SerializeField] Button forgotPassword;
    [SerializeField] TMP_InputField emailInput;
    [SerializeField] TMP_InputField passwordInput;
    [SerializeField] TextMeshProUGUI errorMessageSignUp;
    [SerializeField] TextMeshProUGUI errorMessageLogin;
    [SerializeField] TextMeshProUGUI successText;
    [SerializeField] TextMeshProUGUI failText;
    bool correctEmail;
    bool correctPassword;

    public void OnClickSignUp()
    {
        //full email list not check JUST USING AS TEST
        FirbaseDB.GetJSON(path: "players/player0/email", gameObject.name, callback: "OnSignUpEmailCheck", fallback: "OnSignUpFailed"); //get
        FirbaseDB.GetJSON(path: "players/player0/password", gameObject.name, callback: "OnSignUpPasswordCheck", fallback: "OnSignUpFailed"); //get
        // FirbaseDB.GetJSON(path: "players/player0", gameObject.name, callback: "OnRequestSuccessTest", fallback: "OnRequestFailed");

        if (correctEmail && correctPassword)
        {
            FirbaseDB.PostJSON(path: "players", value: "playerTest: {email: emailInput.text, password: passwordInput.text}", gameObject.name, callback: "OnRequestSuccess", fallback: "OnRequestFailed");
            //Add separate email and password if doesnt work
        }
    }
    private void OnSignUpEmailCheck(string data)
    {
        if (data == emailInput.text)
        {
            correctEmail = false;
        }
        else
        {
            correctEmail = true;
        }
    }
    private void OnSignUpPasswordCheck(string data)
    {
        if (data == passwordInput.text)
        {
            correctPassword = false;
        }
        else
        {
            correctPassword = true;
        }
    }
    private void OnRequestSuccessTest(string data) //All at once ..**FIX**..
    {
        string inputData = "{email: " + emailInput.text + "," + "password: " + passwordInput.text + "}";
        if (data == inputData)
        {
            FirbaseDB.PostJSON(path: "players", value: "player: {email: emailInput.text, password: passwordInput.text}", gameObject.name, callback: "OnRequestSuccess", fallback: "OnRequestFailed");
        }
    }
    //---------------------------------------------------------------------
    public void OnClickLogin()
    {
        // checked email and password
        FirbaseDB.GetJSON(path: "players/player0/email", gameObject.name, callback: "OnSignUpEmailCheck", fallback: "OnRequestFailed");
        FirbaseDB.GetJSON(path: "players/player0/password", gameObject.name, callback: "OnSignUpPasswordCheck", fallback: "OnRequestFailed");
        if (!correctEmail && !correctPassword)
        {
            //load lobby scene
            successText.gameObject.SetActive(true);
            successText.color = Color.blue;
        }
        else
        {
            errorMessageLogin.gameObject.SetActive(true);
        }

    }
    //---------------------------------------------------------------------

    public void OnClickForgotPassword()
    {
        FirbaseDB.DeleteJSON(path: "rooms/room", gameObject.name, callback: "OnRequestSuccess", fallback: "OnRequestFailed");
    }

    private void OnSignUpFailed(string error)
    {
        errorMessageSignUp.gameObject.SetActive(true);
    }
    //---------------------------------------------------------------------
    private void OnRequestFailed(string error)
    {
        failText.gameObject.SetActive(true);
    }
    private void OnRequestSuccess(string error)
    {
        successText.gameObject.SetActive(true);
    }
}
