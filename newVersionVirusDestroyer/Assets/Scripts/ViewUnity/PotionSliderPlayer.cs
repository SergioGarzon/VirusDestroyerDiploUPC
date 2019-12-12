using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;

public class PotionSliderPlayer: MonoBehaviour
{
    [SerializeField] Slider sliderPotionPlayer;

    void Start()
    {
        sliderPotionPlayer.value = 1.0f;
    }
}

