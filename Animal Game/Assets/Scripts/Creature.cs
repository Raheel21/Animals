using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Creature : MonoBehaviour
{
    public Transform thisTransform;
    private Vector3 startPosition;
    private float verticalVelocity;

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

    protected abstract void Talk();

    protected virtual void Jump()
    {
        verticalVelocity = 2.0f; 
    }




}
