using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveSpaceShip : MonoBehaviour
{
    public Rigidbody2D rdb;
    public SpriteRenderer fire;
    public SpriteRenderer spaceship;
    private ParticleSystem destroyedParticles;

    public int lives = 3;
    public int flashCount = 3; 
    public float flashDuration = 0.1f; 
    public float speedY = 5;
    public float speedX = 0.5f;

    private bool isAlive = true;


    void Start()
    {
        transform.position = new Vector3(0,-5,0);
    }
    
    private void FixedUpdate(){
        if (isAlive == true) {
            Movimentos();
        }else{
            Destroy(gameObject);
        }
    }
   
    private void OnCollisionEnter2D(Collision2D collision) {
         if (collision.collider.tag == "Asteroid"){
            lives-=1;
            if (lives == 0){
                isAlive = false;
            }else{
                 StartCoroutine(FlashOnCollision());
                 Start();
            }
        }
    }
    
    void Movimentos(){
        if(Input.GetKey(KeyCode.D)){
            rdb.AddTorque(speedX);
        }
         if(Input.GetKey(KeyCode.A)){
            rdb.AddTorque(-speedX);
        }
         if(Input.GetKey(KeyCode.W)){
            rdb.AddRelativeForce(Vector2.up * speedY);
            fire.enabled = true;
        }else{
            fire.enabled = false;
        }
    }

     private IEnumerator FlashOnCollision()
    {
        for (int i = 0; i < flashCount; i++)
        {
            spaceship.enabled = !spaceship.enabled;
            yield return new WaitForSeconds(flashDuration);
        }
        spaceship.enabled = true; 
    }

   

}
