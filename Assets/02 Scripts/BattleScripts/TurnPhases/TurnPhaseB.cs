using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnPhaseB : MonoBehaviour
{
    /*
     This is the TurnPhaseB class. This is the class that will frame the basis for all the phases in a turn.
     It will consist of a function that initializes the phase, then a fuction that does the thing that the phase is supposed to do,
     and finally it will move on to the next appropriate function. 
    */
    BattleManagerB BM;

    public void Init(BattleManagerB battleManager)//Initializes the phase
    {
        BM = battleManager;
    }

    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
