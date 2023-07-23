using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragTransparency : MonoBehaviour
{
    [SerializeField] private Sprite spriteDespegado;
    [SerializeField] private Sprite spritePegado;

    [SerializeField] private SpriteRenderer spriteRendererCiudad;

    public virtual void OnMouseDown()
    {
        gameObject.GetComponent<SpriteRenderer>().color = new Color(1, 1, 1, 0.75f);
        spriteRendererCiudad.sprite = spriteDespegado;
        //gameObject.transform.localScale = new Vector3(transform.localScale.x / 1.1f, transform.localScale.y / 1.1f, transform.localScale.z / 1.1f);
    }

    public virtual void OnMouseUp()
    {
        gameObject.GetComponent<SpriteRenderer>().color = new Color(1, 1, 1, 1);
        spriteRendererCiudad.sprite = spritePegado;
        //gameObject.transform.localScale = new Vector3(transform.localScale.x * 1.1f, transform.localScale.y * 1.1f, transform.localScale.z * 1.1f);
    }
}
