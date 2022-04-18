using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System.Runtime.InteropServices;

public class FirbaseDB : MonoBehaviour
{
    public TextMeshProUGUI text;

    /// Gets a document from a specified collection path and id
    /// Will return the document in JSON form in the callback output

    /// <param name="collectionPath"> Collection path </param>
    /// <param name="documentId"> Document id </param>
    /// <param name="objectName"> Name of the gameobject to call the callback/fallback of </param>
    /// <param name="callback"> Name of the method to call when the operation was successful. Method must have signature: void Method(string output) </param>
    /// <param name="fallback"> Name of the method to call when the operation was unsuccessful. Method must have signature: void Method(string output). Will return a serialized FirebaseError object </param>

    [DllImport("__Internal")]
    public static extern void GetDocument(string collectionPath, string documentId, string objectName, string callback, string fallback);


    /// Gets all documents from a specified collection path
    /// Will return the documents in JSON array form in the callback output
    /// </summary>
    /// <param name="collectionPath"> Collection path </param>
    /// <param name="objectName"> Name of the gameobject to call the callback/fallback of </param>
    /// <param name="callback"> Name of the method to call when the operation was successful. Method must have signature: void Method(string output) </param>
    /// <param name="fallback"> Name of the method to call when the operation was unsuccessful. Method must have signature: void Method(string output). Will return a serialized FirebaseError object </param>
    // [DllImport("__Internal")]
    // public static extern void GetDocumentsInCollection(string collectionPath, string objectName, string callback,
    //     string fallback);



    private void Start()
    {

    }
    private void OnRequestSuccess(string data)
    {
        text.color = Color.green;
        text.text = data;
    }
    private void OnRequestFailed(string error)
    {
        text.color = Color.red;
        text.text = error;
    }

    public void ConnectFirebaseDB()
    {
         GetDocument(collectionPath: "users", documentId: "0", gameObject.name, callback: "OnRequestSuccess", fallback: "OnRequestFailed");

    }
}
