using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickButtonSpring0 : MonoBehaviour
{
    void Start()
    {
        
    }
    // Start is called before the first frame update
    void OnMouseDown()
    {
        Debug.Log("Clicked button0");
        GlobalVariables.c = 1;
    }
    void Update()
    {
        
    }
}
