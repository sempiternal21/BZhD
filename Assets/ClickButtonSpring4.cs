using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickButtonSpring4 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void OnMouseDown()
    {
        Debug.Log("Clicked button4");
        GlobalVariables.c = 5;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
