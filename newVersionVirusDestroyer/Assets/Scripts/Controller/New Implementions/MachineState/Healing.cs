using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;

public class Healing: MonoBehaviour
{

    [SerializeField] Text txtInformationHealing;
    [SerializeField] Slider sldEnergyPotion;

    void Update()
    {
        if(Input.GetKey(KeyCode.J))
        {
            this.txtInformationHealing.text = "Healing";            
            this.sldEnergyPotion.value = 1.0f;
        }
    }

}
