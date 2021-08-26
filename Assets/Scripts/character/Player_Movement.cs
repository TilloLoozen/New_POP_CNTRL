using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Movement : MonoBehaviour
{
public float moveSpeed = 20;
public Rigidbody theRigBod;
public float rotationRate = 360;

private string moveInputAxis = "Vertical2";
private string turnInputAxis = "Horizontal2";
    // Start is called before the first frame update
    void Start()
    {
        theRigBod = GetComponent<Rigidbody>();
        
    }

    // Update is called once per frame
    void Update()
    {
float moveAxis = UnityEngine.Input.GetAxis(moveInputAxis);
float turnAxis = UnityEngine.Input.GetAxis(turnInputAxis);
ApplyInput(moveAxis,turnAxis);
      //  theRigBod.velocity = new Vector3(UnityEngine.Input.GetAxis("HorizontalUI") * moveSpeed, theRigBod.velocity.y, UnityEngine.Input.GetAxis("VerticalUI") * moveSpeed);
    }

private void ApplyInput(float moveInput, float turnInput){
Move(moveInput);
Turn(turnInput);

}

private void Move(float input){
   // transform.Translate(Vector3.forward * input * moveSpeed);
   theRigBod.AddForce(transform.forward * input * moveSpeed, ForceMode.Force);
}
private void Turn(float input){
    transform.Rotate(0,input * rotationRate * Time.deltaTime, 0);
}


}
