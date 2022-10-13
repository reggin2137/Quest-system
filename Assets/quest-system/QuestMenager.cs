using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestMenager : MonoBehaviour
{
    public List<Quest> quests = new List<Quest>();
    [SerializeField]int currentQuest;

    private void Start()
    {
        currentQuest = 0;
        foreach(Quest i in quests)
        {
            if(i != quests[0])
            {
                i.gameObject.SetActive(false);
            }
            else
            {
                i.gameObject.SetActive(true);
            }
        }
    }
    private void FixedUpdate()
    {
        if(quests[currentQuest].isFinished)
        {
            NextQuest();
        }
    }
    private void NextQuest()
    {
        var maxIndex = quests.Count - 1;
        if (currentQuest < maxIndex)
        {
            quests[currentQuest].gameObject.SetActive(false);
            currentQuest++;
            quests[currentQuest].gameObject.SetActive(true);
        }
        else if(currentQuest == maxIndex)
        {
            quests[currentQuest].gameObject.SetActive(false);
        }
        else
        {
            Debug.LogWarning("current quest index is out of range!");
        }
    }
}
