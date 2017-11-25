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
        if (Quest.activeSelf)
        {
            
            
            ObjectiveText3.GetComponent<Text>().text = "- Reach the tree[x]";
            ObjectiveText4.SetActive(true);
            ObjectiveText4.GetComponent<Text>().text = "- Collect the sword[ ]";
            StartCoroutine(InfoPanelShow());
        }
    }

    IEnumerator InfoPanelShow()
    {
        InfoPanelText.GetComponent<Text>().text = "A new objective of the quest just appeared! This happens from time to time if you reveal something throughout the quest which was not known before";
        InfoPanel.SetActive(true);
        yield return new WaitForSeconds(10);
        InfoPanel.SetActive(false);
    }
}
