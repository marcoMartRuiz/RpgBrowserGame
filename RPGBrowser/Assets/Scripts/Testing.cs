using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Testing : MonoBehaviour
{
    [SerializeField] Texture2D MapLoadedImage;
    // Start is called before the first frame update
    void Start()
    {
        
        Grid TestGrid = new Grid(10,10,10f,new Vector3(0,0,0), MapLoadedImage);
      
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
