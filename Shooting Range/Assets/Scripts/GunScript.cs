using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunScript : MonoBehaviour
{
    public GameObject bulletPrefab;
    private GameObject bullet;
    private float bulletSpeed = 50000f;
    private Transform trans;

    // Start is called before the first frame update
    void Start()
    {
        trans = gameObject.transform;
    }

    // Update is called once per frame
    void Update()
    {
        //trans.Rotate(-sensi * mouseY, 0f, 0f);
        //trans.eulerAngles = new Vector3(trans.parent.eulerAngles.x, trans.parent.eulerAngles.y, 0f);
        //Debug.Log(trans.forward);
        if (Input.GetMouseButtonDown(0))
        {
            PullTrigger();
        }
    }
    private void PullTrigger()
    {
        Rigidbody ridi;
        Transform trans;
        bullet = Instantiate(bulletPrefab);
        trans = bullet.transform;
        ridi = bullet.GetComponent<Rigidbody>();
        trans.parent = null;
        trans.position = this.trans.position;
        //ridi.velocity = new Vector3(this.trans.forward.x, this.trans.forward.y, this.trans.forward.z) * bulletSpeed;
        ridi.AddForce(this.trans.forward * bulletSpeed);//(new Vector3(this.trans.forward.x * bulletSpeed, this.trans.forward.y * bulletSpeed, this.trans.forward.z * bulletSpeed) );
    }
}
