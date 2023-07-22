using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BarraDeEnergia : MonoBehaviour
{
    public Slider slider;

    public void SetEnergy(float energy)
    {
        slider.value = energy;
    }
}
