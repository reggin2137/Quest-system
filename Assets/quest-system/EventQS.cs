using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventQS : MonoBehaviour
{
    public enum Type // enum typ�w event�w(warunek, skutek)
    {
        condition,
        effect,
    }
    public Type type;
    [Header("variables for effect")]
    public bool isEffectActive;

    [Header("variables for condition")]
    public bool isConditionDone;
}
