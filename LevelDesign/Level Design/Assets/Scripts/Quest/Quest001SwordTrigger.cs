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
        if (Quest.activeSelf)
        {
 
            ObjectiveText4.GetComponent<Text>().text = "- Collect the sword[x]";
            Sword.SetActive(false);
        }
    }
}
