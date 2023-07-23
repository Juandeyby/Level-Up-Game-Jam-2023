using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialManager : MonoBehaviour
{
    public GameObject tutorialAnimations;

    private void Start()
    {
        StartCoroutine(TutorialStart());
    }

    IEnumerator TutorialStart()
    {
        yield return new WaitForSeconds(3f);
        tutorialAnimations.SetActive(true);
    }
}
