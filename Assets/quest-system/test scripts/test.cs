using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : EventQS
{
    private void Start()
    {
        SetType(Type.effect);
    }
    void Update()
    {
        if(GetEffectStatus())
        {
            Debug.Log("aktywuje efekt!");
        }
    }
}
