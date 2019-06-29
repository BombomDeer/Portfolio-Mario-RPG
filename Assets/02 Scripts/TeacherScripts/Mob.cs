using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Mob : Character
{
    Vector3 vEnd = Vector3.zero;
    Vector3 vDir = Vector3.zero;
    float fSpeed = 6.0f;
    [SerializeField] HeadLaser _headlaser;
    // Start is called before the first frame update
    [SerializeField] List<GameObject> PatrolPoints;
    
}
