using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterO : MonoBehaviour
{
    protected Vector3 destination;
    float moveSpeed;
    float angleSpeed;
    Rect hurtBox;

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
        Debug.Log("Move");
        Debug.Log(destination);
        if (destination != transform.position)
        {
            //transform.position.Set(transform.position.x + destination.normalized.x * moveSpeed * Time.deltaTime,
            //    transform.position.y, transform.position.z + destination.normalized.z * moveSpeed * Time.deltaTime);
            Vector3.MoveTowards(transform.position, destination, moveSpeed*Time.deltaTime);
            transform.LookAt(destination);
        }
    }
}
