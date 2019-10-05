using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterO : MonoBehaviour
{
    protected Vector3 lookAtPoint;//the point in space where the character will look at
    protected Vector3 moveToPoint;//the point in space where the character will try to go to
                                  //when using keyboard the move point will be like 1 away but when you click with your mouse it'll be where you clicked
    float moveSpeed = 3.0f;//movement speed
    //float angleSpeed;//as of yet unimplemented speed of the character turning to look at point
    //Rect hurtBox;//this is the hurt/hitbox where characters touch or something

    enum State//a list of movement states not implemented yet
    {
        idle,
        moving,
    }

    private void Awake()
    {
        InitAwake();
    }

    // Start is called before the first frame update
    void Start()
    {
        InitStart();
    }

    // Update is called once per frame
    void Update()
    {
        UpdateDo();     
    }

    protected virtual void InitAwake()
    {

    }
    protected virtual void InitStart()
    {

    }

    protected virtual void UpdateDo()
    {

    }

    protected void Move()//moves the character towards the Vector3 destination set by the children class
    {
        //moveSpeed = 1.0f;
        //Debug.Log("Move");
        //Debug.Log(destination);
        Vector3 tmpMoveToPoint = new Vector3();
        //if (lookAtPoint != transform.position)
        if(Vector3.Distance(transform.position, lookAtPoint)>0.7)//this is to get it to stop moving when close to the point
        {
            tmpMoveToPoint.Set(transform.position.x + (moveToPoint.normalized.x * moveSpeed * Time.deltaTime),
              transform.position.y, transform.position.z + (moveToPoint.normalized.z * moveSpeed * Time.deltaTime));
            transform.position = tmpMoveToPoint;
            //transform.LookAt(lookAtPoint);
        }
    }

    protected void LookAtIt(Vector3 lookIt)
    {
        transform.LookAt(lookAtPoint);
    }
}
