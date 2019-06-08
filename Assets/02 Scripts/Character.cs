using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    Vector3 vEnd = Vector3.zero;
    Vector3 vDir = Vector3.zero;
    float fSpeed = 6.0f;
    [SerializeField] HeadLaser _headlaser;
    // Start is called before the first frame update
    void Start()
    {
        vEnd = transform.position;        
    }

    bool MousePick()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit, 100))
        {
            if (!hit.collider.tag.Contains("Terrain"))
                return false;
            Debug.Log(hit.collider.name);
            //마우스 클릭한 지점
            vEnd = hit.point;
            //방향벡터 ( 회전또는 각도계산에 사용 )
            vDir = vEnd - transform.position;
            //vDir를 방향벡터로 만든다.
            vDir.Normalize();//makes it all to 1
            return true;

            
        }
        else
            return false;
    }

    void Moving()
    {
        if (transform.position != vEnd)
        {
            transform.position = Vector3.MoveTowards(transform.position, vEnd, Time.deltaTime * fSpeed);
        }
        //transform.rotation = Quaternion.LookRotation(vDir);
        float step = 10.0f * Time.deltaTime;
        Vector3 newDir = Vector3.RotateTowards(transform.forward, vDir.normalized, step, 0.0f);
        transform.rotation = Quaternion.LookRotation(newDir);
        Debug.DrawLine(transform.position, vEnd, Color.red);
    }

    void HeadLine()
    {
        Vector3 _head = new Vector3();
        _head.Set(_headlaser.GetPosition().x, _headlaser.GetPosition().y, _headlaser.GetPosition().z);
        Vector3 _slightlyBelowHeadLaser = new Vector3();
        _slightlyBelowHeadLaser.Set(_headlaser.GetPosition().x, _headlaser.GetPosition().y - 8, _headlaser.GetPosition().z);

        Debug.DrawLine(_head, _slightlyBelowHeadLaser, Color.magenta);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButton(0))
        {
            if(MousePick())
            {
                Moving();
            }
        }
        HeadLine();
    }
}
