using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Quest001Buttons : MonoBehaviour {

    public GameObject Player;
    public GameObject Cam;
    public GameObject UIQuest;
    public GameObject QuestBox;
    public GameObject Objective1;
    public GameObject Objective2;
    public GameObject Objective3;
    public GameObject Objective4;
    public GameObject Objective5;
    public GameObject DialogPanel;
    public GameObject DialogPanel2;
    public GameObject DialogPanel2Text;
    public GameObject InfoPanel;
    public GameObject InfoPanelText;




    public void TakeOption1()
    {
        DialogPanel.SetActive(false);
        DialogPanel2Text.GetComponent<Text>().text = Quest001DialogConstants.QUEST001DIALOGTEXTOPTION1;
        DialogPanel2.SetActive(true);
        if (Input.GetButtonDown("FinishDialog"))
        {
            Player.SetActive(true);
            Cam.SetActive(false);
            UIQuest.SetActive(false);
        }
    }
       

    public void TakeOption2()
    {
        Player.SetActive(true);
        Cam.SetActive(false);
        UIQuest.SetActive(false);
        StartCoroutine(SetQuestUI());
        DialogPanel.SetActive(false);
        DialogPanel2Text.GetComponent<Text>().text = Quest001DialogConstants.QUEST001DIALOGTEXTOPTION2;
            DialogPanel2.SetActive(true);
            Quest001Events.QuestTaken = true;
            if (Input.GetButtonDown("FinishDialog"))
            {
                Player.SetActive(true);
                Cam.SetActive(false);
                UIQuest.SetActive(false);
            }
          StartCoroutine(FinishDialog());
      
      
    }


    public void TakeOption3()
    {
        Player.SetActive(true);
        Cam.SetActive(false);
        UIQuest.SetActive(false);
    }

    IEnumerator SetQuestUI()
    {
        InfoPanelText.GetComponent<Text>().text = Quest001DialogConstants.QUEST001INFOPANELTEXT1;
        InfoPanel.SetActive(true);
        QuestBox.GetComponent<Text>().text = Quest001DialogConstants.QUEST001NAME ;
        Objective1.GetComponent<Text>().text = Quest001DialogConstants.QUEST001OBJECTIVE1;
        Objective2.GetComponent<Text>().text = Quest001DialogConstants.QUEST001OBJECTIVE2;
        Objective3.GetComponent<Text>().text = Quest001DialogConstants.QUEST001OBJECTIVE3;
        DialogManager.DialogNumber = 1;
        yield return new WaitForSeconds(0.5f);
        QuestBox.SetActive(true);
        Objective4.SetActive(false);
        Objective5.SetActive(false);
        yield return new WaitForSeconds(1);
        Objective1.SetActive(true);
        yield return new WaitForSeconds(0.5f);
        Objective2.SetActive(true);
        yield return new WaitForSeconds(0.5f);
        Objective3.SetActive(true);
        yield return new WaitForSeconds(9);
        InfoPanel.SetActive(false);
        
     


    }

    IEnumerator FinishDialog()
    {
        yield return new WaitForSeconds(12);
        DialogPanel2Text.SetActive(false);
        DialogPanel2.SetActive(false);
    }
    private void Update()
    {
        if (Input.GetButtonDown("Exit"))
        {
            Player.SetActive(true);
            Cam.SetActive(false);
            UIQuest.SetActive(false);
        }
    }

}
