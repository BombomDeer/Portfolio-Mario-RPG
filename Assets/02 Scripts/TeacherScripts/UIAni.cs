using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIAni : MonoBehaviour
{
    public AnimationCurve aniCurve;
    float fSum = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        fSum += Time.deltaTime;
        float fCurValue = aniCurve.Evaluate(fSum);

        Vector3 tmp = transform.position;
        tmp.y = fCurValue;
        transform.position = tmp;
    }
}
