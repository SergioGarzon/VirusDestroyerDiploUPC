using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Scripts.MachineState
{
    public abstract class State : MonoBehaviour
    {
        public abstract void InitState();

        public abstract void UpdateState(float delta);

        public abstract void ExitState();
    }
}
