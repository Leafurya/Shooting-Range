using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseViewScript : MonoBehaviour
{
    private float sensi = 1.5f;
    private Transform trans;
    private Transform parentTrans;
    // Start is called before the first frame update
    void Start()
    {
        //Cursor.lockState = CursorLockMode.Locked;
        //Cursor.visible = false;
        trans = gameObject.transform;
        parentTrans = GameObject.Find("Body").transform;
    }

    // Update is called once per frame
    void Update()
    {
        float mouseX = (float)Input.GetAxis("Mouse X");
        float mouseY = (float)Input.GetAxis("Mouse Y");

        trans.Rotate(-sensi * mouseY, 0f, 0f);
        trans.eulerAngles = new Vector3(trans.eulerAngles.x, trans.eulerAngles.y, 0f);

        parentTrans.Rotate(0f, sensi * mouseX, 0f);
        parentTrans.eulerAngles = new Vector3(0f, parentTrans.eulerAngles.y, 0f);

        //trans.position = new Vector3(parentTrans.position.x, parentTrans.position.y+1.3f, parentTrans.position.z);
    }
}
