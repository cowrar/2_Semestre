using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceShip : MonoBehaviour
{
    public ParticleSystem particleSystem;
     void Start()
    {

    }

    void Update()
    {
        if (Input.GetKey(KeyCode.E))
        {
            Fire();
        }else{
            particleSystem.Stop(true, ParticleSystemStopBehavior.StopEmitting);
        }
    }

    void Fire()
    {
        GetComponent<ParticleSystem>().Emit(1);
    }
}
