using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Player : Character
{
    Vector3 vEnd = Vector3.zero;
    Vector3 vDir = Vector3.zero;
    float fSpeed = 2.0f;
    public float fAniSpeed = 2.0f;

    public override void InitAwake()
    {
        base.InitAwake();
        Debug.Log("Player InitAwake");
    }

    public override void InitStart()
    {
        base.InitStart();
        Debug.Log("Player InitStart");
    }

    void AniUpdate()
    {
        if(transform.position == navi.destination)
        {
            aniManager.SetNextAnimation("idle");
        }

    }

    public void EndAni()
    {
        Debug.Log("End of Idle");
    }

    public override void UpdateDo()
    {
        base.UpdateDo();
        if (Input.GetMouseButton(0))
        {
            if (Utility.MousePick(ref vEnd))
            {
                navi.destination = vEnd;
                aniManager.SetNextAnimation("run");
                ani.speed = fAniSpeed;
            }
        }

        AniUpdate();
    }
}
