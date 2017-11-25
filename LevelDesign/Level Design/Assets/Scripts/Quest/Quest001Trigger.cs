using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Quest001Trigger : MonoBehaviour
{

    public GameObject ObjectiveText1;
    public GameObject Quest;
    public GameObject InfoPanel;
    public GameObject InfoPanelText;

  




    private void OnTriggerEnter(Collider other)
    {
        if (Quest.activeSelf)
        {
        ObjectiveText1.GetComponent<Text>().text = "- Reach the river[x]";
        
            StartCoroutine(InfoPanelShow());



        }
    }

    IEnumerator InfoPanelShow()
    {
        InfoPanelText.GetComponent<Text>().text = "You just completed the first part of the quest! This in indicated by this: [x]";
        InfoPanel.SetActive(true);
        yield return new WaitForSeconds(10);
        InfoPanel.SetActive(false);
            }
}

