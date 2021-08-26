using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class new_Continious_Raycast : MonoBehaviour
{
    public GameObject nextObject;
    public GameObject currentObject;
    public GameObject previousObject;


    public GameObject lastPreviousObject;
    public GameObject lastObject;

    private bool saveObjectOnce = false;
    private bool isFading = false;
    private bool fadeOnce = false;
    RaycastHit hit;

    Ray ray;
    private float offset = 0.5f;

    public void Start()
    {

    }

    public void Update()
    {

        Transform cameraTransform = Camera.main.transform;

        //if(Physics.Raycast(cameraTransform.position,cameraTransform.forward, out hit, 100.0f))
        Debug.DrawRay(cameraTransform.position, cameraTransform.forward * 100.0f, Color.yellow);

        //RaycastHit hit;
        ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        //   ray = Camera.main.ScreenPointToRay(Camera.main.transform.TransformDirection(Vector3.forward) * 10);

        Vector3 forward = Camera.main.transform.TransformDirection(Vector3.forward) * 10;
        //   Debug.DrawRay(Camera.main.transform.position, forward, Color.red);
        Debug.Log("Touched with ray NEW CONT");
        //if player is looking
        //  if (Physics.Raycast(ray, out hit))
        //if (Physics.Raycast(cameraTransform.position,cameraTransform.forward, out hit, 100.0f))
        if (Physics.BoxCast(cameraTransform.position, transform.localScale, cameraTransform.forward, out hit, transform.rotation, 100.0f))
        {
            var selection = hit.transform;
            Debug.Log(hit.transform.name + "Raycast HIT");
            if (selection.CompareTag("ROBOT") || selection.CompareTag("SPHERE") || selection.CompareTag("CUBE"))
            {
                nextObject = selection.gameObject;
                //if previous and current object are same
                if (GameObject.Equals(nextObject, currentObject))
                {
                    isFading = true;

                    ColorFade fadingColor = currentObject.GetComponent<ColorFade>();
                    fadingColor.FadeCheck(isFading);


                    if (previousObject != null)
                    {
                        isFading = false;
                        ColorFade fadingcolor1 = previousObject.GetComponent<ColorFade>();
                        fadingcolor1.FadeCheck(isFading);
                    }

                    if (GameObject.Equals(currentObject, lastPreviousObject))
                    {
                        lastPreviousObject = null;
                    }
                    else
                    {
                        if (lastPreviousObject != null)
                        {
                            isFading = false;
                            ColorFade fadingcolor = lastPreviousObject.GetComponent<ColorFade>();
                            fadingcolor.FadeCheck(isFading);
                        }
                    }




                }
                //if previous and current object are different
                else
                {
                    lastPreviousObject = previousObject;
                    previousObject = currentObject;
                    currentObject = nextObject;
                }
            }
            //if detects other objects than the items
            else
            {
                isFading = false;
                lastObject = nextObject;
                if (lastObject != null)
                {
                    ColorFade fadingColor = lastObject.GetComponent<ColorFade>();
                    fadingColor.FadeCheck(isFading);
                }
            }
        }
        //if the player is not looking 
        else
        {
            isFading = false;
            lastObject = nextObject;
            if (lastObject != null)
            {
                ColorFade fadingColor = lastObject.GetComponent<ColorFade>();
                fadingColor.FadeCheck(isFading);
            }

        }

    }
}
