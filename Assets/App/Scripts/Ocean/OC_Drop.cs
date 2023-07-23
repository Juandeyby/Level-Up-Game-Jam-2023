using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OC_Drop : MonoBehaviour
{
    [SerializeField] private Sprite spriteUp;
    [SerializeField] private Sprite spriteDown;
    
    [SerializeField] private SpriteRenderer spriteRenderer;
    
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

    public virtual void OnMouseDown()
    {
        _dragging = true;

        _offset = GetMousePos() - (Vector2)transform.position;
        //AudioManager.instance.PlayOneShot(stickerPullSound, this.transform.position);
        FMODUnity.RuntimeManager.PlayOneShot("event:/SFX/Park_Level/Sticker Pull");
        spriteRenderer.sprite = spriteUp;
    }

    public virtual void OnMouseUp()
    {
        transform.position = transform.position;
        _dragging = false;
        FMODUnity.RuntimeManager.PlayOneShot("event:/SFX/Park_Level/Sticker Built");
        spriteRenderer.sprite = spriteDown;
    }

    Vector2 GetMousePos()
    {
        return Camera.main.ScreenToWorldPoint(Input.mousePosition);
    }
}