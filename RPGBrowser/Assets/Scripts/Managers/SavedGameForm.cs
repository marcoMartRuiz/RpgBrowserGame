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

namespace ns_Forms
{

    public class SavedGameForm : MonoBehaviour
    {
        [SerializeField] TextMeshProUGUI SavedMessageText;
        public void OnPreviousSavedClick()
        {
            FirebaseAuth.OnAuthStateChanged(gameObject.name, onUserSignedIn: "isUserSignedIn", onUserSignedOut: "isUserSignedOut");

        }
        public void gotkeySuccess(string value)
        {
            string user_name = value;
            SavedMessageText.text = user_name + "'s Saved Game";
        }
        public void gotKeyFailed(string error)
        {
            SavedMessageText.text = error;
        }
        public void isUserSignedIn(string user)
        {
            FirebaseDatabase.GetJSON(path: "rpgGame/users/" + user + "/username", gameObject.name, callback: "gotkeySuccess", fallback: "gotKeyFailed");

        }
        public void isUserSignedOut(string error)
        {
            SavedMessageText.text = error;
        }
    }
}
