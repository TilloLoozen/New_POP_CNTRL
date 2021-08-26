using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camerachange : MonoBehaviour
{
    // Start is called before the first frame update public class RampTriggerVolume : MonoBehaviour {
     public Camera normalCamera;
     public Camera rampCamera;
 
     public void OnTriggerEnter(Collider other) {
         //When the player gets close enough (into this trigger's volume)
         //then we turn on the ramp Camera and temporarily turn off the normal one
         if (other.gameObject.tag == "Player") {
             SwitchToRampCamera();
         }
     }
 
     public void OnTriggerExit(Collider other) {
         if (other.gameObject.tag == "Player") {
             SwitchToNormalCamera();
         }
     }
 
     private void SwitchToRampCamera() {
         rampCamera.enabled = true;
         normalCamera.enabled = false;
     }
 
     private void SwitchToNormalCamera() {
         rampCamera.enabled = false;
         normalCamera.enabled = true;
     }

}
