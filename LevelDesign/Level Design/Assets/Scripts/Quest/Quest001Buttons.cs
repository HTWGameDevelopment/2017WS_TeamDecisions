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
    public GameObject DialogPanel;
    public GameObject DialogPanel2;
    public GameObject DialogPanel2Text;
    public GameObject InfoPanel;
    public GameObject InfoPanelText;



    public void TakeOption1()
    {
        DialogPanel.SetActive(false);
        DialogPanel2Text.GetComponent<Text>().text = "No adult wants to listen to long storytelling, so I will keep it short. This world Sekia consists of multiple parts from different" +
            " worlds which were tore apart. You still remember Enem, right? You don´t? Its the power you need to cast magic and perform certain actions. But be careful, once you are out "
        + "of Enem you will slowly but surely die until you got a bit of Enem back";
        DialogPanel2.SetActive(true);   
    }
       

    public void TakeOption2()
    {
        Player.SetActive(true);
        Cam.SetActive(false);
        UIQuest.SetActive(false);
        StartCoroutine(SetQuestUI());
        DialogPanel.SetActive(false);
        DialogPanel2Text.GetComponent<Text>().text = "Keep walking on the path until you reach the river and then cross it. Turn to the left and you should see a way leading to the ancient tree" +
            " on the mountains. Nobody knows how this tree grew there. Inspect it. Maybe there is some special meaning to it. Keep in mind that your physical body is different from the average" +
            " human. You should be able to use your strong body for your advantage";
        DialogPanel2.SetActive(true);
        if(Input.GetButtonDown("FinishDialog"))
        {
            Player.SetActive(true);
            Cam.SetActive(false);
            UIQuest.SetActive(false);
        }
        StartCoroutine(FinishDialog());
    }


    public void TakeOption3()
    {
        Player.SetActive(true);
        Cam.SetActive(false);
        UIQuest.SetActive(false);
    }

    IEnumerator SetQuestUI()
    {
        InfoPanelText.GetComponent<Text>().text = "This is your first quest! You can see all the objectives of the quest on the top right corner of the screen. Complete them in the order they are listed";
        InfoPanel.SetActive(true);
        QuestBox.GetComponent<Text>().text = "Learning the basics";
        Objective1.GetComponent<Text>().text = "- Reach the river[ ]";
        Objective2.GetComponent<Text>().text = "- Cross the river[ ]";
        Objective3.GetComponent<Text>().text = "- Check the tree[ ]";
        DialogManager.DialogNumber = 1;
        yield return new WaitForSeconds(0.5f);
        QuestBox.SetActive(true);
        Objective4.SetActive(false);
        Objective5.SetActive(false);
        yield return new WaitForSeconds(1);
        Objective1.SetActive(true);
        yield return new WaitForSeconds(0.5f);
        Objective2.SetActive(true);
        yield return new WaitForSeconds(0.5f);
        Objective3.SetActive(true);
        yield return new WaitForSeconds(9);
        InfoPanel.SetActive(false);
     


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
        }
    }

}
