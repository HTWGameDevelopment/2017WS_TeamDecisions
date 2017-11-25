using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloorTriggerEnem : MonoBehaviour {

    public bool enemLost;
    public float loseEnem = 30;

    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Player")
            other.SendMessage((enemLost) ? "LoseEnem" : "GainEnem", Time.deltaTime * loseEnem);
    }
}
