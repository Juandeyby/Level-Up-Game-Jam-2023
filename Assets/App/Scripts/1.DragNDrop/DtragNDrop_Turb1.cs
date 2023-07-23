using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DtragNDrop_Turb1 : MonoBehaviour
{
    private bool _dragging;

    Vector2 _offset, _originalPosition;

    private void Awake()
    {
        _originalPosition = transform.position;
    }

    private void Update()
    {
        if (!_dragging) return;

        if (_dragging && Input.GetKeyDown(KeyCode.Space))
        {
            transform.eulerAngles += Vector3.forward * 45f;
            /*Debug.Log(TurbinasStateGameCont.canIntegrate);
            if(transform.rotation.z == 90)
            {
                TurbinasStateGameCont.canIntegrate = true;
            }
            else
            {
                TurbinasStateGameCont.canIntegrate = false;
            }*/
        }

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
