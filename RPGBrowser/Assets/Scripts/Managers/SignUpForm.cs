using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using FirebaseWebGL.Scripts.FirebaseBridge;
using FirebaseWebGL.Scripts.Objects;
using FirebaseWebGL.Examples.Utils;
using ns_RealtimeDBObj;
using Newtonsoft.Json;

namespace ns_Forms
{
    public class SignUpForm : MonoBehaviour
    {
        [SerializeField] TMP_InputField UsernameInput;
        [SerializeField] TMP_InputField EmailInput;
        [SerializeField] TMP_InputField PasswordInput;
        // [SerializeField] TMP_InputField RegionInput;
        [SerializeField] Toggle toggle;
        [SerializeField] TextMeshProUGUI ErrorMessageText;
        [SerializeField] Button BackToLoginButton;

        public void OnClickCreateAccount()
        {
            if (string.IsNullOrEmpty(UsernameInput.text) || string.IsNullOrEmpty(EmailInput.text) || string.IsNullOrEmpty(PasswordInput.text))
            {
                FormFunctions.SignInMessages(0);
            }
            else
            {
                FirebaseAuth.CreateUserWithEmailAndPassword(email: EmailInput.text, password: PasswordInput.text, gameObject.name, callback: "OnSignUpSuccess", fallback: "DisplayErrorObject");
            }
        }

        private void OnSignUpSuccess(string data)
        {
            FirebaseAuth.OnAuthStateChanged(gameObject.name, onUserSignedIn: "isUserSignedIn", onUserSignedOut: "isUserSignedOut");
            
            BackToLoginButton.gameObject.SetActive(true);
        }
        public void isUserSignedIn(string user)
        {

            UserData userData = new UserData
            {
                username = UsernameInput.text,
                email = EmailInput.text,
                password = PasswordInput.text
    
            };
            string jsonValue = JsonConvert.SerializeObject(userData, Formatting.Indented);// string inputData = "{email: " + emailInput.text + "," + "password: " + passwordInput.text + "}";
            // errorMessageText.text = " ";
            FirebaseDatabase.UpdateJSON(path: "rpgGame/users/"+user, value: jsonValue, gameObject.name, callback: "OnSignInRequestSuccess", fallback: "OnSignInRequestFailed");

            // string user_id = user;
            // ErrorMessageText.text = user_id;
        }
        public void isUserSignedOut(string user)
        {
            //add later
        }
        public void OnSignInRequestSuccess(string data)
        {
            ErrorMessageText.text = FormFunctions.SignInMessages(4);
            UsernameInput.text = "";
            EmailInput.text = "";
            PasswordInput.text = "";
            
            // ErrorMessageText.text = data;
        }
        public void OnSignInRequestFailed(string error)
        {
            ErrorMessageText.text = error;
            ErrorMessageText.fontSize = 14;
        }
        public void DisplayErrorObject(string error)
        {
            var parsedError = StringSerializationAPI.Deserialize(typeof(FirebaseError), error) as FirebaseError;
            OnSignInRequestFailed(parsedError.message);
        }
        public void onToggleHidePassword()
        {
            FormFunctions.ToggleHidePassword(PasswordInput, toggle);
        }
    }
}