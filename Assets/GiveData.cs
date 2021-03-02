using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GiveData : MonoBehaviour
{
    GameObject go;
    // Start is called before the first frame update.
    void Start()
    {
        go = GameObject.Find("Line");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseDown(){
        float b = (float)MathScript.arr[GlobalVariables.c, GlobalVariables.b];
        go.transform.localScale = new Vector3(1.0051f, b, -0.032032f);
        Debug.Log(MathScript.arr[GlobalVariables.c, GlobalVariables.b]);
    }
}
