using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Vector3 offset;
    public Transform target;

    // Update is called once per frame
    void Update()
    {
       /* transform.position = target.position + offset;
        transform.Rotate(0, Input.GetAxis("Horizontal"), 0);
        //transform.rotate*/
    }
}
