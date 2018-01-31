using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClueEnem : MonoBehaviour {

    public GameObject Display;
    public GameObject DialogPanel2Text;
    public GameObject Player;
    public GameObject Cam;
    public GameObject DialogPanel2;
    public float Distance;
    public GameObject DialogPanel;


    void Update()
    {
        Distance = PlayerCasting.DistanceFromTarget;


    }


    void OnMouseOver()
    {
        if (Questlog.Quest001Finished == true &&  Questlog.QuestSaveKid == true)
        {
            if (Distance <= 3)
            {
                Display.SetActive(true);
            }
            if (Input.GetButtonDown("Interaction"))
            {
                if (Distance <= 3)
                {
                    SetDialogPanel2Text(SaburaHintConstants.CLUES_ENEM);
                    SaburaHintEvents.EnemDrainHintFound = true;
                }
            }
        }
    }
    private void OnMouseExit()
    {
        Display.SetActive(false);
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
}
