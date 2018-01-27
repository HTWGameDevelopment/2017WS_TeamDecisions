using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Sabura2Interaction : MonoBehaviour {

    public float Distance;
    public GameObject Display;
    public GameObject DisplayAttack;
    public GameObject DisplayExpose;
    public GameObject DialogPanelText;
    public GameObject Player;
    public GameObject Cam;
    public GameObject DialogPanel;
    public GameObject DialogPanel2;
    public GameObject DialogPanel2Text;
    public Boolean AllHintsFound;
    public GameObject FillerDialogPanel;
    public GameObject FillerDialogText;
    public GameObject InfoPanel;
    public GameObject Sabura;
    public GameObject InfoPanelText;

    void Update()
    {
        Distance = PlayerCasting.DistanceFromTarget;

    }

    void Awake()
    {


    }
    void OnMouseOver()
    {
        if (Distance <= 3 && CheckHints() == true && Quest001Events.KeptSword == true)
        {
            Display.SetActive(true);
            DisplayAttack.SetActive(true);
            DisplayExpose.SetActive(true);
            if (Input.GetButtonDown("Interaction"))
            {
                if (Quest002Events.Quest002Active == true && Quest002Events.Quest002RiverReached == true && Quest002Events.Quest002KiashiReached == true && Quest002Events.Quest002Part1Bought == true && Quest002Events.Quest002Part2Bought == true && Quest002Events.Quest002Part3Found == true && Quest002Events.Quest002ForestReached == true && Questlog.Quest002Finished == false)
                {
                    SetDialogPanel2Text(Quest002DialogConstants.QUEST002_MAINQUEST_FINISHED);
                    //PlayerGainExp();
                    UIBars.upExp(100F);
                    Questlog.Quest002Finished = true;
                }
            }
            else if (Input.GetButtonDown("Attack"))
            {
                StartCoroutine(AttackSabura());
            }
            else if (Input.GetButtonDown("Expose"))
            {

            }
            
        }
        else if (Distance <= 3 && CheckHints() == true && Quest001Events.GaveSword == true)
        {
            Display.SetActive(true);
            DisplayExpose.SetActive(true);
            if (Input.GetButtonDown("Interaction"))
            {

                if (Quest002Events.Quest002Active == true && Quest002Events.Quest002RiverReached == true && Quest002Events.Quest002KiashiReached == true && Quest002Events.Quest002Part1Bought == true && Quest002Events.Quest002Part2Bought == true && Quest002Events.Quest002Part3Found == true && Quest002Events.Quest002ForestReached == true && Questlog.Quest002Finished == false)
                {
                    SetDialogPanel2Text(Quest002DialogConstants.QUEST002_MAINQUEST_FINISHED);
                    //PlayerGainExp();
                    UIBars.upExp(100F);
                    Questlog.Quest002Finished = true;
                }
                else if (Input.GetButtonDown("Expose"))
                {

                }
            }
        }
        else if (Distance <= 3)
        {
            Display.SetActive(true);
            if (Input.GetButtonDown("Interaction"))
            {

                if (Quest002Events.Quest002Active == true && Quest002Events.Quest002RiverReached == true && Quest002Events.Quest002KiashiReached == true && Quest002Events.Quest002Part1Bought == true && Quest002Events.Quest002Part2Bought == true && Quest002Events.Quest002Part3Found == true && Quest002Events.Quest002ForestReached == true && Questlog.Quest002Finished == false)
                {
                    SetDialogPanel2Text(Quest002DialogConstants.QUEST002_MAINQUEST_FINISHED);
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
        DisplayAttack.SetActive(false);
        DisplayExpose.SetActive(false);
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

    private Boolean CheckHints()
    {
        if ( SaburaHintEvents.DeviceHintFound == true && SaburaHintEvents.EnemDrainHintFound == true && SaburaHintEvents.PhotoalbumHintFound == true && SaburaHintEvents.MushroomHintFound == true && SaburaHintEvents.RiftHintFound == true)
        {
            AllHintsFound = true;
            return AllHintsFound;
        }
        return AllHintsFound;
    }
    IEnumerator AttackSabura ()
    {
        InfoPanelText.GetComponent<Text>().text = SaburaHintConstants.ATTACK_SABURA;
        InfoPanel.SetActive(true);
        Sabura.SetActive(false);
        Display.SetActive(false);
        DisplayAttack.SetActive(false);
        DisplayExpose.SetActive(false);
        SaburaHintEvents.SaburaAttacked = true;
        yield return new WaitForSeconds(8.0f);
        InfoPanel.SetActive(false);

    }

    
 

}


