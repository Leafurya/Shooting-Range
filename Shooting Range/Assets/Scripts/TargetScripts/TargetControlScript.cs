using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetControlScript : MonoBehaviour
{
    public GameObject targetPrefab;
    private GameObject target;
    private Vector3 initPos;
    private int nofTarget=18;
    private float targetMargin = 10f;
    private int line=1;
    

    //10m=0.7143

    // Start is called before the first frame update
    void Start()
    {
        initPos = new Vector3(15f, 0f, 0f);
        for(int j = 0; j < 3; j++)
        {
            for (int i = 0; i < nofTarget; i++)
            {
                initPos = new Vector3(10 * j, 0f, 15f + targetMargin * i);
                target = Instantiate(targetPrefab);
                target.transform.parent = gameObject.transform;
                target.transform.position = initPos;
                target.transform.Rotate(90f, 0f, 0f);
            }
        }
        /*for(int i=0;i<90;i++)
            StandTarget(line);*/

    }

    private void Update()
    {
        
    }
}
