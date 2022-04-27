using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Unity.Mathematics;
namespace ns_UI
{

    public class DrawArea : MonoBehaviour
    {
        [SerializeField] GameObject brush;
        GameObject tempBrush;
        // // LineRenderer currentLineRenderer;
        // Vector2 lastPos;
        // Vector2 onScreenMousePos;
        public void CreateBrush()
        {
        //  onScreenMousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            tempBrush = Instantiate(brush, transform.position, Quaternion.identity);
            // currentLineRenderer = brush.GetComponent<LineRenderer>();
            // currentLineRenderer.SetPosition(0, transform.position);
            // currentLineRenderer.SetPosition(1, onScreenMousePos);
        }
        // private void Update()
        // {
        //     if (Input.GetMouseButton(0))
        //     {
        //         PointToMousePos();
        //     }
        //     if (Input.GetKeyUp("escape"))
        //     {
        //         Destroy(tempBrush);
        //     }
        // }
        // public void AddPoint()
        // {
        //     currentLineRenderer.positionCount++;
        //     int positionIndex = currentLineRenderer.positionCount - 1;
        //     currentLineRenderer.SetPosition(positionIndex, onScreenMousePos);
        // }
        // public void PointToMousePos()
        // {
        //     if (onScreenMousePos != lastPos)
        //     {
        //         AddPoint();
        //         lastPos = onScreenMousePos;
        //     }
        // }
        public void DestroyTempBrush()
        {
            Destroy(tempBrush);
        }

    }
}