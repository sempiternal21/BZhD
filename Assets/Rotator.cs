using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Rotator : MonoBehaviour
{
    public static int pos = 1;
    public float mouseSensitivity = 3.0f;
    float x = 0;
    float y = 0;
    float rotationX = 0F;
	float rotationY = 0F;
    public float minimumX = -360F;
	public float maximumX = 360F;
	public float minimumY = -60F;
	public float maximumY = 60F;
    Quaternion originalRotation;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public static float ClampAngle (float angle, float min, float max)
	{
		if (angle < -360F) angle += 360F;
		if (angle > 360F) angle -= 360F;
		return Mathf.Clamp (angle, min, max);
	}

    // Update is called once per frame
    public float speed = 5f;
    public float speedRotateX = 2f;
    public float speedRotateY = 2f;
    public Transform Target;
    void Update()
    {
        if (Input.GetMouseButton(0))
        {

            }  
    
    
    }


    void OnMouseDown()
    {
        transform.Rotate(0.0f, 40.0f, 0.0f);
        pos++;
        if(pos == 10){
            pos = 1;
        }
        GlobalVariables.a = pos;
        Debug.Log(GlobalVariables.a);
    }
}
