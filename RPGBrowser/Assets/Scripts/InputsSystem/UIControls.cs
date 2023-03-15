using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.EventSystems;
using UnityEngine.UI;



public class UIControls : MonoBehaviour
{
    [SerializeField] EventSystem system;
     [SerializeField] TextMeshProUGUI errorMessageText;
       [SerializeField] TMP_InputField emailInput;
    [SerializeField] TMP_InputField passwordInput;
    // Selectable next;


    public void onTab()
    {
        Selectable next = system.currentSelectedGameObject.GetComponent<Selectable>().FindSelectableOnDown();
        if (next != null)
        {
            InputField inputfield = next.GetComponent<InputField>();
            if (inputfield != null)
                inputfield.OnPointerClick(new PointerEventData(system));

            system.SetSelectedGameObject(next.gameObject, new BaseEventData(system));
        }

        // Here is the navigating back part:
        else
        {
            next = Selectable.allSelectablesArray[0];
            system.SetSelectedGameObject(next.gameObject, new BaseEventData(system));
        }
    }
    public void OnCycleTab(InputValue value)
    {
        if (value.isPressed)
        {
            onTab();
        }
    }
    public void OnMouseClick(InputValue value)
    {
        if (value.isPressed)
        {
            onMouse();
        }
    }
    public void OnCopy(InputValue value)
    {
        if (value.isPressed)
        {
            
        }
    }
    public void OnPaste(InputValue value)
    {
         if (value.isPressed)
        {
            
        }
    }
    public void onMouse()
    {
        // RaycastHit hit;
        // //Send a ray from the camera to the mouseposition
        // Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        // //Create a raycast from the Camera and output anything it hits
        // if (Physics.Raycast(ray, out hit))
        // {
        //     //Check the hit GameObject has a Collider
        //     if (hit.collider != null)
        //     {
        //         //Click a GameObject to return that GameObject your mouse pointer hit
        //         GameObject m_MyGameObject = hit.collider.gameObject;
        //         system.SetSelectedGameObject(m_MyGameObject);
        //     }
        // }
    }





}
