using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Creature : MonoBehaviour
{
    protected Transform thisTransform;
    private Vector3 startPosition;
    public float verticalVelocity;

    private void Start()
    {
        thisTransform = transform;
        startPosition = transform.position; 

    }

    private void Update()
    {
        Move(); 
    }

    protected virtual void Move()
    {
        Vector3 pos = startPosition + Vector3.right * Mathf.Sin(Time.time);
        verticalVelocity -= 14 * Time.deltaTime;

        if (verticalVelocity < 0)
            verticalVelocity = 0;

        pos.y = verticalVelocity + startPosition.y;
        thisTransform.position = pos; 

    }

    public abstract void Talk();

    public abstract void Jump();
    

}
