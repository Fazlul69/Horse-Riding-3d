using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform[] target;

    public float smoothSpeed = 0.125f;
    public Vector3 offset;

    void FixedUpdate()
    {
        transform.position = new Vector3(transform.position.x, transform.position.y, -6.0f);
        
        for(int i=0; i< target.Length; i++)
        {
            Vector3 desiredPosition = target[i].position + offset;
            Vector3 smoothPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
            transform.position = smoothPosition;
        }
    }


}
