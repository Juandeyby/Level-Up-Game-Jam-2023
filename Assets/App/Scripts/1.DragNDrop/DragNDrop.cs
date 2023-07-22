using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using FMODUnity;

public class DragNDrop : MonoBehaviour
{
    //[SerializeField] private EventReference stickerPullSound;

    private bool _dragging;

    Vector2 _offset, _originalPosition;

    private void Awake()
    {
        _originalPosition = transform.position;
    }

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
        //AudioManager.instance.PlayOneShot(stickerPullSound, this.transform.position);
        FMODUnity.RuntimeManager.PlayOneShot("event:/SFX/Park_Level/Sticker Pull");
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
