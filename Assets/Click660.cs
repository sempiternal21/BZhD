using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Click660 : MonoBehaviour
{
    GameObject go;
    // Start is called before the first frame update
    void Start()
    {
        go = GameObject.Find("Cube (1)");
        Debug.Log(go.name);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnMouseDown()
    {
        //go.transform.Translate(0, 0, transform.position.z);
        go.transform.position = new Vector3(go.transform.position.x, go.transform.position.y, transform.position.z);
        GlobalVariables.b = 2;
    }
}
