using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseViewScript : MonoBehaviour
{
    private float difSensi = 1.5f;
    private float difFOV = 60f;
    private Transform trans;
    private Transform bodyTrans;
    private Transform headTrans;
    private Camera cam;
    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        //Cursor.visible = false;
        trans = gameObject.transform;
        headTrans = GameObject.Find("Head").transform;
        bodyTrans = GameObject.Find("Body").transform;
        cam = headTrans.Find("Camera").GetComponent<Camera>();
        //gunTrans = trans.Find("Gun").transform;
    }

    // Update is called once per frame
    void Update()
    {
        float sensi = (difSensi / difFOV) * cam.fieldOfView;
        float mouseX = (float)Input.GetAxis("Mouse X");
        float mouseY = (float)Input.GetAxis("Mouse Y");

        /*trans.Rotate(-sensi * mouseY, 0f, 0f);
        trans.eulerAngles = new Vector3(trans.eulerAngles.x, trans.eulerAngles.y, 0f);*/

        //gunTrans.Rotate(-sensi * mouseY, 0f, 0f);
        //gunTrans.eulerAngles = trans.eulerAngles;

        /*parentTrans.Rotate(0f, sensi * mouseX, 0f);
        parentTrans.eulerAngles = new Vector3(0f, parentTrans.eulerAngles.y, 0f);*/

        headTrans.Rotate(-sensi * mouseY, sensi * mouseX, 0f);
        headTrans.eulerAngles = new Vector3(headTrans.eulerAngles.x, headTrans.eulerAngles.y, 0f);

        bodyTrans.Rotate(0f, sensi * mouseX, 0f);
        bodyTrans.eulerAngles = new Vector3(0f, bodyTrans.eulerAngles.y, 0f);

        //trans.position = new Vector3(parentTrans.position.x, parentTrans.position.y+1.3f, parentTrans.position.z);
    }
}
