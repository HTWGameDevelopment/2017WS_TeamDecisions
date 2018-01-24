using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Quest002KiashiTrigger : MonoBehaviour {

    public GameObject ObjectiveText;



    private void OnTriggerEnter(Collider other)
    {
        if (Quest002Events.Quest002Active == true)
        {
            ObjectiveText.GetComponent<Text>().text = Quest002DialogConstants.QUEST002_OBJECTIVE2FINISHED;
            Quest002Events.Quest002KiashiReached = true;
        }

    }
}
