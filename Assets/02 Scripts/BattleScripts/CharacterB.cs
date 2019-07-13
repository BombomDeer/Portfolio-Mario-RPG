using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterB : MonoBehaviour
{
    int HP;
    BattleManagerB battleManager;
    //float Speed;

    virtual protected void Start()
    {
        
    }

    virtual protected void Update()
    {
        
    }

    public void Init(BattleManagerB _battleManager)
    {
        battleManager = _battleManager;
    }

    virtual public void TestDebugPrompt()
    {
        //battleManager.Test();
    }
}


