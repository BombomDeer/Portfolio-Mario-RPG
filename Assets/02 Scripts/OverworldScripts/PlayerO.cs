using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerO : CharacterO
{
    protected override void InitStart()
    {
        base.InitStart();
    }

    protected override void UpdateDo()
    {
        base.UpdateDo();        
        
        if (Input.anyKey)
        {
            MouseMovement();
            KeyboardMovement();
        }
        else
        {
            destination = Vector3.zero;
        }
    }

    void MouseMovement()//Gets where you clicked then gives the coords to that to the move function which will be the one actually moving the character
    {
        Vector3 temp;
        if (Input.GetMouseButton(0))
        {
            if (Utility.MousePick(ref destination))
            {
                temp = destination;
                destination.Set(temp.x - transform.position.x, temp.y - transform.position.y, temp.z - transform.position.z);
                Move();
            }
            else
                return;
        }

        Debug.Log("MouseMovement");
    }

    void KeyboardMovement()
    {

        
        if(Input.GetKey(KeyCode.UpArrow))
        {
            Debug.Log("Up");
            //destination = Vector3.zero;
            destination.z = 1;
        }
        else if(Input.GetKey(KeyCode.DownArrow))
        {
            
            destination.z = -1;
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            Debug.Log("Right");
            destination.x = 1;
        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            destination.x = -1;
        }

        Debug.Log("KeyboardMovement");
        Move();
    }
}
