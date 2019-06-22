using System.Collections;
using System.Collections.Generic;
using UnityEngine;

enum eAniIndex
{
    IDLE = 0,
    RUN = 1
}

public class AniAction
{
    public virtual void Update()
    {

    }
}

public class Idle:AniAction
{
    public override void Update()
    {
        
    }
}

public class Run:AniAction
{
    public override void Update()
    {

    }
}



public class Animanager
{
    Animator ani;
    //Idle idle;
    //Run run;
    Dictionary<eAniIndex, AniAction> aniAction = new Dictionary<eAniIndex, AniAction>();
    AniAction curAction = null;
    string strNextAni = string.Empty;
    string strCurAni = string.Empty;
    Dictionary<eAniIndex, string> aniNames = new Dictionary<eAniIndex, string>();

    public void InitAniManager(Animator _ani)
    {
        ani = _ani;
        aniAction.Add(eAniIndex.IDLE, new Idle());
        aniAction.Add(eAniIndex.RUN, new Run());
        curAction = aniAction[eAniIndex.IDLE];

        AnimatorClipInfo[] ClipInfo = ani.GetCurrentAnimatorClipInfo(0);
        strCurAni = ClipInfo[0].clip.name;
        strNextAni = strCurAni;
        
    }

    public void SetNextAnimation(string strNext)
    {
        strNextAni = strNext;
        if (strCurAni != strNextAni)
        {
            SetAnimation(strNextAni);
            strCurAni = strNextAni;
        }
        //AnimatorClipInfo[] ClipInfo = ani.GetCurrentAnimatorClipInfo(0);
        //strNextAni = ClipInfo[0].clip.name;
        //SetAnimation(nIndex);

    }
    public void SetAnimation(string strName)
    {
        int nIndex = 0;
        //문자열과 애니메이션 파라미터를 저장한 자료구조 사용

        if(strNextAni == "idle")
        {
            nIndex = 0;
        }
        else if(strNextAni == "run")
        {
            nIndex = 1;
        }
        ani.SetInteger("inIndex", nIndex);
        curAction = aniAction[(eAniIndex)nIndex];            
        

        

    }

    public void Update()
    {
        curAction.Update();
    }
}
