using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseClickScript : MonoBehaviour
{
    private Transform headTrans;
    private Transform gunTrans;
    // Start is called before the first frame update
    void Start()
    {
        headTrans = GameObject.Find("Head").transform;
        gunTrans = headTrans.GetChild(1);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            gunTrans.GetComponent<GunScript>().PullTrigger();
        }
        if (Input.GetMouseButton(1))
        {
            gunTrans.localPosition = new Vector3(0f, gunTrans.localPosition.y, gunTrans.localPosition.z);
            if (gunTrans.tag == "sniper rifle")
            {
                gunTrans.gameObject.SetActive(false);
                GameObject.Find("Canvas").transform.Find("ScopeAim").gameObject.SetActive(true);
                GameObject.Find("Canvas").transform.Find("Aim").gameObject.SetActive(false);
            }
            else if (gunTrans.tag == "hand gun")
            {
                GameObject.Find("Canvas").transform.Find("Aim").gameObject.SetActive(false);
            }
        }
        else
        {
            gunTrans.localPosition = new Vector3(1f, gunTrans.localPosition.y, gunTrans.localPosition.z);
            if (gunTrans.tag == "sniper rifle")
            {
                gunTrans.gameObject.SetActive(true);
                GameObject.Find("Canvas").transform.Find("ScopeAim").gameObject.SetActive(false);
                GameObject.Find("Canvas").transform.Find("Aim").gameObject.SetActive(true);
            }
            else if (gunTrans.tag == "hand gun")
            {
                GameObject.Find("Canvas").transform.Find("Aim").gameObject.SetActive(true);
            }
        }
    }
}
