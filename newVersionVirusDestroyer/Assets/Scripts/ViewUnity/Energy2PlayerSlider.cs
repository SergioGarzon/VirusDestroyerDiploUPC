using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;

public class Energy2PlayerSlider: MonoBehaviour
{
    [SerializeField] Text txtSliderEnergy2;
    [SerializeField] Slider sldEnergyPlayer2;

    void Start() {
        txtSliderEnergy2.text = "100%";
        sldEnergyPlayer2.value = 1.0f;
    }

}

