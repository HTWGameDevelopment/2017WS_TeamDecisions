using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Quest001TriggerRiverCrossed : MonoBehaviour {

    public GameObject ObjectiveText2;
    public GameObject Quest;


    private void OnTriggerEnter(Collider other)
    {
        if (Quest.activeSelf)
        {
            ObjectiveText2.GetComponent<Text>().text = "- Cross the river[x]";
        }

    }
}
