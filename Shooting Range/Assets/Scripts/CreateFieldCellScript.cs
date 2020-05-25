using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateFieldCellScript : MonoBehaviour
{
    public GameObject fieldCellPrefab;
    private GameObject fieldCell;
    private int fieldW=3;
    private int fieldH=20;
    // Start is called before the first frame update
    void Start()
    {
        int i, j;
        for (i = 0; i < fieldW; i++)
        {
            for (j = 0; j < fieldH; j++)
            {
                fieldCell=Instantiate(fieldCellPrefab);
                fieldCell.transform.parent = gameObject.transform;
                fieldCell.transform.position = new Vector3(i * fieldCell.transform.lossyScale.x, 0f, j * fieldCell.transform.lossyScale.z);
            }
        }
    }
}
