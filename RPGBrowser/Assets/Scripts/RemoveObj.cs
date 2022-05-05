using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity;
public class RemoveObj : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        var brushobjclone = GameObject.Find("BrushObj(Clone)");
        Destroy(brushobjclone);
    }

   
}
