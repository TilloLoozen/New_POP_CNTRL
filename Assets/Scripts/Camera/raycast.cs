using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
public class raycast : MonoBehaviour
{
    private Touch theTouch;
    // Start is called before the first frame updatepublic class MeshDetector : MonoBehaviour, IPointerDownHandler
    void Start()
    {
        addPhysicsRaycaster();
    }

    void addPhysicsRaycaster()
    {
        PhysicsRaycaster physicsRaycaster = GameObject.FindObjectOfType<PhysicsRaycaster>();
        if (physicsRaycaster == null)
        {
             Debug.Log("no raycaster found, adding new one");
            Camera.main.gameObject.AddComponent<PhysicsRaycaster>();
        }
    }
    public void OnPointerDown(PointerEventData eventData)
    {
        Debug.Log("Clicked: OnPointerDown ");
    }
       public void OnPointerClick(PointerEventData eventData)
    {
        Debug.Log("Clicked:OnPointerClick " );
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        Debug.Log("Mouse Enter");
    }

    //Implement Other Events from Method 1
}