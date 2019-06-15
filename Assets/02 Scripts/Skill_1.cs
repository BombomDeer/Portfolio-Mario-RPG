using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Skill_1 : MonoBehaviour
{
    [SerializeField] Player player;
    [SerializeField] Transform skill_node;
    public float fSpeed = 25;
    // Start is called before the first frame update
    void Start()
    {
        //transform.parent = player.transform;
    }

    // Update is called once per frame
    void Update()
    {
        transform.parent.position = player.transform.position;
        transform.RotateAround(transform.parent.position, Vector3.up,
            Time.deltaTime * fSpeed);
    }
}
