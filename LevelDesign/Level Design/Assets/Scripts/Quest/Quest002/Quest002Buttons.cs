using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Quest002Buttons : MonoBehaviour {
    public GameObject Player;
    public GameObject Cam;
    public GameObject UIQuest;
    public GameObject QuestBox2;
    public GameObject QuestBox;
    public GameObject Objective1;
    public GameObject Objective2;
    public GameObject Objective3;
    public GameObject Objective4;
    public GameObject Objective5;
    public GameObject Objective6;
    public GameObject DialogPanel;
    public GameObject DialogPanel2;
    public GameObject DialogPanel2Text;
    public GameObject DialogPanelText;


    void Awake()
    {
       

    }



    public void TakeOption1()
    {
        TakeOption1Quest002();

    }


    public void TakeOption2()
    {

        TakeOption2Quest002();
    }


    public void TakeOption3()
    {
        TakeOption3Quest002();
    }
    IEnumerator SetQuestUI002()
    {
        Quest002Events.Quest002Active = false;
        QuestBox2.SetActive(false);
        QuestBox.GetComponent<Text>().text = Quest002DialogConstants.QUEST002_MOTHER_NAME;
        Objective2.GetComponent<Text>().text = Quest002DialogConstants.QUEST002_MOTHER_OBJECTIVE2;
        yield return new WaitForSeconds(0.5f);
        QuestBox.SetActive(true);
        Objective3.SetActive(false);
        Objective4.SetActive(false);
        Objective5.SetActive(false);
        Objective6.SetActive(false);
        yield return new WaitForSeconds(1);
        Objective1.SetActive(true);
        yield return new WaitForSeconds(0.5f);
        Objective2.SetActive(true);
        

    }
    private void TakeOption1Quest002()
    {
        DialogPanel.SetActive(false);
        DialogPanel2Text.GetComponent<Text>().text = Quest002DialogConstants.QUEST002_PEASANT_MOTHER_QUEST_ACCEPTED;
        QuestSaveKid.QuestSaveKidActive = true;
        DialogPanel2.SetActive(true);
        QuestSaveKid.KidDied = false;
        StartCoroutine(FinishDialog());
        StartCoroutine(SetQuestUI002());
        if (Input.GetButtonDown("Exit"))
        {
            Player.SetActive(true);
            Cam.SetActive(false);
            UIQuest.SetActive(false);
           


        }
    }
    private void TakeOption2Quest002()
    {

        Player.SetActive(true);
        Cam.SetActive(false);
        UIQuest.SetActive(false);
        DialogPanel.SetActive(false);
        DialogPanel2Text.GetComponent<Text>().text = Quest002DialogConstants.QUEST002_PEASANT_MOTHER_QUEST_DECLINED;
        DialogPanel2.SetActive(true);
        Quest001Events.QuestTaken = true;
        StartCoroutine(FinishDialog());
        if (Input.GetButtonDown("FinishDialog"))
        {
            Player.SetActive(true);
            Cam.SetActive(false);
            UIQuest.SetActive(false);
        
        }
  
    }
    private void TakeOption3Quest002()
    {
        DialogPanelText.GetComponent<Text>().text = Quest002DialogConstants.QUEST002_PEASANT_MOTHER_REWARDINFO;
        
    
       

    }
    IEnumerator FinishDialog()
    {
        yield return new WaitForSeconds(10);
        DialogPanel2.SetActive(false);
    }

    } 
