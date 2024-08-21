using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirePlayer : MonoBehaviour
{
    public GameObject shootPrefab;
    public Transform firepoint;
    void Start()
    {
        
    }

    void Update()
    {
        //if(Input.GetButton("Fire1"))
         if(Input.GetKeyDown(KeyCode.E)){
            Fire();
        }
    }

     void Fire(){
        GameObject shoot = Instantiate(shootPrefab, firepoint.position, firepoint.rotation);
        shoot.GetComponent<Rigidbody2D>().AddRelativeForce(Vector2.up * 10, ForceMode2D.Impulse);
    }
}
