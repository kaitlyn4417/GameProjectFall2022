using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class InstantiateDecor : MonoBehaviour
{
    private Vector3 mousePos;
    private Vector3 objectPos;
    public GameObject decor;
    private Camera cameraObj;

    public int ObjNum = 0;


    void Start()
    {
        cameraObj = Camera.main;
    }

    public void OnMouseDown()
    {
        if (ObjNum < 12)
        {
            mousePos = Input.mousePosition;
            mousePos.z = 2;
            objectPos = Camera.main.ScreenToWorldPoint(mousePos);
            Instantiate(decor, objectPos, Quaternion.identity);
            ObjNum++;
        }

    }


}
