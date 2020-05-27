using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunScript : MonoBehaviour
{
    public GameObject bulletPrefab;
    public float kick = -0.5f;
    private GameObject bullet;
    private Transform camTrans;
    private Transform berralTrans;
    private Transform headTrans;

    // Start is called before the first frame update
    void Start()
    {
        camTrans = GameObject.Find("Head").transform.Find("Camera");
        Debug.Log(gameObject.transform.parent.name);
        berralTrans = gameObject.transform.Find("Berral");
        headTrans = GameObject.Find("Head").transform;
        gameObject.transform.forward = camTrans.forward;
    }

    // Update is called once per frame
    void Update()
    {
        //trans.Rotate(-sensi * mouseY, 0f, 0f);
        //trans.eulerAngles = new Vector3(trans.parent.eulerAngles.x, trans.parent.eulerAngles.y, 0f);
        Debug.DrawRay(berralTrans.position, camTrans.forward * 100f,Color.red);
        /*if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("trigger");
            PullTrigger();
        }*/
    }
    public void PullTrigger()
    {
        Transform trans;
        bullet = Instantiate(bulletPrefab);
        trans = bullet.transform;
        trans.parent = null;
        trans.position = berralTrans.position;
        //Debug.Log(this.trans.parent.transform.Find("Camera").tag);
        trans.forward = this.camTrans.forward;
        headTrans.Rotate(new Vector3(kick, 0f, 0f));
        //slideTrans.localPosition = new Vector3(slideTrans.localPosition.x, slideTrans.localPosition.y, - 0.5f);

        //ridi.velocity = new Vector3(this.trans.forward.x, this.trans.forward.y, this.trans.forward.z) * bulletSpeed;
        //(new Vector3(this.trans.forward.x * bulletSpeed, this.trans.forward.y * bulletSpeed, this.trans.forward.z * bulletSpeed) );
    }
}
