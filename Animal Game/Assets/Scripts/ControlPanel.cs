using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlPanel : MonoBehaviour
{
    public Transform[] creatures;
    public Creature[] cs;

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.T))
        {
            foreach (Creature c in cs)
            {
                c.Talk(); 
            }


        }

        if (Input.GetKeyDown(KeyCode.J))
        {
            foreach(Creature c in cs)
            {

                c.Jump(); 
            }
        }

    }

    public void Move(int creatureIndex)
    {
        creatures[creatureIndex].SendMessage("Move"); 
    }

    public void Talk(int creatureIndex)
    {
        creatures[creatureIndex].SendMessage("Talk");
    }

    public void Jump(int creatureIndex)
    {
        creatures[creatureIndex].SendMessage("Jump");
    }

}
