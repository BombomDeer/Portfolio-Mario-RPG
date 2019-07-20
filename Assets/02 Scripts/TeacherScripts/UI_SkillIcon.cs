using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_SkillIcon : MonoBehaviour
{
    public Image icon;
    public Image Empty;
    public float fCoolTime;
    float fSumTime;

    // Start is called before the first frame update
    void Start()
    {
        fSumTime = fCoolTime;
    }

    public void InitCoolTime()
    {
        fSumTime = fCoolTime;
    }

    // Update is called once per frame
    void Update()
    {
        fSumTime = fSumTime - Time.deltaTime;
        Empty.fillAmount = fSumTime/fCoolTime;
        
        if(Empty.fillAmount<=0)
        {
            InitCoolTime();
        }
    }
}
