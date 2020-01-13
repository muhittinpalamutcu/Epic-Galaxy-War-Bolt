using UnityEngine;
using UnityEngine.SceneManagement;
public class PlayerHealth : Bolt.EntityBehaviour<ICustomCubeState>
{
    public int playerHealth=3;
    public int playerKill = 0;
    

    public static PlayerHealth reference = null;
    //void start
    public override void Attached()
    {
        reference = this;
    
      /*  state.Health = playerHealth;
        state.Kill = playerKill;

        //if bolt state to change in Health 
        state.AddCallback("Health", HealthCallBack);  */
    }

    /*
    private void KillCallBack()
    {
        playerKill = state.Kill;

        if (playerKill >= 3)
        {
            BoltNetwork.Destroy(gameObject);
            BoltNetwork.Shutdown();
        }
    } */

        /*
    private void HealthCallBack()
    {
        playerHealth = state.Health;

        if (playerHealth <= 0)
        {
            BoltNetwork.Destroy(gameObject);
            BoltNetwork.Shutdown();
        }
    } */

    public void Update()
    {
       /* if (Input.GetKeyDown(KeyCode.Space))
        {
            state.Health -= 1;
        } */
        
        
        if (playerHealth <= 0)
        {

            SceneManager.LoadScene(2);

            BoltNetwork.Shutdown();
        }
        if(playerKill>=3)
        {
            SceneManager.LoadScene(3);
            

            BoltNetwork.Shutdown();
        }
        
     
    }

   








}
