using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SingleTon <T> where T:class, new()
{
    private static T inst = null;
    public SingleTon()
    {

    }

    public static T instance
    {
        get
        {
            if (inst == null)
                inst = new T();
            return inst;
        }
    }
}
