using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lineRendererScript : MonoBehaviour
{ 
    public LineRenderer line;
    public Transform pos1,pos2;
    // Start is called before the first frame update
    void Start()
    {
        line.positionCount = 2;
    }

    // Update is called once per frame
    void Update()
    {
        line.material.color = Color.black;
        line.SetPosition(0,pos1.position);
        line.SetPosition(1,pos2.position);
    }
}
