using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionCubeTerrain : MonoBehaviour
{
    public AudioSource audioTerrenoCubo;

    void Start()
    {
        audioTerrenoCubo = GetComponent<AudioSource>();
    }
    
    void OnCollisionEnter(Collision col)
    {
        if(col.gameObject.name == "CubePiso")
        {
            Debug.Log("Collision realizada");

            /*
            audioTerrenoCubo.loop = true;
            audioTerrenoCubo.Play();*/
        }
    }

}
