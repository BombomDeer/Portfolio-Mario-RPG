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
            Move();
            LookAtIt(lookAtPoint);
        }
        else
        {
            lookAtPoint = Vector3.zero;
            moveToPoint = Vector3.zero;
        }
    }

    void MouseMovement()//Gets where you clicked then gives the coords to that to the move function which will be the one actually moving the character
    {
        Vector3 temp;
        if (Input.GetMouseButton(0))
        {
            if (Utility.MousePick(ref lookAtPoint))
            {
                temp = lookAtPoint;
                moveToPoint.Set(temp.x - transform.position.x, temp.y - transform.position.y, temp.z - transform.position.z);                
            }
            else
                return;
        }

        Debug.Log("MouseMovement");
    }

    void KeyboardMovement()
    {

        if (Input.GetKey(KeyCode.UpArrow))
        {
            moveToPoint.z = 1;
        }
        else if(Input.GetKey(KeyCode.DownArrow))
        {
            moveToPoint.z = -1;
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            moveToPoint.x = 1;
        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            moveToPoint.x = -1;
        }

        lookAtPoint.Set(transform.position.x + moveToPoint.x,
              transform.position.y, transform.position.z + moveToPoint.z);

        //Debug.Log("KeyboardMovement");        
    }
}