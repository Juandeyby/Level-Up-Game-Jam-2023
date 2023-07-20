using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StickerDetector : MonoBehaviour
{
    public string targetTag;
    public List<string> secundaryTags;

    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("Hola");

        if (other.CompareTag(targetTag))
        {
            Debug.Log("Green points: 2/2");
        }
        else
        {
            foreach (string secTag in secundaryTags)
            {
                if (other.CompareTag(secTag))
                    Debug.Log("Green points: 1/2");
                else
                    Debug.Log("Green points: 0/0");
            }
        }
    }

}
