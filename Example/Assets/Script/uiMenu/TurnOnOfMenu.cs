using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnOnOfMenu : MonoBehaviour
{
    Transform childMenu;
    

    void Start()
    {
        childMenu = transform.GetChild(0);
    }
    void OnTriggerEnter(Collider other)
    {
        childMenu.gameObject.SetActive(true);
    }
    private void OnTriggerExit(Collider other)
    {
        childMenu.gameObject.SetActive(false);
    }
    public void TurnOn()
    {
        childMenu.gameObject.SetActive(true);
    }
    public void TurnOff()
    {
        childMenu.gameObject.SetActive(false);
    }
}
