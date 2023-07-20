using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StickerDetector : MonoBehaviour
{
    public string targetTag;
    public List<string> secundaryTags;
    // SolarPower, WindPower, SeaWindPower and HydraulicPower <- all tags

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag(targetTag))
        {
            Debug.Log("Adding 2 Green points");
            // Sum max green points
        }
        else
        {
            foreach (string secTag in secundaryTags)
            {
                if (other.CompareTag(secTag))
                {
                    Debug.Log("Adding 1 Green point");
                    // Sum mid green points
                }
            }
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        Debug.Log("Remove Green points");
        // Sum 0 green points
    }

}
