using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Quest001TriggerRiverCrossed : MonoBehaviour {

    public GameObject ObjectiveText2;
    public GameObject Quest;


    private void OnTriggerEnter(Collider other)
    {
        if (Quest001Events.QuestTaken == true)
        {
            ObjectiveText2.GetComponent<Text>().text = Quest001DialogConstants.QUEST001_OBJECTIVE2_FINISHED;
            Quest001Events.RiverCrossed = true;
        }
       
    }
}
