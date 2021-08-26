using System;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;

[Serializable]
public class TimeMachineBehaviour : PlayableBehaviour
{
    public TimeMachineAction action;
    public Condition condition;
    public string markerToJumpTo, markerLabel;
    public float timeToJumpTo;
    //public Platoon platoon;
    public jump Useraction;

    public bool nextscenevfx = false;



    [HideInInspector]
    public bool clipExecuted = false; //the user shouldn't author this, the Mixer does

    public bool ConditionMet()
    {

        //     switch (condition)
        //     {
        //         // case Condition.Always:
        //         //     return true;

        //         // case Condition.PlatoonIsAlive:
        //         //     //The Timeline will jump to the label or time if a specific Platoon still has at least 1 unit alive
        //         //     if (platoon != null)
        //         //     {
        //         //         return !platoon.CheckIfAllDead();
        //         //     }
        //         //     else
        //         //     {
        //         //         return false;
        //         //     }

        //         // case Condition.Never:
        //         // default:
        // return false;
        // }

        switch (condition)
        {

            case Condition.Userdidsomething:
                //The Timeline will jump to the label or time if
                if (Useraction != null)
                {


                    Debug.Log("INSIDE If USER ACTION");
                    Debug.Log("INSIDE If USER ACTION  " + Useraction.checkuserchoice());

                    return Useraction.checkuserchoice();
                }
                else
                {
                    Debug.Log("INSIDE. USER ACTION function is false");
                    Debug.Log(Useraction);
                    return false;
                }

            case Condition.Never:
            default:
                return false;

            case Condition.nextscene:
                // nextscenevfx = true;
                Useraction.changeVFXstatus();
                return true;
        }
    }



    public enum TimeMachineAction
    {
        Marker,
        JumpToTime,
        JumpToMarker,
        Pause,
    }

    public enum Condition
    {
        // Always,
        Never,
        // PlatoonIsAlive,
        Userdidsomething,
        nextscene,
    }
}
