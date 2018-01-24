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
    public GameObject Objective6;
    public GameObject DialogPanel;
    public GameObject DialogPanel2;
    public GameObject DialogPanel2Text;
    public GameObject InfoPanel;
    public GameObject InfoPanelText;
    private GameObject Character;
    public GameObject PeasantMother;
    public GameObject Sabura;


    void Awake()
    {
        Character = GameObject.FindGameObjectWithTag("Player");

    }



    public void TakeOption1()
    {
        if(Questlog.Quest001Finished == false && Quest001Events.QuestTaken == false)
        { TakeOption1Quest001(); }
        else if(Questlog.Quest001Finished == false && Quest001Events.QuestTaken == true && Quest001Events.SwordTaken == true && Quest001Events.RiverCrossed == true && Quest001Events.RiverReached == true && Quest001Events.TreeInspected == true)
        {
            GiveSwordQuest001();
        }
      
    }
       

    public void TakeOption2()
    {

        if (Questlog.Quest001Finished == false && Quest001Events.QuestTaken == false)
        { TakeOption2Quest001(); }
        else if(Questlog.Quest001Finished == false && Quest001Events.QuestTaken == true && Quest001Events.SwordTaken == true && Quest001Events.RiverCrossed == true && Quest001Events.RiverReached == true && Quest001Events.TreeInspected == true)
        {
            KeepSwordQuest001();
        }
      
    }


    public void TakeOption3()
    {
        TakeOption3Quest001();
    }

    IEnumerator SetQuestUI001()
    {
        InfoPanelText.GetComponent<Text>().text = Quest001DialogConstants.QUEST001_INFOPANEL_TEXT1;
        InfoPanel.SetActive(true);
        Quest001Events.QuestTaken = true;
        QuestBox.GetComponent<Text>().text = Quest001DialogConstants.QUEST001_NAME ;
        Objective1.GetComponent<Text>().text = Quest001DialogConstants.QUEST001_OBJECTIVE1;
        Objective2.GetComponent<Text>().text = Quest001DialogConstants.QUEST001_OBJECTIVE2;
        Objective3.GetComponent<Text>().text = Quest001DialogConstants.QUEST001_OBJECTIVE3;
        yield return new WaitForSeconds(0.5f);
        QuestBox.SetActive(true);
        Objective4.SetActive(false);
        Objective5.SetActive(false);
        Objective6.SetActive(false);
        yield return new WaitForSeconds(1);
        Objective1.SetActive(true);
        yield return new WaitForSeconds(0.5f);
        Objective2.SetActive(true);
        yield return new WaitForSeconds(0.5f);
        Objective3.SetActive(true);
        yield return new WaitForSeconds(9);
        InfoPanel.SetActive(false);
        
     


    }

    IEnumerator SetQuestUI002()
    {
        Quest002Events.Quest002Active = true;
        Quest002Events.Quest002Taken = true;
        QuestBox.GetComponent<Text>().text = Quest002DialogConstants.QUEST002_NAME;
        Objective1.GetComponent<Text>().text = Quest002DialogConstants.QUEST002_OBJECTIVE1;
        Objective2.GetComponent<Text>().text = Quest002DialogConstants.QUEST002_OBJECTIVE2;
        Objective3.GetComponent<Text>().text = Quest002DialogConstants.QUEST002_OBJECTIVE3;
        Objective4.GetComponent<Text>().text = Quest002DialogConstants.QUEST002_OBJECTIVE4;
        Objective5.GetComponent<Text>().text = Quest002DialogConstants.QUEST002_OBJECTIVE5;
        Objective6.GetComponent<Text>().text = Quest002DialogConstants.QUEST002_OBJECTIVE6;
        yield return new WaitForSeconds(0.5f);
        QuestBox.SetActive(true);
        yield return new WaitForSeconds(1);
        Objective1.SetActive(true);
        yield return new WaitForSeconds(0.5f);
        Objective2.SetActive(true);
        yield return new WaitForSeconds(0.5f);
        Objective3.SetActive(true);
        yield return new WaitForSeconds(0.5f);
        Objective4.SetActive(true);
        yield return new WaitForSeconds(0.5f);
        Objective5.SetActive(true);
        yield return new WaitForSeconds(0.5f);
        Objective6.SetActive(true);
        PeasantMother.SetActive(true);
        Sabura.SetActive(false);
        
      






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
            DialogPanel2.SetActive(false);
         
        }
    }
    private void TakeOption1Quest001()
    {
        DialogPanel.SetActive(false);
        DialogPanel2Text.GetComponent<Text>().text = Quest001DialogConstants.QUEST001_DIALOGTEXT_OPTION1;
        DialogPanel2.SetActive(true);
        if (Input.GetButtonDown("Exit"))
        {
            Player.SetActive(true);
            Cam.SetActive(false);
            UIQuest.SetActive(false);
           
            
        }
    }
    private void TakeOption2Quest001()
    {
        // DEBUG MODE
        Questlog.Quest001Finished = false;
        Quest001Events.QuestTaken = true;
        Quest001Events.SwordTaken = true;
        Quest001Events.RiverCrossed = true;
        Quest001Events.RiverReached = true;
        Quest001Events.TreeInspected = true;
        // DEBUG MODE
        Player.SetActive(true);
        Cam.SetActive(false);
        UIQuest.SetActive(false);
        StartCoroutine(SetQuestUI001());
        DialogPanel.SetActive(false);
        DialogPanel2Text.GetComponent<Text>().text = Quest001DialogConstants.QUEST001_DIALOGTEXT_OPTION2;
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
    private void TakeOption3Quest001()
    {
        Player.SetActive(true);
        Cam.SetActive(false);
        UIQuest.SetActive(false);
    }
    private void GiveSwordQuest001()
    {
        Quest001Events.GaveSword = true;
        Quest001Events.FinishedDecision001 = true;
        Quest001Events.QuestTaken = false;
        Questlog.Quest001Finished = true;
        Player.SetActive(true);
        Character.SendMessage("GainExperience", 100F);
        Player.SetActive(false);
        DialogPanel.SetActive(false);
        DialogPanel2Text.GetComponent<Text>().text = Quest001DialogConstants.QUEST001_FINISHED_GIVE_SWORD_DIALOG;
        DialogPanel2.SetActive(true);
        StartCoroutine(SetQuestUI002());
    }
    private void KeepSwordQuest001()
    {
        Quest001Events.KeptSword = true;
        Quest001Events.FinishedDecision001 = true;
        Quest001Events.QuestTaken = false;
        Questlog.Quest001Finished = true;
        Player.SetActive(true);
        Character.SendMessage("GainExperience", 100F);
        Player.SetActive(false);
        DialogPanel.SetActive(false);
        DialogPanel2Text.GetComponent<Text>().text = Quest001DialogConstants.QUEST001_FINISHED_KEEP_SWORD_DIALOG;
        DialogPanel2.SetActive(true);
        StartCoroutine(SetQuestUI002());
    }
}
