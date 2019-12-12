using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TMPro;
using UnityEditorInternal;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace Assets.Scripts.MachineState
{
    public class InMovement: MonoBehaviour
    {

        [SerializeField] private float _speedX = 0.1f;
        [SerializeField] ParticleSystem particle;
        [SerializeField] Slider barraSliderEnergyPotion;
        [SerializeField] Text txtInformationAction;
       
        void Start()
        {
            this.txtInformationAction.text = "";
        }


        void Update()
        {
            Vector3 newPosition = this.transform.position;

            if (Input.GetKey(KeyCode.G))
            {
                if (this.barraSliderEnergyPotion.value > 0f)
                {
                    //Right: Movimiento a la Derercha
                    newPosition.z -= (Time.deltaTime * (_speedX * 1));
                    this.particle.Play();
                    this.barraSliderEnergyPotion.value = 0f;
                    this.txtInformationAction.text = "Attack!";
                }
            }
            

            this.transform.position = newPosition;

        } 

        /*
        public override void UpdateState(float delta)
        {
            Vector3 newPosition = objetoMover.transform.position;
           

            //Right: Movimiento a la Derercha
            if (Input.GetKey(KeyCode.D))
            {
                newPosition.x += Time.deltaTime * _speedX;
            }

            //Left: Movimiento a la Izquierda
            if (Input.GetKey(KeyCode.A))
            {
                newPosition.x -= (Time.deltaTime * _speedX);
            }
            objetoMover.transform.position = newPosition;

        }
        */
    }
}
