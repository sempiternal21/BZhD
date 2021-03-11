using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    public static int pos = 1;
    float x = 0;
    float y = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

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
