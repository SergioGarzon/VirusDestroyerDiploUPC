using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;

public class Blocking : MonoBehaviour
{
    [SerializeField] float _speedZ = 0.5f;
    [SerializeField] Text texto;
    [SerializeField] ParticleSystem particleEnergy;

    void Update()
    {
        Vector3 newPosition = this.transform.position;

        //Right: Movimiento a la Derercha
        if (Input.GetKey(KeyCode.H))
        {
            newPosition.y -= (Time.deltaTime * (_speedZ * 1));
            this.texto.text = "Blocking";
            this.particleEnergy.Play();
        }

        this.transform.position = newPosition;

    }
}