using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : Bolt.EntityBehaviour<ICustomCubeState>
{
    public Rigidbody2D bulletPrefab;
    public float bulletSpeed;
    public float bulletDamage;
    public GameObject muzzle; //bullet instantiating point 


    public override void Attached()
    {
        state.OnShoot = Shoot;

    }


    private void Shoot()
    {

        Rigidbody2D bulletClone = Instantiate(bulletPrefab, muzzle.transform.position, this.transform.rotation);
        bulletClone.velocity = transform.TransformDirection(new Vector2(0, bulletSpeed));

        /*
     if (BoltNetwork.IsServer)
     {

         
            Rigidbody2D bulletClone = Instantiate(bulletPrefab, muzzle.transform.position, this.transform.rotation);
            bulletClone.velocity = transform.TransformDirection(new Vector2(0, bulletSpeed));
     }
        if (BoltNetwork.IsClient)
        {
            
            Rigidbody2D bulletClone = Instantiate(bulletPrefab, muzzle.transform.position, this.transform.rotation);
            bulletClone.velocity = transform.TransformDirection(new Vector2(0, bulletSpeed));
        }*/

    }



    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0) && entity.IsOwner)
        {
            state.Shoot();
        }
    }


   
    
}


