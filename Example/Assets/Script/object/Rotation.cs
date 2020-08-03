using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour
{

    float angleVertical;
    float angleHorizontal;
    float mouseSens = 25;

   // Vector3 positionObj;
   // Quaternion rotationObj;
   //float rotationSpeed = 7.0f;

    void Start()
    {
        //positionObj = GetComponent<Transform>().position;
        //rotationObj = GetComponent<Transform>().rotation;
    }

    public void RotationObj(float angleX, float angleY)
    {
        angleHorizontal += angleX * mouseSens;
        angleVertical -= angleY * mouseSens;

        Quaternion rotY = Quaternion.AngleAxis(angleHorizontal, Vector3.up);
        Quaternion rotX = Quaternion.AngleAxis(angleVertical, Vector3.right);

        transform.rotation = rotY * rotX;

    }
    public void EnableObj()
    {
        gameObject.SetActive(true);
    }
    public void DisableObj()
    {
        gameObject.SetActive(false);
    }
    //public void StandartTransform()
    //{
    //        transform.rotation = Quaternion.Lerp(this.transform.rotation, rotationObj, Time.deltaTime * rotationSpeed);
    //        transform.position = positionObj;
    //}
}
