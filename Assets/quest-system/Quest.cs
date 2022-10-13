using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Quest : MonoBehaviour
{
    //public section
    public List<EventQS> eventsQS = new List<EventQS>();
    public bool isFinished = false;

    //private section
    List<EventQS> conditions = new List<EventQS>();
    List<EventQS> effects = new List<EventQS>();
    byte controlVar;

    void Start()
    {
        // pêtla segreguj¹ca skutki i warunki
        foreach (EventQS i in eventsQS)
        {
            if(i.type == EventQS.Type.condition)
            {
                conditions.Add(i);
            }else
            {
                effects.Add(i);
            }
        }
        controlVar = (byte)conditions.Count;
    }
    void FixedUpdate()
    {
        if(controlVar == 0)
        {
            ActiveEffects();
            isFinished = true;
        }
        foreach(EventQS i in conditions)
        {
            if(i.GetConditionStatus())
            {
                conditions.Remove(i);
                controlVar--;
            }
        }
    }

    void ActiveEffects() // metoda do aktywacji skutków
    {
        foreach(EventQS i in effects)
        {
            i.SetEffect(true);
        }
    }
}
