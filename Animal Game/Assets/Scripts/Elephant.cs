using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Elephant : Creature
{
    protected override void Talk()
    {
        
        Debug.Log("I am a Elephant"); 
    }

    protected override void Move()
    {
        base.Move();
        thisTransform.position += Vector3.up * Mathf.Sin(Time.time);
    }

    protected override void Jump()
    {
        
    }













}
