using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickButtonSpring3 : MonoBehaviour
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
        Button4 = GameObject.Find("Cube (81)");
    }

    void OnMouseDown()
    {
        Debug.Log("Clicked button3");

        Button0.transform.position = new Vector3(5.6f, 6f, 21f);
        Button1.transform.position = new Vector3(5.6f, 5f, 21f);
        Button2.transform.position = new Vector3(5.6f, 4f, 21f);
        Button3.transform.position = new Vector3(5.45f, 3f, 21f);
        Button4.transform.position = new Vector3(5.6f, 2f, 21f);


        GlobalVariables.c = 4;
        float a = 1.45f;
        Spring1.transform.localScale = new Vector3(a, a, a);
        Spring2.transform.localScale = new Vector3(a, a, a);
        Spring3.transform.localScale = new Vector3(a, a, a);
        Spring4.transform.localScale = new Vector3(a, a, a);
        Engine.transform.position = new Vector3(-14.5f, 0.5f + 0.7f, 15.4f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
