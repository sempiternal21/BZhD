using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickButtonSpring0 : MonoBehaviour
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
    // Start is called before the first frame update
    void OnMouseDown()
    {
        Debug.Log("Clicked button0");

        Button0.transform.position = new Vector3(5.45f, 6f, 21f);
        Button1.transform.position = new Vector3(5.6f, 5f, 21f);
        Button2.transform.position = new Vector3(5.6f, 4f, 21f);
        Button3.transform.position = new Vector3(5.6f, 3f, 21f);
        Button4.transform.position = new Vector3(5.6f, 2f, 21f);

        GlobalVariables.c = 1;
        float a = 0;
        Spring1.transform.localScale = new Vector3(a, a, a);
        Spring2.transform.localScale = new Vector3(a, a, a);
        Spring3.transform.localScale = new Vector3(a, a, a);
        Spring4.transform.localScale = new Vector3(a, a, a);
        Engine.transform.position = new Vector3(-14.5f, 6.56f, 15.4f);
    }
    void Update()
    {
        
    }
}
