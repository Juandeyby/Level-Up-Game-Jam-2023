using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragTransparency : MonoBehaviour
{
    public virtual void OnMouseDown()
    {
        gameObject.GetComponent<SpriteRenderer>().color = new Color(1, 1, 1, 0.75f);
        gameObject.transform.localScale = new Vector3(transform.localScale.x / 1.5f, transform.localScale.y / 1.5f, transform.localScale.z / 1.5f);
    }

    public virtual void OnMouseUp()
    {
        gameObject.GetComponent<SpriteRenderer>().color = new Color(1, 1, 1, 1);
        gameObject.transform.localScale = new Vector3(transform.localScale.x * 1.5f, transform.localScale.y * 1.5f, transform.localScale.z * 1.5f);
    }
}
