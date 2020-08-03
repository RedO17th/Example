using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;

public class EditColor : MonoBehaviour
{
    private Color basicColor = new Color32(78, 165, 235, 255);
    private Color hoverColor = Color.red;
    private Renderer renderer;

    //private UnityEngine.GameObject menuObj;
    //[SerializeField]
    //private UnityEngine.GameObject menuObjPrefab;
    
    void Start()
    {
        //renderer = GetComponent<Renderer>();
        //renderer.material.color = basicColor;

        //menuObj = Instantiate(menuObjPrefab);
        //menuObj.transform.position = new Vector3(3.5f, 4f, -3f);
        //menuObj.gameObject.SetActive(false);
    }

    //void OnMouseEnter()
    //{
    //    renderer.material.color = hoverColor;
    //}
    //void OnMouseExit()
    //{
    //    renderer.material.color = basicColor;
    //}





    //public void OpenMenu()
    //{
    //    menuObj.gameObject.SetActive(true);
    //}
    //public void CloseMenu()
    //{
    //    menuObj.gameObject.SetActive(false);
    //}
    //public Transform ReturnChild()
    //{
    //     return menuObj.transform.GetChild(0);
    //}

}
