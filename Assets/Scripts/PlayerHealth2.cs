using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHealth2 : Bolt.EntityBehaviour<ICustomCubeState>
{
    public int player2Health = 3;
    public int player2Kill = 0;

    
 

    public static PlayerHealth2 reference = null;
    //void start
    public override void Attached()
    {
        reference = this;
      /*state.Health2 = player2Health;
  
        //if bolt state to change in Health 
        state.AddCallback("Health", HealthCallBack); */
       
    }
     /* 
    private void HealthCallBack()
    {
        player2Health = state.Health2;

        if (player2Health <= 0)
        {
            BoltNetwork.Destroy(gameObject);
            BoltNetwork.Shutdown();

        }
    } */
    

    public void Update()
    {
       /* if (Input.GetKeyDown(KeyCode.Space))
        {
            state.Health2 -= 1;
        } */
        
        if (player2Health <= 0)
        {

            SceneManager.LoadScene(2);

            BoltNetwork.Shutdown();
        }
        
        if (player2Kill >= 3)
        {
            SceneManager.LoadScene(3);

            BoltNetwork.Shutdown();
        }
        
    }


}
