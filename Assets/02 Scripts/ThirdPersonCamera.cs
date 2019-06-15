using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThirdPersonCamera : MonoBehaviour
{
    public Transform chaTr;
    Vector3 oldCha;
    Vector3 oldRot;
    float fAngularSpeed = 10f;
    const float fWheelSpeed = 20f;
    const float fZoomMin = 26;
    const float fZoomMax = 110;

    // Start is called before the first frame update
    void Start()
    {
        oldCha = chaTr.position;
        oldRot = chaTr.eulerAngles;
    }

    private void LateUpdate()
    {
        Vector3 delta = chaTr.position - oldCha;
        Vector3 newCamPos = transform.position + delta;
        transform.position = newCamPos;
        oldCha = chaTr.position;

        //Quaternion deltaRotation;
        //deltaRotation.y = chaTr.rotation.y * oldRot.y;
        //Quaternion newCamRot;
        //newCamRot.y = transform.rotation.y * deltaRotation.y;
        //transform.rotation.Set(0, newCamRot.y,0,0);
        //oldRot.y = chaTr.rotation.y;
        Vector3 deltaAngle = chaTr.eulerAngles - oldRot;
        Vector3 newAngle = transform.eulerAngles + deltaAngle;
        if(deltaAngle.sqrMagnitude > 0.01)
        {
            //transform.RotateAround(chaTr.transform.position, Vector3.up, 
            //    Time.deltaTime * fAngularSpeed);
        }
        oldRot = chaTr.eulerAngles;


        float fWheel = Input.GetAxis("Mouse ScrollWheel");
        if(fWheel != 0)
        {
            float cur = Camera.main.fieldOfView;
            cur += fWheel*fWheelSpeed*-1;
            Camera.main.fieldOfView = Mathf.Clamp(cur, fZoomMin, fZoomMax);
        }
    }

    // Update is called once per frame
    void Update()
    {
        

    }
}
