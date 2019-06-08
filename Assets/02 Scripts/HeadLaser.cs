using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeadLaser : MonoBehaviour
{
    public Vector3 GetPosition()
    {
        Vector3 _headPos = transform.position;//transform.TransformPoint(transform.position);
        
        return _headPos;
    }

}
