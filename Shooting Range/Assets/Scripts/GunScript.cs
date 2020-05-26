using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunScript : MonoBehaviour
{
    public GameObject bulletPrefab;
    private GameObject bullet;
    private Transform trans;
    private Transform berralTrans;

    // Start is called before the first frame update
    void Start()
    {
        trans = GameObject.Find("Head").transform.Find("Camera");
        Debug.Log(gameObject.transform.parent.name);
        berralTrans = gameObject.transform.Find("Berral");
    }

    // Update is called once per frame
    void Update()
    {
        //trans.Rotate(-sensi * mouseY, 0f, 0f);
        //trans.eulerAngles = new Vector3(trans.parent.eulerAngles.x, trans.parent.eulerAngles.y, 0f);
        Debug.DrawRay(berralTrans.position, trans.forward * 100f,Color.red);
        if (Input.GetMouseButtonDown(0))
        {
            PullTrigger();
        }
    }
    private void PullTrigger()
    {
        Transform trans;
        bullet = Instantiate(bulletPrefab);
        trans = bullet.transform;
        trans.parent = null;
        trans.position = berralTrans.position;
        //Debug.Log(this.trans.parent.transform.Find("Camera").tag);
        trans.forward = this.trans.forward;
        //ridi.velocity = new Vector3(this.trans.forward.x, this.trans.forward.y, this.trans.forward.z) * bulletSpeed;
        //(new Vector3(this.trans.forward.x * bulletSpeed, this.trans.forward.y * bulletSpeed, this.trans.forward.z * bulletSpeed) );
    }
}
