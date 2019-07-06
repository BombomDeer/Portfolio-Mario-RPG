using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleManagerB : MonoBehaviour
{
    enum attackNames
    {

    }

    enum ePhase
    {
        
    }

    
    [SerializeField] List<CharacterB> characters = new List<CharacterB>(); //List of all characters 0 is always player
    Dictionary<attackNames, AttackB> attacks;
    // Start is called before the first frame update

    private void Awake()
    {
        CharactersInit();//First make a list of all characters on field
        RollInitiative();
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

    void CharactersInit()//initiates all characters
    {
        for(int i = 0;i<characters.Count;i++)
        {
            characters[i].Init(this);
        }
    }

    void RollInitiative()//Determines Turn order
    {

    }
}
