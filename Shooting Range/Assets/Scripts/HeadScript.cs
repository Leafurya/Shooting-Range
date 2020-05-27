using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeadScript : MonoBehaviour
{
    private Transform trans;
    private Transform bodyTrans;
    private Transform gunTrans;
    // Start is called before the first frame update
    void Start()
    {
        trans = gameObject.transform;
        bodyTrans = GameObject.Find("Body").transform;
        gunTrans = trans.GetChild(1);
    }

    // Update is called once per frame
    void Update()
    {
        trans.position = new Vector3(bodyTrans.position.x, bodyTrans.position.y + 0.4f, bodyTrans.position.z);
        
    }
}
