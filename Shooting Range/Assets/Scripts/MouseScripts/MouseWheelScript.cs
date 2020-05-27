using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseWheelScript : MonoBehaviour
{
    private Camera cam;
    private float zoomSpeed = 10f;
    private float zoom;
    // Start is called before the first frame update
    void Start()
    {
        zoom = 30f;
        cam = GameObject.Find("Head").transform.Find("Camera").gameObject.GetComponent<Camera>();
    }

    // Update is called once per frame
    void Update()
    {
        float wheel = Input.GetAxis("Mouse ScrollWheel");
        //Debug.Log(cam.fieldOfView);
        if (GameObject.Find("Canvas").transform.Find("ScopeAim").gameObject.activeSelf)
        {
            zoom -= wheel * zoomSpeed;
            cam.GetComponent<Camera>().fieldOfView -= wheel * zoomSpeed;
            if (cam.fieldOfView > 60 || cam.fieldOfView < 1)
            {
                zoom += wheel * zoomSpeed;
            }
            cam.GetComponent<Camera>().fieldOfView = zoom;
        }
        else
        {
            cam.GetComponent<Camera>().fieldOfView = 60f;
        }
    }
}
