using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuestSaveKidTrigger : MonoBehaviour
{

    public GameObject ObjectiveText1;
    public GameObject Quest;
   








    private void OnTriggerEnter(Collider other)
    {
        if (QuestSaveKid.QuestSaveKidActive == true && QuestSaveKid.KidSaved == false)
        {

            ObjectiveText1.GetComponent<Text>().text = Quest002DialogConstants.QUEST002_MOTHER_OBJECTIVE1FINISHED;
                    
        }
    }
}
