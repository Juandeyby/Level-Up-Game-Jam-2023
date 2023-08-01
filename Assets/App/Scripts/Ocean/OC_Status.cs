using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OC_Status : MonoBehaviour
{
    [SerializeField] private GameObject[] goodStatus;
    [SerializeField] private GameObject[] badStatus;

    public void SetStatus(int spawned)
    {
        if (spawned == 20)
        {
            goodStatus[0].SetActive(true);
            badStatus[0].SetActive(false);
        }

        if (spawned == 16)
        {
            goodStatus[1].SetActive(true);
            badStatus[1].SetActive(false);
            badStatus[2].SetActive(false);
            badStatus[3].SetActive(false);
            badStatus[4].SetActive(false);
        }
        
        if (spawned == 8)
        {
            goodStatus[2].SetActive(true);
        }
    }
}
