using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorFade : MonoBehaviour
{

    [SerializeField] private bool saveColorOnce = false;
    [SerializeField] private Transform thisObject;
private Material[] myMaterials;

    [SerializeField] private Color startColor;
    [SerializeField] private Color EndColor;

    [SerializeField] private float lerpFadeTime = 0f;

    private void Start()
    {
        startColor = this.transform.GetComponent<Renderer>().material.color;
        thisObject = this.transform;
myMaterials = this.transform.GetComponent<Renderer>().materials;
     Debug.Log(this.myMaterials + " start materials");


    }

    public void Update()
    {

    }

    public void FadeCheck(bool fadingStatus)
    {
        if(fadingStatus == true)
        {
            FadeIn();
        }
        else
        {
            FadeOut();
        }

    }

    private void FadeIn()
    { 
            Debug.Log(this.transform.gameObject.name);
            Debug.Log("FadeIn");

            lerpFadeTime += Time.deltaTime / 3f;

        //    thisObject.GetComponent<Renderer>().material.color = Color.Lerp(startColor, EndColor, lerpFadeTime);

 for (var i = 0; i < thisObject.GetComponent<Renderer>().materials.Length; i++) {
       //  renderer.materials[i].color = Color.red;
         thisObject.GetComponent<Renderer>().materials[i].color = Color.Lerp(startColor, EndColor, lerpFadeTime);
     }


            if(lerpFadeTime >= 1f)
            {
                lerpFadeTime = 1f;
            }
    }

    private void FadeOut()
    {
            Debug.Log(this.transform.gameObject.name);
            Debug.Log("FadeOut");

            lerpFadeTime -= Time.deltaTime / 3f;

          //  thisObject.GetComponent<Renderer>().material.color = Color.Lerp(startColor, EndColor, lerpFadeTime);

 for (var i = 0; i < thisObject.GetComponent<Renderer>().materials.Length; i++) {
       //  renderer.materials[i].color = Color.red;
         thisObject.GetComponent<Renderer>().materials[i].color = Color.Lerp(startColor, EndColor, lerpFadeTime);
     }



            if (lerpFadeTime <= 0f)
            {
                lerpFadeTime = 0f;
            }
    }
}
