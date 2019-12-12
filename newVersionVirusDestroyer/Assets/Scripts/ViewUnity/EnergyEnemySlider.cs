using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;

public class EnergyEnemySlider: MonoBehaviour
{
    [SerializeField] Slider sliderEnemy;
    [SerializeField] Text textoSliderEnemy;

    void Start()
    {
        sliderEnemy.value = 1.0f;
        textoSliderEnemy.text = "100%";

    }
}