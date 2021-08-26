using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Playables;
using UnityEngine.UI;
public class onTap : MonoBehaviour
{
    public UnityEvent onSpacebar;
    public UnityEvent onReturn;
    bool entered = false;

    //
    public Text phaseDisplayText;
    private Touch theTouch;
    private float timeTouchEnded;
    private float displayTime = .5f;



    //

    TouchPhase touchPhase = TouchPhase.Ended;
    private void Update()
    {
        Debug.Log("ToucheINPUTCOUNT " + Input.touchCount);
        // Debug.Log("Touche STATUS " + Input.GetTouch(0).phase);

        if (Input.touchCount == 1 && Input.GetTouch(0).phase == touchPhase)
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);
            RaycastHit hit;
            Debug.DrawRay(ray.origin, ray.direction * 100, Color.yellow, 100f);
            Debug.Log("Touched with ray");
            if (Physics.Raycast(ray, out hit))
            {
                Debug.Log(hit.transform.name);
                if (hit.collider != null)
                {

                    GameObject touchedObject = hit.transform.gameObject;

                    Debug.Log("Touched " + touchedObject.transform.name);
                    // if (touchedObject.transform.name == "intro playing w blocks")
                    if (touchedObject.transform.name == "Gate_Small-room1-right")
                    {
                        Debug.Log("BOOM BOOM BOOM I WANT TO STEAL FROM THIS GOON!");
                        //   onSpacebar.Invoke();
                        // entered = true;
                    }
                    if (touchedObject.transform.name == "Gate_Small-room1-left")
                    {
                        Debug.Log("RED RED RED RATHER FRIENDELY THAN DEAD");
                        // onReturn.Invoke();

                        jump tapchoice = gameObject.GetComponent<jump>();
                        tapchoice.OnMouseUp();
                        // entered = true;
                    }
                    // else
                    // {
                    //     Debug.Log("TAP TAP TAP ON THE WILD");
                    //     jump tapchoice = gameObject.GetComponent<jump>();
                    //     tapchoice.OnMouseUp();


                    // }
                }
            }
        }






        // if (Input.touchCount > 0)
        // {
        //     theTouch = Input.GetTouch(0);
        //     phaseDisplayText.text = theTouch.phase.ToString();

        //     // if (theTouch.phase == TouchPhase.Ended)
        //     // {
        //     //     timeTouchEnded = Time.time;
        //     // }
        // }

        // else if (Time.time - timeTouchEnded > displayTime)
        // {
        //     phaseDisplayText.text = "THIS IS THE ELSE STATEMENT";
        // }

        //     else if (Time.time - timeTouchEnded > displayTime)
        // {
        //     phaseDisplayText.text = "THIS IS THE ELSE STATEMENT";
        // }


    }





    void OnTriggerEnter(Collider other)
    {
        //     if(entered == false){

        //  if (other.gameObject.tag == "Player")
        //         {
        // onSpacebar.Invoke();
        // entered = true;
        //         }


        //     }    


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

    void OnCollisionEnter(Collision collision)
    {

        // if (onSpacebar != null)
        // {
        //     onSpacebar.Invoke();
        // }

    }
}
