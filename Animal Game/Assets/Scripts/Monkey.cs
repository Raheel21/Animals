using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monkey : Creature
{

    public override void Talk()
    {
        Debug.Log("I am a Monkey");
    }


    public override void Jump()
    {

        
            verticalVelocity = 2.0f;
        
    }






}
