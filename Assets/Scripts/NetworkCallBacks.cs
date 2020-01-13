using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[BoltGlobalBehaviour]
public class NetworkCallBacks : Bolt.GlobalEventListener
{

  
    /* public override void SceneLoadLocalDone(string scene)
     {
         var spawnPosition = new Vector3(Random.Range(-8, 8), 0, Random.Range(-8, 8));
         BoltNetwork.Instantiate(BoltPrefabs.Cube, spawnPosition, Quaternion.identity);

     } */

    public override void SceneLoadLocalDone(string map)
    {
        // randomize a position
       // var spawnPosition = new Vector3(Random.Range(-3, 3), 0, Random.Range(-3, 3));
        if (BoltNetwork.IsServer)
        {
            //  var spawnPosition = new Vector3(Random.Range(-3, 3), 0, Random.Range(-3, 3));
            
            var spawnPosition = new Vector2(0, 4);
            BoltNetwork.Instantiate(BoltPrefabs.Player, spawnPosition, Quaternion.Euler(0, 0,180));
            

        }

        // instantiate cube
        if (BoltNetwork.IsClient)
        {
            var spawnPosition = new Vector2(0, -4);
           
            //var spawnPosition = new Vector3(Random.Range(-3, 3), 0, Random.Range(-3, 3));
            BoltNetwork.Instantiate(BoltPrefabs.Player3, spawnPosition, Quaternion.identity);
        }
    }


    
}
