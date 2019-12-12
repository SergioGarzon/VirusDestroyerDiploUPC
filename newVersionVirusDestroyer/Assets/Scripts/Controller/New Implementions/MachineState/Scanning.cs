using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Scanning : MonoBehaviour
{
    [SerializeField] private float _speedY = 10f;

    void Start()
    {

    }

    void Update()
    {        
        Vector3 vector = this.transform.position;

        vector.y += Time.deltaTime * _speedY;
       
        this.transform.position = vector;

    }

    
}
