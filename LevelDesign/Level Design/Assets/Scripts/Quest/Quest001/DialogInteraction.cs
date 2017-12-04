using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogInteraction : MonoBehaviour {

    public float Distance;
    public GameObject Display;
    public GameObject DialogPanelText;
    public GameObject Player;
    public GameObject Cam;
    public GameObject DialogPanel;
    public GameObject DialogPanel2;
    public GameObject DialogPanel2Text;
   
	
	// Update is called once per frame
	void Update () {
        Distance = PlayerCasting.DistanceFromTarget;

		
	}
   void OnMouseOver()
    {
        if (Distance <= 3)
        {
            Display.SetActive(true);
        }
        if(Input.GetButtonDown("Interaction"))
        {
            if(Distance <=3 )
            {
                if (Quest001Events.QuestTaken == false)
                {

                    SetDialogPanelText(Quest001DialogConstants.QUEST001DIALOGTEXT1);
                 
                }

                else if (Quest001Events.QuestTaken == true)
                {
                    if (Quest001Events.SwordTaken == true && Quest001Events.RiverCrossed == true && Quest001Events.RiverReached == true && Quest001Events.TreeInspected == true)
                    {
                        GameObject player = GameObject.FindWithTag("Player");
                        player.SendMessage("GainExperience", 100F);
                        SetDialogPanel2Text(Quest001DialogConstants.QUEST001DIALOGTEXTQUESTFINISHED);
                       
                    }

                    else
                    {
                        SetDialogPanel2Text(Quest001DialogConstants.QUEST001DIALOGTEXTQUESTUNFINISHED);
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
        DialogPanel.SetActive(false);
        Display.SetActive(false);
        Player.SetActive(false);
        Cam.SetActive(true);
        DialogPanel2.SetActive(true);
        DialogPanel2Text.GetComponent<Text>().text = DialogText;
        DialogPanel2Text.SetActive(true);
        StartCoroutine(FinishDialog());
    }
    IEnumerator FinishDialog()
    {
        yield return new WaitForSeconds(5);
        DialogPanel2Text.SetActive(false);
        DialogPanel2.SetActive(false);
    }
}
