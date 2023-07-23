using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnTreesFinal : MonoBehaviour
{
    public GameObject[] Trees;
    int i = 0;

    public GameObject[] nubesSucias;
    public GameObject[] nubesLimpias;

    public void SpawnTreesMethod()
    {
        //Debug.Log(i);
        if (i < Trees.Length)
        {
            Trees[i].SetActive(true);
            i++;
        }
        else
        {
            Debug.Log("NomoreTrees");
        }
    }

    public void DeSpawnTreesMethod()
    {
        //Debug.Log(i);
        if (i>=-1)
        {
            Trees[i-1].SetActive(false);
            i--;
        }
        else
        {
            Debug.Log("i=o");
        }
    }

    public void NubesSucias1Method(int k, float alphaColor)
    {
        nubesSucias[k].GetComponent<SpriteRenderer>().color = new Color(1, 1, 1, alphaColor);
    }

    public void NubesLimpias1Method(int k, float alphaColor)
    {
        nubesLimpias[k].GetComponent<SpriteRenderer>().color = new Color(1, 1, 1, alphaColor);
    }

}
