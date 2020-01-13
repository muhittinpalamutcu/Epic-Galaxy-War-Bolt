using UnityEngine;
public class PlayerMovement : Bolt.EntityBehaviour<ICustomCubeState>
{

    public SpriteRenderer sprite;
    //same as void Start its'called when the entity loads into the game
    public override void Attached()
    {
        //gameobject.transfor also is okay.
        state.SetTransforms(state.CubeTransform, transform);
        


    }

    // for the movement itself put the detection just like normal photon pun in the update funtcion we were writing some key pressed functions

    //same as Update function but it's only  called  on owners computer 
    public override void SimulateOwner()
    {
        var speed = 4f;
        var movement = Vector3.zero;
        if (Input.GetKey(KeyCode.A))
        {
            movement.x -= 1f;
            state.SetTransforms(state.CubeTransform, transform);

        }

        if (Input.GetKey(KeyCode.D))
        {
            movement.x += 1f;
            state.SetTransforms(state.CubeTransform, transform);
        }
        if (Input.GetKey(KeyCode.W))
        {
            movement.y += 1f;
        }

        if (Input.GetKey(KeyCode.S))
        {
            movement.y -= 1f;
        }

        if (movement != Vector3.zero)
        {
            transform.position = transform.position + (movement.normalized * speed * BoltNetwork.FrameDeltaTime);
        }

    }







}

