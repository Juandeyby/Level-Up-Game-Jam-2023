using System.Collections;
using System.Collections.Generic;
using App.Scripts.Ocean;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PA_ReturnToPaper : MonoBehaviour
{
    public void ReturnToPaper()
    {
        SceneManager.LoadScene("Paper");
    }
}
