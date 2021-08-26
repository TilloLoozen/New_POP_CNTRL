using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;
using System.Linq;
using System;
//using UnityEditor.Profiling;
//using Unity.Profiling.LowLevel;
using UnityEngine.VFX;

public class jump : MonoBehaviour
{
    int markerreset = 0;
    int points;
    public int mypoints = 0;
    int myuserchoice;

    public bool choicepressed = false;
    public bool timevfx;
    public GameObject[] vfxspawns;

    // This is to assign ANOTHER timeline (not just to one on this Game Object)
    // b/c This game object is a trigger - someting you mouse up or gaze @ -
    //  that will take you to a specific "Marker"
    // NOTE: the Marker # is not necessarily sequential... Marker # may have to do with the order in which they are created
    public PlayableDirector playableDirector;
    public vfxmanager1 myVFXmanager;
    // public VisualEffect vfx;
    // The # of the Marker you want to go to
    void Start()
    {
        // THIS WOULD GRAB THE TIMELINE ON THIS OBJECT but I rather call a MASTER timeline!
        playableDirector = GetComponent<PlayableDirector>();
        if (vfxspawns.Length < 1)
        {
            vfxspawns = GameObject.FindGameObjectsWithTag("vfx");
        }
        myVFXmanager = GetComponent<vfxmanager1>();
        // timevfx = GetComponent<TimeMachineBehaviour>().nextscenevfx;
    }
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
            Debug.Log("Pressed primary button.");


        if (Input.GetMouseButtonDown(1))
        {
            Debug.Log("Pressed secondary button.");
            //addpoints();
        } // LIST ALL MARKERS
        if (Input.GetMouseButtonDown(2))
        {
            Debug.Log("Pressed middle click.");
            // var instance = new jump();
            //   instance.OnMouseUp();
            // OnMouseUp();
        }
        Debug.Log("INSIDE update want gameobjects" + vfxspawns.Length);
    }
    // public void addpoints()
    // {
    //     mypoints += 1;
    //     Debug.Log("POINTS HAVE BEEN ADDED");
    //     Debug.Log("MY POINTS " + mypoints);


    // }
    public void OnMouseUp()
    {
        // var timelineAsset = playableDirector.playableAsset as TimelineAsset;
        // var markers = timelineAsset.markerTrack.GetMarkers().ToArray();
        // //  var markers = babababa.GetMarkers();
        // Debug.Log(markers);
        // // Debug.Log(markers.Length);
        // foreach (var item in markers)
        // {
        //     double mymarkertime = item.time;
        //     Debug.Log("THIS ITEM IS " + item);
        //     Debug.Log("THIS ITEM HAS TIME " + mymarkertime);
        //     //Useraction = 1;
        Debug.Log("COICE MADE " + myuserchoice);
        myuserchoice += 1;
        Debug.Log("COICE MADE AFTER ADD " + myuserchoice);

        //}



        // var instance = new pointsystem();
        // points = instance.mypoints;

        if (points == markerreset)
        {
            Debug.Log("MY POINTS AND MARKER ARE THE SAME");

        }
        else
        {
            // Debug.Log("MY POINTS AND MARKER ARE DIFFERENT");
            // playableDirector.Play();
            // // playableDirector.time = markers[mypoints].time;
            // playableDirector.time = markers[points].time;
        }




    }



    public bool checkuserchoice()
    {
        if (myuserchoice == 1)
        {
            Debug.Log("CHOICE NUMBER " + myuserchoice);
            //changeVFXstatus();
            choicepressed = true;
            return true;
        }
        else
        {
            Debug.Log("CHOICE NUMBER " + myuserchoice);
            return false;
        }

    }



    public void changeVFXstatus()
    {
        Debug.Log("INSIDE CHANGE VFX STATUS");
        // myVFXmanager = GetComponent<vfxmanager1>();
        // myVFXmanager.DebugSome();
        // myVFXmanager.endVFX();
        foreach (GameObject myvfx in vfxspawns)
        {
            Debug.Log("INSIDE CHANGE VFX STATUS FOR EACH ");
            myvfx.GetComponent<VisualEffect>().Stop();
        }
        choicepressed = true;
    }

}
