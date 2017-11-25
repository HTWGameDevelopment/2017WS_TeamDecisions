using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogManager : MonoBehaviour {

    public static int DialogNumber;
    public int InternelDialogNumber;


     void Update()
    {
        InternelDialogNumber = DialogNumber;
    }
}
