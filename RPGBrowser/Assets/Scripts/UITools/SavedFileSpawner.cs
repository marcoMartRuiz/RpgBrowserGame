using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class SavedFileSpawner : MonoBehaviour
{
    private TextMeshProUGUI titleLabel;
    private TextMeshProUGUI dateLabel;
    private GameObject saveFileContainer;
    public void Awake()
    {
        // Attach the list item to the parent panel:
        saveFileContainer = GameObject.Find("SavedFilesContent");
        
        if (saveFileContainer)
        {
            transform.SetParent(saveFileContainer.transform,false);
        }
        else Debug.LogError(" UI parent container not found");

        // Now try and find the references to the Canvas UI list item's sub elements
        try
        {
            titleLabel = transform.GetChild(0).GetComponent<TextMeshProUGUI>();
            dateLabel = transform.GetChild(1).GetComponent<TextMeshProUGUI>();

        }
        catch (Exception e)
        {
            Debug.LogError(" UI Child items not found - " + e.Message);
        }
    }

    // The following methods are used to simplify setting/getting the list item's sub elements

    public string DateLabel
    {
        get; set;
    }

    public string TitleLabel
    {
        get; set;
    }







}
