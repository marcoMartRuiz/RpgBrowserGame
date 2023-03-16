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
        [SerializeField] TextMeshProUGUI usernameText;
        [SerializeField] Toggle toggle1;
        [SerializeField] Toggle toggle2;

        [SerializeField] TextMeshProUGUI savedCharacterText;
        [SerializeField] TextMeshProUGUI savedCampaignText;

        string userid;

        

        public void DisplayErrorObject(string error)
        {
            var parsedError = StringSerializationAPI.Deserialize(typeof(FirebaseError), error) as FirebaseError;
            failed(parsedError.message);
        }

        public void CreateNewCampaign()
        {

            MyCampaigns myCampaigns = new MyCampaigns
            {
                // name = roomName.text,
                // password = roomPasswordInput.text,

                playerlist = new List<UserID>()
                {
                    new UserID
                    {
                        uid = "",
                    }
                },
            };
            string jsonValue = JsonConvert.SerializeObject(myCampaigns, Formatting.Indented);// string inputData = "{email: " + emailInput.text + "," + "password: " + passwordInput.text + "}";


            int campaignID = 0;
            // FirebaseDatabase.UpdateJSON(path: "rpgGame/users/" + JoinNetwork.userKEY + "/MyCampaigns/"+ campaignName, value: jsonValue, gameObject.name, callback: "success", fallback: "failed");
        }
        public void NewPlayerCharacter()
        {
            MyCharacters myCharacters = new MyCharacters
            {
                characterList = new List<CharacterID>()
                {
                    new CharacterID
                    {
                        id = 0
                    }
                },
            };
            string jsonValue = JsonConvert.SerializeObject(myCharacters, Formatting.Indented);// string inputData = "{email: " + emailInput.text + "," + "password: " + passwordInput.text + "}";

            FirebaseDatabase.UpdateJSON(path: "rpgGame/users/" + JoinNetwork.userKEY, value: jsonValue, gameObject.name, callback: "success", fallback: "failed");
        }
        public void GetCampaigns()
        {
            usernameText.text = JoinNetwork.username + "'s Saved Campaigns";

            FirebaseDatabase.GetChildKeyJSON(path: "rpgGame/users/" + JoinNetwork.userKEY + "/MyCampaigns", gameObject.name, callback: "success", fallback: "DisplayErrorObject");
        }
        public void ChooseCharacter()
        {
            usernameText.text = JoinNetwork.username + "'s Saved Characters";

            FirebaseDatabase.GetChildKeyJSON(path: "rpgGame/users/" + JoinNetwork.userKEY + "/MyCharacters", gameObject.name, callback: "success", fallback: "DisplayErrorObject");
        }
        public void success(string data)
        {
            savedCharacterText.text = data;
        }
        public void failed(string error)
        {
            savedCharacterText.text = error;
        }
    }
    //  https://character-service.dndbeyond.com/character/v3/character/

    // public void isUserSignedIn(string user)
    // {
    //     FirebaseDatabase.GetJSON(path: "rpgGame/users/" + JoinNetwork + "/username", gameObject.name, callback: "gotkeySuccess", fallback: "gotKeyFailed");
    //     userid = user;
    // }
    // public void isUserSignedOut(string error)
    // {
    //     SavedMessageText.text = error;
    // }
}