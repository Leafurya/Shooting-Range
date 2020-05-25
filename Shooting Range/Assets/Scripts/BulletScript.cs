using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour
{
    private Vector3 firstPos;
    private Transform trans;
    private float range=1000f;
    // Start is called before the first frame update
    void Start()
    {
        trans = gameObject.transform;
        firstPos = trans.position;
    }

    // Update is called once per frame
    void Update()
    {
        float dis = Vector3.Distance(firstPos, trans.position);
        //Debug.Log(dis);
        if (dis > range)
        {
            Destroy(gameObject);
        }
    }
    public void OnCollisionEnter(Collision collision)
    {
        Debug.Log(collision.gameObject.name);
    }
}
