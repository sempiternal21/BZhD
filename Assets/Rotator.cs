using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;

public class Rotator : MonoBehaviour
{
    public Text myText;
    public static int pos = 1;
    public float mouseSensitivity = 3.0f;
    float x = 0;
    float y = 0;
    float rotationX = 0F;
	float rotationY = 0F;
    float speed = 10F;
    public float minimumX = -360F;
	public float maximumX = 360F;
	public float minimumY = -60F;
	public float maximumY = 60F;
    Quaternion originalRotation;
    public float friction;

public float lerpSpeed;

private float xDeg;

private float yDeg;

private Quaternion fromRotation;

private Quaternion toRotation;
GameObject go;
    // Start is called before the first frame update
    void Start()
    {
        go = GameObject.Find("Line");
    }

    public static float ClampAngle (float angle, float min, float max)
	{
		if (angle < -360F) angle += 360F;
		if (angle > 360F) angle -= 360F;
		return Mathf.Clamp (angle, min, max);
	}

    // Update is called once per frame
    public float RotationSpeed = 5f;
    public float speedRotateX = 2f;
    public float speedRotateY = 2f;
public float rotationSpeed = 0.00001f;  //This will determine max rotation speed, you can adjust in the inspector
 
     public Camera cam;
public Vector3 target;
    void Update()
    {

        if (Input.GetKey("escape"))  // если нажата клавиша Esc (Escape)
      {
         Application.Quit();    // закрыть приложение
      }


    }


    void OnMouseDown()
    {
        transform.Rotate(0.0f, 30.0f, 0.0f);
        pos++;
        switch (pos)
        {
            case 2: GlobalVariables.volt = 2000f; break;
            case 3: GlobalVariables.volt = 1000f; break;
            case 4: GlobalVariables.volt = 500f; break;
            case 5: GlobalVariables.volt = 200f; break;
            case 6: GlobalVariables.volt = 100f; break;
            case 7: GlobalVariables.volt = 50f; break;
            case 8: GlobalVariables.volt = 20f; break;
            case 9: GlobalVariables.volt = 10f; break;
            case 10: GlobalVariables.volt = 5f; break;
            default: GlobalVariables.volt = 5000f; break;
        }
        //float aa = UnityEngine.Random.Range(0f, 1f);
        float b = (float)MathScript.arr[GlobalVariables.c, GlobalVariables.b];
        if(b / GlobalVariables.volt <= 4.17f){
            go.transform.localScale = new Vector3(1.0051f, b / GlobalVariables.volt + 0.1f, -0.032032f);
        }else{
            go.transform.localScale = new Vector3(1.0051f, 4.17f, -0.032032f);
        }
        
        Debug.Log(b);
        myText.text = "Напряжение миллиВольт: " + GlobalVariables.volt.ToString();
        if(pos == 11){
            pos = 1;
            
            transform.Rotate(0.0f, 60.0f, 0.0f);
        }
        //Debug.Log(GlobalVariables.volt);
        GlobalVariables.a = pos;
    }
}
