using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DtragNDrop_Turb1 : MonoBehaviour
{
    private bool _dragging;

    Vector2 _offset;

    private void Update()
    {
        if (!_dragging) return;


        var mousePositon = GetMousePos();

        transform.position = mousePositon - _offset;
    }

    private void OnMouseDown()
    {
        _dragging = true;

        _offset = GetMousePos() - (Vector2)transform.position;
    }

    private void OnMouseUp()
    {
        transform.position = transform.position;
        _dragging = false;
    }

    Vector2 GetMousePos()
    {
        return Camera.main.ScreenToWorldPoint(Input.mousePosition);
    }

    
}
