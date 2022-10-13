using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : EventQS
{
    void Update()
    {
        if(GetEffectStatus())
        {
            Debug.Log("aktywuje efekt!");
        }
    }
}
