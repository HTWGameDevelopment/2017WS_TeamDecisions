using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PeasantMotherInteraction : MonoBehaviour {
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
    public GameObject SaburaCam;
    public GameObject Clue1Cam;
    public GameObject Clue2Cam;

    void Update()
    {
        Distance = PlayerCasting.DistanceFromTarget;
        if (Input.GetButtonDown("Exit"))
        {
            Player.SetActive(true);
            Cam.SetActive(false);
            DialogPanel.SetActive(false);
            DialogPanel2.SetActive(false);

        }

    }

    void Awake()
    {
        Player = GameObject.FindGameObjectWithTag("Player");

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
                SetDialogPanelText(Quest002DialogConstants.QUEST002_PEASANT_MOTHER_INTRO);
            }
        }
    }
    private void OnMouseExit()
    {
        Display.SetActive(false);
    }
    private void SetDialogPanelText(string DialogText)
    {
        SaburaCam.SetActive(false);
        Clue1Cam.SetActive(false);
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
        SaburaCam.SetActive(false);
        Clue1Cam.SetActive(false);
        Clue2Cam.SetActive(false);
        DialogPanel.SetActive(false);
        Display.SetActive(false);
        Player.SetActive(false);
        Cam.SetActive(true);
        DialogPanel2.SetActive(true);
        DialogPanel2Text.GetComponent<Text>().text = DialogText;
        DialogPanel2Text.SetActive(true);
   
    }
}
