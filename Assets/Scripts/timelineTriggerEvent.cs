using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class timelineTriggerEvent : MonoBehaviour
{
    public PlayableDirector timeline;
    public Camera cam1;
    public Camera cam2;
    public Camera characterCam;
    // Start is called before the first frame update
    void Start()
    {
 cam2.enabled = false;
 cam1.enabled = false;
 characterCam.enabled = true;
        timeline = GetComponent<PlayableDirector>();
         //cam1 = GetComponent<Camera>();
         //cam2 = GetComponent<Camera>();
        // characterCam = GetComponent<Camera>();
    }

    // Update is called once per frame
// void OnTriggerEnter(Collider other) {

//  if (other.gameObject.tag == "Player")
//         {
// cam1.enabled = true;
//  cam2.enabled = true;
//  characterCam.enabled = false;
//           //  timeline.Play();
//         }else{
// timeline.Stop();

//         }
//   }
}
