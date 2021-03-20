using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Polzunok : MonoBehaviour
{
    public Vector3 target;
    public float smoothTime = 0.7F;
    private Vector3 velocity = Vector3.zero;

    void Start()
    {
        //target.Set(transform.position.x, transform.position.y, transform.position.z);
    }

    void Update()
    {
        //Vector3 targetPosition = target.TransformPoint(new Vector3(0, 5, -10));

        //transform.position = Vector3.SmoothDamp(transform.position, target, ref velocity, smoothTime);
    }

    public void MoveTo(float position)
    {
        //target.Set(transform.position.x, transform.position.y, position);
    }

    
}
