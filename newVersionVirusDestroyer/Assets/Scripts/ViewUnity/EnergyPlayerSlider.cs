using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;

public class EnergyPlayerSlider: MonoBehaviour
{
    [SerializeField] Text energyEnemyText;
    [SerializeField] Slider energyEnemy;

    void Start()
    {
        energyEnemyText.text = "100%";
        this.energyEnemy.value = 1.0f;
    }


}
    

