using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLook : MonoBehaviour
{
    
    float rotationSpeed = 3.0f;
    public enum RotationAxes {
        MouseXAndY = 0,
        MouseX = 1,
        MouseY = 2
    }
    public RotationAxes axes = RotationAxes.MouseXAndY;
    private float sensitivityHor = 9.0f;
    private float sensitivityVert = 9.0f;
    private float minVert = -45.0f;
    private float maxVert = 45.0f;

    private float _rotationX = 0;

    private bool checkRotate = true;
    public bool CheckRotate
    {
        get { return checkRotate; }
        set { checkRotate = value; }
    }

    void Start() {
        
        Rigidbody body = GetComponent<Rigidbody>();
        if (body != null)
            body.freezeRotation = true;
    }
    
    void Update()
    {
        if (checkRotate)
        {
            if (axes == RotationAxes.MouseX)
            {
                transform.Rotate(0, Input.GetAxis("Mouse X") * sensitivityHor, 0);
            }
            else if (axes == RotationAxes.MouseY)
            {
                _rotationX -= Input.GetAxis("Mouse Y") * sensitivityVert;
                _rotationX = Mathf.Clamp(_rotationX, minVert, maxVert);

                float rotationY = transform.localEulerAngles.y;
                transform.localEulerAngles = new Vector3(_rotationX, rotationY, 0);
            }
            else
            {
                _rotationX -= Input.GetAxis("Mouse Y") * sensitivityVert;
                _rotationX = Mathf.Clamp(_rotationX, minVert, maxVert);

                float delta = Input.GetAxis("Mouse X") * sensitivityHor;
                float rotationY = transform.localEulerAngles.y + delta;

                transform.localEulerAngles = new Vector3(_rotationX, rotationY, 0);
            }
        }
     }

    //public void LookObject(Vector3 target)
    //{
    //    var look = Quaternion.LookRotation(transform.position);
    //    transform.rotation = Quaternion.Lerp(transform.rotation, look, Time.deltaTime * rotationSpeed);
    //}
}
