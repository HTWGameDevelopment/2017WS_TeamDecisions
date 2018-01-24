using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Quest001TreeReached : MonoBehaviour {

    public GameObject ObjectiveText3;
    public GameObject ObjectiveText4;
    public GameObject Quest;
    public GameObject InfoPanel;
    public GameObject InfoPanelText;





    private void OnTriggerEnter(Collider other)
    {
        if (Quest001Events.QuestTaken == true)
        {
            
            
            ObjectiveText3.GetComponent<Text>().text = Quest001DialogConstants.QUEST001_OBJECTIVE3_FINISHED;
            ObjectiveText4.SetActive(true);
            ObjectiveText4.GetComponent<Text>().text = Quest001DialogConstants.QUEST001_OBJECTIVE4;
            Quest001Events.TreeInspected = true;
            StartCoroutine(InfoPanelShow());
        }
    }

    IEnumerator InfoPanelShow()
    {
        InfoPanelText.GetComponent<Text>().text = Quest001DialogConstants.QUEST001_INFOPANEL_TEXT3;
        InfoPanel.SetActive(true);
        yield return new WaitForSeconds(10);
        InfoPanel.SetActive(false);
    }
}
