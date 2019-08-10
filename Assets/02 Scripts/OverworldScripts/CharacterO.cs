using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterO : MonoBehaviour
{
    protected Vector3 lookAtPoint;
    protected Vector3 moveToPoint;
    float moveSpeed = 3.0f;
    //float angleSpeed;
    Rect hurtBox;

    enum State
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
        if(Vector3.Distance(transform.position, lookAtPoint)>0.7)
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
