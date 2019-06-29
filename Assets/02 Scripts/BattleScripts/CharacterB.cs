using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterB : MonoBehaviour
{
    int HP;

    private void Awake()
    {

    }

    private void Start()
    {
        InitStart();
    }

    private void OnEnable()
    {
        onEnable();
    }
    private void OnDisable()
    {
        onDisable();
    }

    virtual public void InitAwake()
    {

    }
    virtual public void InitStart()
    {

    }

    virtual public void onEnable()
    {
        Debug.Log("onEnable");
    }

    virtual public void onDisable()
    {
        Debug.Log("onDisable");
    }

    virtual public void UpdateDo()
    {

    }

    private void Update()
    {
        UpdateDo();
    }
}


