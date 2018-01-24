using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogInteraction : MonoBehaviour
{

    public float Distance;
    public GameObject Display;
    public GameObject DialogPanelText;
    public GameObject Player;
    public GameObject Cam;
    public GameObject DialogPanel;
    public GameObject DialogPanel2;
    public GameObject DialogPanel2Text;
    public GameObject DialogOption1;
    public GameObject DialogOption1Text;
    public GameObject DialogOption2;
    public GameObject DialogOption2Text;
    public GameObject DialogOption3;
    public GameObject DialogOption3Text;
    private GameObject Character;
    public GameObject FillerDialogPanel;
    public GameObject FillerDialogText;


    // Update is called once per frame
    void Update()
    {
        Distance = PlayerCasting.DistanceFromTarget;


    }

    void Awake()
    {
        Character = GameObject.FindGameObjectWithTag("Player");

    }
    void OnMouseOver()
    {
        if (Distance <= 3)
        {
            Display.SetActive(true);
        }
        if (Input.GetButtonDown("Interaction"))
        {
            if (Distance <= 3)
            {
                if (Quest001Events.QuestTaken == false && Quest001Events.FinishedDecision001 == false)
                {

                    SetDialogPanelText(Quest001DialogConstants.QUEST001_DIALOGTEXT1);

                }

                else if (Quest001Events.QuestTaken == true && Quest001Events.FinishedDecision001 == false)
                {
                    if (Quest001Events.SwordTaken == true && Quest001Events.RiverCrossed == true && Quest001Events.RiverReached == true && Quest001Events.TreeInspected == true && Quest001Events.FinishedDecision001 == false)
                    {
                        Character.SendMessage("GainExperience", 100F);
                        FinishQuest001Decision();

                    }

                    else
                    {
                        if (Input.GetButtonDown("Exit"))
                        {
                            SetDialogFillerText(Quest001DialogConstants.QUEST001_DIALOGTEXT_QUEST_UNFINISHED);
                            Player.SetActive(true);
                            Cam.SetActive(false);
                            FillerDialogPanel.SetActive(false);
                        }
                    }

                }

            }
        }
    }
    private void OnMouseExit()
    {
        Display.SetActive(false);
    }



    private void SetDialogPanelText(string DialogText)
    {
        Screen.lockCursor = false;
        Cursor.visible = true;
        Display.SetActive(false);
        Cam.SetActive(true);
        Player.SetActive(false);
        DialogPanel.SetActive(true);
        DialogPanelText.GetComponent<Text>().text = DialogText;
    }

    private void SetDialogPanel2Text(string DialogText)
    {
        Screen.lockCursor = false;
        Cursor.visible = true;
        DialogPanel.SetActive(false);
        Display.SetActive(false);
        Cam.SetActive(true);
        Player.SetActive(false);
        DialogPanel2.SetActive(true);
        DialogPanel2Text.GetComponent<Text>().text = DialogText;
        DialogPanel2Text.SetActive(true);
    }

    private void FinishQuest001Decision()
    {
        Screen.lockCursor = false;
        Cursor.visible = true;
        Display.SetActive(false);
        Cam.SetActive(true);
        Player.SetActive(false);
        DialogPanel2.SetActive(false);
        DialogPanel.SetActive(true);
        DialogPanelText.GetComponent<Text>().text = Quest001DialogConstants.QUEST001_FINISHED;
        DialogOption1.SetActive(true);
        DialogOption1Text.GetComponent<Text>().text = Quest001DialogConstants.QUEST001_FINISHED_GIVE_SWORD;
        DialogOption2.SetActive(true);
        DialogOption2Text.GetComponent<Text>().text = Quest001DialogConstants.QUEST001_FINISHED_KEEP_SWORD;
        DialogOption3.SetActive(false);
        Quest001Events.FinishedDecision001 = true;
    }

    IEnumerator FinishDialog()
    {
        yield return new WaitForSeconds(5);
        DialogPanel2Text.SetActive(false);
        DialogPanel2.SetActive(false);
    }

    private void SetDialogFillerText(string DialogText)
    {
        Screen.lockCursor = false;
        Cursor.visible = true;
        DialogPanel.SetActive(false);
        Display.SetActive(false);
        Cam.SetActive(true);
        Player.SetActive(false);
        DialogPanel.SetActive(false);
        DialogPanel2.SetActive(false);
        FillerDialogText.GetComponent<Text>().text = DialogText;
        FillerDialogPanel.SetActive(true);
    }
}
