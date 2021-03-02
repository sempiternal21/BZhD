using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GiveData : MonoBehaviour
{
    GameObject go;
    // Start is called before the first frame update
    void Start()
    {
        go = GameObject.Find("Line");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseDown(){
        //go.transform.position = new Vector3(GlobalVariables.c, GlobalVariables.b, -37);
        Debug.Log(MathScript.arr[GlobalVariables.c, GlobalVariables.b]);
    }
}
