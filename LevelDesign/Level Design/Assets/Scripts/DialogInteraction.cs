using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogInteraction : MonoBehaviour {

    public float Distance;
    public GameObject Display;
    public GameObject Player;
    public GameObject Cam;
    public GameObject DialogPanel;
	
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
                Screen.lockCursor = false;
                Cursor.visible = true;
                Display.SetActive(false);
                Cam.SetActive(true);
                Player.SetActive(false);
                DialogPanel.SetActive(true);
              
            }
        }
    }
    private void OnMouseExit()
    {
        Display.SetActive(false);
    }
   

}
