using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthUI : MonoBehaviour
{
   public MoveSpaceShip spaceship; 
   public int numOfLives = 3;

   public Image[] playerLives;
   public Sprite fullShip;
   public Sprite emptyShip;

   void Update(){
       if(spaceship.lives > numOfLives){
            spaceship.lives = numOfLives;
       }

       for(int i = 0; i < numOfLives; i++){
            if(i < spaceship.lives){
                playerLives[i].sprite = fullShip;
            }else{
                playerLives[i].sprite = emptyShip;
            }

            if(i < numOfLives){
                playerLives[i].enabled = true;
            }else{
                playerLives[i].enabled = false;
            }
       }
    }
}
