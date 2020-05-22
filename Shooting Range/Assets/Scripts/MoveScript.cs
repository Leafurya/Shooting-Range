using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveScript : MonoBehaviour
{
    private Rigidbody rigi;
    //private Transform cameraTrans;
    private Transform trans;
    private float speed=4.0f;
    private float distance = 10f;
    // Start is called before the first frame update
    void Start()
    {
        rigi = gameObject.GetComponent<Rigidbody>();
        //cameraTrans = gameObject.transform.Find("Main Camera").transform;
        trans = gameObject.transform;
    }

    // Update is called once per frame
    void Update()
    {
        Ray ray;
        RaycastHit hit;
        GameObject hitObj;
        float tdis;
        ray = new Ray(gameObject.transform.position, gameObject.transform.forward * 100f);

        if (Physics.Raycast(ray, out hit))
        {
            hitObj = hit.collider.gameObject;
            //Debug.Log(hit.collider.gameObject.tag);
            if (hitObj.tag == "works")
            {
                tdis = Mathf.Sqrt(Mathf.Pow(hitObj.transform.position.x - trans.position.x, 2) + Mathf.Pow(hitObj.transform.position.z - trans.position.z, 2));
                Debug.Log(tdis);
                if (tdis < distance)
                {
                    Move(false);
                }
                else
                {
                    Move(true);
                }
            }
            else
            {
                Move(true);
            }
        }
        else
        {
            Move(true);
        }
    }
    public void Move(bool move)
    {
        float sxVel = 0f, szVel = 0f;
        float fxVel = 0f, fzVel = 0f;

        //myTrans.forward = new Vector3(cameraTrans.forward.x, 0f, cameraTrans.forward.z);

        if (move){
            float tvec = (Math.Abs(trans.forward.x) + Math.Abs(trans.forward.z)) > 0 ? (Math.Abs(trans.forward.x) + Math.Abs(trans.forward.z)) : 1;

            /*fxVel = trans.forward.x / tvec;
            fzVel = trans.forward.z / tvec;*/
            if (Input.GetKey(KeyCode.W))
            {
                fxVel = trans.forward.x / tvec;
                fzVel = trans.forward.z / tvec;
            }
            else if (Input.GetKey(KeyCode.S))
            {
                fxVel = -trans.forward.x / tvec;
                fzVel = -trans.forward.z / tvec;
            }

            if (Input.GetKey(KeyCode.A))
            {
                sxVel = -trans.forward.z / tvec;
                szVel = trans.forward.x / tvec;
            }
            else if (Input.GetKey(KeyCode.D))
            {
                sxVel = trans.forward.z / tvec;
                szVel = -trans.forward.x / tvec;
            }

            /*if (Input.GetKey(KeyCode.Space))
            {
                yVel = speed;
            }
            else if (Input.GetKey(KeyCode.LeftShift))
            {
                yVel = -speed;
            }*/
            //rigi.velocity = new Vector3((fxVel + sxVel)*speed, yVel, (fzVel + szVel)*speed);
            rigi.velocity = new Vector3((fxVel + sxVel) * speed, rigi.velocity.y, (fzVel + szVel) * speed);
            //Debug.Log(trans.forward);
            //Debug.Log(string.Format("{0} {1}", fxVel, fzVel));
            //rigi.velocity = new Vector3(xVel, yVel, zVel);
            //Debug.Log(rigi.velocity);
            //rigi.velocity = Vector3.zero;
        }
    }
}
