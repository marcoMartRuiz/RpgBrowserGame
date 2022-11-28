using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System.Runtime.InteropServices;

public class FirbaseDB : MonoBehaviour
{
    
     /// <summary>
        /// Gets JSON from a specified path
        /// Will return a snapshot of the JSON in the callback output
        /// </summary>
        /// <param name="path"> Database path </param>
        /// <param name="objectName"> Name of the gameobject to call the callback/fallback of </param>
        /// <param name="callback"> Name of the method to call when the operation was successful. Method must have signature: void Method(string output) </param>
        /// <param name="fallback"> Name of the method to call when the operation was unsuccessful. Method must have signature: void Method(string output). Will return a serialized FirebaseError object </param>
        [DllImport("__Internal")]
        public static extern void GetJSON(string path, string objectName, string callback, string fallback);

        /// <summary>
        /// Posts JSON to a specified path
        /// </summary>
        /// <param name="path"> Database path </param>
        /// <param name="value"> JSON string to post to the specified path </param>
        /// <param name="objectName"> Name of the gameobject to call the callback/fallback of </param>
        /// <param name="callback"> Name of the method to call when the operation was successful. Method must have signature: void Method(string output) </param>
        /// <param name="fallback"> Name of the method to call when the operation was unsuccessful. Method must have signature: void Method(string output). Will return a serialized FirebaseError object </param>
        [DllImport("__Internal")]
        public static extern void PostJSON(string path, string value, string objectName, string callback,
            string fallback);

        /// <summary>
        /// Pushes JSON to a specified path with a Firebase generated unique key
        /// </summary>
        /// <param name="path"> Database path </param>
        /// <param name="value"> JSON string to push to the specified path </param>
        /// <param name="objectName"> Name of the gameobject to call the callback/fallback of </param>
        /// <param name="callback"> Name of the method to call when the operation was successful. Method must have signature: void Method(string output) </param>
        /// <param name="fallback"> Name of the method to call when the operation was unsuccessful. Method must have signature: void Method(string output). Will return a serialized FirebaseError object </param>
        [DllImport("__Internal")]
        public static extern void PushJSON(string path, string value, string objectName, string callback,
            string fallback);

        /// <summary>
        /// Updates JSON in a specified path
        /// </summary>
        /// <param name="path"> Database path </param>
        /// <param name="value"> JSON string to update in the specified path </param>
        /// <param name="objectName"> Name of the gameobject to call the callback/fallback of </param>
        /// <param name="callback"> Name of the method to call when the operation was successful. Method must have signature: void Method(string output) </param>
        /// <param name="fallback"> Name of the method to call when the operation was unsuccessful. Method must have signature: void Method(string output). Will return a serialized FirebaseError object </param>
        [DllImport("__Internal")]
        public static extern void UpdateJSON(string path, string value, string objectName, string callback,
            string fallback);

        /// <summary>
        /// Deletes JSON in a specified path
        /// </summary>
        /// <param name="path"> Database path </param>
        /// <param name="objectName"> Name of the gameobject to call the callback/fallback of </param>
        /// <param name="callback"> Name of the method to call when the operation was successful. Method must have signature: void Method(string output) </param>
        /// <param name="fallback"> Name of the method to call when the operation was unsuccessful. Method must have signature: void Method(string output). Will return a serialized FirebaseError object </param>
        [DllImport("__Internal")]
        public static extern void DeleteJSON(string path, string objectName, string callback, string fallback);


    
    // private void OnRequestSuccess(string data)
    // {
    //     text.color = Color.green;
    //     text.text = data;
    // }
    // private void OnRequestFailed(string error)
    // {
    //     text.color = Color.red;
    //     text.text = error;
    // }

    // public void ConnectFirebaseDB()
    // {
    //      GetJson(collectionPath: "users", documentId: "0", gameObject.name, callback: "OnRequestSuccess", fallback: "OnRequestFailed");

    // }
}

// <script type="module">
//       // Import the functions you need from the SDKs you need
//       import { initializeApp } from "https://www.gstatic.com/firebasejs/9.14.0/firebase-app.js";
//       import { } from "https://www.gstatic.com/firebasejs/9.14.0/firebase-database.js"
//       // TODO: Add SDKs for Firebase products that you want to use
//       // https://firebase.google.com/docs/web/setup#available-libraries
    
//       // Your web app's Firebase configuration
//       const firebaseConfig = {
//         apiKey: "AIzaSyCywja7OH4TUR7H-DvezNOPv1JgfP1WU2M",
//         authDomain: "testing-bcf26.firebaseapp.com",
//         databaseURL: "https://testing-bcf26.firebaseio.com",
//         projectId: "testing-bcf26",
//         storageBucket: "testing-bcf26.appspot.com",
//         messagingSenderId: "972089481299",
//         appId: "1:972089481299:web:0edddf12eefc25fb62cea6"
//       };
    
//       // Initialize Firebase
//       const app = initializeApp(firebaseConfig);
//     </script>