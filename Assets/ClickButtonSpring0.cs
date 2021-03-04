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
    void Start()
    {
        Spring1 = GameObject.Find("default");
        Spring2 = GameObject.Find("default (1)");
        Spring3 = GameObject.Find("default (2)");
        Spring4 = GameObject.Find("default (3)");
        Engine = GameObject.Find("engine");
    }
    // Start is called before the first frame update
    void OnMouseDown()
    {
        Debug.Log("Clicked button0");
        GlobalVariables.c = 1;
        float a = 0;
        Spring1.transform.localScale = new Vector3(a, a, a);
        Spring2.transform.localScale = new Vector3(a, a, a);
        Spring3.transform.localScale = new Vector3(a, a, a);
        Spring4.transform.localScale = new Vector3(a, a, a);
        Engine.transform.position = new Vector3(-14.5f, 0.5f, 15.4f);
    }
    void Update()
    {
        
    }
}
