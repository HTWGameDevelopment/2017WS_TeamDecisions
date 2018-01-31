using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Sabura2QuestButtons : MonoBehaviour {

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
    public GameObject ChoiceDialogPanel;
    public GameObject ChoiceDialogText;
    public GameObject ChoiceDialogPanelOption1;
    public GameObject ChoiceDialogPanelOption2;
    public GameObject ChoiceDialogPanelOption3;
    public GameObject Sabura;
    public GameObject InfoPanel;
    public GameObject InfoPanelText;
    public GameObject QuestBoxMother;
    public GameObject Interaction;
    public GameObject Expose;
    public GameObject Attack;
    private Boolean Option1_3Taken;

    void Update()
    {
        if (Input.GetButtonDown("Exit"))
        {
            if (SaburaHintEvents.SaburaExposeActive == true)
            {
                Player.SetActive(true);
                Cam.SetActive(false);
                DialogPanel.SetActive(false);
                DialogPanel2.SetActive(false);
                ChoiceDialogPanel.SetActive(false);
                Interaction.SetActive(false);
                Expose.SetActive(false);
                Attack.SetActive(false);
                Sabura.SetActive(false);
                StartCoroutine(SetQuest003());
              
            }
            else
            { 
                Player.SetActive(true);
                Cam.SetActive(false);
                DialogPanel.SetActive(false);
                DialogPanel2.SetActive(false);
                ChoiceDialogPanel.SetActive(false);
            }
        }

    }
    public void SaburaExposeOption1()
    {


        SaburaHintEvents.SaburaExposeDialog1 = true;
        if (SaburaHintEvents.SaburaExposeDialog1_3 == true)
        {
            ChoiceDialogPanel.SetActive(false);
            StartCoroutine(SetQuest003());
        }
        else if (SaburaHintEvents.SaburaExposeDialog1 == true && SaburaHintEvents.SaburaExposeDialog1_1 == false)
        {
          ChoiceDialogText.GetComponent<Text>().text = SaburaHintConstants.SABURA_EXPOSE_EVENT_DIALOG1_1_TEXT;
          ChoiceDialogPanelOption1.GetComponent<Text>().text = SaburaHintConstants.SABURA_EXPOSE_EVENT_DIALOG1_1_CHOICE1;
          ChoiceDialogPanelOption2.GetComponent<Text>().text = SaburaHintConstants.SABURA_EXPOSE_EVENT_DIALOG1_1_CHOICE2;
          ChoiceDialogPanelOption3.GetComponent<Text>().text = SaburaHintConstants.SABURA_EXPOSE_EVENT_DIALOG1_1_CHOICE3;
          SaburaHintEvents.SaburaExposeDialog1_1 = true;
        }
        else if (SaburaHintEvents.SaburaExposeDialog1_1 == true && SaburaHintEvents.SaburaExposeDialog1 == true && SaburaHintEvents.SaburaExposeDialog1_1_1 == true)
        {
            ChoiceDialogPanel.SetActive(false);
            StartCoroutine(SetQuest003());

        }
        else if (SaburaHintEvents.SaburaExposeDialog1_1 == true && SaburaHintEvents.SaburaExposeDialog1 == true)
        {
            ChoiceDialogText.GetComponent<Text>().text = SaburaHintConstants.SABURA_EXPOSE_EVENT_DIALOG1_1_1_TEXT;
            ChoiceDialogPanelOption1.GetComponent<Text>().text = SaburaHintConstants.SABURA_EXPOSE_EVENT_DIALOG1_1_1_CHOICE1;
            ChoiceDialogPanelOption2.GetComponent<Text>().text = SaburaHintConstants.SABURA_EXPOSE_EVENT_DIALOG1_1_1_CHOICE2;
            ChoiceDialogPanelOption3.SetActive(false);
            SaburaHintEvents.SaburaExposeDialog1_1_1 = true;

        }
 
    }

    public void SaburaExposeOption2()
    {

        if (SaburaHintEvents.SaburaExposeDialog1 == true && SaburaHintEvents.SaburaExposeDialog1_1 == true && SaburaHintEvents.SaburaExposeDialog1_1_1 == false && SaburaHintEvents.SaburaExposeDialog1_3 == false)
        {
            ChoiceDialogPanel.SetActive(false);
            DialogPanel2.SetActive(true);
            DialogPanel2Text.SetActive(true);
            DialogPanel2Text.GetComponent<Text>().text = SaburaHintConstants.SABURA_EXPOSE_EVENT_DIALOG1_2_TEXT;
            StartCoroutine(SetQuest003()); ;
        }
        else if(SaburaHintEvents.SaburaExposeDialog1_3 == true)
        {
            StartCoroutine(SetQuest003SaburaAllied());
        }

        else if (SaburaHintEvents.SaburaExposeDialog1 == true && SaburaHintEvents.SaburaExposeDialog1_1 == true && SaburaHintEvents.SaburaExposeDialog1_1_1 == true)
        {
            ChoiceDialogPanel.SetActive(false);
            StartCoroutine(SetQuest003());
        }
        else if (SaburaHintEvents.SaburaExposeDialog1 == true && SaburaHintEvents.SaburaExposeDialog1_3 == true && SaburaHintEvents.SaburaExposeDialog1_1 == false)
        {
            ChoiceDialogPanel.SetActive(false);
            StartCoroutine(SetQuest003());
        }
        else
        {
            ChoiceDialogPanel.SetActive(false);
            DialogPanel2.SetActive(true);
            DialogPanel2Text.SetActive(true);
            DialogPanel2Text.GetComponent<Text>().text = SaburaHintConstants.SABURA_EXPOSE_EVENT_DIALOG2_TEXT;
            StartCoroutine(SetQuest003()); ;
        }

    
    }
    public void SaburaExposeOption3()
    {
        if (SaburaHintEvents.SaburaExposeDialog1_1 == true)
        {
            SaburaHintEvents.SaburaExposeDialog1_3 = true;
            Option1_3Taken = true;
            ChoiceDialogText.GetComponent<Text>().text = SaburaHintConstants.SABURA_EXPOSE_EVENT_DIALOG1_1_3_TEXT;
            ChoiceDialogPanelOption1.GetComponent<Text>().text = SaburaHintConstants.SABURA_EXPOSE_EVENT_DIALOG1_1_3_CHOICE1;
            ChoiceDialogPanelOption2.GetComponent<Text>().text = SaburaHintConstants.SABURA_EXPOSE_EVENT_DIALOG1_1_3_CHOICE2;
            ChoiceDialogPanelOption3.SetActive(false);
      

        }
        else
        {
            ChoiceDialogPanel.SetActive(false);
            StartCoroutine(SetQuest003());
        }
    }

    IEnumerator SetQuest003()
    {
        SaburaHintEvents.SaburaExposeActive = false;
        Expose.SetActive(false);
        Attack.SetActive(false);
        Quest003Events.Quest003Active = true;
        Questlog.Quest002Finished = true;
        QuestBox2.SetActive(false);
        QuestBoxMother.SetActive(false);
        QuestBox.GetComponent<Text>().text = Quest003Constants.QUEST003_NAME;
        Objective1.GetComponent<Text>().text = Quest003Constants.QUEST003_OBJECTIVE;
        yield return new WaitForSeconds(0.5f);
        QuestBox.SetActive(true);
        InfoPanel.SetActive(true);
        InfoPanelText.GetComponent<Text>().text = SaburaHintConstants.SABURA_EXPOSE_FAILED_TEXT;
        Objective2.SetActive(false);
        Objective3.SetActive(false);
        Objective4.SetActive(false);
        Objective5.SetActive(false);
        Objective6.SetActive(false);
        yield return new WaitForSeconds(2f);
        Objective1.SetActive(true);
        yield return new WaitForSeconds(0.5f);
        Sabura.SetActive(false);
        yield return new WaitForSeconds(6f);
        InfoPanel.SetActive(false);
    }
    IEnumerator SetQuest003SaburaAllied()
    {
        SaburaHintEvents.SaburaExposeActive = false;
        Expose.SetActive(false);
        Attack.SetActive(false);
        Quest003Events.Quest003Active = true;
        Questlog.Quest002Finished = true;
        ChoiceDialogPanel.SetActive(false);
        Cam.SetActive(false);
        Player.SetActive(true);
        QuestBox2.SetActive(false);
        QuestBoxMother.SetActive(false);
        QuestBox.GetComponent<Text>().text = Quest003Constants.QUEST003_NAME;
        Objective1.GetComponent<Text>().text = Quest003Constants.QUEST003_OBJECTIVE_SABURA_ALLIED;
        yield return new WaitForSeconds(0.5f);
        QuestBox.SetActive(true);
        Objective2.SetActive(false);
        Objective3.SetActive(false);
        Objective4.SetActive(false);
        Objective5.SetActive(false);
        Objective6.SetActive(false);
        yield return new WaitForSeconds(2f);
        Objective1.SetActive(true);
        yield return new WaitForSeconds(0.5f);
        Sabura.SetActive(false);
    }

}
