using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Quest001SwordTrigger : MonoBehaviour
{

    public GameObject ObjectiveText4;
    public GameObject Quest;
    public GameObject Sword;
    







    private void OnTriggerEnter(Collider other)
    {
        if (Quest001Events.QuestTaken == true)
        {
 
            ObjectiveText4.GetComponent<Text>().text = Quest001DialogConstants.QUEST001_OBJECTIVE4_FINISHED;
            Sword.SetActive(false);
            Quest001Events.SwordTaken = true;
        }
    }
}
