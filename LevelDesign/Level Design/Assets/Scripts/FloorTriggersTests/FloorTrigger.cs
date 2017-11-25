using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloorTrigger : MonoBehaviour {

    public bool dealsDamage;
    public float damage = 5;

    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Player")
            other.SendMessage((dealsDamage) ? "TakeDamage" : "HealDamage", Time.deltaTime * damage);
    }
}
