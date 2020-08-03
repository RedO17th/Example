using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.EventSystems;
using UnityEngine.UI;

public class PickUpButton : MonoBehaviour//, IPointerClickHandler
{
    private Image pickUp;

    void Start()
    {
        pickUp = GetComponent<Image>();
    }
    void OnMouseOver()
    {
        pickUp.color = Color.green;
    }
    void OnMouseExit()
    {
        pickUp.color = new Color32(0, 129, 255, 255);
    }
    //public void OnPointerClick(PointerEventData eventData)
    //{
    //    Debug.Log("click");
    //}
}