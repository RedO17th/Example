using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.EventSystems;
using UnityEngine.UI;

public class RayShooter : MonoBehaviour
{
    private Camera _camera;
    private bool checkCube = false;
    private bool checkSphere = false;
    private bool checkCylinder = false;

    private Rotation cubeObj;
    private Rotation SphereObj;
    private Rotation CylinderObj;

    private bool checkWorkMenu = true;

    MouseLook mLookCam;
    MouseLook mLookBody;

    void Start()
    {
        _camera = gameObject.GetComponent<Camera>();
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        mLookCam = GetComponent<MouseLook>();
        mLookBody = transform.parent.transform.GetComponent<MouseLook>();
    }

    void OnGUI()
    {
        int size = 12;
        float posX = _camera.pixelWidth / 2 - size / 4;
        float posY = _camera.pixelHeight / 2 - size / 2;
        GUI.Label(new Rect(posX, posY, size, size), "*");
    }

    void Update()
    {
        if (checkWorkMenu)
        {
            if (Input.GetMouseButtonDown(0))
            {
                Vector3 point = new Vector3(_camera.pixelWidth / 2, _camera.pixelHeight / 2, 0);
                Ray ray = _camera.ScreenPointToRay(point);
                if (Physics.Raycast(ray, out RaycastHit hit))
                {
                    if (hit.transform.GetComponent<ClickOnMe>())
                    {
                        GetChild parentObj = hit.transform.GetComponent<ClickOnMe>().Parent.GetComponent<GetChild>();
                        if (parentObj)
                        {
                            if (hit.transform.GetComponent<ClickOnMe>().Name == parentObj.cCube.name)
                            {
                                //Debug.Log("Это точно кубик");
                                checkCube = true;
                                cubeObj = transform.GetChild(0).GetComponent<Rotation>();
                                cubeObj.EnableObj();
                            }
                            if (hit.transform.GetComponent<ClickOnMe>().Name == parentObj.cSph.name)
                            {
                                //Debug.Log("Это точно сфера");
                                checkSphere = true;
                                SphereObj = transform.GetChild(1).GetComponent<Rotation>();
                                SphereObj.EnableObj();

                            }
                            if (hit.transform.GetComponent<ClickOnMe>().Name == parentObj.cCyl.name)
                            {
                                //Debug.Log("Это точно цилиндр");
                                checkCylinder = true;
                                CylinderObj = transform.GetChild(2).GetComponent<Rotation>();
                                CylinderObj.EnableObj();
                            }
                            checkWorkMenu = false;
                            parentObj.transform.parent.GetComponent<TurnOnOfMenu>().TurnOff();
                            StaticTransform();
                        }
                    }
                }
            }
        }
        if (!checkWorkMenu)
        {
            if (checkCube)
            {
                cubeObj.RotationObj(Input.GetAxis("Mouse X"), Input.GetAxis("Mouse Y"));
            }
            if (checkSphere)
            {
                SphereObj.RotationObj(Input.GetAxis("Mouse X"), Input.GetAxis("Mouse Y"));
            }
            if (checkCylinder)
            {
                CylinderObj.RotationObj(Input.GetAxis("Mouse X"), Input.GetAxis("Mouse Y"));
            }
            if (Input.GetMouseButtonDown(1))
            {
                if (checkCube)
                    cubeObj.DisableObj();
                if (checkSphere)
                    SphereObj.DisableObj();
                if (checkCylinder)
                    CylinderObj.DisableObj();
                StaticTransform();
                checkCube = false;
                checkSphere = false;
                checkCylinder = false;
                checkWorkMenu = true;
            }
        }
    }
    void StaticTransform()
    {
        mLookCam.CheckRotate = !mLookCam.CheckRotate;
        mLookBody.CheckRotate = !mLookBody.CheckRotate;
    }
}