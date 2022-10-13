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
    public Type type;
    [Header("variables for effect")]
    [SerializeField] bool isEffectActive;
    public void SetEffect(bool value)
    {
        isEffectActive = value;
    }
    public bool GetEffectStatus()
    {
        return isEffectActive;
    }

    [Header("variables for condition")]
    [SerializeField] bool isConditionDone;
    public void SetCondition(bool value)
    {
        isConditionDone = value;
    }
    public bool GetConditionStatus()
    {
        return isConditionDone;
    }
}
