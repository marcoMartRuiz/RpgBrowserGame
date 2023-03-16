using UnityEngine;
using UnityEngine.UI;
using TMPro;
using FirebaseWebGL.Scripts.FirebaseBridge;
using FirebaseWebGL.Scripts.Objects;
using FirebaseWebGL.Examples.Utils;
using MirrorNetwork;

namespace ns_Forms
{
    public class LoginForm : MonoBehaviour
    {
        [SerializeField] TMP_InputField EmailInput;
        [SerializeField] TMP_InputField PasswordInput;
        // [SerializeField] Button LoginButton;
        [SerializeField] Toggle toggle;
        [SerializeField] TextMeshProUGUI ErrorMessageText;
        [SerializeField] GameObject HostClientContainer;
        // [SerializeField] TextMeshProUGUI testing;

        //---------------------------------------------------------------------
        public void OnClickLogin()
        {
            // checked email and password is not empty
            // if (string.IsNullOrEmpty(EmailInput.text) || string.IsNullOrEmpty(PasswordInput.text))
            // {
            //     ErrorMessageText.text = FormFunctions.SignInMessages(0);
            // }
            // else
            // //cross refence with firebase auth db 
            // {
            //     FirebaseAuth.SignInWithEmailAndPassword(email: EmailInput.text, password: PasswordInput.text, gameObject.name, callback: "OnLoginSuccess", fallback: "DisplayErrorObject");
            // }

            testingInBrowser();


        }

        public void testingInBrowser()
        {
            EmailInput.text = "ocram414@gmail.com"; //for testing
            PasswordInput.text = "password"; //for testing
            FirebaseAuth.SignInWithEmailAndPassword(email: EmailInput.text, password: PasswordInput.text, gameObject.name, callback: "OnLoginSuccess", fallback: "DisplayErrorObject");
        }
        public void OnClickSignUp()
        {
            EmailInput.text = "";
            PasswordInput.text = "";
            ErrorMessageText.text = FormFunctions.SignInMessages(3);
        }
        public void OnClickForgotPassword()
        {
            ErrorMessageText.text = FormFunctions.SignInMessages(1);
            // FirebaseAuth.SendPasswordResetEmail(email: EmailInput.text, gameObject.name, callback: "OnRequestSuccess", fallback: "DisplayErrorObject");

        }
        //---------------------------------------------------------------------
        private void OnLoginSuccess(string data)
        {
            // if statement d20 dice animation. and if greater than 12 succes login  else...... 
            FirebaseAuth.OnAuthStateChanged(gameObject.name, onUserSignedIn: "isUserSignedIn", onUserSignedOut: "DisplayErrorObject");
          


        }
        public void isUserSignedIn(string user)
        {
            JoinNetwork.userKEY = user;
              FirebaseDatabase.GetJSON(path: "rpgGame/users/" + JoinNetwork.userKEY + "/username", gameObject.name, callback: "gotUsernameSuccess", fallback: "DisplayErrorObject");
        }
        public void OnRequestSuccess()
        {
            ErrorMessageText.color = Color.green;
            ErrorMessageText.text = FormFunctions.SignInMessages(2);
        }
        public void isUserSignedOut(string error)
        {
            // SavedMessageText.text = error;
        }
        private void OnRequestFailed(string error)
        {
            ErrorMessageText.text = error;
        }
        //---------------------------------------------------------------------
        public void DisplayErrorObject(string error)
        {
            var parsedError = StringSerializationAPI.Deserialize(typeof(FirebaseError), error) as FirebaseError;
            OnRequestFailed(parsedError.message);
        }
        public void OnTogglePassword()
        {
            FormFunctions.ToggleHidePassword(PasswordInput, toggle);
        }
        public void gotUsernameSuccess(string data)
        {
            JoinNetwork.username = data;
            HostClientContainer.SetActive(true);
            gameObject.SetActive(false);
           
        }
        public void gotUsernameFailed(string error)
        {
            ErrorMessageText.text = error;
        }

    }

    static class FormFunctions
    {

        public static string SignInMessages(int i)
        {
            string[] SignInMessages = { "Empty field not valid", "This Feature is Coming Soon", "Password reset email sent", "Welcome", "You have successfully sign up" };
            return SignInMessages[i];
        }
        public static void ToggleHidePassword(TMP_InputField inputField, Toggle toggle)
        {
            if (toggle.isOn == true)
            {
                inputField.contentType = TMP_InputField.ContentType.Password;
            }
            else
            {
                inputField.contentType = TMP_InputField.ContentType.Standard;
            }
        }
    }
}