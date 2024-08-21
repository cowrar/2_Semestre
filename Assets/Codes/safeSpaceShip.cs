using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class safeSpaceShip : MonoBehaviour
{
    public Rigidbody2D rdb;
    public float velocidadeY = 10;
    public float velocidadeX = 3.5f;
    public SpriteRenderer fogo_1;
    public SpriteRenderer bullet;

    void Start()
    {
        transform.position = new Vector3(0,-5,0);
    }

    void Update()
    {
       
    }

    private void FixedUpdate(){
        Movimentos();
    }
   
    void Movimentos(){
        if(Input.GetKey(KeyCode.D)){
           rdb.AddTorque(velocidadeX);
        }
         if(Input.GetKey(KeyCode.A)){
            rdb.AddTorque(-velocidadeX);
        }
         if(Input.GetKey(KeyCode.W)){
           rdb.AddRelativeForce(Vector2.up * velocidadeY);
            fogo_1.enabled = true;
        }else{
             fogo_1.enabled = false;
        }
         if(Input.GetKey(KeyCode.S)){
            rdb.AddRelativeForce(Vector2.down * -velocidadeY);
        }
    }

   
}
