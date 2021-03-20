using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Click480 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseDown(){GameObject go;go = GameObject.Find("Line");
        GameObject go1;
    go1 = GameObject.Find("Cube (1)");
        go1.transform.position = new Vector3(3.384582f, 8.482458f, 20.23184f);
        float b = (float)MathScript.arr[GlobalVariables.c, GlobalVariables.b];
        if(b / GlobalVariables.volt <= 4.17f){
            go.transform.localScale = new Vector3(1.0051f, b / GlobalVariables.volt + 0.1f, -0.032032f);
        }else{
            go.transform.localScale = new Vector3(1.0051f, 4.17f, -0.032032f);
        }
    }
}
