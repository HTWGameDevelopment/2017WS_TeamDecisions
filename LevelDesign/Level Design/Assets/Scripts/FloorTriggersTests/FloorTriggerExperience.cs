using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloorTriggerExperience : MonoBehaviour {


    public bool experienceGain;
    public float gainExperience =30;

    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Player")
        other.SendMessage("GainExperience", 10);
      
    }
}
