using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DemoFinishedScreen : MonoBehaviour {

    public GameObject CanvasNormal;
    public GameObject CanvasEndingScreen;
    public GameObject Player;
    public GameObject PlayerCam;

    private void OnTriggerEnter(Collider other)
    {
        if (Quest003Events.Quest003Active == true)
        {
            Player.SetActive(false);
            CanvasNormal.SetActive(false);
            CanvasEndingScreen.SetActive(true);
            StartCoroutine(EndGame());
        }
    }
    IEnumerator EndGame()
    {
        yield return new WaitForSeconds(15);
        Application.Quit();
    }
}
