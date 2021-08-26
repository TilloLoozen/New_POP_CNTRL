using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Playables;

public class animationtriggernocam : MonoBehaviour
{
     public UnityEvent onSpacebar;
    public UnityEvent onReturn;
bool entered = false;

   void OnTriggerEnter(Collider other)
    {
    if(entered == false){

 if (other.gameObject.tag == "Player")
        {
onSpacebar.Invoke();
entered = true;
        }


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
