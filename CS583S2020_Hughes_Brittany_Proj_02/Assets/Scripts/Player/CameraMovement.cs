using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public Transform mainchar;
    public float smoothing;
   
    void LateUpdate()
    {   
        if(transform.position != mainchar.position)
        {
            Vector3 pos = new Vector3(mainchar.position.x, mainchar.position.y, transform.position.z);
            transform.position = Vector3.Lerp(transform.position, pos, smoothing);
        }
    }
}
