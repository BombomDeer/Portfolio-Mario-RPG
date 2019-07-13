using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleManagerB : MonoBehaviour
{
    enum eAttack
    {
        
    }

    enum eTurnPhase
    {
        START,
        MENU, ENEMYPICK,
        TO_POSITIONS,
        MINIGAME,
        DAMAGE,
        RETURN_TO_POSITION,
        END
    }

    
    public List<CharacterB> characters = new List<CharacterB>(); //List of all characters 0 is always player
    Dictionary<eAttack, AttackB> attacks = new Dictionary<eAttack, AttackB>();
    int curTurnNum = 0;
    int numOfChar = 0;

    // Start is called before the first frame update

    private void Awake()
    {
        InitBattleManager();//initiates battlemanager, this includes everything that goes into initiating the battle manager    
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //public void Test()
    //{
    //    Debug.Log(tmpCount % 3);
    //}

    void InitBattleManager()//initiates battlemanager, this includes everything that goes into initiating the battle manager   
    {
        CharactersInit();//calls the init function of all characters
        numOfChar = characters.Count;
    }

    void CharactersInit()//initiates all characters
    {
        for(int i = 0;i<characters.Count;i++)
        {
            characters[i].Init(this);
        }
    }

    //void RollInitiative()//Determines Turn order
    //{

    //}

    
}
