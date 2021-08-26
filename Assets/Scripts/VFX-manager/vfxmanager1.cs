using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.VFX;

public class vfxmanager1 : MonoBehaviour
{
    public jump UserVFXaction;


    // public jump choicepressed;
    //public bool IsPlaying = true;

    void Start()
    {



        UserVFXaction = GetComponent<jump>();

    }

    void Update()
    {


        // Debug.Log("choice pressed ->  " + choicepressed.choicepressed + "  nextscene pressed -->  " + choicepressed.timevfx);

        // if (choicepressed.choicepressed == true || choicepressed.timevfx == true)
        // {
        //     GetComponent<VisualEffect>().Stop();
        // }
        // else
        // {
        //     GetComponent<VisualEffect>().Play();
        // }



    }


    public void endVFX()
    {
        // UserVFXaction.changeVFXstatus();
        // GetComponent<VisualEffect>().Stop();
        if (UserVFXaction.choicepressed == true)
        {
            //  GameObject.FindGameObjectsWithTag("vfxoptions"); //.GetComponent<VisualEffect>().Stop();
            this.GetComponent<VisualEffect>().Stop();
        }
        else
        {
            GetComponent<VisualEffect>().Play();

        }
    }
    public void DebugSome()
    {
        Debug.Log("INSIDE DEBUG FUNCTION IN SCRIPT");

    }
}



