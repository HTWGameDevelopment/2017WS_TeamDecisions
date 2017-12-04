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
        ObjectiveText1.GetComponent<Text>().text =Quest001DialogConstants.QUEST001OBJECTIVE1FINISHED;
            Quest001Events.RiverReached = true;
        
            StartCoroutine(InfoPanelShow());



        }
    }

    IEnumerator InfoPanelShow()
    {
        InfoPanelText.GetComponent<Text>().text = Quest001DialogConstants.QUEST001INFOPANELTEXT2;
        InfoPanel.SetActive(true);
        yield return new WaitForSeconds(10);
        InfoPanel.SetActive(false);
            }
}

