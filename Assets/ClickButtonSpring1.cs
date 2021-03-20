using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickButtonSpring1 : MonoBehaviour
{
    GameObject Spring1;
    GameObject Spring2;
    GameObject Spring3;
    GameObject Spring4;
    GameObject Engine;

    GameObject Button0;
    GameObject Button1;
    GameObject Button2;
    GameObject Button3;
    GameObject Button4;
    GameObject go;
    // Start is called before the first frame update
    void Start()
    {
        Spring1 = GameObject.Find("default");
        Spring2 = GameObject.Find("default (1)");
        Spring3 = GameObject.Find("default (2)");
        Spring4 = GameObject.Find("default (3)");
        Engine = GameObject.Find("engine");

        Button0 = GameObject.Find("ButtonSpring0");
        Button1 = GameObject.Find("ButtonSpring1");
        Button2 = GameObject.Find("ButtonSpring2");
        Button3 = GameObject.Find("ButtonSpring3");
        Button4 = GameObject.Find("Cube (81)"); go = GameObject.Find("Line");
    }

    void OnMouseDown()
    {

        Button0.transform.position = new Vector3(5.6f, 6f, 21f);
        Button1.transform.position = new Vector3(5.45f, 5f, 21f);
        Button2.transform.position = new Vector3(5.6f, 4f, 21f);
        Button3.transform.position = new Vector3(5.6f, 3f, 21f);
        Button4.transform.position = new Vector3(5.6f, 2f, 21f);


        GlobalVariables.c = 2;
        float a = 1.15f;
        Spring1.transform.localScale = new Vector3(a, a, a);
        Spring2.transform.localScale = new Vector3(a, a, a);
        Spring3.transform.localScale = new Vector3(a, a, a);
        Spring4.transform.localScale = new Vector3(a, a, a);
        Engine.transform.position = new Vector3(-14.5f, 6.56f + 0.5f, 15.4f);float b = (float)MathScript.arr[GlobalVariables.c, GlobalVariables.b];
        if(b / GlobalVariables.volt <= 4.17f){
            go.transform.localScale = new Vector3(1.0051f, b / GlobalVariables.volt + 0.1f, -0.032032f);
        }else{
            go.transform.localScale = new Vector3(1.0051f, 4.17f, -0.032032f);
        }Debug.Log(b);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
