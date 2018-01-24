using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuestSaveKid : MonoBehaviour
{
    public GameObject Display;
    public GameObject Player;
    public GameObject Kid;
    public GameObject Mother;
    public float Distance;
    public static Boolean QuestSaveKidActive = false;
    public static Boolean KidSaved = false;
    public GameObject Quest002Panel;
    public GameObject QuestSaveKidPanel;
    public GameObject ObjectiveText2;
    public GameObject DialogPanel;
    public GameObject DialogPanelText;
    public GameObject Character;


    // Use this for initialization
    void Start()
    {

    }

   void Awake()
    {
        Character = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        Distance = PlayerCasting.DistanceFromTarget;

    }
    void OnMouseOver()
    {
        if (Distance <= 2)
        {
            if (QuestSaveKidActive == true && KidSaved == false)
            {
                Display.SetActive(true);
            }
            if (Input.GetButtonDown("Interaction"))
            {
                if (Distance <= 2)
                {
                    ObjectiveText2.GetComponent<Text>().text = Quest002DialogConstants.QUEST002_MOTHER_OBJECTIVE2FINISHED;
                    Character.SendMessage("GainExperience", 100F);
                    Quest002Panel.SetActive(true);
                    QuestSaveKidActive = false;
                    Quest002Events.Quest002Active = true;
                    KidSaved = true;
                    QuestSaveKidPanel.SetActive(false);
                    Quest002Panel.SetActive(true);
                    Kid.SetActive(false);
                    Questlog.QuestSaveKid = true;
                    StartCoroutine(QuestSaveKidFinished());
                }
            }
        }
    }
    IEnumerator QuestSaveKidFinished()
    {
      
        DialogPanel.SetActive(true);
        DialogPanelText.GetComponent<Text>().text = Quest002DialogConstants.QUEST002_MOTHER_KIDDIALOG;
        DialogPanelText.SetActive(true);
        Mother.SetActive(false);
        yield return new WaitForSeconds(10);
        DialogPanel.SetActive(false);
        DialogPanelText.SetActive(false);

    }
    private void OnMouseExit()
    {
        Display.SetActive(false);
    }
}