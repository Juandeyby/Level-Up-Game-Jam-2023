using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnTreesFinal : MonoBehaviour
{
    public GameObject[] Trees;
    public Animator[] animTrees;
    int i = 0;

    public GameObject[] nubesSucias;
    public GameObject[] nubesLimpias;

    public GameObject smogFilter;

    float smogAlpha = .35f;

    public void SpawnTreesMethod()
    {
        //Debug.Log(i);
        if (i < animTrees.Length)
        {
            //Trees[i].SetActive(true);
            animTrees[i].SetBool("ArbolIn", true);
            i++;
        }
        else
        {
            i = animTrees.Length;
        }
    }

    public void DeSpawnTreesMethod()
    {
        //Debug.Log(i);
        if (i>=0)
        {
            //Trees[i-1].SetActive(false);
            i--;
            animTrees[i].SetBool("ArbolIn", false);
            
        }
        else
        {
            i = 0;
        }
    }

    public void NubesSucias1Method(int k, float alphaColor)
    {
        nubesSucias[k].GetComponent<SpriteRenderer>().color = new Color(1, 1, 1, alphaColor);
    }

    public void NubesLimpias1Method(int l, float alphaColor2)
    {
        nubesLimpias[l].GetComponent<SpriteRenderer>().color = new Color(1, 1, 1, alphaColor2);
    }

    public void SmogFilterMinusAlpha()
    {
        smogFilter.GetComponent<SpriteRenderer>().color = new Color(.660f, 0.469f, 0.295f, smogAlpha -= .039f);
    }

    public void SmogFilterPlusAlpha()
    {
        smogFilter.GetComponent<SpriteRenderer>().color = new Color(.660f, 0.469f, 0.295f, smogAlpha += .039f);
    }

}
