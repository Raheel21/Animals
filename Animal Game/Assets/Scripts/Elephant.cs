using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Elephant : Creature
{


    public override void Talk()
    {
        
        Debug.Log("I am a Elephant"); 
    }

    public override void Jump()
    {
        
            verticalVelocity = 2.0f;
        
    }








    //i can use below code for bird creature movement 
    // protected override void Move()
    // {
    //   base.Move();
    //  thisTransform.position += Vector3.up * Mathf.Sin(Time.time);
    // }

}
