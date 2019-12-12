using Assets.Scripts.MachineState;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;


public class Player : FiniteStateMachine    {

    public KeyCode keyPress;
        
    private void Start()
    {
        SwitchState(new IdleState());
    }

    protected override void Update()
    {
        /*
        switch (keyPress)
        {
            case KeyCode.G: SwitchState(new Attack()); break; //Ataque
            case KeyCode.H: SwitchState(new Blocking()); break; //Bloqueo
            case KeyCode.J: SwitchState(new Healing()); break; //Curación
            case KeyCode.T: SwitchState(new Shooting()); break; //Disparo
        } */          
    }

}
