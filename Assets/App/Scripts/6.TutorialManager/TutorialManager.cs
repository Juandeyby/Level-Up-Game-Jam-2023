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
        yield return new WaitForSeconds(1.5f);
        tutorialAnimations.SetActive(true);
        yield return new WaitForSeconds(15f);
        tutorialAnimations.SetActive(false);
    }
}
