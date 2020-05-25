using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetScript : MonoBehaviour
{
    private int deg = 90;
    private bool standTarget = true;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (standTarget)
        {
            StandTarget();
        }
        else
        {
            LaydownTarget();
        }
    }
    public void StandTarget()
    {
        Transform trans;
        if (deg > 0)
        {
            trans = gameObject.transform;
            trans.Rotate(-1f, 0f, 0f);
            deg--;
        }

    }
    public void LaydownTarget()
    {
        Transform trans;
        if (deg < 90)
        {
            trans = gameObject.transform;
            trans.Rotate(1f, 0f, 0f);
            deg++;
        }
    }
    public void setStandTarget(bool stand)
    {
        standTarget = stand;
    }
}
