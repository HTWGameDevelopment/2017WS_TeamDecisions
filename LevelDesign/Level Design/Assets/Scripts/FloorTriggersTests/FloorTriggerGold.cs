using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloorTriggerGold : MonoBehaviour {


    public bool goldLost;
    public float loseGold = 1;

    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Player")
            other.SendMessage((goldLost) ? "LoseGold" : "GainGold", Time.deltaTime * loseGold);
    }
}



