using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetChild : MonoBehaviour
{
    Transform childTheCub;
    Transform childTheSp;
    Transform childTheCyl;
    void Start()
    {
        childTheCub = transform.GetChild(0).GetChild(0);
        childTheSp = transform.GetChild(0).GetChild(1);
        childTheCyl = transform.GetChild(0).GetChild(2);
    }

    public Transform cCube
    {
        get { return childTheCub; }
    }
    public Transform cSph
    {
        get { return childTheSp; }
    }
    public Transform cCyl
    {
        get { return childTheCyl; }
    }
    // Update is called once per frame
    void Update()
    {

    }



}
