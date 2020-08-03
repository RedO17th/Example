using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickOnMe : MonoBehaviour
{
    private bool tapOnButton { get; set; } = false;
    private string name;
    private Transform parent;

    void Start()
    {
        name = GetComponent<Transform>().name;
        parent = transform.parent.transform.parent;
    }
    public string Name
    {
        get { return name; }
    }
    public Transform Parent
    {
        get { return parent; }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
