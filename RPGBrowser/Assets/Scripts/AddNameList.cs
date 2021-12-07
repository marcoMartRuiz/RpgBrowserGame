using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class AddNameList : MonoBehaviour
{
    public string newNameText;

   
    [SerializeField] TextMeshProUGUI newInputName;
    [SerializeField] TMP_InputField currentInputField;



    public void SubmitText()
    {
        var newInputName2 = GameObject.Instantiate(newInputName);
        newInputName2.transform.position = new Vector3(newInputName.transform.parent.position.x, newInputName.transform.parent.position.y - 40f, newInputName.transform.parent.position.z);
        newInputName2.text = currentInputField.text;
        newInputName2.fontSize = 14f;
        // newInputName.text = currentInputField.text;
        newNameText = currentInputField.textComponent.text; 
        
    }
    public string NameText()
    {

        return newNameText;
    }
    public void ClearInputField()
    {
        currentInputField.text = null;
    }
    
}
