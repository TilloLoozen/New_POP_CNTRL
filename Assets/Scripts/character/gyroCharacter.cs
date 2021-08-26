using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gyroCharacter : MonoBehaviour
{
 private bool gyroEnabled;
 private Gyroscope gyro;

 private GameObject cameraContainer;
 private Quaternion rot;

 private void Start()
 {
    // Debug.Log("START GYROSCOPE");
  cameraContainer = new GameObject ("Camera Container");
  cameraContainer.transform.position = transform.position;
  transform.SetParent (cameraContainer.transform);

  gyroEnabled = EnableGyro ();
 }

 private bool EnableGyro()
 {
  if (SystemInfo.supportsGyroscope) 
  {
     //  Debug.Log("THERE IS A GYROSCOPE");
    //  Input.gyro.enabled = false;
   gyro = Input.gyro;
   
   gyro.enabled = true;

   cameraContainer.transform.rotation = Quaternion.Euler (90f, 90f, 0f);
   rot = new Quaternion (0, 0, 1, 0);

   return true;
  }
//  Debug.Log("NO GYROSCOPE");
  return false;
 }
 private void Update()
 {
  if (gyroEnabled)
  {
       //Debug.Log("UPDATINg TRANSFORM");
      // Debug.Log(gyro.attitude * rot + " rot");
       //Debug.Log(transform.localRotation + " local");
   transform.localRotation = gyro.attitude * rot;
  }
 }
}