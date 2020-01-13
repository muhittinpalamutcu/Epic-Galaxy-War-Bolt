using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Bullet : Bolt.EntityBehaviour<ICustomCubeState>
{
    
    public int bulletDamage = 1;
   

    void OnTriggerEnter2D(Collider2D collision)
    {
       if (collision.gameObject.tag == "Wall")
        {
            // PlayerHealth.reference.playerKill += 1;

            

            Destroy(gameObject);
            
        } 

        if (collision.gameObject.tag == "Player")
        {
            PlayerHealth2.reference.player2Kill += 1;
            PlayerHealth.reference.playerHealth -= bulletDamage;
           

          Destroy(gameObject); 

        } 

        
        if (collision.gameObject.tag == "Player2")
        {
          PlayerHealth2.reference.player2Health -= bulletDamage;
          PlayerHealth.reference.playerKill += 1;

           
           Destroy(gameObject);


       } 


   } 

        }
