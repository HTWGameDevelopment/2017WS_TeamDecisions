﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Merchant2Interaction : MonoBehaviour {

    public float Distance;
    public GameObject Display;
    public GameObject ObjectiveText1;
    public GameObject Player;

    void Update()
    {
        Distance = PlayerCasting.DistanceFromTarget;


    }

    void OnMouseOver()
    {
        if (Distance <= 3 && Quest002Events.Quest002Active == true)
        {
            Display.SetActive(true);
        }
        if (Input.GetButtonDown("Interaction"))
        {
            if (Distance <= 3)
            {
                ObjectiveText1.GetComponent<Text>().text = Quest002DialogConstants.QUEST002_OBJECTIVE4FINISHED;
                Quest002Events.Quest002Part2Bought = true;
            }
        }
    }

    private void OnMouseExit()
    {
        Display.SetActive(false);
    }
}
