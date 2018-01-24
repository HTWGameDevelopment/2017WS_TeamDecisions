using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Sabura2Interaction : MonoBehaviour {

    public float Distance;
    public GameObject Display;
    public GameObject DialogPanelText;
    public GameObject Player;
    public GameObject Cam;
    public GameObject DialogPanel;
    public GameObject DialogPanel2;
    public GameObject DialogPanel2Text;
    private GameObject Character;
    public GameObject FillerDialogPanel;
    public GameObject FillerDialogText;

    void Update()
    {
        Distance = PlayerCasting.DistanceFromTarget;
        Character = GameObject.FindGameObjectWithTag("Player");

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
                if (Quest002Events.Quest002Active == true && Quest002Events.Quest002RiverReached == true && Quest002Events.Quest002KiashiReached == true && Quest002Events.Quest002Part1Bought == true && Quest002Events.Quest002Part2Bought == true && Quest002Events.Quest002Part3Found == true && Quest002Events.Quest002ForestReached == true && Questlog.Quest002Finished == false)
                {
                    SetDialogPanel2Text(Quest002DialogConstants.QUEST002_MAINQUEST_FINISHED);
                    //PlayerGainExp();
                    UIBars.upExp(100F);
                    Questlog.Quest002Finished = true;
                }
                else
                {
                    SetDialogPanel2Text(Quest001DialogConstants.QUEST001_DIALOGTEXT_QUEST_UNFINISHED);
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
        DialogPanel.SetActive(false);
        Display.SetActive(false);
        Player.SetActive(false);
        Cam.SetActive(true);
        DialogPanel2.SetActive(true);
        DialogPanel2Text.GetComponent<Text>().text = DialogText;
        DialogPanel2Text.SetActive(true);
    }

    private void PlayerGainExp()
    {
        // Character.SendMessage("GainExperience", 100F);
    }
    
 

}


