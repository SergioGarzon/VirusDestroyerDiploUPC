using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;


 public class ScanningEnemy: MonoBehaviour
 {
    [SerializeField] public Transform target;
    [SerializeField] private float _speedY;

    void Start()
    {

    }

    void Update()
    {
        this.transform.position = Vector3.MoveTowards(transform.position, target.position, _speedY * Time.deltaTime);
    }

 }
