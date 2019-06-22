using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Character : MonoBehaviour
{
    NavMeshAgent _navi;
    public Animanager aniManager;
    public NavMeshAgent navi
    {
        get
        {
            if(_navi == null)
                _navi = GetComponent<NavMeshAgent>();
            return _navi;
        }
    }

    protected Animator _ani;
    public Animator ani
    {
        get
        {
            if (_ani == null)
                _ani = GetComponent<Animator>();
            return _ani;
        }
    }
    

    private void Awake()
    {
        _navi = GetComponent<NavMeshAgent>();
        InitAwake();
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
        aniManager = new Animanager();
        aniManager.InitAniManager(ani);
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
        aniManager.Update();
    }

    private void Update()
    {
        UpdateDo();
    }
}
