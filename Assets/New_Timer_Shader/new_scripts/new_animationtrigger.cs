using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Playables;

public class new_animationtrigger : MonoBehaviour {

    public UnityEvent onSpacebar;
    public UnityEvent onReturn;
     public Camera cam1;
    public Camera cam2;
    public Camera characterCam;
bool entered = false;

   void OnTriggerEnter(Collider other)
    {
    if(entered == false){

 if (other.gameObject.tag == "Player")
        {
cam1.enabled = true;
 cam2.enabled = true;
 characterCam.enabled = false;
          //  timeline.Play();
        }


onSpacebar.Invoke();
entered = true;
    }    


        // if (Input.GetKeyDown(KeyCode.Space))
        // {
        //     if (onSpacebar != null)
        //     {
        //         onSpacebar.Invoke();
        //     }
        // }

        // if (Input.GetKeyDown(KeyCode.Return))
        // {
        //     if (onReturn != null)
        //     {
        //         onReturn.Invoke();
        //     }
        // }
    }

void OnCollisionEnter(Collision collision){

            // if (onSpacebar != null)
            // {
            //     onSpacebar.Invoke();
            // }
    
}


}
