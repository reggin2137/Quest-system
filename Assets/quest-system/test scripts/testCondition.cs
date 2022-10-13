using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testCondition : EventQS
{
    private void Start()
    {
        SetType(Type.condition);
    }
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.W))
        {
            SetCondition(true);
        }
    }
}
