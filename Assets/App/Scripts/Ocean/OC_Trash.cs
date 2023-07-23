using System;
using UnityEngine;

namespace App.Scripts.Ocean
{
    public class OC_Trash : MonoBehaviour
    {
        private void OnTriggerEnter2D(Collider2D col)
        {
            if (col.CompareTag("Sticker"))
            {
                var ocDrog = col.GetComponent<OC_Drop>();
                ocDrog.OnMouseUp();
                Destroy(col.gameObject);
            }
        }
    }
}
