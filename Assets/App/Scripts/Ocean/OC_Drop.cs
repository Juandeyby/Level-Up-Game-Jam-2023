using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OC_Drop : DragNDrop
{
    [SerializeField] private Sprite spriteUp;
    [SerializeField] private Sprite spriteDown;
    
    [SerializeField] private SpriteRenderer spriteRenderer;
    
    public override void OnMouseDown()
    {
        base.OnMouseDown();
        spriteRenderer.sprite = spriteUp;
    }
    
    public override void OnMouseUp()
    {
        base.OnMouseUp();
        spriteRenderer.sprite = spriteDown;
    }
}