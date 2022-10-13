using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventQS : MonoBehaviour
{
    public enum Type // enum typów eventów(warunek, skutek)
    {
        condition,
        effect,
    }
    Type type;
    [Header("variables for effect")]
    [SerializeField] bool isEffectActive;
    public void SetEffect(bool value)
    {
        if (GetType() == Type.effect)
        {
            isEffectActive = value;
        }
        else
        {
            Debug.LogError("Event is not effect. You can't set effect");
        }
    }
    public bool GetEffectStatus()
    {
        return isEffectActive;
    }

    [Header("variables for condition")]
    [SerializeField] bool isConditionDone;
    public void SetCondition(bool value)
    {
        if(GetType() == Type.condition)
        {
            isConditionDone = value;
        }
        else
        {
            Debug.LogError("Event is not condition. You can't set condition");
        }
    }
    public bool GetConditionStatus()
    {
        return isConditionDone;
    }

    public void SetType(Type eventType)
    {
        type = eventType;
    }
    public void SetType(byte index)
    {
        type = (Type)index;
    }
    public Type GetType()
    {
        return type;
    }
}
