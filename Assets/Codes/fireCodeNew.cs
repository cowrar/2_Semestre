using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fireCodeNew : MonoBehaviour
{
  public ParticleSystem particleSystem;
    // Start is called before the first frame update
    void Start()
    {

    }

    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            Fire();
        }
    }
    void Fire()
    {
        particleSystem.Emit(1);
    }
}
