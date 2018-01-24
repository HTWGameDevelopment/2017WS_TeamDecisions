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
        if (Quest001Events.QuestTaken == true && Questlog.Quest001Finished == false)
        {
        ObjectiveText1.GetComponent<Text>().text =Quest001DialogConstants.QUEST001_OBJECTIVE1_FINISHED;
            Quest001Events.RiverReached = true;
        
            StartCoroutine(InfoPanelShow());



        }
        if (Quest002Events.Quest002Active == true)
        {
            ObjectiveText1.GetComponent<Text>().text = Quest001DialogConstants.QUEST001_OBJECTIVE1_FINISHED;
            Quest002Events.Quest002RiverReached = true;
        }
    }

    IEnumerator InfoPanelShow()
    {
        InfoPanelText.GetComponent<Text>().text = Quest001DialogConstants.QUEST001_INFOPANEL_TEXT2;
        InfoPanel.SetActive(true);
        yield return new WaitForSeconds(10);
        InfoPanel.SetActive(false);
            }
}

