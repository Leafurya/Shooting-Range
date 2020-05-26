using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour
{
    private Vector3 firstPos;
    private Transform trans;
    private Rigidbody rigi;
    public float range=1000f;
    public float speed = 50000f;
    // Start is called before the first frame update
    void Start()
    {
        rigi = gameObject.GetComponent<Rigidbody>();
        trans = gameObject.transform;
        firstPos = trans.position;
        rigi.AddForce(trans.forward * speed);
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
        Destroy(gameObject);
    }
    public void Shooting()
    {
        Debug.Log("shoot");
        firstPos = trans.position;
        rigi.AddForce(trans.forward * speed);
    }
}
