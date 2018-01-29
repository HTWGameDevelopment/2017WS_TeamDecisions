using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PhotoalbumClue : MonoBehaviour {

    public GameObject Display;
    public GameObject DialogPanel2Text;
    public GameObject Player;
    public GameObject Cam;
    public GameObject DialogPanel2;
    public float Distance;
    

    void Update()
    {
        Distance = PlayerCasting.DistanceFromTarget;


    }


    void OnMouseOver()
    {
        if (Questlog.Quest001Finished == true)
        {
            if (Distance <= 4)
            {
                Display.SetActive(true);
            }
            if (Input.GetButtonDown("Interaction"))
            {
                if (Distance <= 4)
                {
                    SetDialogPanel2Text(SaburaHintConstants.CLUES_PHOTOALBUM);
                    SaburaHintEvents.PhotoalbumHintFound = true;
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

        Display.SetActive(false);
        Player.SetActive(false);
        Cam.SetActive(true);
        DialogPanel2.SetActive(true);
        DialogPanel2Text.GetComponent<Text>().text = DialogText;
        DialogPanel2Text.SetActive(true);

    }
}
