using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PolzunokClick : MonoBehaviour
{
    GameObject go;

    [SerializeField] int index;

    // Start is called before the first frame update
    void Start()
    {
        go = GameObject.Find("Cube (1)");
        Debug.Log(go.name);
    }

    public void OnMouseDown()
    {
        //go.transform.Translate(0, 0, transform.position.z);
        //go.transform.position = new Vector3(go.transform.position.x, go.transform.position.y, transform.position.z);
        GlobalVariables.b = index;
        //Debug.Log(index);

        //((Polzunok)go.GetComponent<Polzunok>()).MoveTo(transform.position.z);
    }
}
