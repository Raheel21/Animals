using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Giraffe : Creature
{
    

    public override void Talk()
    {
        Debug.Log("I am a Giraffe");
    }

    public override void Jump()
    {
        
            verticalVelocity = 2.0f;
        

    }







}
