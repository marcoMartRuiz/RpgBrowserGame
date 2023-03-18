using System;
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


        public SavedFileSpawner savedFileSpawner;
        public List<string> campaignList;
        public GameObject[] savedFileButtons;
        public string userid;
        public int itemCOUNTER;


        [SerializeField] TextMeshProUGUI usernameText;
        [SerializeField] Toggle toggle1;
        [SerializeField] Toggle toggle2;

        [SerializeField] public GameObject SavedFilePrefab;
        // [SerializeField] public GameObject ListSavedFile;
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


            // int campaignID = 0;
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

            if (SavedFilePrefab)
            {

                // This is where we create the list item with the UI elements.
                // ListSavedFile.name =  ;
                itemCOUNTER = 0;
                campaignList = new List<string>();
                GameObject[] savedFileButtons = new GameObject[campaignList.Count];


                FirebaseDatabase.GetChildKeyJSON(path: "rpgGame/users/" + JoinNetwork.userKEY + "/MyCampaigns", gameObject.name, callback: "successGetFiles", fallback: "DisplayErrorObject");
               Debug.LogError("please work");
                foreach (var inum in campaignList)
                {
                    Debug.LogError("brokoe 0");

                    savedFileButtons[itemCOUNTER] = Instantiate(SavedFilePrefab.gameObject);
                    Debug.LogError("brokoe 1");
                    Debug.LogError(inum);
                    Debug.LogError("brokoe 2");
                  
                    savedFileSpawner = savedFileButtons[itemCOUNTER].GetComponent<SavedFileSpawner>();
                    savedFileSpawner.transform.position.Set(0, 100 - (itemCOUNTER * 100), 0);
                    Debug.LogError("brokoe 3");

                    savedFileSpawner.TitleLabel = inum;
                    itemCOUNTER = ++itemCOUNTER;
                }

                // if (savedFileSpawner)
                // {
                // }
                // else Debug.LogError("OnClientEnterRoom.OnClientEnterRoom(): no savedFileSpawner Component on list item");

            }
            else Debug.LogError("OnClientEnterRoom.OnClientEnterRoom(): UI list item prefab not found");
        }
        public void ChooseCharacter()
        {
            usernameText.text = JoinNetwork.username + "'s Saved Characters";


            FirebaseDatabase.GetChildKeyJSON(path: "rpgGame/users/" + JoinNetwork.userKEY + "/MyCharacters", gameObject.name, callback: "success", fallback: "DisplayErrorObject");
        }
        public void successGetFiles(string data)
        {

            string datatest = data.Trim('"');
            campaignList.Add(datatest);
            Debug.LogError(datatest);
            // int numofCampaigns = campaignList.Count;
        }
        // savedFileSpawner.DateLabel = data;


        public void failed(string error)
        {
            Debug.LogError("somethings up here :::" + error);
        }

    }
    //  https://character-service.dndbeyond.com/character/v3/character/
    // dt.ToString("MM/dd/yyyy h:mm tt")

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