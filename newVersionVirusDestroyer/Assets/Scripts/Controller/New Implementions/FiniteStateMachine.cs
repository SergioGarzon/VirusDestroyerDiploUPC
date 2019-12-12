using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine; 

namespace Assets.Scripts.MachineState
{
    //Creamos la clase FiniteStateMachine extendiendo de MonoBehaviour
    public class FiniteStateMachine : MonoBehaviour
    {
        //Aqui referencia al objeto state
        protected State _currentState;

        //Delega del metodo abstracto UpdateStete
        protected delegate void UpdateState(float dt);

        //Crea un objeto de referencia a UpdateState
        protected UpdateState _updateState;



        protected virtual void SwitchState(State newState)
        {
            //Compara si el objeto _currentState 
            if (_currentState != null && _currentState.GetType() == newState.GetType())
            {
                return;
            }

            _currentState?.ExitState();
            _currentState = newState;
            _currentState.InitState();
            _updateState = _currentState.UpdateState;
        }

        // Update is called once per frame
        protected virtual void Update()
        {
            if (_currentState == null)
            {
                return;
            }
            _updateState(Time.deltaTime);
        }

        protected bool IsStateRunning(Type state)
        {
            return (_currentState.GetType() == state);
        }
    }
}
