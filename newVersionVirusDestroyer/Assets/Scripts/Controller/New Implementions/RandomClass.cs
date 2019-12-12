using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using Random = UnityEngine.Random;

public static class RandomClass
{
    public static int StateE;

    public static void RandomStateMethod()
    {
        StateE = Random.Range(1, 4);
        return;
    }
}
