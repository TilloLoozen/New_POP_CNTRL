using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;
using UnityEngine.UI;

public class new_triggerTimeline : MonoBehaviour {

    public List<PlayableDirector> playableDirectors;
    public List<TimelineAsset> timelines;


    public void Play()
    {
        Debug.Log("Timeline Trigger Play"); 
        foreach (PlayableDirector playableDirector in playableDirectors) 
        {
            playableDirector.Play ();
        }
    }

    public void PlayFromTimelines( int index)
    {
       Debug.Log("Timeline Trigger Play From Specific Timeline GO"); 
        TimelineAsset selectedAsset;

        if (timelines.Count <= index) 
        {
            selectedAsset = timelines [timelines.Count - 1];
        } 
        else 
        {
            selectedAsset = timelines [index];
        }
    Debug.Log("GO"); 
        playableDirectors [0].Play (selectedAsset);
    }
}
