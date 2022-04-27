using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class BrushLine : MonoBehaviour
{
    LineRenderer currentLineRenderer;
    Vector2 onScreenMousePos;
        Vector2 lastPos;

    void Start()
    {
        currentLineRenderer = this.gameObject.GetComponent<LineRenderer>();
        currentLineRenderer.SetPosition(0, transform.position);
        currentLineRenderer.SetPosition(1, onScreenMousePos);
    }

    // Update is called once per frame
    void Update()
    {
        onScreenMousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
         if (Input.GetMouseButton(0))
            {
                PointToMousePos();
            }
    }

    public void AddPoint()
    {
        currentLineRenderer.positionCount++;
        int positionIndex = currentLineRenderer.positionCount - 1;
        currentLineRenderer.SetPosition(positionIndex, onScreenMousePos);
    }
    public void PointToMousePos()
    {
        if (onScreenMousePos != lastPos)
        {
            AddPoint();
            lastPos = onScreenMousePos;
        }
    }
}
