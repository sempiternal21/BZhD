using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickButtonSpring2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void OnMouseDown()
    {
        Debug.Log("Clicked button2");
        GlobalVariables.c = 3;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
