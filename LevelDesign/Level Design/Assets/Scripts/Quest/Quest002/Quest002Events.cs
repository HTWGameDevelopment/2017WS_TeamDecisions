using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Quest002Events : MonoBehaviour {

    public static Boolean Quest002Taken = false;
    public static Boolean Quest002Done = false;
    public static Boolean Quest002Active = false;
    public static Boolean Quest002Part1Bought = false;
    public static Boolean Quest002Part2Bought = false;
    public static Boolean Quest002Part3Found = false;
    public static Boolean Quest002KiashiReached = false;
    public static Boolean Quest002RiverReached = false;
    public static Boolean Quest002ForestReached = false;
    public  Boolean DebugQuest002Taken = false;
    public  Boolean DebugQuest002Done = false;
    public  Boolean DebugQuest002Active = false;
    public  Boolean DebugQuest002Part1Bought = false;
    public  Boolean DebugQuest002Part2Bought = false;
    public  Boolean DebugQuest002Part3Found = false;
    public  Boolean DebugQuest002KiashiReached = false;
    public  Boolean DebugQuest002RiverReached = false;
    public  Boolean DebugQuest002ForestReached = false;


    private void Update()
    {
    DebugQuest002Taken = Quest002Taken;
    DebugQuest002Done = Quest002Done;
    DebugQuest002Active = Quest002Active;
    DebugQuest002Part1Bought = Quest002Part1Bought;
    DebugQuest002Part2Bought = Quest002Part2Bought;
    DebugQuest002Part3Found = Quest002Part3Found;
    DebugQuest002KiashiReached = Quest002KiashiReached;
    DebugQuest002RiverReached = Quest002RiverReached;
    DebugQuest002ForestReached = Quest002ForestReached;
}


}
