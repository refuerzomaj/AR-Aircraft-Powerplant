using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class objectParentingPosition : MonoBehaviour
{
    public GameObject anyObject;
    public Vector3 offset;

    public bool followXRot = true;
    public bool followYRot = true;
    public bool followZRot = true;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        anyObject.transform.position = transform.position + offset;
        float xRot = 0f;
        float yRot = 0f;
        float zRot = 0f;
        if(followXRot)xRot = transform.eulerAngles.x;
        if(followYRot)yRot = transform.eulerAngles.y;
        if(followZRot)zRot = transform.eulerAngles.z;
        anyObject.transform.eulerAngles = new Vector3(xRot, yRot, zRot);
    }
}
