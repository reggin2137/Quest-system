using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : EventQS
{
    void Update()
    {
        if(isEffectActive)
        {
            Debug.Log("aktywuje efekt!");
        }
    }
}
