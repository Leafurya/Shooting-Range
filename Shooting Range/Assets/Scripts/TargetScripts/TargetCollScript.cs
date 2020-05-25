using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetCollScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnCollisionEnter(Collision collision)
    {
        //Debug.Log(collision.gameObject.name);
        if (collision.gameObject.tag == "bullet")
        {
            Debug.Log(collision.gameObject.name);
            gameObject.transform.parent.gameObject.GetComponent<TargetScript>().setStandTarget(false);
            Destroy(collision.gameObject);
        }
    }
    /*public void OnTriggerEnter(Collider collision)
    {
        Debug.Log("hit");
        if (collision.gameObject.tag == "bullet")
        {
            gameObject.transform.parent.gameObject.SendMessage("setStandTarget", false);
        }
    }*/
}
